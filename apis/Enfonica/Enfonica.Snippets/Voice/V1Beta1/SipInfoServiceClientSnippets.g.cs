// Copyright 2022 Enfonica Pty Ltd
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Enfonica.Voice.V1Beta1.Snippets
{
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSipInfoServiceClientSnippets
    {
        /// <summary>Snippet for GetSipInfo</summary>
        public void GetSipInfoRequestObject()
        {
            // Snippet: GetSipInfo(GetSipInfoRequest, CallSettings)
            // Create client
            SipInfoServiceClient sipInfoServiceClient = SipInfoServiceClient.Create();
            // Initialize request argument(s)
            GetSipInfoRequest request = new GetSipInfoRequest
            {
                SipInfoName = SipInfoName.FromProjectCall("[PROJECT]", "[CALL]"),
            };
            // Make the request
            SipInfo response = sipInfoServiceClient.GetSipInfo(request);
            // End snippet
        }

        /// <summary>Snippet for GetSipInfoAsync</summary>
        public async Task GetSipInfoRequestObjectAsync()
        {
            // Snippet: GetSipInfoAsync(GetSipInfoRequest, CallSettings)
            // Additional: GetSipInfoAsync(GetSipInfoRequest, CancellationToken)
            // Create client
            SipInfoServiceClient sipInfoServiceClient = await SipInfoServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSipInfoRequest request = new GetSipInfoRequest
            {
                SipInfoName = SipInfoName.FromProjectCall("[PROJECT]", "[CALL]"),
            };
            // Make the request
            SipInfo response = await sipInfoServiceClient.GetSipInfoAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSipInfo</summary>
        public void GetSipInfo()
        {
            // Snippet: GetSipInfo(string, CallSettings)
            // Create client
            SipInfoServiceClient sipInfoServiceClient = SipInfoServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/calls/[CALL]/sipInfo";
            // Make the request
            SipInfo response = sipInfoServiceClient.GetSipInfo(name);
            // End snippet
        }

        /// <summary>Snippet for GetSipInfoAsync</summary>
        public async Task GetSipInfoAsync()
        {
            // Snippet: GetSipInfoAsync(string, CallSettings)
            // Additional: GetSipInfoAsync(string, CancellationToken)
            // Create client
            SipInfoServiceClient sipInfoServiceClient = await SipInfoServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/calls/[CALL]/sipInfo";
            // Make the request
            SipInfo response = await sipInfoServiceClient.GetSipInfoAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSipInfo</summary>
        public void GetSipInfoResourceNames()
        {
            // Snippet: GetSipInfo(SipInfoName, CallSettings)
            // Create client
            SipInfoServiceClient sipInfoServiceClient = SipInfoServiceClient.Create();
            // Initialize request argument(s)
            SipInfoName name = SipInfoName.FromProjectCall("[PROJECT]", "[CALL]");
            // Make the request
            SipInfo response = sipInfoServiceClient.GetSipInfo(name);
            // End snippet
        }

        /// <summary>Snippet for GetSipInfoAsync</summary>
        public async Task GetSipInfoResourceNamesAsync()
        {
            // Snippet: GetSipInfoAsync(SipInfoName, CallSettings)
            // Additional: GetSipInfoAsync(SipInfoName, CancellationToken)
            // Create client
            SipInfoServiceClient sipInfoServiceClient = await SipInfoServiceClient.CreateAsync();
            // Initialize request argument(s)
            SipInfoName name = SipInfoName.FromProjectCall("[PROJECT]", "[CALL]");
            // Make the request
            SipInfo response = await sipInfoServiceClient.GetSipInfoAsync(name);
            // End snippet
        }
    }
}
