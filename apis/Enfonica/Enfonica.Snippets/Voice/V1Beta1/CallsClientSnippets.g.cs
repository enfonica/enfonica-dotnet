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
    using Google.Api.Gax;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCallsClientSnippets
    {
        /// <summary>Snippet for CreateCall</summary>
        public void CreateCallRequestObject()
        {
            // Snippet: CreateCall(CreateCallRequest, CallSettings)
            // Create client
            CallsClient callsClient = CallsClient.Create();
            // Initialize request argument(s)
            CreateCallRequest request = new CreateCallRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Call = new Call(),
            };
            // Make the request
            Call response = callsClient.CreateCall(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCallAsync</summary>
        public async Task CreateCallRequestObjectAsync()
        {
            // Snippet: CreateCallAsync(CreateCallRequest, CallSettings)
            // Additional: CreateCallAsync(CreateCallRequest, CancellationToken)
            // Create client
            CallsClient callsClient = await CallsClient.CreateAsync();
            // Initialize request argument(s)
            CreateCallRequest request = new CreateCallRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Call = new Call(),
            };
            // Make the request
            Call response = await callsClient.CreateCallAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCall</summary>
        public void CreateCall()
        {
            // Snippet: CreateCall(string, Call, CallSettings)
            // Create client
            CallsClient callsClient = CallsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Call call = new Call();
            // Make the request
            Call response = callsClient.CreateCall(parent, call);
            // End snippet
        }

        /// <summary>Snippet for CreateCallAsync</summary>
        public async Task CreateCallAsync()
        {
            // Snippet: CreateCallAsync(string, Call, CallSettings)
            // Additional: CreateCallAsync(string, Call, CancellationToken)
            // Create client
            CallsClient callsClient = await CallsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Call call = new Call();
            // Make the request
            Call response = await callsClient.CreateCallAsync(parent, call);
            // End snippet
        }

        /// <summary>Snippet for CreateCall</summary>
        public void CreateCallResourceNames()
        {
            // Snippet: CreateCall(ProjectName, Call, CallSettings)
            // Create client
            CallsClient callsClient = CallsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Call call = new Call();
            // Make the request
            Call response = callsClient.CreateCall(parent, call);
            // End snippet
        }

        /// <summary>Snippet for CreateCallAsync</summary>
        public async Task CreateCallResourceNamesAsync()
        {
            // Snippet: CreateCallAsync(ProjectName, Call, CallSettings)
            // Additional: CreateCallAsync(ProjectName, Call, CancellationToken)
            // Create client
            CallsClient callsClient = await CallsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Call call = new Call();
            // Make the request
            Call response = await callsClient.CreateCallAsync(parent, call);
            // End snippet
        }

        /// <summary>Snippet for GetCall</summary>
        public void GetCallRequestObject()
        {
            // Snippet: GetCall(GetCallRequest, CallSettings)
            // Create client
            CallsClient callsClient = CallsClient.Create();
            // Initialize request argument(s)
            GetCallRequest request = new GetCallRequest
            {
                CallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
            };
            // Make the request
            Call response = callsClient.GetCall(request);
            // End snippet
        }

        /// <summary>Snippet for GetCallAsync</summary>
        public async Task GetCallRequestObjectAsync()
        {
            // Snippet: GetCallAsync(GetCallRequest, CallSettings)
            // Additional: GetCallAsync(GetCallRequest, CancellationToken)
            // Create client
            CallsClient callsClient = await CallsClient.CreateAsync();
            // Initialize request argument(s)
            GetCallRequest request = new GetCallRequest
            {
                CallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
            };
            // Make the request
            Call response = await callsClient.GetCallAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCall</summary>
        public void GetCall()
        {
            // Snippet: GetCall(string, CallSettings)
            // Create client
            CallsClient callsClient = CallsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/calls/[CALL]";
            // Make the request
            Call response = callsClient.GetCall(name);
            // End snippet
        }

        /// <summary>Snippet for GetCallAsync</summary>
        public async Task GetCallAsync()
        {
            // Snippet: GetCallAsync(string, CallSettings)
            // Additional: GetCallAsync(string, CancellationToken)
            // Create client
            CallsClient callsClient = await CallsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/calls/[CALL]";
            // Make the request
            Call response = await callsClient.GetCallAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCall</summary>
        public void GetCallResourceNames()
        {
            // Snippet: GetCall(CallName, CallSettings)
            // Create client
            CallsClient callsClient = CallsClient.Create();
            // Initialize request argument(s)
            CallName name = CallName.FromProjectCall("[PROJECT]", "[CALL]");
            // Make the request
            Call response = callsClient.GetCall(name);
            // End snippet
        }

        /// <summary>Snippet for GetCallAsync</summary>
        public async Task GetCallResourceNamesAsync()
        {
            // Snippet: GetCallAsync(CallName, CallSettings)
            // Additional: GetCallAsync(CallName, CancellationToken)
            // Create client
            CallsClient callsClient = await CallsClient.CreateAsync();
            // Initialize request argument(s)
            CallName name = CallName.FromProjectCall("[PROJECT]", "[CALL]");
            // Make the request
            Call response = await callsClient.GetCallAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCalls</summary>
        public void ListCallsRequestObject()
        {
            // Snippet: ListCalls(ListCallsRequest, CallSettings)
            // Create client
            CallsClient callsClient = CallsClient.Create();
            // Initialize request argument(s)
            ListCallsRequest request = new ListCallsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListCallsResponse, Call> response = callsClient.ListCalls(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Call item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCallsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Call item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Call> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Call item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCallsAsync</summary>
        public async Task ListCallsRequestObjectAsync()
        {
            // Snippet: ListCallsAsync(ListCallsRequest, CallSettings)
            // Create client
            CallsClient callsClient = await CallsClient.CreateAsync();
            // Initialize request argument(s)
            ListCallsRequest request = new ListCallsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCallsResponse, Call> response = callsClient.ListCallsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Call item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCallsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Call item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Call> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Call item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCalls</summary>
        public void ListCalls()
        {
            // Snippet: ListCalls(string, string, int?, CallSettings)
            // Create client
            CallsClient callsClient = CallsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListCallsResponse, Call> response = callsClient.ListCalls(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Call item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCallsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Call item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Call> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Call item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCallsAsync</summary>
        public async Task ListCallsAsync()
        {
            // Snippet: ListCallsAsync(string, string, int?, CallSettings)
            // Create client
            CallsClient callsClient = await CallsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListCallsResponse, Call> response = callsClient.ListCallsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Call item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCallsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Call item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Call> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Call item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCalls</summary>
        public void ListCallsResourceNames()
        {
            // Snippet: ListCalls(ProjectName, string, int?, CallSettings)
            // Create client
            CallsClient callsClient = CallsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListCallsResponse, Call> response = callsClient.ListCalls(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Call item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCallsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Call item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Call> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Call item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCallsAsync</summary>
        public async Task ListCallsResourceNamesAsync()
        {
            // Snippet: ListCallsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            CallsClient callsClient = await CallsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListCallsResponse, Call> response = callsClient.ListCallsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Call item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCallsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Call item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Call> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Call item in singlePage)
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
