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
            CreatePhoneNumberSettings = existing.CreatePhoneNumberSettings;
            GetPhoneNumberSettings = existing.GetPhoneNumberSettings;
            ListPhoneNumbersSettings = existing.ListPhoneNumbersSettings;
            UpdatePhoneNumberSettings = existing.UpdatePhoneNumberSettings;
            DeletePhoneNumberSettings = existing.DeletePhoneNumberSettings;
            SearchPhoneNumbersSettings = existing.SearchPhoneNumbersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PhoneNumbersSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PhoneNumbersClient.CreatePhoneNumber</c> and <c>PhoneNumbersClient.CreatePhoneNumberAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePhoneNumberSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PhoneNumbersClient.GetPhoneNumber</c> and <c>PhoneNumbersClient.GetPhoneNumberAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPhoneNumberSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PhoneNumbersClient.ListPhoneNumbers</c> and <c>PhoneNumbersClient.ListPhoneNumbersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPhoneNumbersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PhoneNumbersClient.UpdatePhoneNumber</c> and <c>PhoneNumbersClient.UpdatePhoneNumberAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePhoneNumberSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PhoneNumbersClient.DeletePhoneNumber</c> and <c>PhoneNumbersClient.DeletePhoneNumberAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePhoneNumberSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PhoneNumbersClient.SearchPhoneNumbers</c> and <c>PhoneNumbersClient.SearchPhoneNumbersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchPhoneNumbersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

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
        /// The default endpoint for the PhoneNumbers service, which is a host of "" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = ":443";

        /// <summary>The default PhoneNumbers scopes.</summary>
        /// <remarks>The default PhoneNumbers scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

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
        /// Creates a phone number.
        /// 
        /// The caller must have `numbering.phoneNumbers.create` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumber CreatePhoneNumber(CreatePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a phone number.
        /// 
        /// The caller must have `numbering.phoneNumbers.create` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> CreatePhoneNumberAsync(CreatePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a phone number.
        /// 
        /// The caller must have `numbering.phoneNumbers.create` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> CreatePhoneNumberAsync(CreatePhoneNumberRequest request, st::CancellationToken cancellationToken) =>
            CreatePhoneNumberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a phone number identified by the supplied resource name.
        /// 
        /// The caller must have `numbering.phoneNumbers.get` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumber GetPhoneNumber(GetPhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a phone number identified by the supplied resource name.
        /// 
        /// The caller must have `numbering.phoneNumbers.get` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> GetPhoneNumberAsync(GetPhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a phone number identified by the supplied resource name.
        /// 
        /// The caller must have `numbering.phoneNumbers.get` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> GetPhoneNumberAsync(GetPhoneNumberRequest request, st::CancellationToken cancellationToken) =>
            GetPhoneNumberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all phone numbers.
        /// 
        /// List returns phone numbers sorted by create_time descending.
        /// 
        /// The caller must have `numbering.phoneNumbers.list` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PhoneNumber"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPhoneNumbersResponse, PhoneNumber> ListPhoneNumbers(ListPhoneNumbersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all phone numbers.
        /// 
        /// List returns phone numbers sorted by create_time descending.
        /// 
        /// The caller must have `numbering.phoneNumbers.list` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PhoneNumber"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPhoneNumbersResponse, PhoneNumber> ListPhoneNumbersAsync(ListPhoneNumbersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a phone number.
        /// 
        /// The caller must have `numbering.phoneNumbers.update` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumber UpdatePhoneNumber(UpdatePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a phone number.
        /// 
        /// The caller must have `numbering.phoneNumbers.update` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> UpdatePhoneNumberAsync(UpdatePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a phone number.
        /// 
        /// The caller must have `numbering.phoneNumbers.update` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> UpdatePhoneNumberAsync(UpdatePhoneNumberRequest request, st::CancellationToken cancellationToken) =>
            UpdatePhoneNumberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a phone number.
        /// 
        /// The caller must have `numbering.phoneNumbers.delete` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumber DeletePhoneNumber(DeletePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a phone number.
        /// 
        /// The caller must have `numbering.phoneNumbers.delete` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> DeletePhoneNumberAsync(DeletePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a phone number.
        /// 
        /// The caller must have `numbering.phoneNumbers.delete` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> DeletePhoneNumberAsync(DeletePhoneNumberRequest request, st::CancellationToken cancellationToken) =>
            DeletePhoneNumberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        private readonly gaxgrpc::ApiCall<CreatePhoneNumberRequest, PhoneNumber> _callCreatePhoneNumber;

        private readonly gaxgrpc::ApiCall<GetPhoneNumberRequest, PhoneNumber> _callGetPhoneNumber;

        private readonly gaxgrpc::ApiCall<ListPhoneNumbersRequest, ListPhoneNumbersResponse> _callListPhoneNumbers;

        private readonly gaxgrpc::ApiCall<UpdatePhoneNumberRequest, PhoneNumber> _callUpdatePhoneNumber;

        private readonly gaxgrpc::ApiCall<DeletePhoneNumberRequest, PhoneNumber> _callDeletePhoneNumber;

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
            _callCreatePhoneNumber = clientHelper.BuildApiCall<CreatePhoneNumberRequest, PhoneNumber>(grpcClient.CreatePhoneNumberAsync, grpcClient.CreatePhoneNumber, effectiveSettings.CreatePhoneNumberSettings);
            Modify_ApiCall(ref _callCreatePhoneNumber);
            Modify_CreatePhoneNumberApiCall(ref _callCreatePhoneNumber);
            _callGetPhoneNumber = clientHelper.BuildApiCall<GetPhoneNumberRequest, PhoneNumber>(grpcClient.GetPhoneNumberAsync, grpcClient.GetPhoneNumber, effectiveSettings.GetPhoneNumberSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPhoneNumber);
            Modify_GetPhoneNumberApiCall(ref _callGetPhoneNumber);
            _callListPhoneNumbers = clientHelper.BuildApiCall<ListPhoneNumbersRequest, ListPhoneNumbersResponse>(grpcClient.ListPhoneNumbersAsync, grpcClient.ListPhoneNumbers, effectiveSettings.ListPhoneNumbersSettings);
            Modify_ApiCall(ref _callListPhoneNumbers);
            Modify_ListPhoneNumbersApiCall(ref _callListPhoneNumbers);
            _callUpdatePhoneNumber = clientHelper.BuildApiCall<UpdatePhoneNumberRequest, PhoneNumber>(grpcClient.UpdatePhoneNumberAsync, grpcClient.UpdatePhoneNumber, effectiveSettings.UpdatePhoneNumberSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdatePhoneNumber);
            Modify_UpdatePhoneNumberApiCall(ref _callUpdatePhoneNumber);
            _callDeletePhoneNumber = clientHelper.BuildApiCall<DeletePhoneNumberRequest, PhoneNumber>(grpcClient.DeletePhoneNumberAsync, grpcClient.DeletePhoneNumber, effectiveSettings.DeletePhoneNumberSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePhoneNumber);
            Modify_DeletePhoneNumberApiCall(ref _callDeletePhoneNumber);
            _callSearchPhoneNumbers = clientHelper.BuildApiCall<SearchPhoneNumbersRequest, SearchPhoneNumbersResponse>(grpcClient.SearchPhoneNumbersAsync, grpcClient.SearchPhoneNumbers, effectiveSettings.SearchPhoneNumbersSettings);
            Modify_ApiCall(ref _callSearchPhoneNumbers);
            Modify_SearchPhoneNumbersApiCall(ref _callSearchPhoneNumbers);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreatePhoneNumberApiCall(ref gaxgrpc::ApiCall<CreatePhoneNumberRequest, PhoneNumber> call);

        partial void Modify_GetPhoneNumberApiCall(ref gaxgrpc::ApiCall<GetPhoneNumberRequest, PhoneNumber> call);

        partial void Modify_ListPhoneNumbersApiCall(ref gaxgrpc::ApiCall<ListPhoneNumbersRequest, ListPhoneNumbersResponse> call);

        partial void Modify_UpdatePhoneNumberApiCall(ref gaxgrpc::ApiCall<UpdatePhoneNumberRequest, PhoneNumber> call);

        partial void Modify_DeletePhoneNumberApiCall(ref gaxgrpc::ApiCall<DeletePhoneNumberRequest, PhoneNumber> call);

        partial void Modify_SearchPhoneNumbersApiCall(ref gaxgrpc::ApiCall<SearchPhoneNumbersRequest, SearchPhoneNumbersResponse> call);

        partial void OnConstruction(PhoneNumbers.PhoneNumbersClient grpcClient, PhoneNumbersSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PhoneNumbers client</summary>
        public override PhoneNumbers.PhoneNumbersClient GrpcClient { get; }

        partial void Modify_CreatePhoneNumberRequest(ref CreatePhoneNumberRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPhoneNumberRequest(ref GetPhoneNumberRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPhoneNumbersRequest(ref ListPhoneNumbersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePhoneNumberRequest(ref UpdatePhoneNumberRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePhoneNumberRequest(ref DeletePhoneNumberRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchPhoneNumbersRequest(ref SearchPhoneNumbersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a phone number.
        /// 
        /// The caller must have `numbering.phoneNumbers.create` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PhoneNumber CreatePhoneNumber(CreatePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePhoneNumberRequest(ref request, ref callSettings);
            return _callCreatePhoneNumber.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a phone number.
        /// 
        /// The caller must have `numbering.phoneNumbers.create` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PhoneNumber> CreatePhoneNumberAsync(CreatePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePhoneNumberRequest(ref request, ref callSettings);
            return _callCreatePhoneNumber.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a phone number identified by the supplied resource name.
        /// 
        /// The caller must have `numbering.phoneNumbers.get` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PhoneNumber GetPhoneNumber(GetPhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPhoneNumberRequest(ref request, ref callSettings);
            return _callGetPhoneNumber.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a phone number identified by the supplied resource name.
        /// 
        /// The caller must have `numbering.phoneNumbers.get` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PhoneNumber> GetPhoneNumberAsync(GetPhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPhoneNumberRequest(ref request, ref callSettings);
            return _callGetPhoneNumber.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all phone numbers.
        /// 
        /// List returns phone numbers sorted by create_time descending.
        /// 
        /// The caller must have `numbering.phoneNumbers.list` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PhoneNumber"/> resources.</returns>
        public override gax::PagedEnumerable<ListPhoneNumbersResponse, PhoneNumber> ListPhoneNumbers(ListPhoneNumbersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPhoneNumbersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPhoneNumbersRequest, ListPhoneNumbersResponse, PhoneNumber>(_callListPhoneNumbers, request, callSettings);
        }

        /// <summary>
        /// Lists all phone numbers.
        /// 
        /// List returns phone numbers sorted by create_time descending.
        /// 
        /// The caller must have `numbering.phoneNumbers.list` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PhoneNumber"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPhoneNumbersResponse, PhoneNumber> ListPhoneNumbersAsync(ListPhoneNumbersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPhoneNumbersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPhoneNumbersRequest, ListPhoneNumbersResponse, PhoneNumber>(_callListPhoneNumbers, request, callSettings);
        }

        /// <summary>
        /// Updates a phone number.
        /// 
        /// The caller must have `numbering.phoneNumbers.update` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PhoneNumber UpdatePhoneNumber(UpdatePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePhoneNumberRequest(ref request, ref callSettings);
            return _callUpdatePhoneNumber.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a phone number.
        /// 
        /// The caller must have `numbering.phoneNumbers.update` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PhoneNumber> UpdatePhoneNumberAsync(UpdatePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePhoneNumberRequest(ref request, ref callSettings);
            return _callUpdatePhoneNumber.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a phone number.
        /// 
        /// The caller must have `numbering.phoneNumbers.delete` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PhoneNumber DeletePhoneNumber(DeletePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePhoneNumberRequest(ref request, ref callSettings);
            return _callDeletePhoneNumber.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a phone number.
        /// 
        /// The caller must have `numbering.phoneNumbers.delete` permission on global resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PhoneNumber> DeletePhoneNumberAsync(DeletePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePhoneNumberRequest(ref request, ref callSettings);
            return _callDeletePhoneNumber.Async(request, callSettings);
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

    public partial class ListPhoneNumbersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchPhoneNumbersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPhoneNumbersResponse : gaxgrpc::IPageResponse<PhoneNumber>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PhoneNumber> GetEnumerator() => PhoneNumbers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchPhoneNumbersResponse : gaxgrpc::IPageResponse<PhoneNumber>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PhoneNumber> GetEnumerator() => PhoneNumbers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
