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
    /// <summary>Settings for <see cref="SipDomainsClient"/> instances.</summary>
    public sealed partial class SipDomainsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SipDomainsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SipDomainsSettings"/>.</returns>
        public static SipDomainsSettings GetDefault() => new SipDomainsSettings();

        /// <summary>Constructs a new <see cref="SipDomainsSettings"/> object with default settings.</summary>
        public SipDomainsSettings()
        {
        }

        private SipDomainsSettings(SipDomainsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateSipDomainSettings = existing.CreateSipDomainSettings;
            GetSipDomainSettings = existing.GetSipDomainSettings;
            ListSipDomainsSettings = existing.ListSipDomainsSettings;
            UpdateSipDomainSettings = existing.UpdateSipDomainSettings;
            DeleteSipDomainSettings = existing.DeleteSipDomainSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SipDomainsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SipDomainsClient.CreateSipDomain</c> and <c>SipDomainsClient.CreateSipDomainAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSipDomainSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SipDomainsClient.GetSipDomain</c> and <c>SipDomainsClient.GetSipDomainAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSipDomainSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SipDomainsClient.ListSipDomains</c> and <c>SipDomainsClient.ListSipDomainsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSipDomainsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SipDomainsClient.UpdateSipDomain</c> and <c>SipDomainsClient.UpdateSipDomainAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSipDomainSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SipDomainsClient.DeleteSipDomain</c> and <c>SipDomainsClient.DeleteSipDomainAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSipDomainSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SipDomainsSettings"/> object.</returns>
        public SipDomainsSettings Clone() => new SipDomainsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SipDomainsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class SipDomainsClientBuilder : enfgaxgrpc::ClientBuilderBase<SipDomainsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SipDomainsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SipDomainsClientBuilder()
        {
            UseJwtAccessWithScopes = SipDomainsClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref SipDomainsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SipDomainsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SipDomainsClient Build()
        {
            SipDomainsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SipDomainsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SipDomainsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SipDomainsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SipDomainsClient.Create(callInvoker, Settings);
        }

        private async stt::Task<SipDomainsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SipDomainsClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => SipDomainsClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => SipDomainsClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override enfgaxgrpc::ChannelPool GetChannelPool() => SipDomainsClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>SipDomains client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages SIP Domains.
    /// </remarks>
    public abstract partial class SipDomainsClient
    {
        /// <summary>
        /// The default endpoint for the SipDomains service, which is a host of "voice.api.enfonica.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "voice.api.enfonica.com:443";

        /// <summary>The default SipDomains scopes.</summary>
        /// <remarks>
        /// The default SipDomains scopes are:
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
        /// Asynchronously creates a <see cref="SipDomainsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SipDomainsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SipDomainsClient"/>.</returns>
        public static stt::Task<SipDomainsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SipDomainsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SipDomainsClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="SipDomainsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SipDomainsClient"/>.</returns>
        public static SipDomainsClient Create() => new SipDomainsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SipDomainsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SipDomainsSettings"/>.</param>
        /// <returns>The created <see cref="SipDomainsClient"/>.</returns>
        internal static SipDomainsClient Create(grpccore::CallInvoker callInvoker, SipDomainsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SipDomains.SipDomainsClient grpcClient = new SipDomains.SipDomainsClient(callInvoker);
            return new SipDomainsClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC SipDomains client</summary>
        public virtual SipDomains.SipDomainsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a sip domain.
        /// 
        /// The caller must have `voice.sipDomains.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SipDomain CreateSipDomain(CreateSipDomainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a sip domain.
        /// 
        /// The caller must have `voice.sipDomains.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipDomain> CreateSipDomainAsync(CreateSipDomainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a sip domain.
        /// 
        /// The caller must have `voice.sipDomains.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipDomain> CreateSipDomainAsync(CreateSipDomainRequest request, st::CancellationToken cancellationToken) =>
            CreateSipDomainAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a sip domain.
        /// 
        /// The caller must have `voice.sipDomains.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to create the sip domain
        /// in the form `projects/*`.
        /// </param>
        /// <param name="sipDomain">
        /// The sip domain resource to be created.
        /// </param>
        /// <param name="sipDomainId">
        /// The subdomain component of the SIP domain. This is the {sip_domain_id} value
        /// from `name` and can only be set on create. The FQDN of the SIP domain
        /// will be &amp;lt;sip_domain_id&amp;gt;.sip.enfonica.com.
        /// 
        /// This value must be globally unique. If the identifier already exists, the create
        /// method will fail with ALREADY_EXISTS.
        /// 
        /// This must be lowercase alpha-numeric or hyphens and
        /// must start and end with an alpha-numeric character, and must be a minimum of 2 and maximum of 30 characters.
        /// This is captured in the following regular expression: ^[a-z0-9][a-z0-9-]{0,28}[a-z0-9]$
        /// Can only be set on create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SipDomain CreateSipDomain(string parent, SipDomain sipDomain, string sipDomainId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSipDomain(new CreateSipDomainRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SipDomain = gax::GaxPreconditions.CheckNotNull(sipDomain, nameof(sipDomain)),
                SipDomainId = gax::GaxPreconditions.CheckNotNullOrEmpty(sipDomainId, nameof(sipDomainId)),
            }, callSettings);

        /// <summary>
        /// Creates a sip domain.
        /// 
        /// The caller must have `voice.sipDomains.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to create the sip domain
        /// in the form `projects/*`.
        /// </param>
        /// <param name="sipDomain">
        /// The sip domain resource to be created.
        /// </param>
        /// <param name="sipDomainId">
        /// The subdomain component of the SIP domain. This is the {sip_domain_id} value
        /// from `name` and can only be set on create. The FQDN of the SIP domain
        /// will be &amp;lt;sip_domain_id&amp;gt;.sip.enfonica.com.
        /// 
        /// This value must be globally unique. If the identifier already exists, the create
        /// method will fail with ALREADY_EXISTS.
        /// 
        /// This must be lowercase alpha-numeric or hyphens and
        /// must start and end with an alpha-numeric character, and must be a minimum of 2 and maximum of 30 characters.
        /// This is captured in the following regular expression: ^[a-z0-9][a-z0-9-]{0,28}[a-z0-9]$
        /// Can only be set on create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipDomain> CreateSipDomainAsync(string parent, SipDomain sipDomain, string sipDomainId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSipDomainAsync(new CreateSipDomainRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SipDomain = gax::GaxPreconditions.CheckNotNull(sipDomain, nameof(sipDomain)),
                SipDomainId = gax::GaxPreconditions.CheckNotNullOrEmpty(sipDomainId, nameof(sipDomainId)),
            }, callSettings);

        /// <summary>
        /// Creates a sip domain.
        /// 
        /// The caller must have `voice.sipDomains.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to create the sip domain
        /// in the form `projects/*`.
        /// </param>
        /// <param name="sipDomain">
        /// The sip domain resource to be created.
        /// </param>
        /// <param name="sipDomainId">
        /// The subdomain component of the SIP domain. This is the {sip_domain_id} value
        /// from `name` and can only be set on create. The FQDN of the SIP domain
        /// will be &amp;lt;sip_domain_id&amp;gt;.sip.enfonica.com.
        /// 
        /// This value must be globally unique. If the identifier already exists, the create
        /// method will fail with ALREADY_EXISTS.
        /// 
        /// This must be lowercase alpha-numeric or hyphens and
        /// must start and end with an alpha-numeric character, and must be a minimum of 2 and maximum of 30 characters.
        /// This is captured in the following regular expression: ^[a-z0-9][a-z0-9-]{0,28}[a-z0-9]$
        /// Can only be set on create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipDomain> CreateSipDomainAsync(string parent, SipDomain sipDomain, string sipDomainId, st::CancellationToken cancellationToken) =>
            CreateSipDomainAsync(parent, sipDomain, sipDomainId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a sip domain.
        /// 
        /// The caller must have `voice.sipDomains.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to create the sip domain
        /// in the form `projects/*`.
        /// </param>
        /// <param name="sipDomain">
        /// The sip domain resource to be created.
        /// </param>
        /// <param name="sipDomainId">
        /// The subdomain component of the SIP domain. This is the {sip_domain_id} value
        /// from `name` and can only be set on create. The FQDN of the SIP domain
        /// will be &amp;lt;sip_domain_id&amp;gt;.sip.enfonica.com.
        /// 
        /// This value must be globally unique. If the identifier already exists, the create
        /// method will fail with ALREADY_EXISTS.
        /// 
        /// This must be lowercase alpha-numeric or hyphens and
        /// must start and end with an alpha-numeric character, and must be a minimum of 2 and maximum of 30 characters.
        /// This is captured in the following regular expression: ^[a-z0-9][a-z0-9-]{0,28}[a-z0-9]$
        /// Can only be set on create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SipDomain CreateSipDomain(ProjectName parent, SipDomain sipDomain, string sipDomainId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSipDomain(new CreateSipDomainRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SipDomain = gax::GaxPreconditions.CheckNotNull(sipDomain, nameof(sipDomain)),
                SipDomainId = gax::GaxPreconditions.CheckNotNullOrEmpty(sipDomainId, nameof(sipDomainId)),
            }, callSettings);

        /// <summary>
        /// Creates a sip domain.
        /// 
        /// The caller must have `voice.sipDomains.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to create the sip domain
        /// in the form `projects/*`.
        /// </param>
        /// <param name="sipDomain">
        /// The sip domain resource to be created.
        /// </param>
        /// <param name="sipDomainId">
        /// The subdomain component of the SIP domain. This is the {sip_domain_id} value
        /// from `name` and can only be set on create. The FQDN of the SIP domain
        /// will be &amp;lt;sip_domain_id&amp;gt;.sip.enfonica.com.
        /// 
        /// This value must be globally unique. If the identifier already exists, the create
        /// method will fail with ALREADY_EXISTS.
        /// 
        /// This must be lowercase alpha-numeric or hyphens and
        /// must start and end with an alpha-numeric character, and must be a minimum of 2 and maximum of 30 characters.
        /// This is captured in the following regular expression: ^[a-z0-9][a-z0-9-]{0,28}[a-z0-9]$
        /// Can only be set on create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipDomain> CreateSipDomainAsync(ProjectName parent, SipDomain sipDomain, string sipDomainId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSipDomainAsync(new CreateSipDomainRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SipDomain = gax::GaxPreconditions.CheckNotNull(sipDomain, nameof(sipDomain)),
                SipDomainId = gax::GaxPreconditions.CheckNotNullOrEmpty(sipDomainId, nameof(sipDomainId)),
            }, callSettings);

        /// <summary>
        /// Creates a sip domain.
        /// 
        /// The caller must have `voice.sipDomains.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to create the sip domain
        /// in the form `projects/*`.
        /// </param>
        /// <param name="sipDomain">
        /// The sip domain resource to be created.
        /// </param>
        /// <param name="sipDomainId">
        /// The subdomain component of the SIP domain. This is the {sip_domain_id} value
        /// from `name` and can only be set on create. The FQDN of the SIP domain
        /// will be &amp;lt;sip_domain_id&amp;gt;.sip.enfonica.com.
        /// 
        /// This value must be globally unique. If the identifier already exists, the create
        /// method will fail with ALREADY_EXISTS.
        /// 
        /// This must be lowercase alpha-numeric or hyphens and
        /// must start and end with an alpha-numeric character, and must be a minimum of 2 and maximum of 30 characters.
        /// This is captured in the following regular expression: ^[a-z0-9][a-z0-9-]{0,28}[a-z0-9]$
        /// Can only be set on create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipDomain> CreateSipDomainAsync(ProjectName parent, SipDomain sipDomain, string sipDomainId, st::CancellationToken cancellationToken) =>
            CreateSipDomainAsync(parent, sipDomain, sipDomainId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a sip domain identified by the supplied resource name.
        /// 
        /// The caller must have `voice.sipDomains.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SipDomain GetSipDomain(GetSipDomainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a sip domain identified by the supplied resource name.
        /// 
        /// The caller must have `voice.sipDomains.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipDomain> GetSipDomainAsync(GetSipDomainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a sip domain identified by the supplied resource name.
        /// 
        /// The caller must have `voice.sipDomains.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipDomain> GetSipDomainAsync(GetSipDomainRequest request, st::CancellationToken cancellationToken) =>
            GetSipDomainAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a sip domain identified by the supplied resource name.
        /// 
        /// The caller must have `voice.sipDomains.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the sip domain to retrieve.
        /// Must be of the form `projects/*/sipDomains/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SipDomain GetSipDomain(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSipDomain(new GetSipDomainRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a sip domain identified by the supplied resource name.
        /// 
        /// The caller must have `voice.sipDomains.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the sip domain to retrieve.
        /// Must be of the form `projects/*/sipDomains/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipDomain> GetSipDomainAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSipDomainAsync(new GetSipDomainRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a sip domain identified by the supplied resource name.
        /// 
        /// The caller must have `voice.sipDomains.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the sip domain to retrieve.
        /// Must be of the form `projects/*/sipDomains/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipDomain> GetSipDomainAsync(string name, st::CancellationToken cancellationToken) =>
            GetSipDomainAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a sip domain identified by the supplied resource name.
        /// 
        /// The caller must have `voice.sipDomains.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the sip domain to retrieve.
        /// Must be of the form `projects/*/sipDomains/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SipDomain GetSipDomain(SipDomainName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSipDomain(new GetSipDomainRequest
            {
                SipDomainName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a sip domain identified by the supplied resource name.
        /// 
        /// The caller must have `voice.sipDomains.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the sip domain to retrieve.
        /// Must be of the form `projects/*/sipDomains/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipDomain> GetSipDomainAsync(SipDomainName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSipDomainAsync(new GetSipDomainRequest
            {
                SipDomainName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a sip domain identified by the supplied resource name.
        /// 
        /// The caller must have `voice.sipDomains.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the sip domain to retrieve.
        /// Must be of the form `projects/*/sipDomains/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipDomain> GetSipDomainAsync(SipDomainName name, st::CancellationToken cancellationToken) =>
            GetSipDomainAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all SipDomains.
        /// List returns sip domain sorted by create_time descending.
        /// 
        /// The caller must have `voice.sipDomains.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SipDomain"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSipDomainsResponse, SipDomain> ListSipDomains(ListSipDomainsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all SipDomains.
        /// List returns sip domain sorted by create_time descending.
        /// 
        /// The caller must have `voice.sipDomains.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SipDomain"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSipDomainsResponse, SipDomain> ListSipDomainsAsync(ListSipDomainsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all SipDomains.
        /// List returns sip domain sorted by create_time descending.
        /// 
        /// The caller must have `voice.sipDomains.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to list sip domain, in the form `projects/*`.
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
        /// <returns>A pageable sequence of <see cref="SipDomain"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSipDomainsResponse, SipDomain> ListSipDomains(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSipDomains(new ListSipDomainsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all SipDomains.
        /// List returns sip domain sorted by create_time descending.
        /// 
        /// The caller must have `voice.sipDomains.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to list sip domain, in the form `projects/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SipDomain"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSipDomainsResponse, SipDomain> ListSipDomainsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSipDomainsAsync(new ListSipDomainsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all SipDomains.
        /// List returns sip domain sorted by create_time descending.
        /// 
        /// The caller must have `voice.sipDomains.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to list sip domain, in the form `projects/*`.
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
        /// <returns>A pageable sequence of <see cref="SipDomain"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSipDomainsResponse, SipDomain> ListSipDomains(ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSipDomains(new ListSipDomainsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all SipDomains.
        /// List returns sip domain sorted by create_time descending.
        /// 
        /// The caller must have `voice.sipDomains.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to list sip domain, in the form `projects/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SipDomain"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSipDomainsResponse, SipDomain> ListSipDomainsAsync(ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSipDomainsAsync(new ListSipDomainsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Updates a sip domain.
        /// 
        /// The caller must have `voice.sipDomains.update` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SipDomain UpdateSipDomain(UpdateSipDomainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a sip domain.
        /// 
        /// The caller must have `voice.sipDomains.update` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipDomain> UpdateSipDomainAsync(UpdateSipDomainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a sip domain.
        /// 
        /// The caller must have `voice.sipDomains.update` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipDomain> UpdateSipDomainAsync(UpdateSipDomainRequest request, st::CancellationToken cancellationToken) =>
            UpdateSipDomainAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a sip domain.
        /// 
        /// The caller must have `voice.sipDomains.update` permission on the project.
        /// </summary>
        /// <param name="sipDomain">
        /// The new definition of the SipDomain.
        /// </param>
        /// <param name="updateMask">
        /// Fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SipDomain UpdateSipDomain(SipDomain sipDomain, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSipDomain(new UpdateSipDomainRequest
            {
                SipDomain = gax::GaxPreconditions.CheckNotNull(sipDomain, nameof(sipDomain)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a sip domain.
        /// 
        /// The caller must have `voice.sipDomains.update` permission on the project.
        /// </summary>
        /// <param name="sipDomain">
        /// The new definition of the SipDomain.
        /// </param>
        /// <param name="updateMask">
        /// Fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipDomain> UpdateSipDomainAsync(SipDomain sipDomain, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSipDomainAsync(new UpdateSipDomainRequest
            {
                SipDomain = gax::GaxPreconditions.CheckNotNull(sipDomain, nameof(sipDomain)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a sip domain.
        /// 
        /// The caller must have `voice.sipDomains.update` permission on the project.
        /// </summary>
        /// <param name="sipDomain">
        /// The new definition of the SipDomain.
        /// </param>
        /// <param name="updateMask">
        /// Fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipDomain> UpdateSipDomainAsync(SipDomain sipDomain, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSipDomainAsync(sipDomain, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs a soft-delete of the specified SIP domain.
        /// 
        /// The caller must have `voice.sipDomains.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SipDomain DeleteSipDomain(DeleteSipDomainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs a soft-delete of the specified SIP domain.
        /// 
        /// The caller must have `voice.sipDomains.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipDomain> DeleteSipDomainAsync(DeleteSipDomainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs a soft-delete of the specified SIP domain.
        /// 
        /// The caller must have `voice.sipDomains.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipDomain> DeleteSipDomainAsync(DeleteSipDomainRequest request, st::CancellationToken cancellationToken) =>
            DeleteSipDomainAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs a soft-delete of the specified SIP domain.
        /// 
        /// The caller must have `voice.sipDomains.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the sip domain to be deleted.
        /// Must be of the form `projects/*/sipDomains/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SipDomain DeleteSipDomain(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSipDomain(new DeleteSipDomainRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Performs a soft-delete of the specified SIP domain.
        /// 
        /// The caller must have `voice.sipDomains.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the sip domain to be deleted.
        /// Must be of the form `projects/*/sipDomains/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipDomain> DeleteSipDomainAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSipDomainAsync(new DeleteSipDomainRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Performs a soft-delete of the specified SIP domain.
        /// 
        /// The caller must have `voice.sipDomains.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the sip domain to be deleted.
        /// Must be of the form `projects/*/sipDomains/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipDomain> DeleteSipDomainAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSipDomainAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs a soft-delete of the specified SIP domain.
        /// 
        /// The caller must have `voice.sipDomains.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the sip domain to be deleted.
        /// Must be of the form `projects/*/sipDomains/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SipDomain DeleteSipDomain(SipDomainName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSipDomain(new DeleteSipDomainRequest
            {
                SipDomainName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Performs a soft-delete of the specified SIP domain.
        /// 
        /// The caller must have `voice.sipDomains.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the sip domain to be deleted.
        /// Must be of the form `projects/*/sipDomains/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipDomain> DeleteSipDomainAsync(SipDomainName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSipDomainAsync(new DeleteSipDomainRequest
            {
                SipDomainName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Performs a soft-delete of the specified SIP domain.
        /// 
        /// The caller must have `voice.sipDomains.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the sip domain to be deleted.
        /// Must be of the form `projects/*/sipDomains/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipDomain> DeleteSipDomainAsync(SipDomainName name, st::CancellationToken cancellationToken) =>
            DeleteSipDomainAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SipDomains client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages SIP Domains.
    /// </remarks>
    public sealed partial class SipDomainsClientImpl : SipDomainsClient
    {
        private readonly gaxgrpc::ApiCall<CreateSipDomainRequest, SipDomain> _callCreateSipDomain;

        private readonly gaxgrpc::ApiCall<GetSipDomainRequest, SipDomain> _callGetSipDomain;

        private readonly gaxgrpc::ApiCall<ListSipDomainsRequest, ListSipDomainsResponse> _callListSipDomains;

        private readonly gaxgrpc::ApiCall<UpdateSipDomainRequest, SipDomain> _callUpdateSipDomain;

        private readonly gaxgrpc::ApiCall<DeleteSipDomainRequest, SipDomain> _callDeleteSipDomain;

        /// <summary>
        /// Constructs a client wrapper for the SipDomains service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SipDomainsSettings"/> used within this client.</param>
        public SipDomainsClientImpl(SipDomains.SipDomainsClient grpcClient, SipDomainsSettings settings)
        {
            GrpcClient = grpcClient;
            SipDomainsSettings effectiveSettings = settings ?? SipDomainsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateSipDomain = clientHelper.BuildApiCall<CreateSipDomainRequest, SipDomain>(grpcClient.CreateSipDomainAsync, grpcClient.CreateSipDomain, effectiveSettings.CreateSipDomainSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSipDomain);
            Modify_CreateSipDomainApiCall(ref _callCreateSipDomain);
            _callGetSipDomain = clientHelper.BuildApiCall<GetSipDomainRequest, SipDomain>(grpcClient.GetSipDomainAsync, grpcClient.GetSipDomain, effectiveSettings.GetSipDomainSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSipDomain);
            Modify_GetSipDomainApiCall(ref _callGetSipDomain);
            _callListSipDomains = clientHelper.BuildApiCall<ListSipDomainsRequest, ListSipDomainsResponse>(grpcClient.ListSipDomainsAsync, grpcClient.ListSipDomains, effectiveSettings.ListSipDomainsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSipDomains);
            Modify_ListSipDomainsApiCall(ref _callListSipDomains);
            _callUpdateSipDomain = clientHelper.BuildApiCall<UpdateSipDomainRequest, SipDomain>(grpcClient.UpdateSipDomainAsync, grpcClient.UpdateSipDomain, effectiveSettings.UpdateSipDomainSettings).WithGoogleRequestParam("sip_domain.name", request => request.SipDomain?.Name);
            Modify_ApiCall(ref _callUpdateSipDomain);
            Modify_UpdateSipDomainApiCall(ref _callUpdateSipDomain);
            _callDeleteSipDomain = clientHelper.BuildApiCall<DeleteSipDomainRequest, SipDomain>(grpcClient.DeleteSipDomainAsync, grpcClient.DeleteSipDomain, effectiveSettings.DeleteSipDomainSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSipDomain);
            Modify_DeleteSipDomainApiCall(ref _callDeleteSipDomain);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateSipDomainApiCall(ref gaxgrpc::ApiCall<CreateSipDomainRequest, SipDomain> call);

        partial void Modify_GetSipDomainApiCall(ref gaxgrpc::ApiCall<GetSipDomainRequest, SipDomain> call);

        partial void Modify_ListSipDomainsApiCall(ref gaxgrpc::ApiCall<ListSipDomainsRequest, ListSipDomainsResponse> call);

        partial void Modify_UpdateSipDomainApiCall(ref gaxgrpc::ApiCall<UpdateSipDomainRequest, SipDomain> call);

        partial void Modify_DeleteSipDomainApiCall(ref gaxgrpc::ApiCall<DeleteSipDomainRequest, SipDomain> call);

        partial void OnConstruction(SipDomains.SipDomainsClient grpcClient, SipDomainsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SipDomains client</summary>
        public override SipDomains.SipDomainsClient GrpcClient { get; }

        partial void Modify_CreateSipDomainRequest(ref CreateSipDomainRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSipDomainRequest(ref GetSipDomainRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSipDomainsRequest(ref ListSipDomainsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSipDomainRequest(ref UpdateSipDomainRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSipDomainRequest(ref DeleteSipDomainRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a sip domain.
        /// 
        /// The caller must have `voice.sipDomains.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SipDomain CreateSipDomain(CreateSipDomainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSipDomainRequest(ref request, ref callSettings);
            return _callCreateSipDomain.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a sip domain.
        /// 
        /// The caller must have `voice.sipDomains.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SipDomain> CreateSipDomainAsync(CreateSipDomainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSipDomainRequest(ref request, ref callSettings);
            return _callCreateSipDomain.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a sip domain identified by the supplied resource name.
        /// 
        /// The caller must have `voice.sipDomains.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SipDomain GetSipDomain(GetSipDomainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSipDomainRequest(ref request, ref callSettings);
            return _callGetSipDomain.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a sip domain identified by the supplied resource name.
        /// 
        /// The caller must have `voice.sipDomains.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SipDomain> GetSipDomainAsync(GetSipDomainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSipDomainRequest(ref request, ref callSettings);
            return _callGetSipDomain.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all SipDomains.
        /// List returns sip domain sorted by create_time descending.
        /// 
        /// The caller must have `voice.sipDomains.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SipDomain"/> resources.</returns>
        public override gax::PagedEnumerable<ListSipDomainsResponse, SipDomain> ListSipDomains(ListSipDomainsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSipDomainsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSipDomainsRequest, ListSipDomainsResponse, SipDomain>(_callListSipDomains, request, callSettings);
        }

        /// <summary>
        /// Lists all SipDomains.
        /// List returns sip domain sorted by create_time descending.
        /// 
        /// The caller must have `voice.sipDomains.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SipDomain"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSipDomainsResponse, SipDomain> ListSipDomainsAsync(ListSipDomainsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSipDomainsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSipDomainsRequest, ListSipDomainsResponse, SipDomain>(_callListSipDomains, request, callSettings);
        }

        /// <summary>
        /// Updates a sip domain.
        /// 
        /// The caller must have `voice.sipDomains.update` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SipDomain UpdateSipDomain(UpdateSipDomainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSipDomainRequest(ref request, ref callSettings);
            return _callUpdateSipDomain.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a sip domain.
        /// 
        /// The caller must have `voice.sipDomains.update` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SipDomain> UpdateSipDomainAsync(UpdateSipDomainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSipDomainRequest(ref request, ref callSettings);
            return _callUpdateSipDomain.Async(request, callSettings);
        }

        /// <summary>
        /// Performs a soft-delete of the specified SIP domain.
        /// 
        /// The caller must have `voice.sipDomains.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SipDomain DeleteSipDomain(DeleteSipDomainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSipDomainRequest(ref request, ref callSettings);
            return _callDeleteSipDomain.Sync(request, callSettings);
        }

        /// <summary>
        /// Performs a soft-delete of the specified SIP domain.
        /// 
        /// The caller must have `voice.sipDomains.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SipDomain> DeleteSipDomainAsync(DeleteSipDomainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSipDomainRequest(ref request, ref callSettings);
            return _callDeleteSipDomain.Async(request, callSettings);
        }
    }

    public partial class ListSipDomainsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSipDomainsResponse : gaxgrpc::IPageResponse<SipDomain>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SipDomain> GetEnumerator() => SipDomains.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
