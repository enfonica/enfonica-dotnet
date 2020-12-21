// Copyright 2020 Enfonica Pty Ltd
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

namespace Enfonica.Messaging.V1
{
    /// <summary>Settings for <see cref="UnsubscribersClient"/> instances.</summary>
    public sealed partial class UnsubscribersSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="UnsubscribersSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="UnsubscribersSettings"/>.</returns>
        public static UnsubscribersSettings GetDefault() => new UnsubscribersSettings();

        /// <summary>Constructs a new <see cref="UnsubscribersSettings"/> object with default settings.</summary>
        public UnsubscribersSettings()
        {
        }

        private UnsubscribersSettings(UnsubscribersSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateUnsubscriberSettings = existing.CreateUnsubscriberSettings;
            GetUnsubscriberSettings = existing.GetUnsubscriberSettings;
            ListUnsubscribersSettings = existing.ListUnsubscribersSettings;
            UpdateUnsubscriberSettings = existing.UpdateUnsubscriberSettings;
            DeleteUnsubscriberSettings = existing.DeleteUnsubscriberSettings;
            OnCopy(existing);
        }

        partial void OnCopy(UnsubscribersSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UnsubscribersClient.CreateUnsubscriber</c> and <c>UnsubscribersClient.CreateUnsubscriberAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateUnsubscriberSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UnsubscribersClient.GetUnsubscriber</c> and <c>UnsubscribersClient.GetUnsubscriberAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetUnsubscriberSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UnsubscribersClient.ListUnsubscribers</c> and <c>UnsubscribersClient.ListUnsubscribersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListUnsubscribersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UnsubscribersClient.UpdateUnsubscriber</c> and <c>UnsubscribersClient.UpdateUnsubscriberAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateUnsubscriberSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UnsubscribersClient.DeleteUnsubscriber</c> and <c>UnsubscribersClient.DeleteUnsubscriberAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteUnsubscriberSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="UnsubscribersSettings"/> object.</returns>
        public UnsubscribersSettings Clone() => new UnsubscribersSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="UnsubscribersClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class UnsubscribersClientBuilder : enfgaxgrpc::ClientBuilderBase<UnsubscribersClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public UnsubscribersSettings Settings { get; set; }

        partial void InterceptBuild(ref UnsubscribersClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<UnsubscribersClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override UnsubscribersClient Build()
        {
            UnsubscribersClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<UnsubscribersClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<UnsubscribersClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private UnsubscribersClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return UnsubscribersClient.Create(callInvoker, Settings);
        }

        private async stt::Task<UnsubscribersClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return UnsubscribersClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => UnsubscribersClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => UnsubscribersClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override enfgaxgrpc::ChannelPool GetChannelPool() => UnsubscribersClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>Unsubscribers client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages Unsubscribers.
    /// </remarks>
    public abstract partial class UnsubscribersClient
    {
        /// <summary>
        /// The default endpoint for the Unsubscribers service, which is a host of "messaging.api.enfonica.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "messaging.api.enfonica.com:443";

        /// <summary>The default Unsubscribers scopes.</summary>
        /// <remarks>
        /// The default Unsubscribers scopes are:
        /// <list type="bullet"><item><description>https://api.enfonica.com/auth/messaging</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://api.enfonica.com/auth/messaging",
        });

        internal static enfgaxgrpc::ChannelPool ChannelPool { get; } = new enfgaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="UnsubscribersClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UnsubscribersClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="UnsubscribersClient"/>.</returns>
        public static stt::Task<UnsubscribersClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new UnsubscribersClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="UnsubscribersClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UnsubscribersClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="UnsubscribersClient"/>.</returns>
        public static UnsubscribersClient Create() => new UnsubscribersClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="UnsubscribersClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="UnsubscribersSettings"/>.</param>
        /// <returns>The created <see cref="UnsubscribersClient"/>.</returns>
        internal static UnsubscribersClient Create(grpccore::CallInvoker callInvoker, UnsubscribersSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Unsubscribers.UnsubscribersClient grpcClient = new Unsubscribers.UnsubscribersClient(callInvoker);
            return new UnsubscribersClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC Unsubscribers client</summary>
        public virtual Unsubscribers.UnsubscribersClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an unsubscriber.
        /// 
        /// The caller must have `messaging.unsubscribers.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Unsubscriber CreateUnsubscriber(CreateUnsubscriberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an unsubscriber.
        /// 
        /// The caller must have `messaging.unsubscribers.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unsubscriber> CreateUnsubscriberAsync(CreateUnsubscriberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an unsubscriber.
        /// 
        /// The caller must have `messaging.unsubscribers.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unsubscriber> CreateUnsubscriberAsync(CreateUnsubscriberRequest request, st::CancellationToken cancellationToken) =>
            CreateUnsubscriberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a Unsubscriber identified by the supplied resource name.
        /// 
        /// The caller must have `messaging.unsubscribers.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Unsubscriber GetUnsubscriber(GetUnsubscriberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a Unsubscriber identified by the supplied resource name.
        /// 
        /// The caller must have `messaging.unsubscribers.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unsubscriber> GetUnsubscriberAsync(GetUnsubscriberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a Unsubscriber identified by the supplied resource name.
        /// 
        /// The caller must have `messaging.unsubscribers.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unsubscriber> GetUnsubscriberAsync(GetUnsubscriberRequest request, st::CancellationToken cancellationToken) =>
            GetUnsubscriberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the Unsubscribers of the specified project.
        /// List returns Unsubscribers sorted by create_time descending.
        /// 
        /// The caller must have `messaging.unsubscribers.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Unsubscriber"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUnsubscribersResponse, Unsubscriber> ListUnsubscribers(ListUnsubscribersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Unsubscribers of the specified project.
        /// List returns Unsubscribers sorted by create_time descending.
        /// 
        /// The caller must have `messaging.unsubscribers.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Unsubscriber"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUnsubscribersResponse, Unsubscriber> ListUnsubscribersAsync(ListUnsubscribersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an unsubscriber.
        /// 
        /// The caller must have `messaging.unsubscribers.update` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Unsubscriber UpdateUnsubscriber(UpdateUnsubscriberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an unsubscriber.
        /// 
        /// The caller must have `messaging.unsubscribers.update` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unsubscriber> UpdateUnsubscriberAsync(UpdateUnsubscriberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an unsubscriber.
        /// 
        /// The caller must have `messaging.unsubscribers.update` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unsubscriber> UpdateUnsubscriberAsync(UpdateUnsubscriberRequest request, st::CancellationToken cancellationToken) =>
            UpdateUnsubscriberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an unsubscriber.
        /// 
        /// The caller must have `messaging.unsubscribers.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Unsubscriber DeleteUnsubscriber(DeleteUnsubscriberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an unsubscriber.
        /// 
        /// The caller must have `messaging.unsubscribers.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unsubscriber> DeleteUnsubscriberAsync(DeleteUnsubscriberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an unsubscriber.
        /// 
        /// The caller must have `messaging.unsubscribers.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unsubscriber> DeleteUnsubscriberAsync(DeleteUnsubscriberRequest request, st::CancellationToken cancellationToken) =>
            DeleteUnsubscriberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Unsubscribers client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages Unsubscribers.
    /// </remarks>
    public sealed partial class UnsubscribersClientImpl : UnsubscribersClient
    {
        private readonly gaxgrpc::ApiCall<CreateUnsubscriberRequest, Unsubscriber> _callCreateUnsubscriber;

        private readonly gaxgrpc::ApiCall<GetUnsubscriberRequest, Unsubscriber> _callGetUnsubscriber;

        private readonly gaxgrpc::ApiCall<ListUnsubscribersRequest, ListUnsubscribersResponse> _callListUnsubscribers;

        private readonly gaxgrpc::ApiCall<UpdateUnsubscriberRequest, Unsubscriber> _callUpdateUnsubscriber;

        private readonly gaxgrpc::ApiCall<DeleteUnsubscriberRequest, Unsubscriber> _callDeleteUnsubscriber;

        /// <summary>
        /// Constructs a client wrapper for the Unsubscribers service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="UnsubscribersSettings"/> used within this client.</param>
        public UnsubscribersClientImpl(Unsubscribers.UnsubscribersClient grpcClient, UnsubscribersSettings settings)
        {
            GrpcClient = grpcClient;
            UnsubscribersSettings effectiveSettings = settings ?? UnsubscribersSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateUnsubscriber = clientHelper.BuildApiCall<CreateUnsubscriberRequest, Unsubscriber>(grpcClient.CreateUnsubscriberAsync, grpcClient.CreateUnsubscriber, effectiveSettings.CreateUnsubscriberSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateUnsubscriber);
            Modify_CreateUnsubscriberApiCall(ref _callCreateUnsubscriber);
            _callGetUnsubscriber = clientHelper.BuildApiCall<GetUnsubscriberRequest, Unsubscriber>(grpcClient.GetUnsubscriberAsync, grpcClient.GetUnsubscriber, effectiveSettings.GetUnsubscriberSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetUnsubscriber);
            Modify_GetUnsubscriberApiCall(ref _callGetUnsubscriber);
            _callListUnsubscribers = clientHelper.BuildApiCall<ListUnsubscribersRequest, ListUnsubscribersResponse>(grpcClient.ListUnsubscribersAsync, grpcClient.ListUnsubscribers, effectiveSettings.ListUnsubscribersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUnsubscribers);
            Modify_ListUnsubscribersApiCall(ref _callListUnsubscribers);
            _callUpdateUnsubscriber = clientHelper.BuildApiCall<UpdateUnsubscriberRequest, Unsubscriber>(grpcClient.UpdateUnsubscriberAsync, grpcClient.UpdateUnsubscriber, effectiveSettings.UpdateUnsubscriberSettings).WithGoogleRequestParam("unsubscriber.name", request => request.Unsubscriber?.Name);
            Modify_ApiCall(ref _callUpdateUnsubscriber);
            Modify_UpdateUnsubscriberApiCall(ref _callUpdateUnsubscriber);
            _callDeleteUnsubscriber = clientHelper.BuildApiCall<DeleteUnsubscriberRequest, Unsubscriber>(grpcClient.DeleteUnsubscriberAsync, grpcClient.DeleteUnsubscriber, effectiveSettings.DeleteUnsubscriberSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteUnsubscriber);
            Modify_DeleteUnsubscriberApiCall(ref _callDeleteUnsubscriber);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateUnsubscriberApiCall(ref gaxgrpc::ApiCall<CreateUnsubscriberRequest, Unsubscriber> call);

        partial void Modify_GetUnsubscriberApiCall(ref gaxgrpc::ApiCall<GetUnsubscriberRequest, Unsubscriber> call);

        partial void Modify_ListUnsubscribersApiCall(ref gaxgrpc::ApiCall<ListUnsubscribersRequest, ListUnsubscribersResponse> call);

        partial void Modify_UpdateUnsubscriberApiCall(ref gaxgrpc::ApiCall<UpdateUnsubscriberRequest, Unsubscriber> call);

        partial void Modify_DeleteUnsubscriberApiCall(ref gaxgrpc::ApiCall<DeleteUnsubscriberRequest, Unsubscriber> call);

        partial void OnConstruction(Unsubscribers.UnsubscribersClient grpcClient, UnsubscribersSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Unsubscribers client</summary>
        public override Unsubscribers.UnsubscribersClient GrpcClient { get; }

        partial void Modify_CreateUnsubscriberRequest(ref CreateUnsubscriberRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetUnsubscriberRequest(ref GetUnsubscriberRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUnsubscribersRequest(ref ListUnsubscribersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateUnsubscriberRequest(ref UpdateUnsubscriberRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteUnsubscriberRequest(ref DeleteUnsubscriberRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates an unsubscriber.
        /// 
        /// The caller must have `messaging.unsubscribers.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Unsubscriber CreateUnsubscriber(CreateUnsubscriberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUnsubscriberRequest(ref request, ref callSettings);
            return _callCreateUnsubscriber.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an unsubscriber.
        /// 
        /// The caller must have `messaging.unsubscribers.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Unsubscriber> CreateUnsubscriberAsync(CreateUnsubscriberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUnsubscriberRequest(ref request, ref callSettings);
            return _callCreateUnsubscriber.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a Unsubscriber identified by the supplied resource name.
        /// 
        /// The caller must have `messaging.unsubscribers.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Unsubscriber GetUnsubscriber(GetUnsubscriberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUnsubscriberRequest(ref request, ref callSettings);
            return _callGetUnsubscriber.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a Unsubscriber identified by the supplied resource name.
        /// 
        /// The caller must have `messaging.unsubscribers.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Unsubscriber> GetUnsubscriberAsync(GetUnsubscriberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUnsubscriberRequest(ref request, ref callSettings);
            return _callGetUnsubscriber.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the Unsubscribers of the specified project.
        /// List returns Unsubscribers sorted by create_time descending.
        /// 
        /// The caller must have `messaging.unsubscribers.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Unsubscriber"/> resources.</returns>
        public override gax::PagedEnumerable<ListUnsubscribersResponse, Unsubscriber> ListUnsubscribers(ListUnsubscribersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUnsubscribersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUnsubscribersRequest, ListUnsubscribersResponse, Unsubscriber>(_callListUnsubscribers, request, callSettings);
        }

        /// <summary>
        /// Lists the Unsubscribers of the specified project.
        /// List returns Unsubscribers sorted by create_time descending.
        /// 
        /// The caller must have `messaging.unsubscribers.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Unsubscriber"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUnsubscribersResponse, Unsubscriber> ListUnsubscribersAsync(ListUnsubscribersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUnsubscribersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUnsubscribersRequest, ListUnsubscribersResponse, Unsubscriber>(_callListUnsubscribers, request, callSettings);
        }

        /// <summary>
        /// Updates an unsubscriber.
        /// 
        /// The caller must have `messaging.unsubscribers.update` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Unsubscriber UpdateUnsubscriber(UpdateUnsubscriberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUnsubscriberRequest(ref request, ref callSettings);
            return _callUpdateUnsubscriber.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an unsubscriber.
        /// 
        /// The caller must have `messaging.unsubscribers.update` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Unsubscriber> UpdateUnsubscriberAsync(UpdateUnsubscriberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUnsubscriberRequest(ref request, ref callSettings);
            return _callUpdateUnsubscriber.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an unsubscriber.
        /// 
        /// The caller must have `messaging.unsubscribers.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Unsubscriber DeleteUnsubscriber(DeleteUnsubscriberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUnsubscriberRequest(ref request, ref callSettings);
            return _callDeleteUnsubscriber.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an unsubscriber.
        /// 
        /// The caller must have `messaging.unsubscribers.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Unsubscriber> DeleteUnsubscriberAsync(DeleteUnsubscriberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUnsubscriberRequest(ref request, ref callSettings);
            return _callDeleteUnsubscriber.Async(request, callSettings);
        }
    }

    public partial class ListUnsubscribersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUnsubscribersResponse : gaxgrpc::IPageResponse<Unsubscriber>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Unsubscriber> GetEnumerator() => Unsubscribers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
