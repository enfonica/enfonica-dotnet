#!/bin/bash
set -e

# path to compiled api generator
code_gen=/c/dev/google/gapic-generator-csharp/Google.Api.Generator/bin/Debug/netcoreapp3.1/publish/Google.Api.Generator

# clean tmp folder and set it up
rm -rf tmp
mkdir -p tmp/micro
mkdir -p tmp/grpc

# generate messaging client
protoc \
  --proto_path=/c/dev/googleapis \
  --proto_path=/c/dev/enfonica/api/api-protos \
  --proto_path=/c/dev/protocolbuffers/protobuf/src \
  --plugin=protoc-gen-csharp_gapic=$code_gen \
  --csharp_gapic_out=tmp/ \
  --csharp_gapic_opt="grpc-service-config=service-config.json" \
  --csharp_gapic_opt="common-resources-config=common-resources.json" \
  enfonica/messaging/v1/Messages.proto
