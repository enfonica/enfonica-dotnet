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
    public sealed class GeneratedTranscriptionsClientSnippets
    {
        /// <summary>Snippet for GetTranscription</summary>
        public void GetTranscriptionRequestObject()
        {
            // Snippet: GetTranscription(GetTranscriptionRequest, CallSettings)
            // Create client
            TranscriptionsClient transcriptionsClient = TranscriptionsClient.Create();
            // Initialize request argument(s)
            GetTranscriptionRequest request = new GetTranscriptionRequest
            {
                TranscriptionName = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]"),
                View = TranscriptionView.Unspecified,
            };
            // Make the request
            Transcription response = transcriptionsClient.GetTranscription(request);
            // End snippet
        }

        /// <summary>Snippet for GetTranscriptionAsync</summary>
        public async Task GetTranscriptionRequestObjectAsync()
        {
            // Snippet: GetTranscriptionAsync(GetTranscriptionRequest, CallSettings)
            // Additional: GetTranscriptionAsync(GetTranscriptionRequest, CancellationToken)
            // Create client
            TranscriptionsClient transcriptionsClient = await TranscriptionsClient.CreateAsync();
            // Initialize request argument(s)
            GetTranscriptionRequest request = new GetTranscriptionRequest
            {
                TranscriptionName = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]"),
                View = TranscriptionView.Unspecified,
            };
            // Make the request
            Transcription response = await transcriptionsClient.GetTranscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTranscription</summary>
        public void GetTranscription()
        {
            // Snippet: GetTranscription(string, CallSettings)
            // Create client
            TranscriptionsClient transcriptionsClient = TranscriptionsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/calls/[CALL]/transcriptions/[TRANSCRIPTION]";
            // Make the request
            Transcription response = transcriptionsClient.GetTranscription(name);
            // End snippet
        }

        /// <summary>Snippet for GetTranscriptionAsync</summary>
        public async Task GetTranscriptionAsync()
        {
            // Snippet: GetTranscriptionAsync(string, CallSettings)
            // Additional: GetTranscriptionAsync(string, CancellationToken)
            // Create client
            TranscriptionsClient transcriptionsClient = await TranscriptionsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/calls/[CALL]/transcriptions/[TRANSCRIPTION]";
            // Make the request
            Transcription response = await transcriptionsClient.GetTranscriptionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTranscription</summary>
        public void GetTranscriptionResourceNames()
        {
            // Snippet: GetTranscription(TranscriptionName, CallSettings)
            // Create client
            TranscriptionsClient transcriptionsClient = TranscriptionsClient.Create();
            // Initialize request argument(s)
            TranscriptionName name = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]");
            // Make the request
            Transcription response = transcriptionsClient.GetTranscription(name);
            // End snippet
        }

        /// <summary>Snippet for GetTranscriptionAsync</summary>
        public async Task GetTranscriptionResourceNamesAsync()
        {
            // Snippet: GetTranscriptionAsync(TranscriptionName, CallSettings)
            // Additional: GetTranscriptionAsync(TranscriptionName, CancellationToken)
            // Create client
            TranscriptionsClient transcriptionsClient = await TranscriptionsClient.CreateAsync();
            // Initialize request argument(s)
            TranscriptionName name = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]");
            // Make the request
            Transcription response = await transcriptionsClient.GetTranscriptionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTranscriptions</summary>
        public void ListTranscriptionsRequestObject()
        {
            // Snippet: ListTranscriptions(ListTranscriptionsRequest, CallSettings)
            // Create client
            TranscriptionsClient transcriptionsClient = TranscriptionsClient.Create();
            // Initialize request argument(s)
            ListTranscriptionsRequest request = new ListTranscriptionsRequest
            {
                ParentAsCallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
                View = TranscriptionView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListTranscriptionsResponse, Transcription> response = transcriptionsClient.ListTranscriptions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Transcription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTranscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Transcription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Transcription> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Transcription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTranscriptionsAsync</summary>
        public async Task ListTranscriptionsRequestObjectAsync()
        {
            // Snippet: ListTranscriptionsAsync(ListTranscriptionsRequest, CallSettings)
            // Create client
            TranscriptionsClient transcriptionsClient = await TranscriptionsClient.CreateAsync();
            // Initialize request argument(s)
            ListTranscriptionsRequest request = new ListTranscriptionsRequest
            {
                ParentAsCallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
                View = TranscriptionView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListTranscriptionsResponse, Transcription> response = transcriptionsClient.ListTranscriptionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Transcription item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTranscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Transcription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Transcription> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Transcription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTranscriptions</summary>
        public void ListTranscriptions()
        {
            // Snippet: ListTranscriptions(string, string, int?, CallSettings)
            // Create client
            TranscriptionsClient transcriptionsClient = TranscriptionsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/calls/[CALL]";
            // Make the request
            PagedEnumerable<ListTranscriptionsResponse, Transcription> response = transcriptionsClient.ListTranscriptions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Transcription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTranscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Transcription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Transcription> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Transcription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTranscriptionsAsync</summary>
        public async Task ListTranscriptionsAsync()
        {
            // Snippet: ListTranscriptionsAsync(string, string, int?, CallSettings)
            // Create client
            TranscriptionsClient transcriptionsClient = await TranscriptionsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/calls/[CALL]";
            // Make the request
            PagedAsyncEnumerable<ListTranscriptionsResponse, Transcription> response = transcriptionsClient.ListTranscriptionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Transcription item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTranscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Transcription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Transcription> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Transcription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTranscriptions</summary>
        public void ListTranscriptionsResourceNames()
        {
            // Snippet: ListTranscriptions(CallName, string, int?, CallSettings)
            // Create client
            TranscriptionsClient transcriptionsClient = TranscriptionsClient.Create();
            // Initialize request argument(s)
            CallName parent = CallName.FromProjectCall("[PROJECT]", "[CALL]");
            // Make the request
            PagedEnumerable<ListTranscriptionsResponse, Transcription> response = transcriptionsClient.ListTranscriptions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Transcription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTranscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Transcription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Transcription> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Transcription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTranscriptionsAsync</summary>
        public async Task ListTranscriptionsResourceNamesAsync()
        {
            // Snippet: ListTranscriptionsAsync(CallName, string, int?, CallSettings)
            // Create client
            TranscriptionsClient transcriptionsClient = await TranscriptionsClient.CreateAsync();
            // Initialize request argument(s)
            CallName parent = CallName.FromProjectCall("[PROJECT]", "[CALL]");
            // Make the request
            PagedAsyncEnumerable<ListTranscriptionsResponse, Transcription> response = transcriptionsClient.ListTranscriptionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Transcription item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTranscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Transcription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Transcription> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Transcription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteTranscription</summary>
        public void DeleteTranscriptionRequestObject()
        {
            // Snippet: DeleteTranscription(DeleteTranscriptionRequest, CallSettings)
            // Create client
            TranscriptionsClient transcriptionsClient = TranscriptionsClient.Create();
            // Initialize request argument(s)
            DeleteTranscriptionRequest request = new DeleteTranscriptionRequest
            {
                TranscriptionName = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]"),
            };
            // Make the request
            transcriptionsClient.DeleteTranscription(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTranscriptionAsync</summary>
        public async Task DeleteTranscriptionRequestObjectAsync()
        {
            // Snippet: DeleteTranscriptionAsync(DeleteTranscriptionRequest, CallSettings)
            // Additional: DeleteTranscriptionAsync(DeleteTranscriptionRequest, CancellationToken)
            // Create client
            TranscriptionsClient transcriptionsClient = await TranscriptionsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTranscriptionRequest request = new DeleteTranscriptionRequest
            {
                TranscriptionName = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]"),
            };
            // Make the request
            await transcriptionsClient.DeleteTranscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTranscription</summary>
        public void DeleteTranscription()
        {
            // Snippet: DeleteTranscription(string, CallSettings)
            // Create client
            TranscriptionsClient transcriptionsClient = TranscriptionsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/calls/[CALL]/transcriptions/[TRANSCRIPTION]";
            // Make the request
            transcriptionsClient.DeleteTranscription(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTranscriptionAsync</summary>
        public async Task DeleteTranscriptionAsync()
        {
            // Snippet: DeleteTranscriptionAsync(string, CallSettings)
            // Additional: DeleteTranscriptionAsync(string, CancellationToken)
            // Create client
            TranscriptionsClient transcriptionsClient = await TranscriptionsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/calls/[CALL]/transcriptions/[TRANSCRIPTION]";
            // Make the request
            await transcriptionsClient.DeleteTranscriptionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTranscription</summary>
        public void DeleteTranscriptionResourceNames()
        {
            // Snippet: DeleteTranscription(TranscriptionName, CallSettings)
            // Create client
            TranscriptionsClient transcriptionsClient = TranscriptionsClient.Create();
            // Initialize request argument(s)
            TranscriptionName name = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]");
            // Make the request
            transcriptionsClient.DeleteTranscription(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTranscriptionAsync</summary>
        public async Task DeleteTranscriptionResourceNamesAsync()
        {
            // Snippet: DeleteTranscriptionAsync(TranscriptionName, CallSettings)
            // Additional: DeleteTranscriptionAsync(TranscriptionName, CancellationToken)
            // Create client
            TranscriptionsClient transcriptionsClient = await TranscriptionsClient.CreateAsync();
            // Initialize request argument(s)
            TranscriptionName name = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]");
            // Make the request
            await transcriptionsClient.DeleteTranscriptionAsync(name);
            // End snippet
        }
    }
}
