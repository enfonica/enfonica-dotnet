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
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Enfonica.Voice.V1Beta1
{
    /// <summary>Settings for <see cref="SipInfoServiceClient"/> instances.</summary>
    public sealed partial class SipInfoServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SipInfoServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SipInfoServiceSettings"/>.</returns>
        public static SipInfoServiceSettings GetDefault() => new SipInfoServiceSettings();

        /// <summary>Constructs a new <see cref="SipInfoServiceSettings"/> object with default settings.</summary>
        public SipInfoServiceSettings()
        {
        }

        private SipInfoServiceSettings(SipInfoServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSipInfoSettings = existing.GetSipInfoSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SipInfoServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SipInfoServiceClient.GetSipInfo</c> and <c>SipInfoServiceClient.GetSipInfoAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSipInfoSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SipInfoServiceSettings"/> object.</returns>
        public SipInfoServiceSettings Clone() => new SipInfoServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SipInfoServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class SipInfoServiceClientBuilder : enfgaxgrpc::ClientBuilderBase<SipInfoServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SipInfoServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SipInfoServiceClientBuilder()
        {
            UseJwtAccessWithScopes = SipInfoServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref SipInfoServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SipInfoServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SipInfoServiceClient Build()
        {
            SipInfoServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SipInfoServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SipInfoServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SipInfoServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SipInfoServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<SipInfoServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SipInfoServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => SipInfoServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => SipInfoServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override enfgaxgrpc::ChannelPool GetChannelPool() => SipInfoServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>SipInfoService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides information about SIP calls.
    /// </remarks>
    public abstract partial class SipInfoServiceClient
    {
        /// <summary>
        /// The default endpoint for the SipInfoService service, which is a host of "voice.api.enfonica.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "voice.api.enfonica.com:443";

        /// <summary>The default SipInfoService scopes.</summary>
        /// <remarks>
        /// The default SipInfoService scopes are:
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
        /// Asynchronously creates a <see cref="SipInfoServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SipInfoServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SipInfoServiceClient"/>.</returns>
        public static stt::Task<SipInfoServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SipInfoServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SipInfoServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SipInfoServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SipInfoServiceClient"/>.</returns>
        public static SipInfoServiceClient Create() => new SipInfoServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SipInfoServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SipInfoServiceSettings"/>.</param>
        /// <returns>The created <see cref="SipInfoServiceClient"/>.</returns>
        internal static SipInfoServiceClient Create(grpccore::CallInvoker callInvoker, SipInfoServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SipInfoService.SipInfoServiceClient grpcClient = new SipInfoService.SipInfoServiceClient(callInvoker);
            return new SipInfoServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC SipInfoService client</summary>
        public virtual SipInfoService.SipInfoServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves SIP information about the specified SIP call. If the call is not
        /// a SIP call, throws NOT_FOUND. If the call has not yet completed, throws
        /// FAILED_PRECONDITION. If the SIP call was created greater than 30 days ago,
        /// returns NOT_FOUND.
        /// 
        /// The caller must have `voice.calls.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SipInfo GetSipInfo(GetSipInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves SIP information about the specified SIP call. If the call is not
        /// a SIP call, throws NOT_FOUND. If the call has not yet completed, throws
        /// FAILED_PRECONDITION. If the SIP call was created greater than 30 days ago,
        /// returns NOT_FOUND.
        /// 
        /// The caller must have `voice.calls.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipInfo> GetSipInfoAsync(GetSipInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves SIP information about the specified SIP call. If the call is not
        /// a SIP call, throws NOT_FOUND. If the call has not yet completed, throws
        /// FAILED_PRECONDITION. If the SIP call was created greater than 30 days ago,
        /// returns NOT_FOUND.
        /// 
        /// The caller must have `voice.calls.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipInfo> GetSipInfoAsync(GetSipInfoRequest request, st::CancellationToken cancellationToken) =>
            GetSipInfoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves SIP information about the specified SIP call. If the call is not
        /// a SIP call, throws NOT_FOUND. If the call has not yet completed, throws
        /// FAILED_PRECONDITION. If the SIP call was created greater than 30 days ago,
        /// returns NOT_FOUND.
        /// 
        /// The caller must have `voice.calls.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the SipInfo to retrieve.
        /// Must be of the form `projects/*/calls/*/sipInfo`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SipInfo GetSipInfo(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSipInfo(new GetSipInfoRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves SIP information about the specified SIP call. If the call is not
        /// a SIP call, throws NOT_FOUND. If the call has not yet completed, throws
        /// FAILED_PRECONDITION. If the SIP call was created greater than 30 days ago,
        /// returns NOT_FOUND.
        /// 
        /// The caller must have `voice.calls.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the SipInfo to retrieve.
        /// Must be of the form `projects/*/calls/*/sipInfo`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipInfo> GetSipInfoAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSipInfoAsync(new GetSipInfoRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves SIP information about the specified SIP call. If the call is not
        /// a SIP call, throws NOT_FOUND. If the call has not yet completed, throws
        /// FAILED_PRECONDITION. If the SIP call was created greater than 30 days ago,
        /// returns NOT_FOUND.
        /// 
        /// The caller must have `voice.calls.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the SipInfo to retrieve.
        /// Must be of the form `projects/*/calls/*/sipInfo`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipInfo> GetSipInfoAsync(string name, st::CancellationToken cancellationToken) =>
            GetSipInfoAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves SIP information about the specified SIP call. If the call is not
        /// a SIP call, throws NOT_FOUND. If the call has not yet completed, throws
        /// FAILED_PRECONDITION. If the SIP call was created greater than 30 days ago,
        /// returns NOT_FOUND.
        /// 
        /// The caller must have `voice.calls.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the SipInfo to retrieve.
        /// Must be of the form `projects/*/calls/*/sipInfo`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SipInfo GetSipInfo(SipInfoName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSipInfo(new GetSipInfoRequest
            {
                SipInfoName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves SIP information about the specified SIP call. If the call is not
        /// a SIP call, throws NOT_FOUND. If the call has not yet completed, throws
        /// FAILED_PRECONDITION. If the SIP call was created greater than 30 days ago,
        /// returns NOT_FOUND.
        /// 
        /// The caller must have `voice.calls.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the SipInfo to retrieve.
        /// Must be of the form `projects/*/calls/*/sipInfo`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipInfo> GetSipInfoAsync(SipInfoName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSipInfoAsync(new GetSipInfoRequest
            {
                SipInfoName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves SIP information about the specified SIP call. If the call is not
        /// a SIP call, throws NOT_FOUND. If the call has not yet completed, throws
        /// FAILED_PRECONDITION. If the SIP call was created greater than 30 days ago,
        /// returns NOT_FOUND.
        /// 
        /// The caller must have `voice.calls.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the SipInfo to retrieve.
        /// Must be of the form `projects/*/calls/*/sipInfo`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipInfo> GetSipInfoAsync(SipInfoName name, st::CancellationToken cancellationToken) =>
            GetSipInfoAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SipInfoService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides information about SIP calls.
    /// </remarks>
    public sealed partial class SipInfoServiceClientImpl : SipInfoServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetSipInfoRequest, SipInfo> _callGetSipInfo;

        /// <summary>
        /// Constructs a client wrapper for the SipInfoService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SipInfoServiceSettings"/> used within this client.</param>
        public SipInfoServiceClientImpl(SipInfoService.SipInfoServiceClient grpcClient, SipInfoServiceSettings settings)
        {
            GrpcClient = grpcClient;
            SipInfoServiceSettings effectiveSettings = settings ?? SipInfoServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetSipInfo = clientHelper.BuildApiCall<GetSipInfoRequest, SipInfo>(grpcClient.GetSipInfoAsync, grpcClient.GetSipInfo, effectiveSettings.GetSipInfoSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSipInfo);
            Modify_GetSipInfoApiCall(ref _callGetSipInfo);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetSipInfoApiCall(ref gaxgrpc::ApiCall<GetSipInfoRequest, SipInfo> call);

        partial void OnConstruction(SipInfoService.SipInfoServiceClient grpcClient, SipInfoServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SipInfoService client</summary>
        public override SipInfoService.SipInfoServiceClient GrpcClient { get; }

        partial void Modify_GetSipInfoRequest(ref GetSipInfoRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves SIP information about the specified SIP call. If the call is not
        /// a SIP call, throws NOT_FOUND. If the call has not yet completed, throws
        /// FAILED_PRECONDITION. If the SIP call was created greater than 30 days ago,
        /// returns NOT_FOUND.
        /// 
        /// The caller must have `voice.calls.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SipInfo GetSipInfo(GetSipInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSipInfoRequest(ref request, ref callSettings);
            return _callGetSipInfo.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves SIP information about the specified SIP call. If the call is not
        /// a SIP call, throws NOT_FOUND. If the call has not yet completed, throws
        /// FAILED_PRECONDITION. If the SIP call was created greater than 30 days ago,
        /// returns NOT_FOUND.
        /// 
        /// The caller must have `voice.calls.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SipInfo> GetSipInfoAsync(GetSipInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSipInfoRequest(ref request, ref callSettings);
            return _callGetSipInfo.Async(request, callSettings);
        }
    }
}
