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

namespace Enfonica.Numbering.V1Beta1.Snippets
{
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRegulatoryListingsClientSnippets
    {
        /// <summary>Snippet for CreateRegulatoryListing</summary>
        public void CreateRegulatoryListingRequestObject()
        {
            // Snippet: CreateRegulatoryListing(CreateRegulatoryListingRequest, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = RegulatoryListingsClient.Create();
            // Initialize request argument(s)
            CreateRegulatoryListingRequest request = new CreateRegulatoryListingRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                RegulatoryListing = new RegulatoryListing(),
            };
            // Make the request
            RegulatoryListing response = regulatoryListingsClient.CreateRegulatoryListing(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRegulatoryListingAsync</summary>
        public async Task CreateRegulatoryListingRequestObjectAsync()
        {
            // Snippet: CreateRegulatoryListingAsync(CreateRegulatoryListingRequest, CallSettings)
            // Additional: CreateRegulatoryListingAsync(CreateRegulatoryListingRequest, CancellationToken)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = await RegulatoryListingsClient.CreateAsync();
            // Initialize request argument(s)
            CreateRegulatoryListingRequest request = new CreateRegulatoryListingRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                RegulatoryListing = new RegulatoryListing(),
            };
            // Make the request
            RegulatoryListing response = await regulatoryListingsClient.CreateRegulatoryListingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRegulatoryListing</summary>
        public void CreateRegulatoryListing()
        {
            // Snippet: CreateRegulatoryListing(string, RegulatoryListing, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = RegulatoryListingsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            RegulatoryListing regulatoryListing = new RegulatoryListing();
            // Make the request
            RegulatoryListing response = regulatoryListingsClient.CreateRegulatoryListing(parent, regulatoryListing);
            // End snippet
        }

        /// <summary>Snippet for CreateRegulatoryListingAsync</summary>
        public async Task CreateRegulatoryListingAsync()
        {
            // Snippet: CreateRegulatoryListingAsync(string, RegulatoryListing, CallSettings)
            // Additional: CreateRegulatoryListingAsync(string, RegulatoryListing, CancellationToken)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = await RegulatoryListingsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            RegulatoryListing regulatoryListing = new RegulatoryListing();
            // Make the request
            RegulatoryListing response = await regulatoryListingsClient.CreateRegulatoryListingAsync(parent, regulatoryListing);
            // End snippet
        }

        /// <summary>Snippet for CreateRegulatoryListing</summary>
        public void CreateRegulatoryListingResourceNames()
        {
            // Snippet: CreateRegulatoryListing(ProjectName, RegulatoryListing, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = RegulatoryListingsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            RegulatoryListing regulatoryListing = new RegulatoryListing();
            // Make the request
            RegulatoryListing response = regulatoryListingsClient.CreateRegulatoryListing(parent, regulatoryListing);
            // End snippet
        }

        /// <summary>Snippet for CreateRegulatoryListingAsync</summary>
        public async Task CreateRegulatoryListingResourceNamesAsync()
        {
            // Snippet: CreateRegulatoryListingAsync(ProjectName, RegulatoryListing, CallSettings)
            // Additional: CreateRegulatoryListingAsync(ProjectName, RegulatoryListing, CancellationToken)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = await RegulatoryListingsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            RegulatoryListing regulatoryListing = new RegulatoryListing();
            // Make the request
            RegulatoryListing response = await regulatoryListingsClient.CreateRegulatoryListingAsync(parent, regulatoryListing);
            // End snippet
        }

        /// <summary>Snippet for GetRegulatoryListing</summary>
        public void GetRegulatoryListingRequestObject()
        {
            // Snippet: GetRegulatoryListing(GetRegulatoryListingRequest, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = RegulatoryListingsClient.Create();
            // Initialize request argument(s)
            GetRegulatoryListingRequest request = new GetRegulatoryListingRequest
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
            };
            // Make the request
            RegulatoryListing response = regulatoryListingsClient.GetRegulatoryListing(request);
            // End snippet
        }

        /// <summary>Snippet for GetRegulatoryListingAsync</summary>
        public async Task GetRegulatoryListingRequestObjectAsync()
        {
            // Snippet: GetRegulatoryListingAsync(GetRegulatoryListingRequest, CallSettings)
            // Additional: GetRegulatoryListingAsync(GetRegulatoryListingRequest, CancellationToken)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = await RegulatoryListingsClient.CreateAsync();
            // Initialize request argument(s)
            GetRegulatoryListingRequest request = new GetRegulatoryListingRequest
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
            };
            // Make the request
            RegulatoryListing response = await regulatoryListingsClient.GetRegulatoryListingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRegulatoryListing</summary>
        public void GetRegulatoryListing()
        {
            // Snippet: GetRegulatoryListing(string, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = RegulatoryListingsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/regulatoryListings/[REGULATORY_LISTING]";
            // Make the request
            RegulatoryListing response = regulatoryListingsClient.GetRegulatoryListing(name);
            // End snippet
        }

        /// <summary>Snippet for GetRegulatoryListingAsync</summary>
        public async Task GetRegulatoryListingAsync()
        {
            // Snippet: GetRegulatoryListingAsync(string, CallSettings)
            // Additional: GetRegulatoryListingAsync(string, CancellationToken)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = await RegulatoryListingsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/regulatoryListings/[REGULATORY_LISTING]";
            // Make the request
            RegulatoryListing response = await regulatoryListingsClient.GetRegulatoryListingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRegulatoryListing</summary>
        public void GetRegulatoryListingResourceNames()
        {
            // Snippet: GetRegulatoryListing(RegulatoryListingName, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = RegulatoryListingsClient.Create();
            // Initialize request argument(s)
            RegulatoryListingName name = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]");
            // Make the request
            RegulatoryListing response = regulatoryListingsClient.GetRegulatoryListing(name);
            // End snippet
        }

        /// <summary>Snippet for GetRegulatoryListingAsync</summary>
        public async Task GetRegulatoryListingResourceNamesAsync()
        {
            // Snippet: GetRegulatoryListingAsync(RegulatoryListingName, CallSettings)
            // Additional: GetRegulatoryListingAsync(RegulatoryListingName, CancellationToken)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = await RegulatoryListingsClient.CreateAsync();
            // Initialize request argument(s)
            RegulatoryListingName name = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]");
            // Make the request
            RegulatoryListing response = await regulatoryListingsClient.GetRegulatoryListingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListRegulatoryListings</summary>
        public void ListRegulatoryListingsRequestObject()
        {
            // Snippet: ListRegulatoryListings(ListRegulatoryListingsRequest, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = RegulatoryListingsClient.Create();
            // Initialize request argument(s)
            ListRegulatoryListingsRequest request = new ListRegulatoryListingsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListRegulatoryListingsResponse, RegulatoryListing> response = regulatoryListingsClient.ListRegulatoryListings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RegulatoryListing item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRegulatoryListingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RegulatoryListing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RegulatoryListing> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RegulatoryListing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRegulatoryListingsAsync</summary>
        public async Task ListRegulatoryListingsRequestObjectAsync()
        {
            // Snippet: ListRegulatoryListingsAsync(ListRegulatoryListingsRequest, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = await RegulatoryListingsClient.CreateAsync();
            // Initialize request argument(s)
            ListRegulatoryListingsRequest request = new ListRegulatoryListingsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListRegulatoryListingsResponse, RegulatoryListing> response = regulatoryListingsClient.ListRegulatoryListingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RegulatoryListing item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRegulatoryListingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RegulatoryListing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RegulatoryListing> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RegulatoryListing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRegulatoryListings</summary>
        public void ListRegulatoryListings()
        {
            // Snippet: ListRegulatoryListings(string, string, int?, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = RegulatoryListingsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListRegulatoryListingsResponse, RegulatoryListing> response = regulatoryListingsClient.ListRegulatoryListings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RegulatoryListing item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRegulatoryListingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RegulatoryListing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RegulatoryListing> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RegulatoryListing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRegulatoryListingsAsync</summary>
        public async Task ListRegulatoryListingsAsync()
        {
            // Snippet: ListRegulatoryListingsAsync(string, string, int?, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = await RegulatoryListingsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListRegulatoryListingsResponse, RegulatoryListing> response = regulatoryListingsClient.ListRegulatoryListingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RegulatoryListing item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRegulatoryListingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RegulatoryListing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RegulatoryListing> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RegulatoryListing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRegulatoryListings</summary>
        public void ListRegulatoryListingsResourceNames()
        {
            // Snippet: ListRegulatoryListings(ProjectName, string, int?, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = RegulatoryListingsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListRegulatoryListingsResponse, RegulatoryListing> response = regulatoryListingsClient.ListRegulatoryListings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RegulatoryListing item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRegulatoryListingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RegulatoryListing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RegulatoryListing> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RegulatoryListing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRegulatoryListingsAsync</summary>
        public async Task ListRegulatoryListingsResourceNamesAsync()
        {
            // Snippet: ListRegulatoryListingsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = await RegulatoryListingsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListRegulatoryListingsResponse, RegulatoryListing> response = regulatoryListingsClient.ListRegulatoryListingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RegulatoryListing item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRegulatoryListingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RegulatoryListing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RegulatoryListing> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RegulatoryListing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateRegulatoryListing</summary>
        public void UpdateRegulatoryListingRequestObject()
        {
            // Snippet: UpdateRegulatoryListing(UpdateRegulatoryListingRequest, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = RegulatoryListingsClient.Create();
            // Initialize request argument(s)
            UpdateRegulatoryListingRequest request = new UpdateRegulatoryListingRequest
            {
                RegulatoryListing = new RegulatoryListing(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            RegulatoryListing response = regulatoryListingsClient.UpdateRegulatoryListing(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRegulatoryListingAsync</summary>
        public async Task UpdateRegulatoryListingRequestObjectAsync()
        {
            // Snippet: UpdateRegulatoryListingAsync(UpdateRegulatoryListingRequest, CallSettings)
            // Additional: UpdateRegulatoryListingAsync(UpdateRegulatoryListingRequest, CancellationToken)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = await RegulatoryListingsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRegulatoryListingRequest request = new UpdateRegulatoryListingRequest
            {
                RegulatoryListing = new RegulatoryListing(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            RegulatoryListing response = await regulatoryListingsClient.UpdateRegulatoryListingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRegulatoryListing</summary>
        public void UpdateRegulatoryListing()
        {
            // Snippet: UpdateRegulatoryListing(RegulatoryListing, FieldMask, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = RegulatoryListingsClient.Create();
            // Initialize request argument(s)
            RegulatoryListing regulatoryListing = new RegulatoryListing();
            FieldMask updateMask = new FieldMask();
            // Make the request
            RegulatoryListing response = regulatoryListingsClient.UpdateRegulatoryListing(regulatoryListing, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateRegulatoryListingAsync</summary>
        public async Task UpdateRegulatoryListingAsync()
        {
            // Snippet: UpdateRegulatoryListingAsync(RegulatoryListing, FieldMask, CallSettings)
            // Additional: UpdateRegulatoryListingAsync(RegulatoryListing, FieldMask, CancellationToken)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = await RegulatoryListingsClient.CreateAsync();
            // Initialize request argument(s)
            RegulatoryListing regulatoryListing = new RegulatoryListing();
            FieldMask updateMask = new FieldMask();
            // Make the request
            RegulatoryListing response = await regulatoryListingsClient.UpdateRegulatoryListingAsync(regulatoryListing, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteRegulatoryListing</summary>
        public void DeleteRegulatoryListingRequestObject()
        {
            // Snippet: DeleteRegulatoryListing(DeleteRegulatoryListingRequest, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = RegulatoryListingsClient.Create();
            // Initialize request argument(s)
            DeleteRegulatoryListingRequest request = new DeleteRegulatoryListingRequest
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
            };
            // Make the request
            regulatoryListingsClient.DeleteRegulatoryListing(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRegulatoryListingAsync</summary>
        public async Task DeleteRegulatoryListingRequestObjectAsync()
        {
            // Snippet: DeleteRegulatoryListingAsync(DeleteRegulatoryListingRequest, CallSettings)
            // Additional: DeleteRegulatoryListingAsync(DeleteRegulatoryListingRequest, CancellationToken)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = await RegulatoryListingsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegulatoryListingRequest request = new DeleteRegulatoryListingRequest
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
            };
            // Make the request
            await regulatoryListingsClient.DeleteRegulatoryListingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRegulatoryListing</summary>
        public void DeleteRegulatoryListing()
        {
            // Snippet: DeleteRegulatoryListing(string, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = RegulatoryListingsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/regulatoryListings/[REGULATORY_LISTING]";
            // Make the request
            regulatoryListingsClient.DeleteRegulatoryListing(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRegulatoryListingAsync</summary>
        public async Task DeleteRegulatoryListingAsync()
        {
            // Snippet: DeleteRegulatoryListingAsync(string, CallSettings)
            // Additional: DeleteRegulatoryListingAsync(string, CancellationToken)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = await RegulatoryListingsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/regulatoryListings/[REGULATORY_LISTING]";
            // Make the request
            await regulatoryListingsClient.DeleteRegulatoryListingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRegulatoryListing</summary>
        public void DeleteRegulatoryListingResourceNames()
        {
            // Snippet: DeleteRegulatoryListing(RegulatoryListingName, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = RegulatoryListingsClient.Create();
            // Initialize request argument(s)
            RegulatoryListingName name = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]");
            // Make the request
            regulatoryListingsClient.DeleteRegulatoryListing(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRegulatoryListingAsync</summary>
        public async Task DeleteRegulatoryListingResourceNamesAsync()
        {
            // Snippet: DeleteRegulatoryListingAsync(RegulatoryListingName, CallSettings)
            // Additional: DeleteRegulatoryListingAsync(RegulatoryListingName, CancellationToken)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = await RegulatoryListingsClient.CreateAsync();
            // Initialize request argument(s)
            RegulatoryListingName name = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]");
            // Make the request
            await regulatoryListingsClient.DeleteRegulatoryListingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SearchRegulatoryListings</summary>
        public void SearchRegulatoryListingsRequestObject()
        {
            // Snippet: SearchRegulatoryListings(SearchRegulatoryListingsRequest, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = RegulatoryListingsClient.Create();
            // Initialize request argument(s)
            SearchRegulatoryListingsRequest request = new SearchRegulatoryListingsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                RegionCode = "",
                NumberType = PhoneNumber.Types.PhoneNumberType.Unspecified,
            };
            // Make the request
            PagedEnumerable<SearchRegulatoryListingsResponse, RegulatoryListing> response = regulatoryListingsClient.SearchRegulatoryListings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RegulatoryListing item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchRegulatoryListingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RegulatoryListing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RegulatoryListing> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RegulatoryListing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchRegulatoryListingsAsync</summary>
        public async Task SearchRegulatoryListingsRequestObjectAsync()
        {
            // Snippet: SearchRegulatoryListingsAsync(SearchRegulatoryListingsRequest, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = await RegulatoryListingsClient.CreateAsync();
            // Initialize request argument(s)
            SearchRegulatoryListingsRequest request = new SearchRegulatoryListingsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                RegionCode = "",
                NumberType = PhoneNumber.Types.PhoneNumberType.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<SearchRegulatoryListingsResponse, RegulatoryListing> response = regulatoryListingsClient.SearchRegulatoryListingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RegulatoryListing item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchRegulatoryListingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RegulatoryListing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RegulatoryListing> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RegulatoryListing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchRegulatoryListings</summary>
        public void SearchRegulatoryListings()
        {
            // Snippet: SearchRegulatoryListings(string, string, PhoneNumber.Types.PhoneNumberType, string, int?, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = RegulatoryListingsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string regionCode = "";
            PhoneNumber.Types.PhoneNumberType numberType = PhoneNumber.Types.PhoneNumberType.Unspecified;
            // Make the request
            PagedEnumerable<SearchRegulatoryListingsResponse, RegulatoryListing> response = regulatoryListingsClient.SearchRegulatoryListings(parent, regionCode, numberType);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RegulatoryListing item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchRegulatoryListingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RegulatoryListing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RegulatoryListing> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RegulatoryListing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchRegulatoryListingsAsync</summary>
        public async Task SearchRegulatoryListingsAsync()
        {
            // Snippet: SearchRegulatoryListingsAsync(string, string, PhoneNumber.Types.PhoneNumberType, string, int?, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = await RegulatoryListingsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string regionCode = "";
            PhoneNumber.Types.PhoneNumberType numberType = PhoneNumber.Types.PhoneNumberType.Unspecified;
            // Make the request
            PagedAsyncEnumerable<SearchRegulatoryListingsResponse, RegulatoryListing> response = regulatoryListingsClient.SearchRegulatoryListingsAsync(parent, regionCode, numberType);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RegulatoryListing item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchRegulatoryListingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RegulatoryListing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RegulatoryListing> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RegulatoryListing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchRegulatoryListings</summary>
        public void SearchRegulatoryListingsResourceNames()
        {
            // Snippet: SearchRegulatoryListings(ProjectName, string, PhoneNumber.Types.PhoneNumberType, string, int?, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = RegulatoryListingsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string regionCode = "";
            PhoneNumber.Types.PhoneNumberType numberType = PhoneNumber.Types.PhoneNumberType.Unspecified;
            // Make the request
            PagedEnumerable<SearchRegulatoryListingsResponse, RegulatoryListing> response = regulatoryListingsClient.SearchRegulatoryListings(parent, regionCode, numberType);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RegulatoryListing item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchRegulatoryListingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RegulatoryListing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RegulatoryListing> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RegulatoryListing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchRegulatoryListingsAsync</summary>
        public async Task SearchRegulatoryListingsResourceNamesAsync()
        {
            // Snippet: SearchRegulatoryListingsAsync(ProjectName, string, PhoneNumber.Types.PhoneNumberType, string, int?, CallSettings)
            // Create client
            RegulatoryListingsClient regulatoryListingsClient = await RegulatoryListingsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string regionCode = "";
            PhoneNumber.Types.PhoneNumberType numberType = PhoneNumber.Types.PhoneNumberType.Unspecified;
            // Make the request
            PagedAsyncEnumerable<SearchRegulatoryListingsResponse, RegulatoryListing> response = regulatoryListingsClient.SearchRegulatoryListingsAsync(parent, regionCode, numberType);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RegulatoryListing item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchRegulatoryListingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RegulatoryListing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RegulatoryListing> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RegulatoryListing item in singlePage)
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
