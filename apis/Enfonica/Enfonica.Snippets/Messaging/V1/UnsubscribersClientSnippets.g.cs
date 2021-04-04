// Copyright 2021 Enfonica Pty Ltd
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

namespace Enfonica.Messaging.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedUnsubscribersClientSnippets
    {
        /// <summary>Snippet for CreateUnsubscriber</summary>
        public void CreateUnsubscriberRequestObject()
        {
            // Snippet: CreateUnsubscriber(CreateUnsubscriberRequest, CallSettings)
            // Create client
            UnsubscribersClient unsubscribersClient = UnsubscribersClient.Create();
            // Initialize request argument(s)
            CreateUnsubscriberRequest request = new CreateUnsubscriberRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Unsubscriber = new Unsubscriber(),
            };
            // Make the request
            Unsubscriber response = unsubscribersClient.CreateUnsubscriber(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUnsubscriberAsync</summary>
        public async Task CreateUnsubscriberRequestObjectAsync()
        {
            // Snippet: CreateUnsubscriberAsync(CreateUnsubscriberRequest, CallSettings)
            // Additional: CreateUnsubscriberAsync(CreateUnsubscriberRequest, CancellationToken)
            // Create client
            UnsubscribersClient unsubscribersClient = await UnsubscribersClient.CreateAsync();
            // Initialize request argument(s)
            CreateUnsubscriberRequest request = new CreateUnsubscriberRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Unsubscriber = new Unsubscriber(),
            };
            // Make the request
            Unsubscriber response = await unsubscribersClient.CreateUnsubscriberAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUnsubscriber</summary>
        public void CreateUnsubscriber()
        {
            // Snippet: CreateUnsubscriber(string, Unsubscriber, CallSettings)
            // Create client
            UnsubscribersClient unsubscribersClient = UnsubscribersClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Unsubscriber unsubscriber = new Unsubscriber();
            // Make the request
            Unsubscriber response = unsubscribersClient.CreateUnsubscriber(parent, unsubscriber);
            // End snippet
        }

        /// <summary>Snippet for CreateUnsubscriberAsync</summary>
        public async Task CreateUnsubscriberAsync()
        {
            // Snippet: CreateUnsubscriberAsync(string, Unsubscriber, CallSettings)
            // Additional: CreateUnsubscriberAsync(string, Unsubscriber, CancellationToken)
            // Create client
            UnsubscribersClient unsubscribersClient = await UnsubscribersClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Unsubscriber unsubscriber = new Unsubscriber();
            // Make the request
            Unsubscriber response = await unsubscribersClient.CreateUnsubscriberAsync(parent, unsubscriber);
            // End snippet
        }

        /// <summary>Snippet for CreateUnsubscriber</summary>
        public void CreateUnsubscriberResourceNames()
        {
            // Snippet: CreateUnsubscriber(ProjectName, Unsubscriber, CallSettings)
            // Create client
            UnsubscribersClient unsubscribersClient = UnsubscribersClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Unsubscriber unsubscriber = new Unsubscriber();
            // Make the request
            Unsubscriber response = unsubscribersClient.CreateUnsubscriber(parent, unsubscriber);
            // End snippet
        }

        /// <summary>Snippet for CreateUnsubscriberAsync</summary>
        public async Task CreateUnsubscriberResourceNamesAsync()
        {
            // Snippet: CreateUnsubscriberAsync(ProjectName, Unsubscriber, CallSettings)
            // Additional: CreateUnsubscriberAsync(ProjectName, Unsubscriber, CancellationToken)
            // Create client
            UnsubscribersClient unsubscribersClient = await UnsubscribersClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Unsubscriber unsubscriber = new Unsubscriber();
            // Make the request
            Unsubscriber response = await unsubscribersClient.CreateUnsubscriberAsync(parent, unsubscriber);
            // End snippet
        }

        /// <summary>Snippet for GetUnsubscriber</summary>
        public void GetUnsubscriberRequestObject()
        {
            // Snippet: GetUnsubscriber(GetUnsubscriberRequest, CallSettings)
            // Create client
            UnsubscribersClient unsubscribersClient = UnsubscribersClient.Create();
            // Initialize request argument(s)
            GetUnsubscriberRequest request = new GetUnsubscriberRequest
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
            };
            // Make the request
            Unsubscriber response = unsubscribersClient.GetUnsubscriber(request);
            // End snippet
        }

        /// <summary>Snippet for GetUnsubscriberAsync</summary>
        public async Task GetUnsubscriberRequestObjectAsync()
        {
            // Snippet: GetUnsubscriberAsync(GetUnsubscriberRequest, CallSettings)
            // Additional: GetUnsubscriberAsync(GetUnsubscriberRequest, CancellationToken)
            // Create client
            UnsubscribersClient unsubscribersClient = await UnsubscribersClient.CreateAsync();
            // Initialize request argument(s)
            GetUnsubscriberRequest request = new GetUnsubscriberRequest
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
            };
            // Make the request
            Unsubscriber response = await unsubscribersClient.GetUnsubscriberAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUnsubscriber</summary>
        public void GetUnsubscriber()
        {
            // Snippet: GetUnsubscriber(string, CallSettings)
            // Create client
            UnsubscribersClient unsubscribersClient = UnsubscribersClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/unsubscribers/[UNSUBSCRIBER]";
            // Make the request
            Unsubscriber response = unsubscribersClient.GetUnsubscriber(name);
            // End snippet
        }

        /// <summary>Snippet for GetUnsubscriberAsync</summary>
        public async Task GetUnsubscriberAsync()
        {
            // Snippet: GetUnsubscriberAsync(string, CallSettings)
            // Additional: GetUnsubscriberAsync(string, CancellationToken)
            // Create client
            UnsubscribersClient unsubscribersClient = await UnsubscribersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/unsubscribers/[UNSUBSCRIBER]";
            // Make the request
            Unsubscriber response = await unsubscribersClient.GetUnsubscriberAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUnsubscriber</summary>
        public void GetUnsubscriberResourceNames()
        {
            // Snippet: GetUnsubscriber(UnsubscriberName, CallSettings)
            // Create client
            UnsubscribersClient unsubscribersClient = UnsubscribersClient.Create();
            // Initialize request argument(s)
            UnsubscriberName name = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]");
            // Make the request
            Unsubscriber response = unsubscribersClient.GetUnsubscriber(name);
            // End snippet
        }

        /// <summary>Snippet for GetUnsubscriberAsync</summary>
        public async Task GetUnsubscriberResourceNamesAsync()
        {
            // Snippet: GetUnsubscriberAsync(UnsubscriberName, CallSettings)
            // Additional: GetUnsubscriberAsync(UnsubscriberName, CancellationToken)
            // Create client
            UnsubscribersClient unsubscribersClient = await UnsubscribersClient.CreateAsync();
            // Initialize request argument(s)
            UnsubscriberName name = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]");
            // Make the request
            Unsubscriber response = await unsubscribersClient.GetUnsubscriberAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListUnsubscribers</summary>
        public void ListUnsubscribersRequestObject()
        {
            // Snippet: ListUnsubscribers(ListUnsubscribersRequest, CallSettings)
            // Create client
            UnsubscribersClient unsubscribersClient = UnsubscribersClient.Create();
            // Initialize request argument(s)
            ListUnsubscribersRequest request = new ListUnsubscribersRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Phone = "",
            };
            // Make the request
            PagedEnumerable<ListUnsubscribersResponse, Unsubscriber> response = unsubscribersClient.ListUnsubscribers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Unsubscriber item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUnsubscribersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Unsubscriber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Unsubscriber> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Unsubscriber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUnsubscribersAsync</summary>
        public async Task ListUnsubscribersRequestObjectAsync()
        {
            // Snippet: ListUnsubscribersAsync(ListUnsubscribersRequest, CallSettings)
            // Create client
            UnsubscribersClient unsubscribersClient = await UnsubscribersClient.CreateAsync();
            // Initialize request argument(s)
            ListUnsubscribersRequest request = new ListUnsubscribersRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Phone = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListUnsubscribersResponse, Unsubscriber> response = unsubscribersClient.ListUnsubscribersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Unsubscriber item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUnsubscribersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Unsubscriber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Unsubscriber> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Unsubscriber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUnsubscribers</summary>
        public void ListUnsubscribers()
        {
            // Snippet: ListUnsubscribers(string, string, int?, CallSettings)
            // Create client
            UnsubscribersClient unsubscribersClient = UnsubscribersClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListUnsubscribersResponse, Unsubscriber> response = unsubscribersClient.ListUnsubscribers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Unsubscriber item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUnsubscribersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Unsubscriber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Unsubscriber> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Unsubscriber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUnsubscribersAsync</summary>
        public async Task ListUnsubscribersAsync()
        {
            // Snippet: ListUnsubscribersAsync(string, string, int?, CallSettings)
            // Create client
            UnsubscribersClient unsubscribersClient = await UnsubscribersClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListUnsubscribersResponse, Unsubscriber> response = unsubscribersClient.ListUnsubscribersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Unsubscriber item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUnsubscribersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Unsubscriber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Unsubscriber> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Unsubscriber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUnsubscribers</summary>
        public void ListUnsubscribersResourceNames()
        {
            // Snippet: ListUnsubscribers(ProjectName, string, int?, CallSettings)
            // Create client
            UnsubscribersClient unsubscribersClient = UnsubscribersClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListUnsubscribersResponse, Unsubscriber> response = unsubscribersClient.ListUnsubscribers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Unsubscriber item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUnsubscribersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Unsubscriber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Unsubscriber> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Unsubscriber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUnsubscribersAsync</summary>
        public async Task ListUnsubscribersResourceNamesAsync()
        {
            // Snippet: ListUnsubscribersAsync(ProjectName, string, int?, CallSettings)
            // Create client
            UnsubscribersClient unsubscribersClient = await UnsubscribersClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListUnsubscribersResponse, Unsubscriber> response = unsubscribersClient.ListUnsubscribersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Unsubscriber item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUnsubscribersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Unsubscriber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Unsubscriber> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Unsubscriber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateUnsubscriber</summary>
        public void UpdateUnsubscriberRequestObject()
        {
            // Snippet: UpdateUnsubscriber(UpdateUnsubscriberRequest, CallSettings)
            // Create client
            UnsubscribersClient unsubscribersClient = UnsubscribersClient.Create();
            // Initialize request argument(s)
            UpdateUnsubscriberRequest request = new UpdateUnsubscriberRequest
            {
                Unsubscriber = new Unsubscriber(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Unsubscriber response = unsubscribersClient.UpdateUnsubscriber(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUnsubscriberAsync</summary>
        public async Task UpdateUnsubscriberRequestObjectAsync()
        {
            // Snippet: UpdateUnsubscriberAsync(UpdateUnsubscriberRequest, CallSettings)
            // Additional: UpdateUnsubscriberAsync(UpdateUnsubscriberRequest, CancellationToken)
            // Create client
            UnsubscribersClient unsubscribersClient = await UnsubscribersClient.CreateAsync();
            // Initialize request argument(s)
            UpdateUnsubscriberRequest request = new UpdateUnsubscriberRequest
            {
                Unsubscriber = new Unsubscriber(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Unsubscriber response = await unsubscribersClient.UpdateUnsubscriberAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUnsubscriber</summary>
        public void UpdateUnsubscriber()
        {
            // Snippet: UpdateUnsubscriber(Unsubscriber, FieldMask, CallSettings)
            // Create client
            UnsubscribersClient unsubscribersClient = UnsubscribersClient.Create();
            // Initialize request argument(s)
            Unsubscriber unsubscriber = new Unsubscriber();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Unsubscriber response = unsubscribersClient.UpdateUnsubscriber(unsubscriber, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateUnsubscriberAsync</summary>
        public async Task UpdateUnsubscriberAsync()
        {
            // Snippet: UpdateUnsubscriberAsync(Unsubscriber, FieldMask, CallSettings)
            // Additional: UpdateUnsubscriberAsync(Unsubscriber, FieldMask, CancellationToken)
            // Create client
            UnsubscribersClient unsubscribersClient = await UnsubscribersClient.CreateAsync();
            // Initialize request argument(s)
            Unsubscriber unsubscriber = new Unsubscriber();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Unsubscriber response = await unsubscribersClient.UpdateUnsubscriberAsync(unsubscriber, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnsubscriber</summary>
        public void DeleteUnsubscriberRequestObject()
        {
            // Snippet: DeleteUnsubscriber(DeleteUnsubscriberRequest, CallSettings)
            // Create client
            UnsubscribersClient unsubscribersClient = UnsubscribersClient.Create();
            // Initialize request argument(s)
            DeleteUnsubscriberRequest request = new DeleteUnsubscriberRequest
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
            };
            // Make the request
            Unsubscriber response = unsubscribersClient.DeleteUnsubscriber(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnsubscriberAsync</summary>
        public async Task DeleteUnsubscriberRequestObjectAsync()
        {
            // Snippet: DeleteUnsubscriberAsync(DeleteUnsubscriberRequest, CallSettings)
            // Additional: DeleteUnsubscriberAsync(DeleteUnsubscriberRequest, CancellationToken)
            // Create client
            UnsubscribersClient unsubscribersClient = await UnsubscribersClient.CreateAsync();
            // Initialize request argument(s)
            DeleteUnsubscriberRequest request = new DeleteUnsubscriberRequest
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
            };
            // Make the request
            Unsubscriber response = await unsubscribersClient.DeleteUnsubscriberAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnsubscriber</summary>
        public void DeleteUnsubscriber()
        {
            // Snippet: DeleteUnsubscriber(string, CallSettings)
            // Create client
            UnsubscribersClient unsubscribersClient = UnsubscribersClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/unsubscribers/[UNSUBSCRIBER]";
            // Make the request
            Unsubscriber response = unsubscribersClient.DeleteUnsubscriber(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnsubscriberAsync</summary>
        public async Task DeleteUnsubscriberAsync()
        {
            // Snippet: DeleteUnsubscriberAsync(string, CallSettings)
            // Additional: DeleteUnsubscriberAsync(string, CancellationToken)
            // Create client
            UnsubscribersClient unsubscribersClient = await UnsubscribersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/unsubscribers/[UNSUBSCRIBER]";
            // Make the request
            Unsubscriber response = await unsubscribersClient.DeleteUnsubscriberAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnsubscriber</summary>
        public void DeleteUnsubscriberResourceNames()
        {
            // Snippet: DeleteUnsubscriber(UnsubscriberName, CallSettings)
            // Create client
            UnsubscribersClient unsubscribersClient = UnsubscribersClient.Create();
            // Initialize request argument(s)
            UnsubscriberName name = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]");
            // Make the request
            Unsubscriber response = unsubscribersClient.DeleteUnsubscriber(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnsubscriberAsync</summary>
        public async Task DeleteUnsubscriberResourceNamesAsync()
        {
            // Snippet: DeleteUnsubscriberAsync(UnsubscriberName, CallSettings)
            // Additional: DeleteUnsubscriberAsync(UnsubscriberName, CancellationToken)
            // Create client
            UnsubscribersClient unsubscribersClient = await UnsubscribersClient.CreateAsync();
            // Initialize request argument(s)
            UnsubscriberName name = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]");
            // Make the request
            Unsubscriber response = await unsubscribersClient.DeleteUnsubscriberAsync(name);
            // End snippet
        }
    }
}
