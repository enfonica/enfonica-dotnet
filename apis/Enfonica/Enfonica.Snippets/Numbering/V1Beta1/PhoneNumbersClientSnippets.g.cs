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
    public sealed class GeneratedPhoneNumbersClientSnippets
    {
        /// <summary>Snippet for CreatePhoneNumber</summary>
        public void CreatePhoneNumberRequestObject()
        {
            // Snippet: CreatePhoneNumber(CreatePhoneNumberRequest, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = PhoneNumbersClient.Create();
            // Initialize request argument(s)
            CreatePhoneNumberRequest request = new CreatePhoneNumberRequest
            {
                PhoneNumber = new PhoneNumber(),
            };
            // Make the request
            PhoneNumber response = phoneNumbersClient.CreatePhoneNumber(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePhoneNumberAsync</summary>
        public async Task CreatePhoneNumberRequestObjectAsync()
        {
            // Snippet: CreatePhoneNumberAsync(CreatePhoneNumberRequest, CallSettings)
            // Additional: CreatePhoneNumberAsync(CreatePhoneNumberRequest, CancellationToken)
            // Create client
            PhoneNumbersClient phoneNumbersClient = await PhoneNumbersClient.CreateAsync();
            // Initialize request argument(s)
            CreatePhoneNumberRequest request = new CreatePhoneNumberRequest
            {
                PhoneNumber = new PhoneNumber(),
            };
            // Make the request
            PhoneNumber response = await phoneNumbersClient.CreatePhoneNumberAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPhoneNumber</summary>
        public void GetPhoneNumberRequestObject()
        {
            // Snippet: GetPhoneNumber(GetPhoneNumberRequest, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = PhoneNumbersClient.Create();
            // Initialize request argument(s)
            GetPhoneNumberRequest request = new GetPhoneNumberRequest { Name = "", };
            // Make the request
            PhoneNumber response = phoneNumbersClient.GetPhoneNumber(request);
            // End snippet
        }

        /// <summary>Snippet for GetPhoneNumberAsync</summary>
        public async Task GetPhoneNumberRequestObjectAsync()
        {
            // Snippet: GetPhoneNumberAsync(GetPhoneNumberRequest, CallSettings)
            // Additional: GetPhoneNumberAsync(GetPhoneNumberRequest, CancellationToken)
            // Create client
            PhoneNumbersClient phoneNumbersClient = await PhoneNumbersClient.CreateAsync();
            // Initialize request argument(s)
            GetPhoneNumberRequest request = new GetPhoneNumberRequest { Name = "", };
            // Make the request
            PhoneNumber response = await phoneNumbersClient.GetPhoneNumberAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListPhoneNumbers</summary>
        public void ListPhoneNumbersRequestObject()
        {
            // Snippet: ListPhoneNumbers(ListPhoneNumbersRequest, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = PhoneNumbersClient.Create();
            // Initialize request argument(s)
            ListPhoneNumbersRequest request = new ListPhoneNumbersRequest { };
            // Make the request
            PagedEnumerable<ListPhoneNumbersResponse, PhoneNumber> response = phoneNumbersClient.ListPhoneNumbers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PhoneNumber item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPhoneNumbersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhoneNumber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhoneNumber> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhoneNumber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPhoneNumbers</summary>
        public async Task ListPhoneNumbersRequestObjectAsync()
        {
            // Snippet: ListPhoneNumbersAsync(ListPhoneNumbersRequest, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = await PhoneNumbersClient.CreateAsync();
            // Initialize request argument(s)
            ListPhoneNumbersRequest request = new ListPhoneNumbersRequest { };
            // Make the request
            PagedAsyncEnumerable<ListPhoneNumbersResponse, PhoneNumber> response = phoneNumbersClient.ListPhoneNumbersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PhoneNumber item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPhoneNumbersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhoneNumber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhoneNumber> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhoneNumber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdatePhoneNumber</summary>
        public void UpdatePhoneNumberRequestObject()
        {
            // Snippet: UpdatePhoneNumber(UpdatePhoneNumberRequest, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = PhoneNumbersClient.Create();
            // Initialize request argument(s)
            UpdatePhoneNumberRequest request = new UpdatePhoneNumberRequest
            {
                Name = "",
                PhoneNumber = new PhoneNumber(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PhoneNumber response = phoneNumbersClient.UpdatePhoneNumber(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePhoneNumberAsync</summary>
        public async Task UpdatePhoneNumberRequestObjectAsync()
        {
            // Snippet: UpdatePhoneNumberAsync(UpdatePhoneNumberRequest, CallSettings)
            // Additional: UpdatePhoneNumberAsync(UpdatePhoneNumberRequest, CancellationToken)
            // Create client
            PhoneNumbersClient phoneNumbersClient = await PhoneNumbersClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePhoneNumberRequest request = new UpdatePhoneNumberRequest
            {
                Name = "",
                PhoneNumber = new PhoneNumber(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PhoneNumber response = await phoneNumbersClient.UpdatePhoneNumberAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePhoneNumber</summary>
        public void DeletePhoneNumberRequestObject()
        {
            // Snippet: DeletePhoneNumber(DeletePhoneNumberRequest, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = PhoneNumbersClient.Create();
            // Initialize request argument(s)
            DeletePhoneNumberRequest request = new DeletePhoneNumberRequest { Name = "", };
            // Make the request
            PhoneNumber response = phoneNumbersClient.DeletePhoneNumber(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePhoneNumberAsync</summary>
        public async Task DeletePhoneNumberRequestObjectAsync()
        {
            // Snippet: DeletePhoneNumberAsync(DeletePhoneNumberRequest, CallSettings)
            // Additional: DeletePhoneNumberAsync(DeletePhoneNumberRequest, CancellationToken)
            // Create client
            PhoneNumbersClient phoneNumbersClient = await PhoneNumbersClient.CreateAsync();
            // Initialize request argument(s)
            DeletePhoneNumberRequest request = new DeletePhoneNumberRequest { Name = "", };
            // Make the request
            PhoneNumber response = await phoneNumbersClient.DeletePhoneNumberAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SearchPhoneNumbers</summary>
        public void SearchPhoneNumbersRequestObject()
        {
            // Snippet: SearchPhoneNumbers(SearchPhoneNumbersRequest, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = PhoneNumbersClient.Create();
            // Initialize request argument(s)
            SearchPhoneNumbersRequest request = new SearchPhoneNumbersRequest
            {
                Capabilities =
                {
                    PhoneNumber.Types.PhoneNumberCapability.Unspecified,
                },
                NumberType = PhoneNumber.Types.PhoneNumberType.Unspecified,
                CountryCode = "",
                Prefix = "",
            };
            // Make the request
            PagedEnumerable<SearchPhoneNumbersResponse, PhoneNumber> response = phoneNumbersClient.SearchPhoneNumbers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PhoneNumber item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchPhoneNumbersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhoneNumber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhoneNumber> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhoneNumber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchPhoneNumbers</summary>
        public async Task SearchPhoneNumbersRequestObjectAsync()
        {
            // Snippet: SearchPhoneNumbersAsync(SearchPhoneNumbersRequest, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = await PhoneNumbersClient.CreateAsync();
            // Initialize request argument(s)
            SearchPhoneNumbersRequest request = new SearchPhoneNumbersRequest
            {
                Capabilities =
                {
                    PhoneNumber.Types.PhoneNumberCapability.Unspecified,
                },
                NumberType = PhoneNumber.Types.PhoneNumberType.Unspecified,
                CountryCode = "",
                Prefix = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchPhoneNumbersResponse, PhoneNumber> response = phoneNumbersClient.SearchPhoneNumbersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PhoneNumber item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchPhoneNumbersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhoneNumber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhoneNumber> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhoneNumber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
