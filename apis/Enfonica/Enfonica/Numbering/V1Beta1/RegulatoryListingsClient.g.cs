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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using enfgaxgrpc = Enfonica.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Enfonica.Numbering.V1Beta1
{
    /// <summary>Settings for <see cref="RegulatoryListingsClient"/> instances.</summary>
    public sealed partial class RegulatoryListingsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RegulatoryListingsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RegulatoryListingsSettings"/>.</returns>
        public static RegulatoryListingsSettings GetDefault() => new RegulatoryListingsSettings();

        /// <summary>Constructs a new <see cref="RegulatoryListingsSettings"/> object with default settings.</summary>
        public RegulatoryListingsSettings()
        {
        }

        private RegulatoryListingsSettings(RegulatoryListingsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateRegulatoryListingSettings = existing.CreateRegulatoryListingSettings;
            GetRegulatoryListingSettings = existing.GetRegulatoryListingSettings;
            ListRegulatoryListingsSettings = existing.ListRegulatoryListingsSettings;
            UpdateRegulatoryListingSettings = existing.UpdateRegulatoryListingSettings;
            DeleteRegulatoryListingSettings = existing.DeleteRegulatoryListingSettings;
            SearchRegulatoryListingsSettings = existing.SearchRegulatoryListingsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RegulatoryListingsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegulatoryListingsClient.CreateRegulatoryListing</c> and
        /// <c>RegulatoryListingsClient.CreateRegulatoryListingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRegulatoryListingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegulatoryListingsClient.GetRegulatoryListing</c> and
        /// <c>RegulatoryListingsClient.GetRegulatoryListingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRegulatoryListingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegulatoryListingsClient.ListRegulatoryListings</c> and
        /// <c>RegulatoryListingsClient.ListRegulatoryListingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRegulatoryListingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegulatoryListingsClient.UpdateRegulatoryListing</c> and
        /// <c>RegulatoryListingsClient.UpdateRegulatoryListingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateRegulatoryListingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegulatoryListingsClient.DeleteRegulatoryListing</c> and
        /// <c>RegulatoryListingsClient.DeleteRegulatoryListingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRegulatoryListingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegulatoryListingsClient.SearchRegulatoryListings</c> and
        /// <c>RegulatoryListingsClient.SearchRegulatoryListingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchRegulatoryListingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RegulatoryListingsSettings"/> object.</returns>
        public RegulatoryListingsSettings Clone() => new RegulatoryListingsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RegulatoryListingsClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class RegulatoryListingsClientBuilder : enfgaxgrpc::ClientBuilderBase<RegulatoryListingsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RegulatoryListingsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RegulatoryListingsClientBuilder()
        {
            UseJwtAccessWithScopes = RegulatoryListingsClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref RegulatoryListingsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RegulatoryListingsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RegulatoryListingsClient Build()
        {
            RegulatoryListingsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RegulatoryListingsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RegulatoryListingsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RegulatoryListingsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RegulatoryListingsClient.Create(callInvoker, Settings);
        }

        private async stt::Task<RegulatoryListingsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RegulatoryListingsClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => RegulatoryListingsClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => RegulatoryListingsClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override enfgaxgrpc::ChannelPool GetChannelPool() => RegulatoryListingsClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>RegulatoryListings client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages regulatory listings.
    /// </remarks>
    public abstract partial class RegulatoryListingsClient
    {
        /// <summary>
        /// The default endpoint for the RegulatoryListings service, which is a host of "numbering.api.enfonica.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "numbering.api.enfonica.com:443";

        /// <summary>The default RegulatoryListings scopes.</summary>
        /// <remarks>
        /// The default RegulatoryListings scopes are:
        /// <list type="bullet"><item><description>https://api.enfonica.com/auth/numbering</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://api.enfonica.com/auth/numbering",
        });

        internal static enfgaxgrpc::ChannelPool ChannelPool { get; } = new enfgaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="RegulatoryListingsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RegulatoryListingsClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RegulatoryListingsClient"/>.</returns>
        public static stt::Task<RegulatoryListingsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RegulatoryListingsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RegulatoryListingsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RegulatoryListingsClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="RegulatoryListingsClient"/>.</returns>
        public static RegulatoryListingsClient Create() => new RegulatoryListingsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RegulatoryListingsClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RegulatoryListingsSettings"/>.</param>
        /// <returns>The created <see cref="RegulatoryListingsClient"/>.</returns>
        internal static RegulatoryListingsClient Create(grpccore::CallInvoker callInvoker, RegulatoryListingsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RegulatoryListings.RegulatoryListingsClient grpcClient = new RegulatoryListings.RegulatoryListingsClient(callInvoker);
            return new RegulatoryListingsClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC RegulatoryListings client</summary>
        public virtual RegulatoryListings.RegulatoryListingsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a regulatory listing.
        /// 
        /// By creating a regulatory listing, you acknowledge that the person or entity
        /// located at the specified address is the only party that will be utilizing
        /// phone numbers associated with this regulatory listing. You acknowledge that
        /// Enfonica may process the information provided for the purpose of identity
        /// verification, and will share this information with local telecommunications
        /// providers or authorities where required by local law. You understand that
        /// Enfonica phone numbers may be taken out of service if inaccurate or false
        /// information has been provided.
        /// 
        /// The caller must have `numbering.regulatoryListings.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RegulatoryListing CreateRegulatoryListing(CreateRegulatoryListingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a regulatory listing.
        /// 
        /// By creating a regulatory listing, you acknowledge that the person or entity
        /// located at the specified address is the only party that will be utilizing
        /// phone numbers associated with this regulatory listing. You acknowledge that
        /// Enfonica may process the information provided for the purpose of identity
        /// verification, and will share this information with local telecommunications
        /// providers or authorities where required by local law. You understand that
        /// Enfonica phone numbers may be taken out of service if inaccurate or false
        /// information has been provided.
        /// 
        /// The caller must have `numbering.regulatoryListings.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegulatoryListing> CreateRegulatoryListingAsync(CreateRegulatoryListingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a regulatory listing.
        /// 
        /// By creating a regulatory listing, you acknowledge that the person or entity
        /// located at the specified address is the only party that will be utilizing
        /// phone numbers associated with this regulatory listing. You acknowledge that
        /// Enfonica may process the information provided for the purpose of identity
        /// verification, and will share this information with local telecommunications
        /// providers or authorities where required by local law. You understand that
        /// Enfonica phone numbers may be taken out of service if inaccurate or false
        /// information has been provided.
        /// 
        /// The caller must have `numbering.regulatoryListings.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegulatoryListing> CreateRegulatoryListingAsync(CreateRegulatoryListingRequest request, st::CancellationToken cancellationToken) =>
            CreateRegulatoryListingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a regulatory listing.
        /// 
        /// By creating a regulatory listing, you acknowledge that the person or entity
        /// located at the specified address is the only party that will be utilizing
        /// phone numbers associated with this regulatory listing. You acknowledge that
        /// Enfonica may process the information provided for the purpose of identity
        /// verification, and will share this information with local telecommunications
        /// providers or authorities where required by local law. You understand that
        /// Enfonica phone numbers may be taken out of service if inaccurate or false
        /// information has been provided.
        /// 
        /// The caller must have `numbering.regulatoryListings.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to create the regulatory listing
        /// in the form `projects/*`.
        /// </param>
        /// <param name="regulatoryListing">
        /// The resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RegulatoryListing CreateRegulatoryListing(string parent, RegulatoryListing regulatoryListing, gaxgrpc::CallSettings callSettings = null) =>
            CreateRegulatoryListing(new CreateRegulatoryListingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RegulatoryListing = gax::GaxPreconditions.CheckNotNull(regulatoryListing, nameof(regulatoryListing)),
            }, callSettings);

        /// <summary>
        /// Creates a regulatory listing.
        /// 
        /// By creating a regulatory listing, you acknowledge that the person or entity
        /// located at the specified address is the only party that will be utilizing
        /// phone numbers associated with this regulatory listing. You acknowledge that
        /// Enfonica may process the information provided for the purpose of identity
        /// verification, and will share this information with local telecommunications
        /// providers or authorities where required by local law. You understand that
        /// Enfonica phone numbers may be taken out of service if inaccurate or false
        /// information has been provided.
        /// 
        /// The caller must have `numbering.regulatoryListings.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to create the regulatory listing
        /// in the form `projects/*`.
        /// </param>
        /// <param name="regulatoryListing">
        /// The resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegulatoryListing> CreateRegulatoryListingAsync(string parent, RegulatoryListing regulatoryListing, gaxgrpc::CallSettings callSettings = null) =>
            CreateRegulatoryListingAsync(new CreateRegulatoryListingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RegulatoryListing = gax::GaxPreconditions.CheckNotNull(regulatoryListing, nameof(regulatoryListing)),
            }, callSettings);

        /// <summary>
        /// Creates a regulatory listing.
        /// 
        /// By creating a regulatory listing, you acknowledge that the person or entity
        /// located at the specified address is the only party that will be utilizing
        /// phone numbers associated with this regulatory listing. You acknowledge that
        /// Enfonica may process the information provided for the purpose of identity
        /// verification, and will share this information with local telecommunications
        /// providers or authorities where required by local law. You understand that
        /// Enfonica phone numbers may be taken out of service if inaccurate or false
        /// information has been provided.
        /// 
        /// The caller must have `numbering.regulatoryListings.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to create the regulatory listing
        /// in the form `projects/*`.
        /// </param>
        /// <param name="regulatoryListing">
        /// The resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegulatoryListing> CreateRegulatoryListingAsync(string parent, RegulatoryListing regulatoryListing, st::CancellationToken cancellationToken) =>
            CreateRegulatoryListingAsync(parent, regulatoryListing, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a regulatory listing.
        /// 
        /// By creating a regulatory listing, you acknowledge that the person or entity
        /// located at the specified address is the only party that will be utilizing
        /// phone numbers associated with this regulatory listing. You acknowledge that
        /// Enfonica may process the information provided for the purpose of identity
        /// verification, and will share this information with local telecommunications
        /// providers or authorities where required by local law. You understand that
        /// Enfonica phone numbers may be taken out of service if inaccurate or false
        /// information has been provided.
        /// 
        /// The caller must have `numbering.regulatoryListings.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to create the regulatory listing
        /// in the form `projects/*`.
        /// </param>
        /// <param name="regulatoryListing">
        /// The resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RegulatoryListing CreateRegulatoryListing(ProjectName parent, RegulatoryListing regulatoryListing, gaxgrpc::CallSettings callSettings = null) =>
            CreateRegulatoryListing(new CreateRegulatoryListingRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RegulatoryListing = gax::GaxPreconditions.CheckNotNull(regulatoryListing, nameof(regulatoryListing)),
            }, callSettings);

        /// <summary>
        /// Creates a regulatory listing.
        /// 
        /// By creating a regulatory listing, you acknowledge that the person or entity
        /// located at the specified address is the only party that will be utilizing
        /// phone numbers associated with this regulatory listing. You acknowledge that
        /// Enfonica may process the information provided for the purpose of identity
        /// verification, and will share this information with local telecommunications
        /// providers or authorities where required by local law. You understand that
        /// Enfonica phone numbers may be taken out of service if inaccurate or false
        /// information has been provided.
        /// 
        /// The caller must have `numbering.regulatoryListings.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to create the regulatory listing
        /// in the form `projects/*`.
        /// </param>
        /// <param name="regulatoryListing">
        /// The resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegulatoryListing> CreateRegulatoryListingAsync(ProjectName parent, RegulatoryListing regulatoryListing, gaxgrpc::CallSettings callSettings = null) =>
            CreateRegulatoryListingAsync(new CreateRegulatoryListingRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RegulatoryListing = gax::GaxPreconditions.CheckNotNull(regulatoryListing, nameof(regulatoryListing)),
            }, callSettings);

        /// <summary>
        /// Creates a regulatory listing.
        /// 
        /// By creating a regulatory listing, you acknowledge that the person or entity
        /// located at the specified address is the only party that will be utilizing
        /// phone numbers associated with this regulatory listing. You acknowledge that
        /// Enfonica may process the information provided for the purpose of identity
        /// verification, and will share this information with local telecommunications
        /// providers or authorities where required by local law. You understand that
        /// Enfonica phone numbers may be taken out of service if inaccurate or false
        /// information has been provided.
        /// 
        /// The caller must have `numbering.regulatoryListings.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to create the regulatory listing
        /// in the form `projects/*`.
        /// </param>
        /// <param name="regulatoryListing">
        /// The resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegulatoryListing> CreateRegulatoryListingAsync(ProjectName parent, RegulatoryListing regulatoryListing, st::CancellationToken cancellationToken) =>
            CreateRegulatoryListingAsync(parent, regulatoryListing, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a regulatory listing.
        /// 
        /// The caller must have `numbering.regulatoryListings.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RegulatoryListing GetRegulatoryListing(GetRegulatoryListingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a regulatory listing.
        /// 
        /// The caller must have `numbering.regulatoryListings.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegulatoryListing> GetRegulatoryListingAsync(GetRegulatoryListingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a regulatory listing.
        /// 
        /// The caller must have `numbering.regulatoryListings.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegulatoryListing> GetRegulatoryListingAsync(GetRegulatoryListingRequest request, st::CancellationToken cancellationToken) =>
            GetRegulatoryListingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a regulatory listing.
        /// 
        /// The caller must have `numbering.regulatoryListings.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the regulatory listing to retrieve.
        /// Must be of the form `projects/*/regulatoryListings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RegulatoryListing GetRegulatoryListing(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRegulatoryListing(new GetRegulatoryListingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a regulatory listing.
        /// 
        /// The caller must have `numbering.regulatoryListings.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the regulatory listing to retrieve.
        /// Must be of the form `projects/*/regulatoryListings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegulatoryListing> GetRegulatoryListingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRegulatoryListingAsync(new GetRegulatoryListingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a regulatory listing.
        /// 
        /// The caller must have `numbering.regulatoryListings.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the regulatory listing to retrieve.
        /// Must be of the form `projects/*/regulatoryListings/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegulatoryListing> GetRegulatoryListingAsync(string name, st::CancellationToken cancellationToken) =>
            GetRegulatoryListingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a regulatory listing.
        /// 
        /// The caller must have `numbering.regulatoryListings.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the regulatory listing to retrieve.
        /// Must be of the form `projects/*/regulatoryListings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RegulatoryListing GetRegulatoryListing(RegulatoryListingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRegulatoryListing(new GetRegulatoryListingRequest
            {
                RegulatoryListingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a regulatory listing.
        /// 
        /// The caller must have `numbering.regulatoryListings.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the regulatory listing to retrieve.
        /// Must be of the form `projects/*/regulatoryListings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegulatoryListing> GetRegulatoryListingAsync(RegulatoryListingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRegulatoryListingAsync(new GetRegulatoryListingRequest
            {
                RegulatoryListingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a regulatory listing.
        /// 
        /// The caller must have `numbering.regulatoryListings.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the regulatory listing to retrieve.
        /// Must be of the form `projects/*/regulatoryListings/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegulatoryListing> GetRegulatoryListingAsync(RegulatoryListingName name, st::CancellationToken cancellationToken) =>
            GetRegulatoryListingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all regulatory listings.
        /// 
        /// List returns regulatory listings sorted by `create_time` descending.
        /// 
        /// The caller must have `numbering.regulatoryListings.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RegulatoryListing"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRegulatoryListingsResponse, RegulatoryListing> ListRegulatoryListings(ListRegulatoryListingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all regulatory listings.
        /// 
        /// List returns regulatory listings sorted by `create_time` descending.
        /// 
        /// The caller must have `numbering.regulatoryListings.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RegulatoryListing"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRegulatoryListingsResponse, RegulatoryListing> ListRegulatoryListingsAsync(ListRegulatoryListingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all regulatory listings.
        /// 
        /// List returns regulatory listings sorted by `create_time` descending.
        /// 
        /// The caller must have `numbering.regulatoryListings.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to list regulatory listing, in the form `projects/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RegulatoryListing"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRegulatoryListingsResponse, RegulatoryListing> ListRegulatoryListings(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRegulatoryListings(new ListRegulatoryListingsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all regulatory listings.
        /// 
        /// List returns regulatory listings sorted by `create_time` descending.
        /// 
        /// The caller must have `numbering.regulatoryListings.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to list regulatory listing, in the form `projects/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RegulatoryListing"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRegulatoryListingsResponse, RegulatoryListing> ListRegulatoryListingsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRegulatoryListingsAsync(new ListRegulatoryListingsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all regulatory listings.
        /// 
        /// List returns regulatory listings sorted by `create_time` descending.
        /// 
        /// The caller must have `numbering.regulatoryListings.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to list regulatory listing, in the form `projects/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RegulatoryListing"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRegulatoryListingsResponse, RegulatoryListing> ListRegulatoryListings(ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRegulatoryListings(new ListRegulatoryListingsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all regulatory listings.
        /// 
        /// List returns regulatory listings sorted by `create_time` descending.
        /// 
        /// The caller must have `numbering.regulatoryListings.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to list regulatory listing, in the form `projects/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RegulatoryListing"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRegulatoryListingsResponse, RegulatoryListing> ListRegulatoryListingsAsync(ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRegulatoryListingsAsync(new ListRegulatoryListingsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Updates a regulatory listing.
        /// 
        /// The caller must have `numbering.regulatoryListings.update` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RegulatoryListing UpdateRegulatoryListing(UpdateRegulatoryListingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a regulatory listing.
        /// 
        /// The caller must have `numbering.regulatoryListings.update` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegulatoryListing> UpdateRegulatoryListingAsync(UpdateRegulatoryListingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a regulatory listing.
        /// 
        /// The caller must have `numbering.regulatoryListings.update` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegulatoryListing> UpdateRegulatoryListingAsync(UpdateRegulatoryListingRequest request, st::CancellationToken cancellationToken) =>
            UpdateRegulatoryListingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a regulatory listing.
        /// 
        /// The caller must have `numbering.regulatoryListings.update` permission on the project.
        /// </summary>
        /// <param name="regulatoryListing">
        /// The updated definition of the RegulatoryListing.
        /// </param>
        /// <param name="updateMask">
        /// Fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RegulatoryListing UpdateRegulatoryListing(RegulatoryListing regulatoryListing, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRegulatoryListing(new UpdateRegulatoryListingRequest
            {
                RegulatoryListing = gax::GaxPreconditions.CheckNotNull(regulatoryListing, nameof(regulatoryListing)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a regulatory listing.
        /// 
        /// The caller must have `numbering.regulatoryListings.update` permission on the project.
        /// </summary>
        /// <param name="regulatoryListing">
        /// The updated definition of the RegulatoryListing.
        /// </param>
        /// <param name="updateMask">
        /// Fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegulatoryListing> UpdateRegulatoryListingAsync(RegulatoryListing regulatoryListing, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRegulatoryListingAsync(new UpdateRegulatoryListingRequest
            {
                RegulatoryListing = gax::GaxPreconditions.CheckNotNull(regulatoryListing, nameof(regulatoryListing)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a regulatory listing.
        /// 
        /// The caller must have `numbering.regulatoryListings.update` permission on the project.
        /// </summary>
        /// <param name="regulatoryListing">
        /// The updated definition of the RegulatoryListing.
        /// </param>
        /// <param name="updateMask">
        /// Fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegulatoryListing> UpdateRegulatoryListingAsync(RegulatoryListing regulatoryListing, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateRegulatoryListingAsync(regulatoryListing, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a regulatory listing. Regulatory listings that are associated with
        /// an active phone number instance cannot be deleted.
        /// 
        /// The caller must have `numbering.regulatoryListings.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRegulatoryListing(DeleteRegulatoryListingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a regulatory listing. Regulatory listings that are associated with
        /// an active phone number instance cannot be deleted.
        /// 
        /// The caller must have `numbering.regulatoryListings.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRegulatoryListingAsync(DeleteRegulatoryListingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a regulatory listing. Regulatory listings that are associated with
        /// an active phone number instance cannot be deleted.
        /// 
        /// The caller must have `numbering.regulatoryListings.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRegulatoryListingAsync(DeleteRegulatoryListingRequest request, st::CancellationToken cancellationToken) =>
            DeleteRegulatoryListingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a regulatory listing. Regulatory listings that are associated with
        /// an active phone number instance cannot be deleted.
        /// 
        /// The caller must have `numbering.regulatoryListings.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the regulatory listing to be deleted.
        /// Must be of the form `projects/*/regulatoryListings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRegulatoryListing(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRegulatoryListing(new DeleteRegulatoryListingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a regulatory listing. Regulatory listings that are associated with
        /// an active phone number instance cannot be deleted.
        /// 
        /// The caller must have `numbering.regulatoryListings.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the regulatory listing to be deleted.
        /// Must be of the form `projects/*/regulatoryListings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRegulatoryListingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRegulatoryListingAsync(new DeleteRegulatoryListingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a regulatory listing. Regulatory listings that are associated with
        /// an active phone number instance cannot be deleted.
        /// 
        /// The caller must have `numbering.regulatoryListings.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the regulatory listing to be deleted.
        /// Must be of the form `projects/*/regulatoryListings/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRegulatoryListingAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRegulatoryListingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a regulatory listing. Regulatory listings that are associated with
        /// an active phone number instance cannot be deleted.
        /// 
        /// The caller must have `numbering.regulatoryListings.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the regulatory listing to be deleted.
        /// Must be of the form `projects/*/regulatoryListings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRegulatoryListing(RegulatoryListingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRegulatoryListing(new DeleteRegulatoryListingRequest
            {
                RegulatoryListingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a regulatory listing. Regulatory listings that are associated with
        /// an active phone number instance cannot be deleted.
        /// 
        /// The caller must have `numbering.regulatoryListings.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the regulatory listing to be deleted.
        /// Must be of the form `projects/*/regulatoryListings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRegulatoryListingAsync(RegulatoryListingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRegulatoryListingAsync(new DeleteRegulatoryListingRequest
            {
                RegulatoryListingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a regulatory listing. Regulatory listings that are associated with
        /// an active phone number instance cannot be deleted.
        /// 
        /// The caller must have `numbering.regulatoryListings.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the regulatory listing to be deleted.
        /// Must be of the form `projects/*/regulatoryListings/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRegulatoryListingAsync(RegulatoryListingName name, st::CancellationToken cancellationToken) =>
            DeleteRegulatoryListingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Searches all usable regulatory listings with the specified number type.
        /// 
        /// List returns regulatory listings sorted by `create_time` descending.
        /// 
        /// The caller must have `numbering.regulatoryListings.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RegulatoryListing"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchRegulatoryListingsResponse, RegulatoryListing> SearchRegulatoryListings(SearchRegulatoryListingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches all usable regulatory listings with the specified number type.
        /// 
        /// List returns regulatory listings sorted by `create_time` descending.
        /// 
        /// The caller must have `numbering.regulatoryListings.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RegulatoryListing"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchRegulatoryListingsResponse, RegulatoryListing> SearchRegulatoryListingsAsync(SearchRegulatoryListingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches all usable regulatory listings with the specified number type.
        /// 
        /// List returns regulatory listings sorted by `create_time` descending.
        /// 
        /// The caller must have `numbering.regulatoryListings.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to list regulatory listing, in the form `projects/*`.
        /// </param>
        /// <param name="regionCode">
        /// The region code of the number that the regulatory listing must be usable
        /// with.
        /// </param>
        /// <param name="numberType">
        /// The type of number that the regulatory listing must be usable with.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RegulatoryListing"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchRegulatoryListingsResponse, RegulatoryListing> SearchRegulatoryListings(string parent, string regionCode, PhoneNumber.Types.PhoneNumberType numberType, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchRegulatoryListings(new SearchRegulatoryListingsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RegionCode = gax::GaxPreconditions.CheckNotNullOrEmpty(regionCode, nameof(regionCode)),
                NumberType = numberType,
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Searches all usable regulatory listings with the specified number type.
        /// 
        /// List returns regulatory listings sorted by `create_time` descending.
        /// 
        /// The caller must have `numbering.regulatoryListings.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to list regulatory listing, in the form `projects/*`.
        /// </param>
        /// <param name="regionCode">
        /// The region code of the number that the regulatory listing must be usable
        /// with.
        /// </param>
        /// <param name="numberType">
        /// The type of number that the regulatory listing must be usable with.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RegulatoryListing"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchRegulatoryListingsResponse, RegulatoryListing> SearchRegulatoryListingsAsync(string parent, string regionCode, PhoneNumber.Types.PhoneNumberType numberType, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchRegulatoryListingsAsync(new SearchRegulatoryListingsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RegionCode = gax::GaxPreconditions.CheckNotNullOrEmpty(regionCode, nameof(regionCode)),
                NumberType = numberType,
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Searches all usable regulatory listings with the specified number type.
        /// 
        /// List returns regulatory listings sorted by `create_time` descending.
        /// 
        /// The caller must have `numbering.regulatoryListings.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to list regulatory listing, in the form `projects/*`.
        /// </param>
        /// <param name="regionCode">
        /// The region code of the number that the regulatory listing must be usable
        /// with.
        /// </param>
        /// <param name="numberType">
        /// The type of number that the regulatory listing must be usable with.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RegulatoryListing"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchRegulatoryListingsResponse, RegulatoryListing> SearchRegulatoryListings(ProjectName parent, string regionCode, PhoneNumber.Types.PhoneNumberType numberType, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchRegulatoryListings(new SearchRegulatoryListingsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RegionCode = gax::GaxPreconditions.CheckNotNullOrEmpty(regionCode, nameof(regionCode)),
                NumberType = numberType,
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Searches all usable regulatory listings with the specified number type.
        /// 
        /// List returns regulatory listings sorted by `create_time` descending.
        /// 
        /// The caller must have `numbering.regulatoryListings.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to list regulatory listing, in the form `projects/*`.
        /// </param>
        /// <param name="regionCode">
        /// The region code of the number that the regulatory listing must be usable
        /// with.
        /// </param>
        /// <param name="numberType">
        /// The type of number that the regulatory listing must be usable with.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RegulatoryListing"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchRegulatoryListingsResponse, RegulatoryListing> SearchRegulatoryListingsAsync(ProjectName parent, string regionCode, PhoneNumber.Types.PhoneNumberType numberType, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchRegulatoryListingsAsync(new SearchRegulatoryListingsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RegionCode = gax::GaxPreconditions.CheckNotNullOrEmpty(regionCode, nameof(regionCode)),
                NumberType = numberType,
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>RegulatoryListings client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages regulatory listings.
    /// </remarks>
    public sealed partial class RegulatoryListingsClientImpl : RegulatoryListingsClient
    {
        private readonly gaxgrpc::ApiCall<CreateRegulatoryListingRequest, RegulatoryListing> _callCreateRegulatoryListing;

        private readonly gaxgrpc::ApiCall<GetRegulatoryListingRequest, RegulatoryListing> _callGetRegulatoryListing;

        private readonly gaxgrpc::ApiCall<ListRegulatoryListingsRequest, ListRegulatoryListingsResponse> _callListRegulatoryListings;

        private readonly gaxgrpc::ApiCall<UpdateRegulatoryListingRequest, RegulatoryListing> _callUpdateRegulatoryListing;

        private readonly gaxgrpc::ApiCall<DeleteRegulatoryListingRequest, wkt::Empty> _callDeleteRegulatoryListing;

        private readonly gaxgrpc::ApiCall<SearchRegulatoryListingsRequest, SearchRegulatoryListingsResponse> _callSearchRegulatoryListings;

        /// <summary>
        /// Constructs a client wrapper for the RegulatoryListings service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RegulatoryListingsSettings"/> used within this client.</param>
        public RegulatoryListingsClientImpl(RegulatoryListings.RegulatoryListingsClient grpcClient, RegulatoryListingsSettings settings)
        {
            GrpcClient = grpcClient;
            RegulatoryListingsSettings effectiveSettings = settings ?? RegulatoryListingsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateRegulatoryListing = clientHelper.BuildApiCall<CreateRegulatoryListingRequest, RegulatoryListing>(grpcClient.CreateRegulatoryListingAsync, grpcClient.CreateRegulatoryListing, effectiveSettings.CreateRegulatoryListingSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRegulatoryListing);
            Modify_CreateRegulatoryListingApiCall(ref _callCreateRegulatoryListing);
            _callGetRegulatoryListing = clientHelper.BuildApiCall<GetRegulatoryListingRequest, RegulatoryListing>(grpcClient.GetRegulatoryListingAsync, grpcClient.GetRegulatoryListing, effectiveSettings.GetRegulatoryListingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRegulatoryListing);
            Modify_GetRegulatoryListingApiCall(ref _callGetRegulatoryListing);
            _callListRegulatoryListings = clientHelper.BuildApiCall<ListRegulatoryListingsRequest, ListRegulatoryListingsResponse>(grpcClient.ListRegulatoryListingsAsync, grpcClient.ListRegulatoryListings, effectiveSettings.ListRegulatoryListingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRegulatoryListings);
            Modify_ListRegulatoryListingsApiCall(ref _callListRegulatoryListings);
            _callUpdateRegulatoryListing = clientHelper.BuildApiCall<UpdateRegulatoryListingRequest, RegulatoryListing>(grpcClient.UpdateRegulatoryListingAsync, grpcClient.UpdateRegulatoryListing, effectiveSettings.UpdateRegulatoryListingSettings).WithGoogleRequestParam("regulatory_listing.name", request => request.RegulatoryListing?.Name);
            Modify_ApiCall(ref _callUpdateRegulatoryListing);
            Modify_UpdateRegulatoryListingApiCall(ref _callUpdateRegulatoryListing);
            _callDeleteRegulatoryListing = clientHelper.BuildApiCall<DeleteRegulatoryListingRequest, wkt::Empty>(grpcClient.DeleteRegulatoryListingAsync, grpcClient.DeleteRegulatoryListing, effectiveSettings.DeleteRegulatoryListingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRegulatoryListing);
            Modify_DeleteRegulatoryListingApiCall(ref _callDeleteRegulatoryListing);
            _callSearchRegulatoryListings = clientHelper.BuildApiCall<SearchRegulatoryListingsRequest, SearchRegulatoryListingsResponse>(grpcClient.SearchRegulatoryListingsAsync, grpcClient.SearchRegulatoryListings, effectiveSettings.SearchRegulatoryListingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchRegulatoryListings);
            Modify_SearchRegulatoryListingsApiCall(ref _callSearchRegulatoryListings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateRegulatoryListingApiCall(ref gaxgrpc::ApiCall<CreateRegulatoryListingRequest, RegulatoryListing> call);

        partial void Modify_GetRegulatoryListingApiCall(ref gaxgrpc::ApiCall<GetRegulatoryListingRequest, RegulatoryListing> call);

        partial void Modify_ListRegulatoryListingsApiCall(ref gaxgrpc::ApiCall<ListRegulatoryListingsRequest, ListRegulatoryListingsResponse> call);

        partial void Modify_UpdateRegulatoryListingApiCall(ref gaxgrpc::ApiCall<UpdateRegulatoryListingRequest, RegulatoryListing> call);

        partial void Modify_DeleteRegulatoryListingApiCall(ref gaxgrpc::ApiCall<DeleteRegulatoryListingRequest, wkt::Empty> call);

        partial void Modify_SearchRegulatoryListingsApiCall(ref gaxgrpc::ApiCall<SearchRegulatoryListingsRequest, SearchRegulatoryListingsResponse> call);

        partial void OnConstruction(RegulatoryListings.RegulatoryListingsClient grpcClient, RegulatoryListingsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RegulatoryListings client</summary>
        public override RegulatoryListings.RegulatoryListingsClient GrpcClient { get; }

        partial void Modify_CreateRegulatoryListingRequest(ref CreateRegulatoryListingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRegulatoryListingRequest(ref GetRegulatoryListingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRegulatoryListingsRequest(ref ListRegulatoryListingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRegulatoryListingRequest(ref UpdateRegulatoryListingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRegulatoryListingRequest(ref DeleteRegulatoryListingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchRegulatoryListingsRequest(ref SearchRegulatoryListingsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a regulatory listing.
        /// 
        /// By creating a regulatory listing, you acknowledge that the person or entity
        /// located at the specified address is the only party that will be utilizing
        /// phone numbers associated with this regulatory listing. You acknowledge that
        /// Enfonica may process the information provided for the purpose of identity
        /// verification, and will share this information with local telecommunications
        /// providers or authorities where required by local law. You understand that
        /// Enfonica phone numbers may be taken out of service if inaccurate or false
        /// information has been provided.
        /// 
        /// The caller must have `numbering.regulatoryListings.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RegulatoryListing CreateRegulatoryListing(CreateRegulatoryListingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRegulatoryListingRequest(ref request, ref callSettings);
            return _callCreateRegulatoryListing.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a regulatory listing.
        /// 
        /// By creating a regulatory listing, you acknowledge that the person or entity
        /// located at the specified address is the only party that will be utilizing
        /// phone numbers associated with this regulatory listing. You acknowledge that
        /// Enfonica may process the information provided for the purpose of identity
        /// verification, and will share this information with local telecommunications
        /// providers or authorities where required by local law. You understand that
        /// Enfonica phone numbers may be taken out of service if inaccurate or false
        /// information has been provided.
        /// 
        /// The caller must have `numbering.regulatoryListings.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RegulatoryListing> CreateRegulatoryListingAsync(CreateRegulatoryListingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRegulatoryListingRequest(ref request, ref callSettings);
            return _callCreateRegulatoryListing.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a regulatory listing.
        /// 
        /// The caller must have `numbering.regulatoryListings.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RegulatoryListing GetRegulatoryListing(GetRegulatoryListingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegulatoryListingRequest(ref request, ref callSettings);
            return _callGetRegulatoryListing.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a regulatory listing.
        /// 
        /// The caller must have `numbering.regulatoryListings.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RegulatoryListing> GetRegulatoryListingAsync(GetRegulatoryListingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegulatoryListingRequest(ref request, ref callSettings);
            return _callGetRegulatoryListing.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all regulatory listings.
        /// 
        /// List returns regulatory listings sorted by `create_time` descending.
        /// 
        /// The caller must have `numbering.regulatoryListings.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RegulatoryListing"/> resources.</returns>
        public override gax::PagedEnumerable<ListRegulatoryListingsResponse, RegulatoryListing> ListRegulatoryListings(ListRegulatoryListingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegulatoryListingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRegulatoryListingsRequest, ListRegulatoryListingsResponse, RegulatoryListing>(_callListRegulatoryListings, request, callSettings);
        }

        /// <summary>
        /// Lists all regulatory listings.
        /// 
        /// List returns regulatory listings sorted by `create_time` descending.
        /// 
        /// The caller must have `numbering.regulatoryListings.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RegulatoryListing"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRegulatoryListingsResponse, RegulatoryListing> ListRegulatoryListingsAsync(ListRegulatoryListingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegulatoryListingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRegulatoryListingsRequest, ListRegulatoryListingsResponse, RegulatoryListing>(_callListRegulatoryListings, request, callSettings);
        }

        /// <summary>
        /// Updates a regulatory listing.
        /// 
        /// The caller must have `numbering.regulatoryListings.update` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RegulatoryListing UpdateRegulatoryListing(UpdateRegulatoryListingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRegulatoryListingRequest(ref request, ref callSettings);
            return _callUpdateRegulatoryListing.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a regulatory listing.
        /// 
        /// The caller must have `numbering.regulatoryListings.update` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RegulatoryListing> UpdateRegulatoryListingAsync(UpdateRegulatoryListingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRegulatoryListingRequest(ref request, ref callSettings);
            return _callUpdateRegulatoryListing.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a regulatory listing. Regulatory listings that are associated with
        /// an active phone number instance cannot be deleted.
        /// 
        /// The caller must have `numbering.regulatoryListings.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteRegulatoryListing(DeleteRegulatoryListingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegulatoryListingRequest(ref request, ref callSettings);
            _callDeleteRegulatoryListing.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a regulatory listing. Regulatory listings that are associated with
        /// an active phone number instance cannot be deleted.
        /// 
        /// The caller must have `numbering.regulatoryListings.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteRegulatoryListingAsync(DeleteRegulatoryListingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegulatoryListingRequest(ref request, ref callSettings);
            return _callDeleteRegulatoryListing.Async(request, callSettings);
        }

        /// <summary>
        /// Searches all usable regulatory listings with the specified number type.
        /// 
        /// List returns regulatory listings sorted by `create_time` descending.
        /// 
        /// The caller must have `numbering.regulatoryListings.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RegulatoryListing"/> resources.</returns>
        public override gax::PagedEnumerable<SearchRegulatoryListingsResponse, RegulatoryListing> SearchRegulatoryListings(SearchRegulatoryListingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchRegulatoryListingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchRegulatoryListingsRequest, SearchRegulatoryListingsResponse, RegulatoryListing>(_callSearchRegulatoryListings, request, callSettings);
        }

        /// <summary>
        /// Searches all usable regulatory listings with the specified number type.
        /// 
        /// List returns regulatory listings sorted by `create_time` descending.
        /// 
        /// The caller must have `numbering.regulatoryListings.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RegulatoryListing"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchRegulatoryListingsResponse, RegulatoryListing> SearchRegulatoryListingsAsync(SearchRegulatoryListingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchRegulatoryListingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchRegulatoryListingsRequest, SearchRegulatoryListingsResponse, RegulatoryListing>(_callSearchRegulatoryListings, request, callSettings);
        }
    }

    public partial class ListRegulatoryListingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchRegulatoryListingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRegulatoryListingsResponse : gaxgrpc::IPageResponse<RegulatoryListing>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<RegulatoryListing> GetEnumerator() => RegulatoryListings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchRegulatoryListingsResponse : gaxgrpc::IPageResponse<RegulatoryListing>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<RegulatoryListing> GetEnumerator() => RegulatoryListings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
