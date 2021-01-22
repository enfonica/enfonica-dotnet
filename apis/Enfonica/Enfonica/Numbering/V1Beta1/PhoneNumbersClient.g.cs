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

namespace Enfonica.Numbering.V1Beta1
{
    /// <summary>Settings for <see cref="PhoneNumbersClient"/> instances.</summary>
    public sealed partial class PhoneNumbersSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PhoneNumbersSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PhoneNumbersSettings"/>.</returns>
        public static PhoneNumbersSettings GetDefault() => new PhoneNumbersSettings();

        /// <summary>Constructs a new <see cref="PhoneNumbersSettings"/> object with default settings.</summary>
        public PhoneNumbersSettings()
        {
        }

        private PhoneNumbersSettings(PhoneNumbersSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SearchPhoneNumbersSettings = existing.SearchPhoneNumbersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PhoneNumbersSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PhoneNumbersClient.SearchPhoneNumbers</c> and <c>PhoneNumbersClient.SearchPhoneNumbersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchPhoneNumbersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PhoneNumbersSettings"/> object.</returns>
        public PhoneNumbersSettings Clone() => new PhoneNumbersSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PhoneNumbersClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class PhoneNumbersClientBuilder : enfgaxgrpc::ClientBuilderBase<PhoneNumbersClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PhoneNumbersSettings Settings { get; set; }

        partial void InterceptBuild(ref PhoneNumbersClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PhoneNumbersClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PhoneNumbersClient Build()
        {
            PhoneNumbersClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PhoneNumbersClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PhoneNumbersClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PhoneNumbersClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PhoneNumbersClient.Create(callInvoker, Settings);
        }

        private async stt::Task<PhoneNumbersClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PhoneNumbersClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => PhoneNumbersClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => PhoneNumbersClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override enfgaxgrpc::ChannelPool GetChannelPool() => PhoneNumbersClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>PhoneNumbers client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages PhoneNumbers.
    /// </remarks>
    public abstract partial class PhoneNumbersClient
    {
        /// <summary>
        /// The default endpoint for the PhoneNumbers service, which is a host of "numbering.api.enfonica.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "numbering.api.enfonica.com:443";

        /// <summary>The default PhoneNumbers scopes.</summary>
        /// <remarks>
        /// The default PhoneNumbers scopes are:
        /// <list type="bullet"><item><description>https://api.enfonica.com/auth/numbering</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://api.enfonica.com/auth/numbering",
        });

        internal static enfgaxgrpc::ChannelPool ChannelPool { get; } = new enfgaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="PhoneNumbersClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PhoneNumbersClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PhoneNumbersClient"/>.</returns>
        public static stt::Task<PhoneNumbersClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PhoneNumbersClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PhoneNumbersClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PhoneNumbersClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PhoneNumbersClient"/>.</returns>
        public static PhoneNumbersClient Create() => new PhoneNumbersClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PhoneNumbersClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PhoneNumbersSettings"/>.</param>
        /// <returns>The created <see cref="PhoneNumbersClient"/>.</returns>
        internal static PhoneNumbersClient Create(grpccore::CallInvoker callInvoker, PhoneNumbersSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PhoneNumbers.PhoneNumbersClient grpcClient = new PhoneNumbers.PhoneNumbersClient(callInvoker);
            return new PhoneNumbersClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC PhoneNumbers client</summary>
        public virtual PhoneNumbers.PhoneNumbersClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Searches available phone numbers with the specified filters.
        /// 
        /// Search returns phone numbers sorted by create_time descending.
        /// 
        /// The caller must be authenticated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PhoneNumber"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchPhoneNumbersResponse, PhoneNumber> SearchPhoneNumbers(SearchPhoneNumbersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches available phone numbers with the specified filters.
        /// 
        /// Search returns phone numbers sorted by create_time descending.
        /// 
        /// The caller must be authenticated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PhoneNumber"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchPhoneNumbersResponse, PhoneNumber> SearchPhoneNumbersAsync(SearchPhoneNumbersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>PhoneNumbers client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages PhoneNumbers.
    /// </remarks>
    public sealed partial class PhoneNumbersClientImpl : PhoneNumbersClient
    {
        private readonly gaxgrpc::ApiCall<SearchPhoneNumbersRequest, SearchPhoneNumbersResponse> _callSearchPhoneNumbers;

        /// <summary>
        /// Constructs a client wrapper for the PhoneNumbers service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PhoneNumbersSettings"/> used within this client.</param>
        public PhoneNumbersClientImpl(PhoneNumbers.PhoneNumbersClient grpcClient, PhoneNumbersSettings settings)
        {
            GrpcClient = grpcClient;
            PhoneNumbersSettings effectiveSettings = settings ?? PhoneNumbersSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callSearchPhoneNumbers = clientHelper.BuildApiCall<SearchPhoneNumbersRequest, SearchPhoneNumbersResponse>(grpcClient.SearchPhoneNumbersAsync, grpcClient.SearchPhoneNumbers, effectiveSettings.SearchPhoneNumbersSettings);
            Modify_ApiCall(ref _callSearchPhoneNumbers);
            Modify_SearchPhoneNumbersApiCall(ref _callSearchPhoneNumbers);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SearchPhoneNumbersApiCall(ref gaxgrpc::ApiCall<SearchPhoneNumbersRequest, SearchPhoneNumbersResponse> call);

        partial void OnConstruction(PhoneNumbers.PhoneNumbersClient grpcClient, PhoneNumbersSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PhoneNumbers client</summary>
        public override PhoneNumbers.PhoneNumbersClient GrpcClient { get; }

        partial void Modify_SearchPhoneNumbersRequest(ref SearchPhoneNumbersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Searches available phone numbers with the specified filters.
        /// 
        /// Search returns phone numbers sorted by create_time descending.
        /// 
        /// The caller must be authenticated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PhoneNumber"/> resources.</returns>
        public override gax::PagedEnumerable<SearchPhoneNumbersResponse, PhoneNumber> SearchPhoneNumbers(SearchPhoneNumbersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchPhoneNumbersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchPhoneNumbersRequest, SearchPhoneNumbersResponse, PhoneNumber>(_callSearchPhoneNumbers, request, callSettings);
        }

        /// <summary>
        /// Searches available phone numbers with the specified filters.
        /// 
        /// Search returns phone numbers sorted by create_time descending.
        /// 
        /// The caller must be authenticated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PhoneNumber"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchPhoneNumbersResponse, PhoneNumber> SearchPhoneNumbersAsync(SearchPhoneNumbersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchPhoneNumbersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchPhoneNumbersRequest, SearchPhoneNumbersResponse, PhoneNumber>(_callSearchPhoneNumbers, request, callSettings);
        }
    }

    public partial class SearchPhoneNumbersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchPhoneNumbersResponse : gaxgrpc::IPageResponse<PhoneNumber>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PhoneNumber> GetEnumerator() => PhoneNumbers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
