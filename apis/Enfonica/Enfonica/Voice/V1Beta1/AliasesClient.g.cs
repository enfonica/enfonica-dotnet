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

namespace Enfonica.Voice.V1Beta1
{
    /// <summary>Settings for <see cref="AliasesClient"/> instances.</summary>
    public sealed partial class AliasesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AliasesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AliasesSettings"/>.</returns>
        public static AliasesSettings GetDefault() => new AliasesSettings();

        /// <summary>Constructs a new <see cref="AliasesSettings"/> object with default settings.</summary>
        public AliasesSettings()
        {
        }

        private AliasesSettings(AliasesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateAliasSettings = existing.CreateAliasSettings;
            GetAliasSettings = existing.GetAliasSettings;
            ListAliasesSettings = existing.ListAliasesSettings;
            UpdateAliasSettings = existing.UpdateAliasSettings;
            DeleteAliasSettings = existing.DeleteAliasSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AliasesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AliasesClient.CreateAlias</c>
        ///  and <c>AliasesClient.CreateAliasAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAliasSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AliasesClient.GetAlias</c>
        /// and <c>AliasesClient.GetAliasAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAliasSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AliasesClient.ListAliases</c>
        ///  and <c>AliasesClient.ListAliasesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAliasesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AliasesClient.UpdateAlias</c>
        ///  and <c>AliasesClient.UpdateAliasAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAliasSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AliasesClient.DeleteAlias</c>
        ///  and <c>AliasesClient.DeleteAliasAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAliasSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AliasesSettings"/> object.</returns>
        public AliasesSettings Clone() => new AliasesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AliasesClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AliasesClientBuilder : enfgaxgrpc::ClientBuilderBase<AliasesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AliasesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AliasesClientBuilder()
        {
            UseJwtAccessWithScopes = AliasesClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref AliasesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AliasesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AliasesClient Build()
        {
            AliasesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AliasesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AliasesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AliasesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AliasesClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AliasesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AliasesClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AliasesClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AliasesClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override enfgaxgrpc::ChannelPool GetChannelPool() => AliasesClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>Aliases client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages SIP aliases.
    /// </remarks>
    public abstract partial class AliasesClient
    {
        /// <summary>
        /// The default endpoint for the Aliases service, which is a host of "voice.api.enfonica.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "voice.api.enfonica.com:443";

        /// <summary>The default Aliases scopes.</summary>
        /// <remarks>
        /// The default Aliases scopes are:
        /// <list type="bullet"><item><description>https://api.enfonica.com/auth/voice</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://api.enfonica.com/auth/voice",
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
        /// Asynchronously creates a <see cref="AliasesClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="AliasesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AliasesClient"/>.</returns>
        public static stt::Task<AliasesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AliasesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AliasesClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="AliasesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AliasesClient"/>.</returns>
        public static AliasesClient Create() => new AliasesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AliasesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AliasesSettings"/>.</param>
        /// <returns>The created <see cref="AliasesClient"/>.</returns>
        internal static AliasesClient Create(grpccore::CallInvoker callInvoker, AliasesSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Aliases.AliasesClient grpcClient = new Aliases.AliasesClient(callInvoker);
            return new AliasesClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC Aliases client</summary>
        public virtual Aliases.AliasesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a alias.
        /// 
        /// The caller must have `voice.aliases.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Alias CreateAlias(CreateAliasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a alias.
        /// 
        /// The caller must have `voice.aliases.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Alias> CreateAliasAsync(CreateAliasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a alias.
        /// 
        /// The caller must have `voice.aliases.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Alias> CreateAliasAsync(CreateAliasRequest request, st::CancellationToken cancellationToken) =>
            CreateAliasAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a alias.
        /// 
        /// The caller must have `voice.aliases.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The SIP domain under which to create the alias in the form `projects/*/sipDomains/*`.
        /// </param>
        /// <param name="alias">
        /// The alias resource to be created.
        /// </param>
        /// <param name="aliasId">
        /// The `alias_id` component of the resource name to create, which will be of the form
        /// `projects/{project_id}/sipDomains/{sip_domain_id}/aliases/{alias_id}`.
        /// 
        /// This also forms the address of the alias, of the form: {alias}@{sip_domain_id}.sip.enfonica.com
        /// 
        /// This must be lowercase alpha-numeric or hyphens and
        /// must start and end with an alpha-numeric character, and must be a minimum of 2 and maximum of 30 characters.
        /// This is captured in the following regular expression: ^[a-z0-9][a-z0-9-]{0,28}[a-z0-9]$
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Alias CreateAlias(string parent, Alias alias, string aliasId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAlias(new CreateAliasRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Alias = gax::GaxPreconditions.CheckNotNull(alias, nameof(alias)),
                AliasId = gax::GaxPreconditions.CheckNotNullOrEmpty(aliasId, nameof(aliasId)),
            }, callSettings);

        /// <summary>
        /// Creates a alias.
        /// 
        /// The caller must have `voice.aliases.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The SIP domain under which to create the alias in the form `projects/*/sipDomains/*`.
        /// </param>
        /// <param name="alias">
        /// The alias resource to be created.
        /// </param>
        /// <param name="aliasId">
        /// The `alias_id` component of the resource name to create, which will be of the form
        /// `projects/{project_id}/sipDomains/{sip_domain_id}/aliases/{alias_id}`.
        /// 
        /// This also forms the address of the alias, of the form: {alias}@{sip_domain_id}.sip.enfonica.com
        /// 
        /// This must be lowercase alpha-numeric or hyphens and
        /// must start and end with an alpha-numeric character, and must be a minimum of 2 and maximum of 30 characters.
        /// This is captured in the following regular expression: ^[a-z0-9][a-z0-9-]{0,28}[a-z0-9]$
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Alias> CreateAliasAsync(string parent, Alias alias, string aliasId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAliasAsync(new CreateAliasRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Alias = gax::GaxPreconditions.CheckNotNull(alias, nameof(alias)),
                AliasId = gax::GaxPreconditions.CheckNotNullOrEmpty(aliasId, nameof(aliasId)),
            }, callSettings);

        /// <summary>
        /// Creates a alias.
        /// 
        /// The caller must have `voice.aliases.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The SIP domain under which to create the alias in the form `projects/*/sipDomains/*`.
        /// </param>
        /// <param name="alias">
        /// The alias resource to be created.
        /// </param>
        /// <param name="aliasId">
        /// The `alias_id` component of the resource name to create, which will be of the form
        /// `projects/{project_id}/sipDomains/{sip_domain_id}/aliases/{alias_id}`.
        /// 
        /// This also forms the address of the alias, of the form: {alias}@{sip_domain_id}.sip.enfonica.com
        /// 
        /// This must be lowercase alpha-numeric or hyphens and
        /// must start and end with an alpha-numeric character, and must be a minimum of 2 and maximum of 30 characters.
        /// This is captured in the following regular expression: ^[a-z0-9][a-z0-9-]{0,28}[a-z0-9]$
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Alias> CreateAliasAsync(string parent, Alias alias, string aliasId, st::CancellationToken cancellationToken) =>
            CreateAliasAsync(parent, alias, aliasId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a alias.
        /// 
        /// The caller must have `voice.aliases.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The SIP domain under which to create the alias in the form `projects/*/sipDomains/*`.
        /// </param>
        /// <param name="alias">
        /// The alias resource to be created.
        /// </param>
        /// <param name="aliasId">
        /// The `alias_id` component of the resource name to create, which will be of the form
        /// `projects/{project_id}/sipDomains/{sip_domain_id}/aliases/{alias_id}`.
        /// 
        /// This also forms the address of the alias, of the form: {alias}@{sip_domain_id}.sip.enfonica.com
        /// 
        /// This must be lowercase alpha-numeric or hyphens and
        /// must start and end with an alpha-numeric character, and must be a minimum of 2 and maximum of 30 characters.
        /// This is captured in the following regular expression: ^[a-z0-9][a-z0-9-]{0,28}[a-z0-9]$
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Alias CreateAlias(SipDomainName parent, Alias alias, string aliasId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAlias(new CreateAliasRequest
            {
                ParentAsSipDomainName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Alias = gax::GaxPreconditions.CheckNotNull(alias, nameof(alias)),
                AliasId = gax::GaxPreconditions.CheckNotNullOrEmpty(aliasId, nameof(aliasId)),
            }, callSettings);

        /// <summary>
        /// Creates a alias.
        /// 
        /// The caller must have `voice.aliases.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The SIP domain under which to create the alias in the form `projects/*/sipDomains/*`.
        /// </param>
        /// <param name="alias">
        /// The alias resource to be created.
        /// </param>
        /// <param name="aliasId">
        /// The `alias_id` component of the resource name to create, which will be of the form
        /// `projects/{project_id}/sipDomains/{sip_domain_id}/aliases/{alias_id}`.
        /// 
        /// This also forms the address of the alias, of the form: {alias}@{sip_domain_id}.sip.enfonica.com
        /// 
        /// This must be lowercase alpha-numeric or hyphens and
        /// must start and end with an alpha-numeric character, and must be a minimum of 2 and maximum of 30 characters.
        /// This is captured in the following regular expression: ^[a-z0-9][a-z0-9-]{0,28}[a-z0-9]$
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Alias> CreateAliasAsync(SipDomainName parent, Alias alias, string aliasId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAliasAsync(new CreateAliasRequest
            {
                ParentAsSipDomainName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Alias = gax::GaxPreconditions.CheckNotNull(alias, nameof(alias)),
                AliasId = gax::GaxPreconditions.CheckNotNullOrEmpty(aliasId, nameof(aliasId)),
            }, callSettings);

        /// <summary>
        /// Creates a alias.
        /// 
        /// The caller must have `voice.aliases.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The SIP domain under which to create the alias in the form `projects/*/sipDomains/*`.
        /// </param>
        /// <param name="alias">
        /// The alias resource to be created.
        /// </param>
        /// <param name="aliasId">
        /// The `alias_id` component of the resource name to create, which will be of the form
        /// `projects/{project_id}/sipDomains/{sip_domain_id}/aliases/{alias_id}`.
        /// 
        /// This also forms the address of the alias, of the form: {alias}@{sip_domain_id}.sip.enfonica.com
        /// 
        /// This must be lowercase alpha-numeric or hyphens and
        /// must start and end with an alpha-numeric character, and must be a minimum of 2 and maximum of 30 characters.
        /// This is captured in the following regular expression: ^[a-z0-9][a-z0-9-]{0,28}[a-z0-9]$
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Alias> CreateAliasAsync(SipDomainName parent, Alias alias, string aliasId, st::CancellationToken cancellationToken) =>
            CreateAliasAsync(parent, alias, aliasId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a alias identified by the supplied resource name.
        /// 
        /// The caller must have `voice.aliases.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Alias GetAlias(GetAliasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a alias identified by the supplied resource name.
        /// 
        /// The caller must have `voice.aliases.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Alias> GetAliasAsync(GetAliasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a alias identified by the supplied resource name.
        /// 
        /// The caller must have `voice.aliases.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Alias> GetAliasAsync(GetAliasRequest request, st::CancellationToken cancellationToken) =>
            GetAliasAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a alias identified by the supplied resource name.
        /// 
        /// The caller must have `voice.aliases.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the alias to retrieve.
        /// Must be of the form `projects/*/sipDomains/*/aliases/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Alias GetAlias(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAlias(new GetAliasRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a alias identified by the supplied resource name.
        /// 
        /// The caller must have `voice.aliases.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the alias to retrieve.
        /// Must be of the form `projects/*/sipDomains/*/aliases/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Alias> GetAliasAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAliasAsync(new GetAliasRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a alias identified by the supplied resource name.
        /// 
        /// The caller must have `voice.aliases.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the alias to retrieve.
        /// Must be of the form `projects/*/sipDomains/*/aliases/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Alias> GetAliasAsync(string name, st::CancellationToken cancellationToken) =>
            GetAliasAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a alias identified by the supplied resource name.
        /// 
        /// The caller must have `voice.aliases.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the alias to retrieve.
        /// Must be of the form `projects/*/sipDomains/*/aliases/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Alias GetAlias(AliasName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAlias(new GetAliasRequest
            {
                AliasName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a alias identified by the supplied resource name.
        /// 
        /// The caller must have `voice.aliases.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the alias to retrieve.
        /// Must be of the form `projects/*/sipDomains/*/aliases/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Alias> GetAliasAsync(AliasName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAliasAsync(new GetAliasRequest
            {
                AliasName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a alias identified by the supplied resource name.
        /// 
        /// The caller must have `voice.aliases.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the alias to retrieve.
        /// Must be of the form `projects/*/sipDomains/*/aliases/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Alias> GetAliasAsync(AliasName name, st::CancellationToken cancellationToken) =>
            GetAliasAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all Aliases.
        /// List returns alias sorted by create_time descending.
        /// 
        /// The caller must have `voice.aliases.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Alias"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAliasesResponse, Alias> ListAliases(ListAliasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Aliases.
        /// List returns alias sorted by create_time descending.
        /// 
        /// The caller must have `voice.aliases.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Alias"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAliasesResponse, Alias> ListAliasesAsync(ListAliasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Aliases.
        /// List returns alias sorted by create_time descending.
        /// 
        /// The caller must have `voice.aliases.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The SIP domain under which to list aliases, in the form `projects/*/sipDomains/*`.
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
        /// <returns>A pageable sequence of <see cref="Alias"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAliasesResponse, Alias> ListAliases(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAliases(new ListAliasesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all Aliases.
        /// List returns alias sorted by create_time descending.
        /// 
        /// The caller must have `voice.aliases.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The SIP domain under which to list aliases, in the form `projects/*/sipDomains/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Alias"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAliasesResponse, Alias> ListAliasesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAliasesAsync(new ListAliasesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all Aliases.
        /// List returns alias sorted by create_time descending.
        /// 
        /// The caller must have `voice.aliases.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The SIP domain under which to list aliases, in the form `projects/*/sipDomains/*`.
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
        /// <returns>A pageable sequence of <see cref="Alias"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAliasesResponse, Alias> ListAliases(SipDomainName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAliases(new ListAliasesRequest
            {
                ParentAsSipDomainName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all Aliases.
        /// List returns alias sorted by create_time descending.
        /// 
        /// The caller must have `voice.aliases.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The SIP domain under which to list aliases, in the form `projects/*/sipDomains/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Alias"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAliasesResponse, Alias> ListAliasesAsync(SipDomainName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAliasesAsync(new ListAliasesRequest
            {
                ParentAsSipDomainName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Updates a alias.
        /// 
        /// The caller must have `voice.aliases.update` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Alias UpdateAlias(UpdateAliasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a alias.
        /// 
        /// The caller must have `voice.aliases.update` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Alias> UpdateAliasAsync(UpdateAliasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a alias.
        /// 
        /// The caller must have `voice.aliases.update` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Alias> UpdateAliasAsync(UpdateAliasRequest request, st::CancellationToken cancellationToken) =>
            UpdateAliasAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a alias.
        /// 
        /// The caller must have `voice.aliases.update` permission on the project.
        /// </summary>
        /// <param name="alias">
        /// The new definition of the Alias.
        /// </param>
        /// <param name="updateMask">
        /// Fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Alias UpdateAlias(Alias alias, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAlias(new UpdateAliasRequest
            {
                Alias = gax::GaxPreconditions.CheckNotNull(alias, nameof(alias)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a alias.
        /// 
        /// The caller must have `voice.aliases.update` permission on the project.
        /// </summary>
        /// <param name="alias">
        /// The new definition of the Alias.
        /// </param>
        /// <param name="updateMask">
        /// Fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Alias> UpdateAliasAsync(Alias alias, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAliasAsync(new UpdateAliasRequest
            {
                Alias = gax::GaxPreconditions.CheckNotNull(alias, nameof(alias)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a alias.
        /// 
        /// The caller must have `voice.aliases.update` permission on the project.
        /// </summary>
        /// <param name="alias">
        /// The new definition of the Alias.
        /// </param>
        /// <param name="updateMask">
        /// Fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Alias> UpdateAliasAsync(Alias alias, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAliasAsync(alias, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified alias.
        /// 
        /// The caller must have `voice.aliases.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAlias(DeleteAliasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified alias.
        /// 
        /// The caller must have `voice.aliases.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAliasAsync(DeleteAliasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified alias.
        /// 
        /// The caller must have `voice.aliases.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAliasAsync(DeleteAliasRequest request, st::CancellationToken cancellationToken) =>
            DeleteAliasAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified alias.
        /// 
        /// The caller must have `voice.aliases.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the alias to be deleted.
        /// Must be of the form `projects/*/sipDomains/*/aliases/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAlias(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAlias(new DeleteAliasRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified alias.
        /// 
        /// The caller must have `voice.aliases.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the alias to be deleted.
        /// Must be of the form `projects/*/sipDomains/*/aliases/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAliasAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAliasAsync(new DeleteAliasRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified alias.
        /// 
        /// The caller must have `voice.aliases.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the alias to be deleted.
        /// Must be of the form `projects/*/sipDomains/*/aliases/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAliasAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAliasAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified alias.
        /// 
        /// The caller must have `voice.aliases.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the alias to be deleted.
        /// Must be of the form `projects/*/sipDomains/*/aliases/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAlias(AliasName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAlias(new DeleteAliasRequest
            {
                AliasName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified alias.
        /// 
        /// The caller must have `voice.aliases.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the alias to be deleted.
        /// Must be of the form `projects/*/sipDomains/*/aliases/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAliasAsync(AliasName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAliasAsync(new DeleteAliasRequest
            {
                AliasName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified alias.
        /// 
        /// The caller must have `voice.aliases.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the alias to be deleted.
        /// Must be of the form `projects/*/sipDomains/*/aliases/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAliasAsync(AliasName name, st::CancellationToken cancellationToken) =>
            DeleteAliasAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Aliases client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages SIP aliases.
    /// </remarks>
    public sealed partial class AliasesClientImpl : AliasesClient
    {
        private readonly gaxgrpc::ApiCall<CreateAliasRequest, Alias> _callCreateAlias;

        private readonly gaxgrpc::ApiCall<GetAliasRequest, Alias> _callGetAlias;

        private readonly gaxgrpc::ApiCall<ListAliasesRequest, ListAliasesResponse> _callListAliases;

        private readonly gaxgrpc::ApiCall<UpdateAliasRequest, Alias> _callUpdateAlias;

        private readonly gaxgrpc::ApiCall<DeleteAliasRequest, wkt::Empty> _callDeleteAlias;

        /// <summary>
        /// Constructs a client wrapper for the Aliases service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AliasesSettings"/> used within this client.</param>
        public AliasesClientImpl(Aliases.AliasesClient grpcClient, AliasesSettings settings)
        {
            GrpcClient = grpcClient;
            AliasesSettings effectiveSettings = settings ?? AliasesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateAlias = clientHelper.BuildApiCall<CreateAliasRequest, Alias>(grpcClient.CreateAliasAsync, grpcClient.CreateAlias, effectiveSettings.CreateAliasSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAlias);
            Modify_CreateAliasApiCall(ref _callCreateAlias);
            _callGetAlias = clientHelper.BuildApiCall<GetAliasRequest, Alias>(grpcClient.GetAliasAsync, grpcClient.GetAlias, effectiveSettings.GetAliasSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAlias);
            Modify_GetAliasApiCall(ref _callGetAlias);
            _callListAliases = clientHelper.BuildApiCall<ListAliasesRequest, ListAliasesResponse>(grpcClient.ListAliasesAsync, grpcClient.ListAliases, effectiveSettings.ListAliasesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAliases);
            Modify_ListAliasesApiCall(ref _callListAliases);
            _callUpdateAlias = clientHelper.BuildApiCall<UpdateAliasRequest, Alias>(grpcClient.UpdateAliasAsync, grpcClient.UpdateAlias, effectiveSettings.UpdateAliasSettings).WithGoogleRequestParam("alias.name", request => request.Alias?.Name);
            Modify_ApiCall(ref _callUpdateAlias);
            Modify_UpdateAliasApiCall(ref _callUpdateAlias);
            _callDeleteAlias = clientHelper.BuildApiCall<DeleteAliasRequest, wkt::Empty>(grpcClient.DeleteAliasAsync, grpcClient.DeleteAlias, effectiveSettings.DeleteAliasSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAlias);
            Modify_DeleteAliasApiCall(ref _callDeleteAlias);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateAliasApiCall(ref gaxgrpc::ApiCall<CreateAliasRequest, Alias> call);

        partial void Modify_GetAliasApiCall(ref gaxgrpc::ApiCall<GetAliasRequest, Alias> call);

        partial void Modify_ListAliasesApiCall(ref gaxgrpc::ApiCall<ListAliasesRequest, ListAliasesResponse> call);

        partial void Modify_UpdateAliasApiCall(ref gaxgrpc::ApiCall<UpdateAliasRequest, Alias> call);

        partial void Modify_DeleteAliasApiCall(ref gaxgrpc::ApiCall<DeleteAliasRequest, wkt::Empty> call);

        partial void OnConstruction(Aliases.AliasesClient grpcClient, AliasesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Aliases client</summary>
        public override Aliases.AliasesClient GrpcClient { get; }

        partial void Modify_CreateAliasRequest(ref CreateAliasRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAliasRequest(ref GetAliasRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAliasesRequest(ref ListAliasesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAliasRequest(ref UpdateAliasRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAliasRequest(ref DeleteAliasRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a alias.
        /// 
        /// The caller must have `voice.aliases.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Alias CreateAlias(CreateAliasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAliasRequest(ref request, ref callSettings);
            return _callCreateAlias.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a alias.
        /// 
        /// The caller must have `voice.aliases.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Alias> CreateAliasAsync(CreateAliasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAliasRequest(ref request, ref callSettings);
            return _callCreateAlias.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a alias identified by the supplied resource name.
        /// 
        /// The caller must have `voice.aliases.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Alias GetAlias(GetAliasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAliasRequest(ref request, ref callSettings);
            return _callGetAlias.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a alias identified by the supplied resource name.
        /// 
        /// The caller must have `voice.aliases.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Alias> GetAliasAsync(GetAliasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAliasRequest(ref request, ref callSettings);
            return _callGetAlias.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all Aliases.
        /// List returns alias sorted by create_time descending.
        /// 
        /// The caller must have `voice.aliases.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Alias"/> resources.</returns>
        public override gax::PagedEnumerable<ListAliasesResponse, Alias> ListAliases(ListAliasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAliasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAliasesRequest, ListAliasesResponse, Alias>(_callListAliases, request, callSettings);
        }

        /// <summary>
        /// Lists all Aliases.
        /// List returns alias sorted by create_time descending.
        /// 
        /// The caller must have `voice.aliases.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Alias"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAliasesResponse, Alias> ListAliasesAsync(ListAliasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAliasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAliasesRequest, ListAliasesResponse, Alias>(_callListAliases, request, callSettings);
        }

        /// <summary>
        /// Updates a alias.
        /// 
        /// The caller must have `voice.aliases.update` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Alias UpdateAlias(UpdateAliasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAliasRequest(ref request, ref callSettings);
            return _callUpdateAlias.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a alias.
        /// 
        /// The caller must have `voice.aliases.update` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Alias> UpdateAliasAsync(UpdateAliasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAliasRequest(ref request, ref callSettings);
            return _callUpdateAlias.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified alias.
        /// 
        /// The caller must have `voice.aliases.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAlias(DeleteAliasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAliasRequest(ref request, ref callSettings);
            _callDeleteAlias.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified alias.
        /// 
        /// The caller must have `voice.aliases.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAliasAsync(DeleteAliasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAliasRequest(ref request, ref callSettings);
            return _callDeleteAlias.Async(request, callSettings);
        }
    }

    public partial class ListAliasesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAliasesResponse : gaxgrpc::IPageResponse<Alias>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Alias> GetEnumerator() => Aliases.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
