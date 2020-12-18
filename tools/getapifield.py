# Copyright 2019 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     https://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

import json
import sys
import argparse

parser = argparse.ArgumentParser(description='Fetches a field from a single API in the catalog')
parser.add_argument('file', help='File to load')
parser.add_argument('id', help='ID of API to fetch')
parser.add_argument('field', help='Field to find and output')
parser.add_argument('--default', help='Default value to output if field is not present')
args = parser.parse_args()

filename = sys.argv[1]
file = open(filename, "r") 
catalog = json.load(file)

query = [api.get(args.field) for api in catalog["apis"] if api["id"] == args.id]

if len(query) != 1:
  raise Exception(f"API {args.id} not found (or has duplicate definitions)")
elif not query[0] and args.default:
  print(args.default)
elif not query[0]:
  raise Exception(f"API {args.id} has no field {args.field}")
else:
  print(query[0])