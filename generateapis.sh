#!/bin/bash

# Copyright 2020 Enfonica Pty Ltd
#
# Copyright 2020 Google LLC.
# 
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# 
#     http://www.apache.org/licenses/LICENSE-2.0
# 
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# 
# This file has been modified by Enfonica Pty Ltd to align the
# functionality to different requirements.

set -e

# this is the only environment variable that must be set before running
# todo: in future, pull the apis from github
if [[ -z $ENFONICAAPIS ]]; then
  echo "ENFONICAAPIS environment variable must be set"
  exit 1
fi

source toolversions.sh
declare -r CORE_PROTOS_ROOT=$PROTOBUF_TOOLS_ROOT/tools

# This script generates all APIs from the googleapis/googleapis github repository,
# using the code generator from googleapis/gapic-generator-csharp.
# It will fetch both repositories if necessary.

# Currently it will only work on Windows due to the way nuget packages installed;
# changing toolversions.sh could mitigate that, if it's ever necessary.
#
# Prerequisites
# - Bash as supplied with Windows git
# - git
# - wget
# - unzip

OUTDIR=tmp
declare -r GOOGLEAPIS="$PWD/googleapis"

# Allow pre/post-generation scripts to know where to find the repo
export GOOGLEAPIS

fetch_github_repos() {
  if [ -d "$GOOGLEAPIS" ]
  then
    git -C $GOOGLEAPIS pull -q
  else
    # Auto-detect whether we're cloning the public or private googleapis repo.
    git remote -v | grep -q google-cloud-dotnet-private && repo=googleapis-private || repo=googleapis
    git clone https://github.com/googleapis/${repo} $GOOGLEAPIS --depth 1
  fi
}

delete_generated() {
  find $1 -type f -name '*.g.cs' -exec rm "{}" +
}

generate_microgenerator() {
  PACKAGE_ID=$1
  API_TMP_DIR=$OUTDIR/$PACKAGE_ID/client
  GRPC_TMP_DIR=$OUTDIR/$PACKAGE_ID/grpc
  API_OUT_DIR=apis
  API_SRC_DIR=$ENFONICAAPIS/$($PYTHON3 tools/getapifield.py apis/apis.json $PACKAGE_ID protoPath)
  PACKAGE=$($PYTHON3 tools/getapifield.py apis/apis.json $PACKAGE_ID package)

  # Clean API tmp dir
  rm -rf $API_TMP_DIR

  # If there's exactly one service config file, pass it in. Otherwise, omit it.
  GRPC_SERVICE_CONFIG=$(echo $API_SRC_DIR/*.json)
  SERVICE_CONFIG_OPTION=
  if [[ -f "$GRPC_SERVICE_CONFIG" ]]
  then
    SERVICE_CONFIG_OPTION=--gapic_opt=grpc-service-config=$GRPC_SERVICE_CONFIG
  fi

  # Defalt to "all resources are common" but allow a per-API config file too.
  COMMON_RESOURCES_CONFIG=common_resources.json
  if [[ -f "$API_OUT_DIR/$PACKAGE_ID/common_resources.json" ]]
  then
    COMMON_RESOURCES_CONFIG=$API_OUT_DIR/$PACKAGE_ID/common_resources.json
  fi
  COMMON_RESOURCES_OPTION=--gapic_opt=common-resources-config=$COMMON_RESOURCES_CONFIG
  
  COMMON_RESOURCES_PROTO=$ENFONICAAPIS/enfonica/common_resources.proto
  
  # Message and service generation. This doesn't need the common resources,
  # and we don't want to pass in the common resources proto because we don't
  # want to generate it.
  echo "Generating $PACKAGE_ID: message and service"
  mkdir -p $GRPC_TMP_DIR
  $PROTOC \
    --csharp_out=$GRPC_TMP_DIR \
    --grpc_out=$GRPC_TMP_DIR \
    --plugin=protoc-gen-grpc=$GRPC_PLUGIN \
    -I $ENFONICAAPIS \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    $API_SRC_DIR/*.proto \
    2>&1 | grep -v "is unused" || true # Ignore import warnings (and grep exit code)
  
  # Use .g.cs for generated files
  for f in $GRPC_TMP_DIR/*.cs; do 
    mv -- "$f" "${f%.cs}.g.cs"
  done

  # # Allow protos to be changed after proto/gRPC generation but before the
  # # GAPIC microgenerator. This is pretty extreme, but is used for service renaming.
  # if [[ -f $API_OUT_DIR/$1/midmicrogeneration.sh ]]
  # then
  #   echo "Running mid-micro-generation script for $1"
  #   (cd $API_OUT_DIR/$1; ./midmicrogeneration.sh)
  # fi

  # Client generation. This needs the common resources proto as a reference,
  # but it won't generate anything for it.
  echo "Generating $PACKAGE_ID: client"
  mkdir $API_TMP_DIR
  $PROTOC \
    --gapic_out=$API_TMP_DIR \
    $SERVICE_CONFIG_OPTION \
    $COMMON_RESOURCES_OPTION \
    --plugin=protoc-gen-gapic=$GAPIC_PLUGIN \
    -I $ENFONICAAPIS \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    $API_SRC_DIR/*.proto \
    $COMMON_RESOURCES_PROTO \
    2>&1 | grep -v "is unused" || true # Ignore import warnings (and grep exit code)

  # The microgenerator currently creates Google.Cloud directories due to being given
  # the common resources proto. Clean up for now; this is being fixed in the generator.
  rm -rf $API_TMP_DIR/Google.Cloud{,.Snippets,.Tests}

  # Fix copyright notices in generated clients
  find $API_TMP_DIR -type f -name '*.g.cs' -exec sh -c 'sed -i "s/Google LLC/Enfonica Pty Ltd/" "$1"' -- {} \;
  # Introduce aliased namespace
  find $API_TMP_DIR -type f -name '*Client.g.cs' -exec sh -c 'sed -i "s/using gaxgrpc = Google.Api.Gax.Grpc;/using gaxgrpc = Google.Api.Gax.Grpc;\nusing enfgaxgrpc = Enfonica.Api.Gax.Grpc;/" "$1"' -- {} \;
  # Modify generated client to use Enfonica versions
  find $API_TMP_DIR -type f -name '*Client.g.cs' -exec sh -c 'sed -i "s/gaxgrpc::ClientBuilderBase/enfgaxgrpc::ClientBuilderBase/g" "$1"' -- {} \;
  find $API_TMP_DIR -type f -name '*Client.g.cs' -exec sh -c 'sed -i "s/gaxgrpc::ChannelPool/enfgaxgrpc::ChannelPool/g" "$1"' -- {} \;

  DEST_SUB_PATH=${PACKAGE_ID//\./\/}
  DEST_PACKAGE=$API_OUT_DIR/$PACKAGE/$DEST_SUB_PATH
  DEST_SNIPPETS=$API_OUT_DIR/$PACKAGE/${DEST_SUB_PATH/\//.Snippets\/}
  DEST_TESTS=$API_OUT_DIR/$PACKAGE/${DEST_SUB_PATH/\//.Tests\/}

  # Copy the rest into the right place
  # cp -r $API_TMP_DIR $API_OUT_DIR
  mkdir -p $DEST_PACKAGE
  mkdir -p $DEST_SNIPPETS
  mkdir -p $DEST_TESTS
  mv $GRPC_TMP_DIR/*.g.cs $DEST_PACKAGE
  mv $API_TMP_DIR/$PACKAGE_ID/*.g.cs $DEST_PACKAGE
  mv $API_TMP_DIR/$PACKAGE_ID.Snippets/*.g.cs $DEST_SNIPPETS
  mv $API_TMP_DIR/$PACKAGE_ID.Tests/*.g.cs $DEST_TESTS
}

generate_microgenerator_commonresourcenames() {
  API_TMP_DIR=$OUTDIR/Common
  API_OUT_DIR=apis

  # Clean API tmp dir
  rm -rf $API_TMP_DIR

  COMMON_RESOURCES_PROTO=$ENFONICAAPIS/enfonica/common_resources.proto

  # Generate common resource name classes
  echo "Generating common resource name classes"
  mkdir $API_TMP_DIR
  $PROTOC \
    --gapic_out=$API_TMP_DIR \
    --plugin=protoc-gen-gapic=$GAPIC_PLUGIN \
    -I $ENFONICAAPIS \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    $COMMON_RESOURCES_PROTO \
    2>&1 | grep -v "is unused" || true # Ignore import warnings (and grep exit code)

  # The microgenerator currently creates Google.Cloud directories due to being given
  # the common resources proto. Clean up for now; this is being fixed in the generator.
  rm -rf $API_TMP_DIR/Google.Cloud{,.Snippets,.Tests}

  # Fix copyright notices in generated code
  find $API_TMP_DIR -type f -name '*.g.cs' -exec sh -c 'sed -i "s/Google LLC/Enfonica Pty Ltd/" "$1"' -- {} \;

  DEST=$API_OUT_DIR/Enfonica/Enfonica

  # Copy into the right place
  mkdir -p $DEST
  mv $API_TMP_DIR/Enfonica/*.g.cs $DEST
}

generate_proto() {
  # Delete previously-generated files
  delete_generated apis/$1/$1

  API_SRC_DIR=$ENFONICAAPIS/$($PYTHON3 tools/getapifield.py apis/apis.json $1 protoPath)
  mkdir -p apis/$1/$1
  $PROTOC \
    --csharp_out=apis/$1/$1 \
    -I $ENFONICAAPIS \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    $API_SRC_DIR/*.proto \
    2>&1 | grep -v "is unused" || true # Ignore import warnings (and grep exit code)
}

generate_protogrpc() {
  # Delete previously-generated files
  delete_generated apis/$1/$1

  API_SRC_DIR=$ENFONICAAPIS/$($PYTHON3 tools/getapifield.py apis/apis.json $1 protoPath)
  $PROTOC \
    --csharp_out=apis/$1/$1 \
    --grpc_out=apis/$1/$1 \
    -I $ENFONICAAPIS \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    --plugin=protoc-gen-grpc=$GRPC_PLUGIN \
    $API_SRC_DIR/*.proto \
    2>&1 | grep -v "is unused" || true # Ignore import warnings (and grep exit code)
}

generate_api() {
  PACKAGE=$1
  PACKAGE_DIR=apis/$1
  # if [[ $CHECK_COMPATIBILITY == "true" && -d $PACKAGE_DIR ]]
  # then
  #   echo "Building existing version of $PACKAGE for compatibility checking"
  #   dotnet build -c Release -f netstandard2.0 -v quiet -nologo -clp:NoSummary -p:SourceLinkCreate=false $PACKAGE_DIR/$PACKAGE
  #   cp $PACKAGE_DIR/$PACKAGE/bin/Release/netstandard2.0/$PACKAGE.dll $OUTDIR
  # fi
  echo "Generating $PACKAGE"
  GENERATOR=$($PYTHON3 tools/getapifield.py apis/apis.json $PACKAGE generator)
  # if [[ -f $PACKAGE_DIR/pregeneration.sh ]]
  # then
  #   echo "Running pre-generation script for $PACKAGE"
  #   (cd $PACKAGE_DIR; ./pregeneration.sh)
  # fi

  case "$GENERATOR" in
    micro)
      generate_microgenerator $1
      ;;
    proto)
      generate_proto $1
      ;;
    protogrpc)
      generate_protogrpc $1
      ;;
    *)
      echo "Unknown generator: $GENERATOR"
      exit 1
  esac
  # if [[ -f $PACKAGE_DIR/postgeneration.patch ]]
  # then
  #   echo "Applying post-generation patch for $PACKAGE"
  #   (cd $PACKAGE_DIR; git apply postgeneration.patch)
  # fi

  # if [[ -f $PACKAGE_DIR/postgeneration.sh ]]
  # then    
  #   echo "Running post-generation script for $PACKAGE"
  #   (cd $PACKAGE_DIR; ./postgeneration.sh)
  # fi
  
  # if [[ $(grep -E "^namespace" apis/$1/$1/*.cs | grep -Ev "namespace ${1}[[:space:]{]*\$") ]]
  # then
  #   echo "API $1 has broken namespace declarations"
  #   exit 1
  # fi

  # if [[ $CHECK_COMPATIBILITY == "true" ]]
  # then
  #   if [[ -f $OUTDIR/$PACKAGE.dll ]]
  #   then
  #     # In order to skip expensive "build and check compatibility" step,
  #     # first see whether git thinks anything has changed.
  #     # Command line arguments:
  #     # -c core.safecrlf=false: don't warn on line ending changes
  #     # diff: do a diff :)
  #     # -s: suppress output as we only care about the exit code
  #     # -b: ignore whitespace
  #     # --exit-code: set the exit code to 0 for no diff, 1 when a diff is detected      
  #     if git -c core.safecrlf=false diff -s -b --exit-code -- $PACKAGE_DIR
  #     then
  #       echo "git detects no change in $PACKAGE; skipping compatibility checking"
  #     else
  #       echo "Building new version of $PACKAGE for compatibility checking"
  #       dotnet build -c Release -f netstandard2.0 -v quiet -nologo -clp:NoSummary -p:SourceLinkCreate=false $PACKAGE_DIR/$PACKAGE
  #       echo ""
  #       echo "Changes in $PACKAGE:"
  #       dotnet run -p tools/Google.Cloud.Tools.CompareVersions -- \
  #         --file1=$OUTDIR/$PACKAGE.dll \
  #         --file2=$PACKAGE_DIR/$PACKAGE/bin/Release/netstandard2.0/$PACKAGE.dll
  #     fi
  #   else
  #     echo ""
  #     echo "$PACKAGE is a new API."
  #   fi
  # fi

#   # Record the commit in synth.metadata
#   cat > $PACKAGE_DIR/synth.metadata <<END
# {
#   "sources": [
#     {
#       "git": {
#         "name": "googleapis",
#         "remote": "https://github.com/googleapis/googleapis.git",
#         "sha": "$(git -C $GOOGLEAPIS rev-parse HEAD)"        
#       }
#     }
#   ]
# }
# END
}



# Entry point
install_protoc
install_microgenerator
install_grpc
fetch_github_repos

OUTDIR=tmp
rm -rf $OUTDIR
mkdir $OUTDIR
# CHECK_COMPATIBILITY=false
# if [[ $1 == "--check_compatibility" ]]
# then
#   CHECK_COMPATIBILITY=true
#   shift
# fi

# Delete previously-generated files
delete_generated apis/Enfonica/Enfonica
delete_generated apis/Enfonica/Enfonica.Tests
delete_generated apis/Enfonica/Enfonica.Snippets

packages=$@
if [[ -z "$packages" ]]
then
  packages=$($PYTHON3 tools/listapis.py apis/apis.json --test generator)
fi

generate_microgenerator_commonresourcenames

for package in $packages
do
  generate_api $package
done
