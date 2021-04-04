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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using enfgaxgrpc = Enfonica.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
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
    /// <summary>Settings for <see cref="CallsClient"/> instances.</summary>
    public sealed partial class CallsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CallsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CallsSettings"/>.</returns>
        public static CallsSettings GetDefault() => new CallsSettings();

        /// <summary>Constructs a new <see cref="CallsSettings"/> object with default settings.</summary>
        public CallsSettings()
        {
        }

        private CallsSettings(CallsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCallSettings = existing.GetCallSettings;
            ListCallsSettings = existing.ListCallsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CallsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CallsClient.GetCall</c> and
        /// <c>CallsClient.GetCallAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCallSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CallsClient.ListCalls</c>
        /// and <c>CallsClient.ListCallsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCallsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CallsSettings"/> object.</returns>
        public CallsSettings Clone() => new CallsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CallsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class CallsClientBuilder : enfgaxgrpc::ClientBuilderBase<CallsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CallsSettings Settings { get; set; }

        partial void InterceptBuild(ref CallsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CallsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CallsClient Build()
        {
            CallsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CallsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CallsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CallsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CallsClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CallsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CallsClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CallsClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CallsClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override enfgaxgrpc::ChannelPool GetChannelPool() => CallsClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>Calls client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages Calls.
    /// </remarks>
    public abstract partial class CallsClient
    {
        /// <summary>
        /// The default endpoint for the Calls service, which is a host of "voice.api.enfonica.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "voice.api.enfonica.com:443";

        /// <summary>The default Calls scopes.</summary>
        /// <remarks>
        /// The default Calls scopes are:
        /// <list type="bullet"><item><description>https://api.enfonica.com/auth/voice</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://api.enfonica.com/auth/voice",
        });

        internal static enfgaxgrpc::ChannelPool ChannelPool { get; } = new enfgaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CallsClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="CallsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CallsClient"/>.</returns>
        public static stt::Task<CallsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CallsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CallsClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="CallsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CallsClient"/>.</returns>
        public static CallsClient Create() => new CallsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CallsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CallsSettings"/>.</param>
        /// <returns>The created <see cref="CallsClient"/>.</returns>
        internal static CallsClient Create(grpccore::CallInvoker callInvoker, CallsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Calls.CallsClient grpcClient = new Calls.CallsClient(callInvoker);
            return new CallsClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC Calls client</summary>
        public virtual Calls.CallsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a Call identified by the supplied resource name.
        /// 
        /// The caller must have `voice.calls.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Call GetCall(GetCallRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a Call identified by the supplied resource name.
        /// 
        /// The caller must have `voice.calls.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Call> GetCallAsync(GetCallRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a Call identified by the supplied resource name.
        /// 
        /// The caller must have `voice.calls.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Call> GetCallAsync(GetCallRequest request, st::CancellationToken cancellationToken) =>
            GetCallAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a Call identified by the supplied resource name.
        /// 
        /// The caller must have `voice.calls.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Call to retrieve.
        /// Must be of the form `projects/*/calls/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Call GetCall(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCall(new GetCallRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Call identified by the supplied resource name.
        /// 
        /// The caller must have `voice.calls.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Call to retrieve.
        /// Must be of the form `projects/*/calls/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Call> GetCallAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCallAsync(new GetCallRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Call identified by the supplied resource name.
        /// 
        /// The caller must have `voice.calls.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Call to retrieve.
        /// Must be of the form `projects/*/calls/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Call> GetCallAsync(string name, st::CancellationToken cancellationToken) =>
            GetCallAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a Call identified by the supplied resource name.
        /// 
        /// The caller must have `voice.calls.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Call to retrieve.
        /// Must be of the form `projects/*/calls/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Call GetCall(CallName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCall(new GetCallRequest
            {
                CallName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Call identified by the supplied resource name.
        /// 
        /// The caller must have `voice.calls.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Call to retrieve.
        /// Must be of the form `projects/*/calls/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Call> GetCallAsync(CallName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCallAsync(new GetCallRequest
            {
                CallName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Call identified by the supplied resource name.
        /// 
        /// The caller must have `voice.calls.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Call to retrieve.
        /// Must be of the form `projects/*/calls/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Call> GetCallAsync(CallName name, st::CancellationToken cancellationToken) =>
            GetCallAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the Calls of the specified project.
        /// List returns Calls sorted by create_time descending.
        /// 
        /// The caller must have `voice.calls.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Call"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCallsResponse, Call> ListCalls(ListCallsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Calls of the specified project.
        /// List returns Calls sorted by create_time descending.
        /// 
        /// The caller must have `voice.calls.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Call"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCallsResponse, Call> ListCallsAsync(ListCallsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Calls of the specified project.
        /// List returns Calls sorted by create_time descending.
        /// 
        /// The caller must have `voice.calls.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the parent of which to list calls.
        /// Must be of the form `projects/*`.
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
        /// <returns>A pageable sequence of <see cref="Call"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCallsResponse, Call> ListCalls(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCalls(new ListCallsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the Calls of the specified project.
        /// List returns Calls sorted by create_time descending.
        /// 
        /// The caller must have `voice.calls.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the parent of which to list calls.
        /// Must be of the form `projects/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Call"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCallsResponse, Call> ListCallsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCallsAsync(new ListCallsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the Calls of the specified project.
        /// List returns Calls sorted by create_time descending.
        /// 
        /// The caller must have `voice.calls.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the parent of which to list calls.
        /// Must be of the form `projects/*`.
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
        /// <returns>A pageable sequence of <see cref="Call"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCallsResponse, Call> ListCalls(ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCalls(new ListCallsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the Calls of the specified project.
        /// List returns Calls sorted by create_time descending.
        /// 
        /// The caller must have `voice.calls.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the parent of which to list calls.
        /// Must be of the form `projects/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Call"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCallsResponse, Call> ListCallsAsync(ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCallsAsync(new ListCallsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>Calls client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages Calls.
    /// </remarks>
    public sealed partial class CallsClientImpl : CallsClient
    {
        private readonly gaxgrpc::ApiCall<GetCallRequest, Call> _callGetCall;

        private readonly gaxgrpc::ApiCall<ListCallsRequest, ListCallsResponse> _callListCalls;

        /// <summary>
        /// Constructs a client wrapper for the Calls service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CallsSettings"/> used within this client.</param>
        public CallsClientImpl(Calls.CallsClient grpcClient, CallsSettings settings)
        {
            GrpcClient = grpcClient;
            CallsSettings effectiveSettings = settings ?? CallsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCall = clientHelper.BuildApiCall<GetCallRequest, Call>(grpcClient.GetCallAsync, grpcClient.GetCall, effectiveSettings.GetCallSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCall);
            Modify_GetCallApiCall(ref _callGetCall);
            _callListCalls = clientHelper.BuildApiCall<ListCallsRequest, ListCallsResponse>(grpcClient.ListCallsAsync, grpcClient.ListCalls, effectiveSettings.ListCallsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCalls);
            Modify_ListCallsApiCall(ref _callListCalls);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCallApiCall(ref gaxgrpc::ApiCall<GetCallRequest, Call> call);

        partial void Modify_ListCallsApiCall(ref gaxgrpc::ApiCall<ListCallsRequest, ListCallsResponse> call);

        partial void OnConstruction(Calls.CallsClient grpcClient, CallsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Calls client</summary>
        public override Calls.CallsClient GrpcClient { get; }

        partial void Modify_GetCallRequest(ref GetCallRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCallsRequest(ref ListCallsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a Call identified by the supplied resource name.
        /// 
        /// The caller must have `voice.calls.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Call GetCall(GetCallRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCallRequest(ref request, ref callSettings);
            return _callGetCall.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a Call identified by the supplied resource name.
        /// 
        /// The caller must have `voice.calls.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Call> GetCallAsync(GetCallRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCallRequest(ref request, ref callSettings);
            return _callGetCall.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the Calls of the specified project.
        /// List returns Calls sorted by create_time descending.
        /// 
        /// The caller must have `voice.calls.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Call"/> resources.</returns>
        public override gax::PagedEnumerable<ListCallsResponse, Call> ListCalls(ListCallsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCallsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCallsRequest, ListCallsResponse, Call>(_callListCalls, request, callSettings);
        }

        /// <summary>
        /// Lists the Calls of the specified project.
        /// List returns Calls sorted by create_time descending.
        /// 
        /// The caller must have `voice.calls.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Call"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCallsResponse, Call> ListCallsAsync(ListCallsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCallsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCallsRequest, ListCallsResponse, Call>(_callListCalls, request, callSettings);
        }
    }

    public partial class ListCallsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCallsResponse : gaxgrpc::IPageResponse<Call>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Call> GetEnumerator() => Calls.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
