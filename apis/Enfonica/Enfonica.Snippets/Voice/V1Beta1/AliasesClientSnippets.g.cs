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
    public sealed class AllGeneratedAliasesClientSnippets
    {
        /// <summary>Snippet for CreateAlias</summary>
        public void CreateAliasRequestObject()
        {
            // Snippet: CreateAlias(CreateAliasRequest, CallSettings)
            // Create client
            AliasesClient aliasesClient = AliasesClient.Create();
            // Initialize request argument(s)
            CreateAliasRequest request = new CreateAliasRequest
            {
                ParentAsSipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                Alias = new Alias(),
                AliasId = "",
            };
            // Make the request
            Alias response = aliasesClient.CreateAlias(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAliasAsync</summary>
        public async Task CreateAliasRequestObjectAsync()
        {
            // Snippet: CreateAliasAsync(CreateAliasRequest, CallSettings)
            // Additional: CreateAliasAsync(CreateAliasRequest, CancellationToken)
            // Create client
            AliasesClient aliasesClient = await AliasesClient.CreateAsync();
            // Initialize request argument(s)
            CreateAliasRequest request = new CreateAliasRequest
            {
                ParentAsSipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                Alias = new Alias(),
                AliasId = "",
            };
            // Make the request
            Alias response = await aliasesClient.CreateAliasAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAlias</summary>
        public void CreateAlias()
        {
            // Snippet: CreateAlias(string, Alias, string, CallSettings)
            // Create client
            AliasesClient aliasesClient = AliasesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/sipDomains/[SIP_DOMAIN]";
            Alias alias = new Alias();
            string aliasId = "";
            // Make the request
            Alias response = aliasesClient.CreateAlias(parent, alias, aliasId);
            // End snippet
        }

        /// <summary>Snippet for CreateAliasAsync</summary>
        public async Task CreateAliasAsync()
        {
            // Snippet: CreateAliasAsync(string, Alias, string, CallSettings)
            // Additional: CreateAliasAsync(string, Alias, string, CancellationToken)
            // Create client
            AliasesClient aliasesClient = await AliasesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/sipDomains/[SIP_DOMAIN]";
            Alias alias = new Alias();
            string aliasId = "";
            // Make the request
            Alias response = await aliasesClient.CreateAliasAsync(parent, alias, aliasId);
            // End snippet
        }

        /// <summary>Snippet for CreateAlias</summary>
        public void CreateAliasResourceNames()
        {
            // Snippet: CreateAlias(SipDomainName, Alias, string, CallSettings)
            // Create client
            AliasesClient aliasesClient = AliasesClient.Create();
            // Initialize request argument(s)
            SipDomainName parent = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]");
            Alias alias = new Alias();
            string aliasId = "";
            // Make the request
            Alias response = aliasesClient.CreateAlias(parent, alias, aliasId);
            // End snippet
        }

        /// <summary>Snippet for CreateAliasAsync</summary>
        public async Task CreateAliasResourceNamesAsync()
        {
            // Snippet: CreateAliasAsync(SipDomainName, Alias, string, CallSettings)
            // Additional: CreateAliasAsync(SipDomainName, Alias, string, CancellationToken)
            // Create client
            AliasesClient aliasesClient = await AliasesClient.CreateAsync();
            // Initialize request argument(s)
            SipDomainName parent = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]");
            Alias alias = new Alias();
            string aliasId = "";
            // Make the request
            Alias response = await aliasesClient.CreateAliasAsync(parent, alias, aliasId);
            // End snippet
        }

        /// <summary>Snippet for GetAlias</summary>
        public void GetAliasRequestObject()
        {
            // Snippet: GetAlias(GetAliasRequest, CallSettings)
            // Create client
            AliasesClient aliasesClient = AliasesClient.Create();
            // Initialize request argument(s)
            GetAliasRequest request = new GetAliasRequest
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
            };
            // Make the request
            Alias response = aliasesClient.GetAlias(request);
            // End snippet
        }

        /// <summary>Snippet for GetAliasAsync</summary>
        public async Task GetAliasRequestObjectAsync()
        {
            // Snippet: GetAliasAsync(GetAliasRequest, CallSettings)
            // Additional: GetAliasAsync(GetAliasRequest, CancellationToken)
            // Create client
            AliasesClient aliasesClient = await AliasesClient.CreateAsync();
            // Initialize request argument(s)
            GetAliasRequest request = new GetAliasRequest
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
            };
            // Make the request
            Alias response = await aliasesClient.GetAliasAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAlias</summary>
        public void GetAlias()
        {
            // Snippet: GetAlias(string, CallSettings)
            // Create client
            AliasesClient aliasesClient = AliasesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/sipDomains/[SIP_DOMAIN]/aliases/[ALIAS]";
            // Make the request
            Alias response = aliasesClient.GetAlias(name);
            // End snippet
        }

        /// <summary>Snippet for GetAliasAsync</summary>
        public async Task GetAliasAsync()
        {
            // Snippet: GetAliasAsync(string, CallSettings)
            // Additional: GetAliasAsync(string, CancellationToken)
            // Create client
            AliasesClient aliasesClient = await AliasesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/sipDomains/[SIP_DOMAIN]/aliases/[ALIAS]";
            // Make the request
            Alias response = await aliasesClient.GetAliasAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAlias</summary>
        public void GetAliasResourceNames()
        {
            // Snippet: GetAlias(AliasName, CallSettings)
            // Create client
            AliasesClient aliasesClient = AliasesClient.Create();
            // Initialize request argument(s)
            AliasName name = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]");
            // Make the request
            Alias response = aliasesClient.GetAlias(name);
            // End snippet
        }

        /// <summary>Snippet for GetAliasAsync</summary>
        public async Task GetAliasResourceNamesAsync()
        {
            // Snippet: GetAliasAsync(AliasName, CallSettings)
            // Additional: GetAliasAsync(AliasName, CancellationToken)
            // Create client
            AliasesClient aliasesClient = await AliasesClient.CreateAsync();
            // Initialize request argument(s)
            AliasName name = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]");
            // Make the request
            Alias response = await aliasesClient.GetAliasAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAliases</summary>
        public void ListAliasesRequestObject()
        {
            // Snippet: ListAliases(ListAliasesRequest, CallSettings)
            // Create client
            AliasesClient aliasesClient = AliasesClient.Create();
            // Initialize request argument(s)
            ListAliasesRequest request = new ListAliasesRequest
            {
                ParentAsSipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
            };
            // Make the request
            PagedEnumerable<ListAliasesResponse, Alias> response = aliasesClient.ListAliases(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Alias item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAliasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Alias item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Alias> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Alias item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAliasesAsync</summary>
        public async Task ListAliasesRequestObjectAsync()
        {
            // Snippet: ListAliasesAsync(ListAliasesRequest, CallSettings)
            // Create client
            AliasesClient aliasesClient = await AliasesClient.CreateAsync();
            // Initialize request argument(s)
            ListAliasesRequest request = new ListAliasesRequest
            {
                ParentAsSipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAliasesResponse, Alias> response = aliasesClient.ListAliasesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Alias item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAliasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Alias item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Alias> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Alias item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAliases</summary>
        public void ListAliases()
        {
            // Snippet: ListAliases(string, string, int?, CallSettings)
            // Create client
            AliasesClient aliasesClient = AliasesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/sipDomains/[SIP_DOMAIN]";
            // Make the request
            PagedEnumerable<ListAliasesResponse, Alias> response = aliasesClient.ListAliases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Alias item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAliasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Alias item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Alias> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Alias item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAliasesAsync</summary>
        public async Task ListAliasesAsync()
        {
            // Snippet: ListAliasesAsync(string, string, int?, CallSettings)
            // Create client
            AliasesClient aliasesClient = await AliasesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/sipDomains/[SIP_DOMAIN]";
            // Make the request
            PagedAsyncEnumerable<ListAliasesResponse, Alias> response = aliasesClient.ListAliasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Alias item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAliasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Alias item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Alias> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Alias item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAliases</summary>
        public void ListAliasesResourceNames()
        {
            // Snippet: ListAliases(SipDomainName, string, int?, CallSettings)
            // Create client
            AliasesClient aliasesClient = AliasesClient.Create();
            // Initialize request argument(s)
            SipDomainName parent = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]");
            // Make the request
            PagedEnumerable<ListAliasesResponse, Alias> response = aliasesClient.ListAliases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Alias item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAliasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Alias item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Alias> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Alias item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAliasesAsync</summary>
        public async Task ListAliasesResourceNamesAsync()
        {
            // Snippet: ListAliasesAsync(SipDomainName, string, int?, CallSettings)
            // Create client
            AliasesClient aliasesClient = await AliasesClient.CreateAsync();
            // Initialize request argument(s)
            SipDomainName parent = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]");
            // Make the request
            PagedAsyncEnumerable<ListAliasesResponse, Alias> response = aliasesClient.ListAliasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Alias item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAliasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Alias item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Alias> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Alias item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateAlias</summary>
        public void UpdateAliasRequestObject()
        {
            // Snippet: UpdateAlias(UpdateAliasRequest, CallSettings)
            // Create client
            AliasesClient aliasesClient = AliasesClient.Create();
            // Initialize request argument(s)
            UpdateAliasRequest request = new UpdateAliasRequest
            {
                Alias = new Alias(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Alias response = aliasesClient.UpdateAlias(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAliasAsync</summary>
        public async Task UpdateAliasRequestObjectAsync()
        {
            // Snippet: UpdateAliasAsync(UpdateAliasRequest, CallSettings)
            // Additional: UpdateAliasAsync(UpdateAliasRequest, CancellationToken)
            // Create client
            AliasesClient aliasesClient = await AliasesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAliasRequest request = new UpdateAliasRequest
            {
                Alias = new Alias(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Alias response = await aliasesClient.UpdateAliasAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAlias</summary>
        public void UpdateAlias()
        {
            // Snippet: UpdateAlias(Alias, FieldMask, CallSettings)
            // Create client
            AliasesClient aliasesClient = AliasesClient.Create();
            // Initialize request argument(s)
            Alias alias = new Alias();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Alias response = aliasesClient.UpdateAlias(alias, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAliasAsync</summary>
        public async Task UpdateAliasAsync()
        {
            // Snippet: UpdateAliasAsync(Alias, FieldMask, CallSettings)
            // Additional: UpdateAliasAsync(Alias, FieldMask, CancellationToken)
            // Create client
            AliasesClient aliasesClient = await AliasesClient.CreateAsync();
            // Initialize request argument(s)
            Alias alias = new Alias();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Alias response = await aliasesClient.UpdateAliasAsync(alias, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteAlias</summary>
        public void DeleteAliasRequestObject()
        {
            // Snippet: DeleteAlias(DeleteAliasRequest, CallSettings)
            // Create client
            AliasesClient aliasesClient = AliasesClient.Create();
            // Initialize request argument(s)
            DeleteAliasRequest request = new DeleteAliasRequest
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
            };
            // Make the request
            aliasesClient.DeleteAlias(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAliasAsync</summary>
        public async Task DeleteAliasRequestObjectAsync()
        {
            // Snippet: DeleteAliasAsync(DeleteAliasRequest, CallSettings)
            // Additional: DeleteAliasAsync(DeleteAliasRequest, CancellationToken)
            // Create client
            AliasesClient aliasesClient = await AliasesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAliasRequest request = new DeleteAliasRequest
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
            };
            // Make the request
            await aliasesClient.DeleteAliasAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAlias</summary>
        public void DeleteAlias()
        {
            // Snippet: DeleteAlias(string, CallSettings)
            // Create client
            AliasesClient aliasesClient = AliasesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/sipDomains/[SIP_DOMAIN]/aliases/[ALIAS]";
            // Make the request
            aliasesClient.DeleteAlias(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAliasAsync</summary>
        public async Task DeleteAliasAsync()
        {
            // Snippet: DeleteAliasAsync(string, CallSettings)
            // Additional: DeleteAliasAsync(string, CancellationToken)
            // Create client
            AliasesClient aliasesClient = await AliasesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/sipDomains/[SIP_DOMAIN]/aliases/[ALIAS]";
            // Make the request
            await aliasesClient.DeleteAliasAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAlias</summary>
        public void DeleteAliasResourceNames()
        {
            // Snippet: DeleteAlias(AliasName, CallSettings)
            // Create client
            AliasesClient aliasesClient = AliasesClient.Create();
            // Initialize request argument(s)
            AliasName name = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]");
            // Make the request
            aliasesClient.DeleteAlias(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAliasAsync</summary>
        public async Task DeleteAliasResourceNamesAsync()
        {
            // Snippet: DeleteAliasAsync(AliasName, CallSettings)
            // Additional: DeleteAliasAsync(AliasName, CancellationToken)
            // Create client
            AliasesClient aliasesClient = await AliasesClient.CreateAsync();
            // Initialize request argument(s)
            AliasName name = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]");
            // Make the request
            await aliasesClient.DeleteAliasAsync(name);
            // End snippet
        }
    }
}
