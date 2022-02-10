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
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSipDomainsClientSnippets
    {
        /// <summary>Snippet for CreateSipDomain</summary>
        public void CreateSipDomainRequestObject()
        {
            // Snippet: CreateSipDomain(CreateSipDomainRequest, CallSettings)
            // Create client
            SipDomainsClient sipDomainsClient = SipDomainsClient.Create();
            // Initialize request argument(s)
            CreateSipDomainRequest request = new CreateSipDomainRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                SipDomain = new SipDomain(),
                SipDomainId = "",
            };
            // Make the request
            SipDomain response = sipDomainsClient.CreateSipDomain(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSipDomainAsync</summary>
        public async Task CreateSipDomainRequestObjectAsync()
        {
            // Snippet: CreateSipDomainAsync(CreateSipDomainRequest, CallSettings)
            // Additional: CreateSipDomainAsync(CreateSipDomainRequest, CancellationToken)
            // Create client
            SipDomainsClient sipDomainsClient = await SipDomainsClient.CreateAsync();
            // Initialize request argument(s)
            CreateSipDomainRequest request = new CreateSipDomainRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                SipDomain = new SipDomain(),
                SipDomainId = "",
            };
            // Make the request
            SipDomain response = await sipDomainsClient.CreateSipDomainAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSipDomain</summary>
        public void CreateSipDomain()
        {
            // Snippet: CreateSipDomain(string, SipDomain, string, CallSettings)
            // Create client
            SipDomainsClient sipDomainsClient = SipDomainsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            SipDomain sipDomain = new SipDomain();
            string sipDomainId = "";
            // Make the request
            SipDomain response = sipDomainsClient.CreateSipDomain(parent, sipDomain, sipDomainId);
            // End snippet
        }

        /// <summary>Snippet for CreateSipDomainAsync</summary>
        public async Task CreateSipDomainAsync()
        {
            // Snippet: CreateSipDomainAsync(string, SipDomain, string, CallSettings)
            // Additional: CreateSipDomainAsync(string, SipDomain, string, CancellationToken)
            // Create client
            SipDomainsClient sipDomainsClient = await SipDomainsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            SipDomain sipDomain = new SipDomain();
            string sipDomainId = "";
            // Make the request
            SipDomain response = await sipDomainsClient.CreateSipDomainAsync(parent, sipDomain, sipDomainId);
            // End snippet
        }

        /// <summary>Snippet for CreateSipDomain</summary>
        public void CreateSipDomainResourceNames()
        {
            // Snippet: CreateSipDomain(ProjectName, SipDomain, string, CallSettings)
            // Create client
            SipDomainsClient sipDomainsClient = SipDomainsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            SipDomain sipDomain = new SipDomain();
            string sipDomainId = "";
            // Make the request
            SipDomain response = sipDomainsClient.CreateSipDomain(parent, sipDomain, sipDomainId);
            // End snippet
        }

        /// <summary>Snippet for CreateSipDomainAsync</summary>
        public async Task CreateSipDomainResourceNamesAsync()
        {
            // Snippet: CreateSipDomainAsync(ProjectName, SipDomain, string, CallSettings)
            // Additional: CreateSipDomainAsync(ProjectName, SipDomain, string, CancellationToken)
            // Create client
            SipDomainsClient sipDomainsClient = await SipDomainsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            SipDomain sipDomain = new SipDomain();
            string sipDomainId = "";
            // Make the request
            SipDomain response = await sipDomainsClient.CreateSipDomainAsync(parent, sipDomain, sipDomainId);
            // End snippet
        }

        /// <summary>Snippet for GetSipDomain</summary>
        public void GetSipDomainRequestObject()
        {
            // Snippet: GetSipDomain(GetSipDomainRequest, CallSettings)
            // Create client
            SipDomainsClient sipDomainsClient = SipDomainsClient.Create();
            // Initialize request argument(s)
            GetSipDomainRequest request = new GetSipDomainRequest
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
            };
            // Make the request
            SipDomain response = sipDomainsClient.GetSipDomain(request);
            // End snippet
        }

        /// <summary>Snippet for GetSipDomainAsync</summary>
        public async Task GetSipDomainRequestObjectAsync()
        {
            // Snippet: GetSipDomainAsync(GetSipDomainRequest, CallSettings)
            // Additional: GetSipDomainAsync(GetSipDomainRequest, CancellationToken)
            // Create client
            SipDomainsClient sipDomainsClient = await SipDomainsClient.CreateAsync();
            // Initialize request argument(s)
            GetSipDomainRequest request = new GetSipDomainRequest
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
            };
            // Make the request
            SipDomain response = await sipDomainsClient.GetSipDomainAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSipDomain</summary>
        public void GetSipDomain()
        {
            // Snippet: GetSipDomain(string, CallSettings)
            // Create client
            SipDomainsClient sipDomainsClient = SipDomainsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/sipDomains/[SIP_DOMAIN]";
            // Make the request
            SipDomain response = sipDomainsClient.GetSipDomain(name);
            // End snippet
        }

        /// <summary>Snippet for GetSipDomainAsync</summary>
        public async Task GetSipDomainAsync()
        {
            // Snippet: GetSipDomainAsync(string, CallSettings)
            // Additional: GetSipDomainAsync(string, CancellationToken)
            // Create client
            SipDomainsClient sipDomainsClient = await SipDomainsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/sipDomains/[SIP_DOMAIN]";
            // Make the request
            SipDomain response = await sipDomainsClient.GetSipDomainAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSipDomain</summary>
        public void GetSipDomainResourceNames()
        {
            // Snippet: GetSipDomain(SipDomainName, CallSettings)
            // Create client
            SipDomainsClient sipDomainsClient = SipDomainsClient.Create();
            // Initialize request argument(s)
            SipDomainName name = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]");
            // Make the request
            SipDomain response = sipDomainsClient.GetSipDomain(name);
            // End snippet
        }

        /// <summary>Snippet for GetSipDomainAsync</summary>
        public async Task GetSipDomainResourceNamesAsync()
        {
            // Snippet: GetSipDomainAsync(SipDomainName, CallSettings)
            // Additional: GetSipDomainAsync(SipDomainName, CancellationToken)
            // Create client
            SipDomainsClient sipDomainsClient = await SipDomainsClient.CreateAsync();
            // Initialize request argument(s)
            SipDomainName name = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]");
            // Make the request
            SipDomain response = await sipDomainsClient.GetSipDomainAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSipDomains</summary>
        public void ListSipDomainsRequestObject()
        {
            // Snippet: ListSipDomains(ListSipDomainsRequest, CallSettings)
            // Create client
            SipDomainsClient sipDomainsClient = SipDomainsClient.Create();
            // Initialize request argument(s)
            ListSipDomainsRequest request = new ListSipDomainsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<ListSipDomainsResponse, SipDomain> response = sipDomainsClient.ListSipDomains(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SipDomain item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSipDomainsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SipDomain item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SipDomain> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SipDomain item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSipDomainsAsync</summary>
        public async Task ListSipDomainsRequestObjectAsync()
        {
            // Snippet: ListSipDomainsAsync(ListSipDomainsRequest, CallSettings)
            // Create client
            SipDomainsClient sipDomainsClient = await SipDomainsClient.CreateAsync();
            // Initialize request argument(s)
            ListSipDomainsRequest request = new ListSipDomainsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListSipDomainsResponse, SipDomain> response = sipDomainsClient.ListSipDomainsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SipDomain item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSipDomainsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SipDomain item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SipDomain> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SipDomain item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSipDomains</summary>
        public void ListSipDomains()
        {
            // Snippet: ListSipDomains(string, string, int?, CallSettings)
            // Create client
            SipDomainsClient sipDomainsClient = SipDomainsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListSipDomainsResponse, SipDomain> response = sipDomainsClient.ListSipDomains(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SipDomain item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSipDomainsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SipDomain item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SipDomain> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SipDomain item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSipDomainsAsync</summary>
        public async Task ListSipDomainsAsync()
        {
            // Snippet: ListSipDomainsAsync(string, string, int?, CallSettings)
            // Create client
            SipDomainsClient sipDomainsClient = await SipDomainsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListSipDomainsResponse, SipDomain> response = sipDomainsClient.ListSipDomainsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SipDomain item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSipDomainsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SipDomain item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SipDomain> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SipDomain item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSipDomains</summary>
        public void ListSipDomainsResourceNames()
        {
            // Snippet: ListSipDomains(ProjectName, string, int?, CallSettings)
            // Create client
            SipDomainsClient sipDomainsClient = SipDomainsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListSipDomainsResponse, SipDomain> response = sipDomainsClient.ListSipDomains(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SipDomain item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSipDomainsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SipDomain item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SipDomain> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SipDomain item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSipDomainsAsync</summary>
        public async Task ListSipDomainsResourceNamesAsync()
        {
            // Snippet: ListSipDomainsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            SipDomainsClient sipDomainsClient = await SipDomainsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListSipDomainsResponse, SipDomain> response = sipDomainsClient.ListSipDomainsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SipDomain item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSipDomainsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SipDomain item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SipDomain> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SipDomain item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateSipDomain</summary>
        public void UpdateSipDomainRequestObject()
        {
            // Snippet: UpdateSipDomain(UpdateSipDomainRequest, CallSettings)
            // Create client
            SipDomainsClient sipDomainsClient = SipDomainsClient.Create();
            // Initialize request argument(s)
            UpdateSipDomainRequest request = new UpdateSipDomainRequest
            {
                SipDomain = new SipDomain(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SipDomain response = sipDomainsClient.UpdateSipDomain(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSipDomainAsync</summary>
        public async Task UpdateSipDomainRequestObjectAsync()
        {
            // Snippet: UpdateSipDomainAsync(UpdateSipDomainRequest, CallSettings)
            // Additional: UpdateSipDomainAsync(UpdateSipDomainRequest, CancellationToken)
            // Create client
            SipDomainsClient sipDomainsClient = await SipDomainsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSipDomainRequest request = new UpdateSipDomainRequest
            {
                SipDomain = new SipDomain(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SipDomain response = await sipDomainsClient.UpdateSipDomainAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSipDomain</summary>
        public void UpdateSipDomain()
        {
            // Snippet: UpdateSipDomain(SipDomain, FieldMask, CallSettings)
            // Create client
            SipDomainsClient sipDomainsClient = SipDomainsClient.Create();
            // Initialize request argument(s)
            SipDomain sipDomain = new SipDomain();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SipDomain response = sipDomainsClient.UpdateSipDomain(sipDomain, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSipDomainAsync</summary>
        public async Task UpdateSipDomainAsync()
        {
            // Snippet: UpdateSipDomainAsync(SipDomain, FieldMask, CallSettings)
            // Additional: UpdateSipDomainAsync(SipDomain, FieldMask, CancellationToken)
            // Create client
            SipDomainsClient sipDomainsClient = await SipDomainsClient.CreateAsync();
            // Initialize request argument(s)
            SipDomain sipDomain = new SipDomain();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SipDomain response = await sipDomainsClient.UpdateSipDomainAsync(sipDomain, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteSipDomain</summary>
        public void DeleteSipDomainRequestObject()
        {
            // Snippet: DeleteSipDomain(DeleteSipDomainRequest, CallSettings)
            // Create client
            SipDomainsClient sipDomainsClient = SipDomainsClient.Create();
            // Initialize request argument(s)
            DeleteSipDomainRequest request = new DeleteSipDomainRequest
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
            };
            // Make the request
            SipDomain response = sipDomainsClient.DeleteSipDomain(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSipDomainAsync</summary>
        public async Task DeleteSipDomainRequestObjectAsync()
        {
            // Snippet: DeleteSipDomainAsync(DeleteSipDomainRequest, CallSettings)
            // Additional: DeleteSipDomainAsync(DeleteSipDomainRequest, CancellationToken)
            // Create client
            SipDomainsClient sipDomainsClient = await SipDomainsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSipDomainRequest request = new DeleteSipDomainRequest
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
            };
            // Make the request
            SipDomain response = await sipDomainsClient.DeleteSipDomainAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSipDomain</summary>
        public void DeleteSipDomain()
        {
            // Snippet: DeleteSipDomain(string, CallSettings)
            // Create client
            SipDomainsClient sipDomainsClient = SipDomainsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/sipDomains/[SIP_DOMAIN]";
            // Make the request
            SipDomain response = sipDomainsClient.DeleteSipDomain(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSipDomainAsync</summary>
        public async Task DeleteSipDomainAsync()
        {
            // Snippet: DeleteSipDomainAsync(string, CallSettings)
            // Additional: DeleteSipDomainAsync(string, CancellationToken)
            // Create client
            SipDomainsClient sipDomainsClient = await SipDomainsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/sipDomains/[SIP_DOMAIN]";
            // Make the request
            SipDomain response = await sipDomainsClient.DeleteSipDomainAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSipDomain</summary>
        public void DeleteSipDomainResourceNames()
        {
            // Snippet: DeleteSipDomain(SipDomainName, CallSettings)
            // Create client
            SipDomainsClient sipDomainsClient = SipDomainsClient.Create();
            // Initialize request argument(s)
            SipDomainName name = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]");
            // Make the request
            SipDomain response = sipDomainsClient.DeleteSipDomain(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSipDomainAsync</summary>
        public async Task DeleteSipDomainResourceNamesAsync()
        {
            // Snippet: DeleteSipDomainAsync(SipDomainName, CallSettings)
            // Additional: DeleteSipDomainAsync(SipDomainName, CancellationToken)
            // Create client
            SipDomainsClient sipDomainsClient = await SipDomainsClient.CreateAsync();
            // Initialize request argument(s)
            SipDomainName name = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]");
            // Make the request
            SipDomain response = await sipDomainsClient.DeleteSipDomainAsync(name);
            // End snippet
        }
    }
}
