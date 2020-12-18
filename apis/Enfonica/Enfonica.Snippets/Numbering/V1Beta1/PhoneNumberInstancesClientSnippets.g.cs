// Copyright 2020 Google LLC
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

namespace Enfonica.Numbering.V1Beta1.Snippets
{
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedPhoneNumberInstancesClientSnippets
    {
        /// <summary>Snippet for CreatePhoneNumberInstance</summary>
        public void CreatePhoneNumberInstanceRequestObject()
        {
            // Snippet: CreatePhoneNumberInstance(CreatePhoneNumberInstanceRequest, CallSettings)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = PhoneNumberInstancesClient.Create();
            // Initialize request argument(s)
            CreatePhoneNumberInstanceRequest request = new CreatePhoneNumberInstanceRequest
            {
                Parent = "",
                PhoneNumberInstance = new PhoneNumberInstance(),
            };
            // Make the request
            PhoneNumberInstance response = phoneNumberInstancesClient.CreatePhoneNumberInstance(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePhoneNumberInstanceAsync</summary>
        public async Task CreatePhoneNumberInstanceRequestObjectAsync()
        {
            // Snippet: CreatePhoneNumberInstanceAsync(CreatePhoneNumberInstanceRequest, CallSettings)
            // Additional: CreatePhoneNumberInstanceAsync(CreatePhoneNumberInstanceRequest, CancellationToken)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = await PhoneNumberInstancesClient.CreateAsync();
            // Initialize request argument(s)
            CreatePhoneNumberInstanceRequest request = new CreatePhoneNumberInstanceRequest
            {
                Parent = "",
                PhoneNumberInstance = new PhoneNumberInstance(),
            };
            // Make the request
            PhoneNumberInstance response = await phoneNumberInstancesClient.CreatePhoneNumberInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPhoneNumberInstance</summary>
        public void GetPhoneNumberInstanceRequestObject()
        {
            // Snippet: GetPhoneNumberInstance(GetPhoneNumberInstanceRequest, CallSettings)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = PhoneNumberInstancesClient.Create();
            // Initialize request argument(s)
            GetPhoneNumberInstanceRequest request = new GetPhoneNumberInstanceRequest { Name = "", };
            // Make the request
            PhoneNumberInstance response = phoneNumberInstancesClient.GetPhoneNumberInstance(request);
            // End snippet
        }

        /// <summary>Snippet for GetPhoneNumberInstanceAsync</summary>
        public async Task GetPhoneNumberInstanceRequestObjectAsync()
        {
            // Snippet: GetPhoneNumberInstanceAsync(GetPhoneNumberInstanceRequest, CallSettings)
            // Additional: GetPhoneNumberInstanceAsync(GetPhoneNumberInstanceRequest, CancellationToken)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = await PhoneNumberInstancesClient.CreateAsync();
            // Initialize request argument(s)
            GetPhoneNumberInstanceRequest request = new GetPhoneNumberInstanceRequest { Name = "", };
            // Make the request
            PhoneNumberInstance response = await phoneNumberInstancesClient.GetPhoneNumberInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListPhoneNumberInstances</summary>
        public void ListPhoneNumberInstancesRequestObject()
        {
            // Snippet: ListPhoneNumberInstances(ListPhoneNumberInstancesRequest, CallSettings)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = PhoneNumberInstancesClient.Create();
            // Initialize request argument(s)
            ListPhoneNumberInstancesRequest request = new ListPhoneNumberInstancesRequest
            {
                Parent = "",
                Prefix = "",
                IncludeDeleted = false,
            };
            // Make the request
            PagedEnumerable<ListPhoneNumberInstancesResponse, PhoneNumberInstance> response = phoneNumberInstancesClient.ListPhoneNumberInstances(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PhoneNumberInstance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPhoneNumberInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhoneNumberInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhoneNumberInstance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhoneNumberInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPhoneNumberInstances</summary>
        public async Task ListPhoneNumberInstancesRequestObjectAsync()
        {
            // Snippet: ListPhoneNumberInstancesAsync(ListPhoneNumberInstancesRequest, CallSettings)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = await PhoneNumberInstancesClient.CreateAsync();
            // Initialize request argument(s)
            ListPhoneNumberInstancesRequest request = new ListPhoneNumberInstancesRequest
            {
                Parent = "",
                Prefix = "",
                IncludeDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListPhoneNumberInstancesResponse, PhoneNumberInstance> response = phoneNumberInstancesClient.ListPhoneNumberInstancesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PhoneNumberInstance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPhoneNumberInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhoneNumberInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhoneNumberInstance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhoneNumberInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdatePhoneNumberInstance</summary>
        public void UpdatePhoneNumberInstanceRequestObject()
        {
            // Snippet: UpdatePhoneNumberInstance(UpdatePhoneNumberInstanceRequest, CallSettings)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = PhoneNumberInstancesClient.Create();
            // Initialize request argument(s)
            UpdatePhoneNumberInstanceRequest request = new UpdatePhoneNumberInstanceRequest
            {
                Name = "",
                PhoneNumberInstance = new PhoneNumberInstance(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PhoneNumberInstance response = phoneNumberInstancesClient.UpdatePhoneNumberInstance(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePhoneNumberInstanceAsync</summary>
        public async Task UpdatePhoneNumberInstanceRequestObjectAsync()
        {
            // Snippet: UpdatePhoneNumberInstanceAsync(UpdatePhoneNumberInstanceRequest, CallSettings)
            // Additional: UpdatePhoneNumberInstanceAsync(UpdatePhoneNumberInstanceRequest, CancellationToken)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = await PhoneNumberInstancesClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePhoneNumberInstanceRequest request = new UpdatePhoneNumberInstanceRequest
            {
                Name = "",
                PhoneNumberInstance = new PhoneNumberInstance(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PhoneNumberInstance response = await phoneNumberInstancesClient.UpdatePhoneNumberInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePhoneNumberInstance</summary>
        public void DeletePhoneNumberInstanceRequestObject()
        {
            // Snippet: DeletePhoneNumberInstance(DeletePhoneNumberInstanceRequest, CallSettings)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = PhoneNumberInstancesClient.Create();
            // Initialize request argument(s)
            DeletePhoneNumberInstanceRequest request = new DeletePhoneNumberInstanceRequest { Name = "", };
            // Make the request
            PhoneNumberInstance response = phoneNumberInstancesClient.DeletePhoneNumberInstance(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePhoneNumberInstanceAsync</summary>
        public async Task DeletePhoneNumberInstanceRequestObjectAsync()
        {
            // Snippet: DeletePhoneNumberInstanceAsync(DeletePhoneNumberInstanceRequest, CallSettings)
            // Additional: DeletePhoneNumberInstanceAsync(DeletePhoneNumberInstanceRequest, CancellationToken)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = await PhoneNumberInstancesClient.CreateAsync();
            // Initialize request argument(s)
            DeletePhoneNumberInstanceRequest request = new DeletePhoneNumberInstanceRequest { Name = "", };
            // Make the request
            PhoneNumberInstance response = await phoneNumberInstancesClient.DeletePhoneNumberInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProvisionedPhoneNumberInstance</summary>
        public void GetProvisionedPhoneNumberInstanceRequestObject()
        {
            // Snippet: GetProvisionedPhoneNumberInstance(GetProvisionedPhoneNumberInstanceRequest, CallSettings)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = PhoneNumberInstancesClient.Create();
            // Initialize request argument(s)
            GetProvisionedPhoneNumberInstanceRequest request = new GetProvisionedPhoneNumberInstanceRequest
            {
                Parent = "",
                PhoneNumber = "",
            };
            // Make the request
            PhoneNumberInstance response = phoneNumberInstancesClient.GetProvisionedPhoneNumberInstance(request);
            // End snippet
        }

        /// <summary>Snippet for GetProvisionedPhoneNumberInstanceAsync</summary>
        public async Task GetProvisionedPhoneNumberInstanceRequestObjectAsync()
        {
            // Snippet: GetProvisionedPhoneNumberInstanceAsync(GetProvisionedPhoneNumberInstanceRequest, CallSettings)
            // Additional: GetProvisionedPhoneNumberInstanceAsync(GetProvisionedPhoneNumberInstanceRequest, CancellationToken)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = await PhoneNumberInstancesClient.CreateAsync();
            // Initialize request argument(s)
            GetProvisionedPhoneNumberInstanceRequest request = new GetProvisionedPhoneNumberInstanceRequest
            {
                Parent = "",
                PhoneNumber = "",
            };
            // Make the request
            PhoneNumberInstance response = await phoneNumberInstancesClient.GetProvisionedPhoneNumberInstanceAsync(request);
            // End snippet
        }
    }
}
