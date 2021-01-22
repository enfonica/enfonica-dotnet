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
    public sealed class GeneratedMessagesClientSnippets
    {
        /// <summary>Snippet for CreateMessage</summary>
        public void CreateMessageRequestObject()
        {
            // Snippet: CreateMessage(CreateMessageRequest, CallSettings)
            // Create client
            MessagesClient messagesClient = MessagesClient.Create();
            // Initialize request argument(s)
            CreateMessageRequest request = new CreateMessageRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Message = new Message(),
            };
            // Make the request
            Message response = messagesClient.CreateMessage(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMessageAsync</summary>
        public async Task CreateMessageRequestObjectAsync()
        {
            // Snippet: CreateMessageAsync(CreateMessageRequest, CallSettings)
            // Additional: CreateMessageAsync(CreateMessageRequest, CancellationToken)
            // Create client
            MessagesClient messagesClient = await MessagesClient.CreateAsync();
            // Initialize request argument(s)
            CreateMessageRequest request = new CreateMessageRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Message = new Message(),
            };
            // Make the request
            Message response = await messagesClient.CreateMessageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMessage</summary>
        public void CreateMessage()
        {
            // Snippet: CreateMessage(string, Message, CallSettings)
            // Create client
            MessagesClient messagesClient = MessagesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Message message = new Message();
            // Make the request
            Message response = messagesClient.CreateMessage(parent, message);
            // End snippet
        }

        /// <summary>Snippet for CreateMessageAsync</summary>
        public async Task CreateMessageAsync()
        {
            // Snippet: CreateMessageAsync(string, Message, CallSettings)
            // Additional: CreateMessageAsync(string, Message, CancellationToken)
            // Create client
            MessagesClient messagesClient = await MessagesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Message message = new Message();
            // Make the request
            Message response = await messagesClient.CreateMessageAsync(parent, message);
            // End snippet
        }

        /// <summary>Snippet for CreateMessage</summary>
        public void CreateMessageResourceNames()
        {
            // Snippet: CreateMessage(ProjectName, Message, CallSettings)
            // Create client
            MessagesClient messagesClient = MessagesClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Message message = new Message();
            // Make the request
            Message response = messagesClient.CreateMessage(parent, message);
            // End snippet
        }

        /// <summary>Snippet for CreateMessageAsync</summary>
        public async Task CreateMessageResourceNamesAsync()
        {
            // Snippet: CreateMessageAsync(ProjectName, Message, CallSettings)
            // Additional: CreateMessageAsync(ProjectName, Message, CancellationToken)
            // Create client
            MessagesClient messagesClient = await MessagesClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Message message = new Message();
            // Make the request
            Message response = await messagesClient.CreateMessageAsync(parent, message);
            // End snippet
        }

        /// <summary>Snippet for GetMessage</summary>
        public void GetMessageRequestObject()
        {
            // Snippet: GetMessage(GetMessageRequest, CallSettings)
            // Create client
            MessagesClient messagesClient = MessagesClient.Create();
            // Initialize request argument(s)
            GetMessageRequest request = new GetMessageRequest
            {
                MessageName = MessageName.FromProjectMessage("[PROJECT]", "[MESSAGE]"),
            };
            // Make the request
            Message response = messagesClient.GetMessage(request);
            // End snippet
        }

        /// <summary>Snippet for GetMessageAsync</summary>
        public async Task GetMessageRequestObjectAsync()
        {
            // Snippet: GetMessageAsync(GetMessageRequest, CallSettings)
            // Additional: GetMessageAsync(GetMessageRequest, CancellationToken)
            // Create client
            MessagesClient messagesClient = await MessagesClient.CreateAsync();
            // Initialize request argument(s)
            GetMessageRequest request = new GetMessageRequest
            {
                MessageName = MessageName.FromProjectMessage("[PROJECT]", "[MESSAGE]"),
            };
            // Make the request
            Message response = await messagesClient.GetMessageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMessage</summary>
        public void GetMessage()
        {
            // Snippet: GetMessage(string, CallSettings)
            // Create client
            MessagesClient messagesClient = MessagesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/messages/[MESSAGE]";
            // Make the request
            Message response = messagesClient.GetMessage(name);
            // End snippet
        }

        /// <summary>Snippet for GetMessageAsync</summary>
        public async Task GetMessageAsync()
        {
            // Snippet: GetMessageAsync(string, CallSettings)
            // Additional: GetMessageAsync(string, CancellationToken)
            // Create client
            MessagesClient messagesClient = await MessagesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/messages/[MESSAGE]";
            // Make the request
            Message response = await messagesClient.GetMessageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMessage</summary>
        public void GetMessageResourceNames()
        {
            // Snippet: GetMessage(MessageName, CallSettings)
            // Create client
            MessagesClient messagesClient = MessagesClient.Create();
            // Initialize request argument(s)
            MessageName name = MessageName.FromProjectMessage("[PROJECT]", "[MESSAGE]");
            // Make the request
            Message response = messagesClient.GetMessage(name);
            // End snippet
        }

        /// <summary>Snippet for GetMessageAsync</summary>
        public async Task GetMessageResourceNamesAsync()
        {
            // Snippet: GetMessageAsync(MessageName, CallSettings)
            // Additional: GetMessageAsync(MessageName, CancellationToken)
            // Create client
            MessagesClient messagesClient = await MessagesClient.CreateAsync();
            // Initialize request argument(s)
            MessageName name = MessageName.FromProjectMessage("[PROJECT]", "[MESSAGE]");
            // Make the request
            Message response = await messagesClient.GetMessageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMessages</summary>
        public void ListMessagesRequestObject()
        {
            // Snippet: ListMessages(ListMessagesRequest, CallSettings)
            // Create client
            MessagesClient messagesClient = MessagesClient.Create();
            // Initialize request argument(s)
            ListMessagesRequest request = new ListMessagesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            // Make the request
            PagedEnumerable<ListMessagesResponse, Message> response = messagesClient.ListMessages(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Message item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMessagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Message item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Message> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Message item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMessages</summary>
        public async Task ListMessagesRequestObjectAsync()
        {
            // Snippet: ListMessagesAsync(ListMessagesRequest, CallSettings)
            // Create client
            MessagesClient messagesClient = await MessagesClient.CreateAsync();
            // Initialize request argument(s)
            ListMessagesRequest request = new ListMessagesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            // Make the request
            PagedAsyncEnumerable<ListMessagesResponse, Message> response = messagesClient.ListMessagesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Message item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMessagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Message item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Message> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Message item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMessages</summary>
        public void ListMessages()
        {
            // Snippet: ListMessages(string, string, int?, CallSettings)
            // Create client
            MessagesClient messagesClient = MessagesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListMessagesResponse, Message> response = messagesClient.ListMessages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Message item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMessagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Message item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Message> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Message item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMessages</summary>
        public async Task ListMessagesAsync()
        {
            // Snippet: ListMessagesAsync(string, string, int?, CallSettings)
            // Create client
            MessagesClient messagesClient = await MessagesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListMessagesResponse, Message> response = messagesClient.ListMessagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Message item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMessagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Message item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Message> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Message item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMessages</summary>
        public void ListMessagesResourceNames()
        {
            // Snippet: ListMessages(ProjectName, string, int?, CallSettings)
            // Create client
            MessagesClient messagesClient = MessagesClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListMessagesResponse, Message> response = messagesClient.ListMessages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Message item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMessagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Message item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Message> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Message item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMessages</summary>
        public async Task ListMessagesResourceNamesAsync()
        {
            // Snippet: ListMessagesAsync(ProjectName, string, int?, CallSettings)
            // Create client
            MessagesClient messagesClient = await MessagesClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListMessagesResponse, Message> response = messagesClient.ListMessagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Message item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMessagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Message item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Message> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Message item in singlePage)
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
