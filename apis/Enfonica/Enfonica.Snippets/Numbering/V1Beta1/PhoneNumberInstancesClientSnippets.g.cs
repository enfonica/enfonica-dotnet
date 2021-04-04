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
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
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
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                PhoneNumberInstance = new PhoneNumberInstance(),
            };
            // Make the request
            PhoneNumberInstance response = await phoneNumberInstancesClient.CreatePhoneNumberInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePhoneNumberInstance</summary>
        public void CreatePhoneNumberInstance()
        {
            // Snippet: CreatePhoneNumberInstance(string, PhoneNumberInstance, CallSettings)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = PhoneNumberInstancesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            PhoneNumberInstance phoneNumberInstance = new PhoneNumberInstance();
            // Make the request
            PhoneNumberInstance response = phoneNumberInstancesClient.CreatePhoneNumberInstance(parent, phoneNumberInstance);
            // End snippet
        }

        /// <summary>Snippet for CreatePhoneNumberInstanceAsync</summary>
        public async Task CreatePhoneNumberInstanceAsync()
        {
            // Snippet: CreatePhoneNumberInstanceAsync(string, PhoneNumberInstance, CallSettings)
            // Additional: CreatePhoneNumberInstanceAsync(string, PhoneNumberInstance, CancellationToken)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = await PhoneNumberInstancesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            PhoneNumberInstance phoneNumberInstance = new PhoneNumberInstance();
            // Make the request
            PhoneNumberInstance response = await phoneNumberInstancesClient.CreatePhoneNumberInstanceAsync(parent, phoneNumberInstance);
            // End snippet
        }

        /// <summary>Snippet for CreatePhoneNumberInstance</summary>
        public void CreatePhoneNumberInstanceResourceNames()
        {
            // Snippet: CreatePhoneNumberInstance(ProjectName, PhoneNumberInstance, CallSettings)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = PhoneNumberInstancesClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            PhoneNumberInstance phoneNumberInstance = new PhoneNumberInstance();
            // Make the request
            PhoneNumberInstance response = phoneNumberInstancesClient.CreatePhoneNumberInstance(parent, phoneNumberInstance);
            // End snippet
        }

        /// <summary>Snippet for CreatePhoneNumberInstanceAsync</summary>
        public async Task CreatePhoneNumberInstanceResourceNamesAsync()
        {
            // Snippet: CreatePhoneNumberInstanceAsync(ProjectName, PhoneNumberInstance, CallSettings)
            // Additional: CreatePhoneNumberInstanceAsync(ProjectName, PhoneNumberInstance, CancellationToken)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = await PhoneNumberInstancesClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            PhoneNumberInstance phoneNumberInstance = new PhoneNumberInstance();
            // Make the request
            PhoneNumberInstance response = await phoneNumberInstancesClient.CreatePhoneNumberInstanceAsync(parent, phoneNumberInstance);
            // End snippet
        }

        /// <summary>Snippet for GetPhoneNumberInstance</summary>
        public void GetPhoneNumberInstanceRequestObject()
        {
            // Snippet: GetPhoneNumberInstance(GetPhoneNumberInstanceRequest, CallSettings)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = PhoneNumberInstancesClient.Create();
            // Initialize request argument(s)
            GetPhoneNumberInstanceRequest request = new GetPhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
            };
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
            GetPhoneNumberInstanceRequest request = new GetPhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
            };
            // Make the request
            PhoneNumberInstance response = await phoneNumberInstancesClient.GetPhoneNumberInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPhoneNumberInstance</summary>
        public void GetPhoneNumberInstance()
        {
            // Snippet: GetPhoneNumberInstance(string, CallSettings)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = PhoneNumberInstancesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/phoneNumberInstances/[PHONE_NUMBER_INSTANCE]";
            // Make the request
            PhoneNumberInstance response = phoneNumberInstancesClient.GetPhoneNumberInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetPhoneNumberInstanceAsync</summary>
        public async Task GetPhoneNumberInstanceAsync()
        {
            // Snippet: GetPhoneNumberInstanceAsync(string, CallSettings)
            // Additional: GetPhoneNumberInstanceAsync(string, CancellationToken)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = await PhoneNumberInstancesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/phoneNumberInstances/[PHONE_NUMBER_INSTANCE]";
            // Make the request
            PhoneNumberInstance response = await phoneNumberInstancesClient.GetPhoneNumberInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPhoneNumberInstance</summary>
        public void GetPhoneNumberInstanceResourceNames()
        {
            // Snippet: GetPhoneNumberInstance(PhoneNumberInstanceName, CallSettings)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = PhoneNumberInstancesClient.Create();
            // Initialize request argument(s)
            PhoneNumberInstanceName name = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]");
            // Make the request
            PhoneNumberInstance response = phoneNumberInstancesClient.GetPhoneNumberInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetPhoneNumberInstanceAsync</summary>
        public async Task GetPhoneNumberInstanceResourceNamesAsync()
        {
            // Snippet: GetPhoneNumberInstanceAsync(PhoneNumberInstanceName, CallSettings)
            // Additional: GetPhoneNumberInstanceAsync(PhoneNumberInstanceName, CancellationToken)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = await PhoneNumberInstancesClient.CreateAsync();
            // Initialize request argument(s)
            PhoneNumberInstanceName name = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]");
            // Make the request
            PhoneNumberInstance response = await phoneNumberInstancesClient.GetPhoneNumberInstanceAsync(name);
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
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
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

        /// <summary>Snippet for ListPhoneNumberInstancesAsync</summary>
        public async Task ListPhoneNumberInstancesRequestObjectAsync()
        {
            // Snippet: ListPhoneNumberInstancesAsync(ListPhoneNumberInstancesRequest, CallSettings)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = await PhoneNumberInstancesClient.CreateAsync();
            // Initialize request argument(s)
            ListPhoneNumberInstancesRequest request = new ListPhoneNumberInstancesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
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

        /// <summary>Snippet for ListPhoneNumberInstances</summary>
        public void ListPhoneNumberInstances()
        {
            // Snippet: ListPhoneNumberInstances(string, string, int?, CallSettings)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = PhoneNumberInstancesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListPhoneNumberInstancesResponse, PhoneNumberInstance> response = phoneNumberInstancesClient.ListPhoneNumberInstances(parent);

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

        /// <summary>Snippet for ListPhoneNumberInstancesAsync</summary>
        public async Task ListPhoneNumberInstancesAsync()
        {
            // Snippet: ListPhoneNumberInstancesAsync(string, string, int?, CallSettings)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = await PhoneNumberInstancesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListPhoneNumberInstancesResponse, PhoneNumberInstance> response = phoneNumberInstancesClient.ListPhoneNumberInstancesAsync(parent);

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

        /// <summary>Snippet for ListPhoneNumberInstances</summary>
        public void ListPhoneNumberInstancesResourceNames()
        {
            // Snippet: ListPhoneNumberInstances(ProjectName, string, int?, CallSettings)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = PhoneNumberInstancesClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListPhoneNumberInstancesResponse, PhoneNumberInstance> response = phoneNumberInstancesClient.ListPhoneNumberInstances(parent);

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

        /// <summary>Snippet for ListPhoneNumberInstancesAsync</summary>
        public async Task ListPhoneNumberInstancesResourceNamesAsync()
        {
            // Snippet: ListPhoneNumberInstancesAsync(ProjectName, string, int?, CallSettings)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = await PhoneNumberInstancesClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListPhoneNumberInstancesResponse, PhoneNumberInstance> response = phoneNumberInstancesClient.ListPhoneNumberInstancesAsync(parent);

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
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
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
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumberInstance = new PhoneNumberInstance(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PhoneNumberInstance response = await phoneNumberInstancesClient.UpdatePhoneNumberInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePhoneNumberInstance</summary>
        public void UpdatePhoneNumberInstance()
        {
            // Snippet: UpdatePhoneNumberInstance(string, PhoneNumberInstance, FieldMask, CallSettings)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = PhoneNumberInstancesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/phoneNumberInstances/[PHONE_NUMBER_INSTANCE]";
            PhoneNumberInstance phoneNumberInstance = new PhoneNumberInstance();
            FieldMask updateMask = new FieldMask();
            // Make the request
            PhoneNumberInstance response = phoneNumberInstancesClient.UpdatePhoneNumberInstance(name, phoneNumberInstance, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdatePhoneNumberInstanceAsync</summary>
        public async Task UpdatePhoneNumberInstanceAsync()
        {
            // Snippet: UpdatePhoneNumberInstanceAsync(string, PhoneNumberInstance, FieldMask, CallSettings)
            // Additional: UpdatePhoneNumberInstanceAsync(string, PhoneNumberInstance, FieldMask, CancellationToken)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = await PhoneNumberInstancesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/phoneNumberInstances/[PHONE_NUMBER_INSTANCE]";
            PhoneNumberInstance phoneNumberInstance = new PhoneNumberInstance();
            FieldMask updateMask = new FieldMask();
            // Make the request
            PhoneNumberInstance response = await phoneNumberInstancesClient.UpdatePhoneNumberInstanceAsync(name, phoneNumberInstance, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdatePhoneNumberInstance</summary>
        public void UpdatePhoneNumberInstanceResourceNames()
        {
            // Snippet: UpdatePhoneNumberInstance(PhoneNumberInstanceName, PhoneNumberInstance, FieldMask, CallSettings)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = PhoneNumberInstancesClient.Create();
            // Initialize request argument(s)
            PhoneNumberInstanceName name = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]");
            PhoneNumberInstance phoneNumberInstance = new PhoneNumberInstance();
            FieldMask updateMask = new FieldMask();
            // Make the request
            PhoneNumberInstance response = phoneNumberInstancesClient.UpdatePhoneNumberInstance(name, phoneNumberInstance, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdatePhoneNumberInstanceAsync</summary>
        public async Task UpdatePhoneNumberInstanceResourceNamesAsync()
        {
            // Snippet: UpdatePhoneNumberInstanceAsync(PhoneNumberInstanceName, PhoneNumberInstance, FieldMask, CallSettings)
            // Additional: UpdatePhoneNumberInstanceAsync(PhoneNumberInstanceName, PhoneNumberInstance, FieldMask, CancellationToken)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = await PhoneNumberInstancesClient.CreateAsync();
            // Initialize request argument(s)
            PhoneNumberInstanceName name = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]");
            PhoneNumberInstance phoneNumberInstance = new PhoneNumberInstance();
            FieldMask updateMask = new FieldMask();
            // Make the request
            PhoneNumberInstance response = await phoneNumberInstancesClient.UpdatePhoneNumberInstanceAsync(name, phoneNumberInstance, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeletePhoneNumberInstance</summary>
        public void DeletePhoneNumberInstanceRequestObject()
        {
            // Snippet: DeletePhoneNumberInstance(DeletePhoneNumberInstanceRequest, CallSettings)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = PhoneNumberInstancesClient.Create();
            // Initialize request argument(s)
            DeletePhoneNumberInstanceRequest request = new DeletePhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
            };
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
            DeletePhoneNumberInstanceRequest request = new DeletePhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
            };
            // Make the request
            PhoneNumberInstance response = await phoneNumberInstancesClient.DeletePhoneNumberInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePhoneNumberInstance</summary>
        public void DeletePhoneNumberInstance()
        {
            // Snippet: DeletePhoneNumberInstance(string, CallSettings)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = PhoneNumberInstancesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/phoneNumberInstances/[PHONE_NUMBER_INSTANCE]";
            // Make the request
            PhoneNumberInstance response = phoneNumberInstancesClient.DeletePhoneNumberInstance(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePhoneNumberInstanceAsync</summary>
        public async Task DeletePhoneNumberInstanceAsync()
        {
            // Snippet: DeletePhoneNumberInstanceAsync(string, CallSettings)
            // Additional: DeletePhoneNumberInstanceAsync(string, CancellationToken)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = await PhoneNumberInstancesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/phoneNumberInstances/[PHONE_NUMBER_INSTANCE]";
            // Make the request
            PhoneNumberInstance response = await phoneNumberInstancesClient.DeletePhoneNumberInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePhoneNumberInstance</summary>
        public void DeletePhoneNumberInstanceResourceNames()
        {
            // Snippet: DeletePhoneNumberInstance(PhoneNumberInstanceName, CallSettings)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = PhoneNumberInstancesClient.Create();
            // Initialize request argument(s)
            PhoneNumberInstanceName name = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]");
            // Make the request
            PhoneNumberInstance response = phoneNumberInstancesClient.DeletePhoneNumberInstance(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePhoneNumberInstanceAsync</summary>
        public async Task DeletePhoneNumberInstanceResourceNamesAsync()
        {
            // Snippet: DeletePhoneNumberInstanceAsync(PhoneNumberInstanceName, CallSettings)
            // Additional: DeletePhoneNumberInstanceAsync(PhoneNumberInstanceName, CancellationToken)
            // Create client
            PhoneNumberInstancesClient phoneNumberInstancesClient = await PhoneNumberInstancesClient.CreateAsync();
            // Initialize request argument(s)
            PhoneNumberInstanceName name = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]");
            // Make the request
            PhoneNumberInstance response = await phoneNumberInstancesClient.DeletePhoneNumberInstanceAsync(name);
            // End snippet
        }
    }
}
