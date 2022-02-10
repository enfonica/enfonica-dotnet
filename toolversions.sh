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

# This is intended to be imported using the "source" function from
# any scripts that use tools.

declare -r REPO_ROOT=$(readlink -f $(dirname ${BASH_SOURCE}))
declare -r TOOL_PACKAGES=$REPO_ROOT/packages

declare -r PROTOC_VERSION=3.13.0
declare -r GRPC_VERSION=2.31.0

declare -r PROTOBUF_TOOLS_ROOT=$TOOL_PACKAGES/Google.Protobuf.Tools.$PROTOC_VERSION

if [[ "$KOKORO_GIT_COMMIT" != "" ]]; then declare -r RUNNING_ON_KOKORO=true; fi

# Bit of a hack... assume that if we're running on Kokoro, we should be able to use the cache...
# TODO: Remove this, and create the cache in the autosynth script instead, perhaps.
if [[ $RUNNING_ON_KOKORO == "true" ]]
then
  mkdir -p ~/.cache/synthtool
fi

# Detect a synthtool cache, used for other repos that we clone and build from.
if [[ -d ~/.cache/synthtool ]]; then declare -r SYNTHTOOL_CACHE=~/.cache/synthtool; fi

# Try to detect Python 3. It's quite different between Windows and Linux.
if which python > /dev/null && python --version 2>&1 | grep -q "Python 3"; then declare -r PYTHON3=python
elif which py > /dev/null && py -3 --version 2>&1 | grep -q "Python 3"; then declare -r PYTHON3="py -3"
elif which python3 > /dev/null && python3 --version 2>&1 | grep -q "Python 3"; then declare -r PYTHON3=python3
else
  echo "Unable to detect Python 3 installation."
  exit 1
fi

# Cross-platform tools
case "$OSTYPE" in
  linux*)
    declare -r PROTOC=$PROTOBUF_TOOLS_ROOT/tools/linux_x64/protoc
    declare -r GRPC_PLUGIN=packages/Grpc.Tools.$GRPC_VERSION/tools/linux_x64/grpc_csharp_plugin
    ;;
  darwin*)
    declare -r PROTOC=$PROTOBUF_TOOLS_ROOT/tools/macosx_x64/protoc
    declare -r GRPC_PLUGIN=packages/Grpc.Tools.$GRPC_VERSION/tools/macosx_x64/grpc_csharp_plugin
    ;;
  win* | msys* | cygwin*)
    declare -r PROTOC=$PROTOBUF_TOOLS_ROOT/tools/windows_x64/protoc.exe
    declare -r GRPC_PLUGIN=packages/Grpc.Tools.$GRPC_VERSION/tools/windows_x64/grpc_csharp_plugin.exe
    ;;
  *)
    echo "Unknown OSTYPE: $OSTYPE"
    exit 1
esac

# The nuget command line tool is annoying to get installed on Linux/Mac.
# We only need to be able to install tool packages, so let's just fake that by fetching with curl and unzipping.
# Arguments:
# - Package name
# - Version
install_nuget_package() {
  local output=$TOOL_PACKAGES/$1.$2
  # Assume that if the directory exists, it's already installed correctly.  
  if [[ -d $output ]]; then return 0; fi
  
  (mkdir -p $output;
   cd $output;
   curl -sSL https://www.nuget.org/api/v2/package/$1/$2 --output tmp.zip;
   unzip -q tmp.zip;
   rm tmp.zip)
}

# Installation functions, all of which should be unconditionally called
# when required. (They handle the case where the tool is already installed.)

install_protoc() {
  install_nuget_package Google.Protobuf.Tools $PROTOC_VERSION
  
  # Temporary fix for a broken proto in the protobuf tools package
  sed -i 's/--)/-- )/g' $PROTOBUF_TOOLS_ROOT/tools/google/protobuf/timestamp.proto
  chmod +x $PROTOC
}

install_microgenerator() {
  case "$OSTYPE" in
    linux*)
      declare -r RUNTIME=linux-x64
      declare -r EXTENSION=
      ;;
    darwin*)
      echo "Microgenerator not currently supported on MacOSX. Ask jonskeet@ for help."
      exit 1
      ;;
    win* | msys* | cygwin*)
      declare -r RUNTIME=win-x64
      declare -r EXTENSION=.exe
      ;;
    *)
      echo "Unknown OSTYPE: $OSTYPE"
      exit 1
  esac
  
  if [[ "$SYNTHTOOL_CACHE" != "" ]]
  then
    declare -r GENERATOR_ROOT=$SYNTHTOOL_CACHE/gapic-generator-csharp
  else
    declare -r GENERATOR_ROOT=$REPO_ROOT/gapic-generator-csharp
  fi
  
  export GAPIC_PLUGIN=$GENERATOR_ROOT/Google.Api.Generator/bin/Release/netcoreapp3.1/$RUNTIME/publish/Google.Api.Generator$EXTENSION
  
  # TODO: Use a specific tag, or even a NuGet package eventually
  if [ -d $GENERATOR_ROOT ]
  then
      git -C $GENERATOR_ROOT pull -q
  else
      git clone https://github.com/googleapis/gapic-generator-csharp $GENERATOR_ROOT -b main --depth 1
  fi

  (cd $GENERATOR_ROOT; dotnet publish -v quiet -nologo -clp:NoSummary -c Release --self-contained --runtime=$RUNTIME Google.Api.Generator)
}

install_grpc() {
  install_nuget_package Grpc.Tools $GRPC_VERSION
  chmod +x $GRPC_PLUGIN
}

# Logs to stdout
log_build_action() {
  echo -e "\e[1;35m$1\e[0m"
}
