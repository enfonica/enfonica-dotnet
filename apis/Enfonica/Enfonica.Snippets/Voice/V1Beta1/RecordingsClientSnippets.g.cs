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

namespace Enfonica.Voice.V1Beta1.Snippets
{
    using Google.Api.Gax;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedRecordingsClientSnippets
    {
        /// <summary>Snippet for GetRecording</summary>
        public void GetRecordingRequestObject()
        {
            // Snippet: GetRecording(GetRecordingRequest, CallSettings)
            // Create client
            RecordingsClient recordingsClient = RecordingsClient.Create();
            // Initialize request argument(s)
            GetRecordingRequest request = new GetRecordingRequest
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
                View = RecordingView.Unspecified,
            };
            // Make the request
            Recording response = recordingsClient.GetRecording(request);
            // End snippet
        }

        /// <summary>Snippet for GetRecordingAsync</summary>
        public async Task GetRecordingRequestObjectAsync()
        {
            // Snippet: GetRecordingAsync(GetRecordingRequest, CallSettings)
            // Additional: GetRecordingAsync(GetRecordingRequest, CancellationToken)
            // Create client
            RecordingsClient recordingsClient = await RecordingsClient.CreateAsync();
            // Initialize request argument(s)
            GetRecordingRequest request = new GetRecordingRequest
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
                View = RecordingView.Unspecified,
            };
            // Make the request
            Recording response = await recordingsClient.GetRecordingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRecording</summary>
        public void GetRecording()
        {
            // Snippet: GetRecording(string, CallSettings)
            // Create client
            RecordingsClient recordingsClient = RecordingsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/calls/[CALL]/recordings/[RECORDING]";
            // Make the request
            Recording response = recordingsClient.GetRecording(name);
            // End snippet
        }

        /// <summary>Snippet for GetRecordingAsync</summary>
        public async Task GetRecordingAsync()
        {
            // Snippet: GetRecordingAsync(string, CallSettings)
            // Additional: GetRecordingAsync(string, CancellationToken)
            // Create client
            RecordingsClient recordingsClient = await RecordingsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/calls/[CALL]/recordings/[RECORDING]";
            // Make the request
            Recording response = await recordingsClient.GetRecordingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRecording</summary>
        public void GetRecordingResourceNames()
        {
            // Snippet: GetRecording(RecordingName, CallSettings)
            // Create client
            RecordingsClient recordingsClient = RecordingsClient.Create();
            // Initialize request argument(s)
            RecordingName name = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]");
            // Make the request
            Recording response = recordingsClient.GetRecording(name);
            // End snippet
        }

        /// <summary>Snippet for GetRecordingAsync</summary>
        public async Task GetRecordingResourceNamesAsync()
        {
            // Snippet: GetRecordingAsync(RecordingName, CallSettings)
            // Additional: GetRecordingAsync(RecordingName, CancellationToken)
            // Create client
            RecordingsClient recordingsClient = await RecordingsClient.CreateAsync();
            // Initialize request argument(s)
            RecordingName name = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]");
            // Make the request
            Recording response = await recordingsClient.GetRecordingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListRecordings</summary>
        public void ListRecordingsRequestObject()
        {
            // Snippet: ListRecordings(ListRecordingsRequest, CallSettings)
            // Create client
            RecordingsClient recordingsClient = RecordingsClient.Create();
            // Initialize request argument(s)
            ListRecordingsRequest request = new ListRecordingsRequest
            {
                ParentAsCallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
                View = RecordingView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListRecordingsResponse, Recording> response = recordingsClient.ListRecordings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Recording item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRecordingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Recording item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Recording> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Recording item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRecordingsAsync</summary>
        public async Task ListRecordingsRequestObjectAsync()
        {
            // Snippet: ListRecordingsAsync(ListRecordingsRequest, CallSettings)
            // Create client
            RecordingsClient recordingsClient = await RecordingsClient.CreateAsync();
            // Initialize request argument(s)
            ListRecordingsRequest request = new ListRecordingsRequest
            {
                ParentAsCallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
                View = RecordingView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListRecordingsResponse, Recording> response = recordingsClient.ListRecordingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Recording item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRecordingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Recording item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Recording> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Recording item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRecordings</summary>
        public void ListRecordings()
        {
            // Snippet: ListRecordings(string, string, int?, CallSettings)
            // Create client
            RecordingsClient recordingsClient = RecordingsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/calls/[CALL]";
            // Make the request
            PagedEnumerable<ListRecordingsResponse, Recording> response = recordingsClient.ListRecordings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Recording item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRecordingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Recording item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Recording> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Recording item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRecordingsAsync</summary>
        public async Task ListRecordingsAsync()
        {
            // Snippet: ListRecordingsAsync(string, string, int?, CallSettings)
            // Create client
            RecordingsClient recordingsClient = await RecordingsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/calls/[CALL]";
            // Make the request
            PagedAsyncEnumerable<ListRecordingsResponse, Recording> response = recordingsClient.ListRecordingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Recording item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRecordingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Recording item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Recording> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Recording item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRecordings</summary>
        public void ListRecordingsResourceNames()
        {
            // Snippet: ListRecordings(CallName, string, int?, CallSettings)
            // Create client
            RecordingsClient recordingsClient = RecordingsClient.Create();
            // Initialize request argument(s)
            CallName parent = CallName.FromProjectCall("[PROJECT]", "[CALL]");
            // Make the request
            PagedEnumerable<ListRecordingsResponse, Recording> response = recordingsClient.ListRecordings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Recording item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRecordingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Recording item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Recording> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Recording item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRecordingsAsync</summary>
        public async Task ListRecordingsResourceNamesAsync()
        {
            // Snippet: ListRecordingsAsync(CallName, string, int?, CallSettings)
            // Create client
            RecordingsClient recordingsClient = await RecordingsClient.CreateAsync();
            // Initialize request argument(s)
            CallName parent = CallName.FromProjectCall("[PROJECT]", "[CALL]");
            // Make the request
            PagedAsyncEnumerable<ListRecordingsResponse, Recording> response = recordingsClient.ListRecordingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Recording item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRecordingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Recording item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Recording> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Recording item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteRecording</summary>
        public void DeleteRecordingRequestObject()
        {
            // Snippet: DeleteRecording(DeleteRecordingRequest, CallSettings)
            // Create client
            RecordingsClient recordingsClient = RecordingsClient.Create();
            // Initialize request argument(s)
            DeleteRecordingRequest request = new DeleteRecordingRequest
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
            };
            // Make the request
            Recording response = recordingsClient.DeleteRecording(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRecordingAsync</summary>
        public async Task DeleteRecordingRequestObjectAsync()
        {
            // Snippet: DeleteRecordingAsync(DeleteRecordingRequest, CallSettings)
            // Additional: DeleteRecordingAsync(DeleteRecordingRequest, CancellationToken)
            // Create client
            RecordingsClient recordingsClient = await RecordingsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRecordingRequest request = new DeleteRecordingRequest
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
            };
            // Make the request
            Recording response = await recordingsClient.DeleteRecordingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRecording</summary>
        public void DeleteRecording()
        {
            // Snippet: DeleteRecording(string, CallSettings)
            // Create client
            RecordingsClient recordingsClient = RecordingsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/calls/[CALL]/recordings/[RECORDING]";
            // Make the request
            Recording response = recordingsClient.DeleteRecording(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRecordingAsync</summary>
        public async Task DeleteRecordingAsync()
        {
            // Snippet: DeleteRecordingAsync(string, CallSettings)
            // Additional: DeleteRecordingAsync(string, CancellationToken)
            // Create client
            RecordingsClient recordingsClient = await RecordingsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/calls/[CALL]/recordings/[RECORDING]";
            // Make the request
            Recording response = await recordingsClient.DeleteRecordingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRecording</summary>
        public void DeleteRecordingResourceNames()
        {
            // Snippet: DeleteRecording(RecordingName, CallSettings)
            // Create client
            RecordingsClient recordingsClient = RecordingsClient.Create();
            // Initialize request argument(s)
            RecordingName name = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]");
            // Make the request
            Recording response = recordingsClient.DeleteRecording(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRecordingAsync</summary>
        public async Task DeleteRecordingResourceNamesAsync()
        {
            // Snippet: DeleteRecordingAsync(RecordingName, CallSettings)
            // Additional: DeleteRecordingAsync(RecordingName, CancellationToken)
            // Create client
            RecordingsClient recordingsClient = await RecordingsClient.CreateAsync();
            // Initialize request argument(s)
            RecordingName name = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]");
            // Make the request
            Recording response = await recordingsClient.DeleteRecordingAsync(name);
            // End snippet
        }
    }
}
