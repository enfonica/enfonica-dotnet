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
    /// <summary>Settings for <see cref="TranscriptionsClient"/> instances.</summary>
    public sealed partial class TranscriptionsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TranscriptionsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TranscriptionsSettings"/>.</returns>
        public static TranscriptionsSettings GetDefault() => new TranscriptionsSettings();

        /// <summary>Constructs a new <see cref="TranscriptionsSettings"/> object with default settings.</summary>
        public TranscriptionsSettings()
        {
        }

        private TranscriptionsSettings(TranscriptionsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetTranscriptionSettings = existing.GetTranscriptionSettings;
            ListTranscriptionsSettings = existing.ListTranscriptionsSettings;
            DeleteTranscriptionSettings = existing.DeleteTranscriptionSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TranscriptionsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranscriptionsClient.GetTranscription</c> and <c>TranscriptionsClient.GetTranscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTranscriptionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranscriptionsClient.ListTranscriptions</c> and <c>TranscriptionsClient.ListTranscriptionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTranscriptionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranscriptionsClient.DeleteTranscription</c> and <c>TranscriptionsClient.DeleteTranscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTranscriptionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TranscriptionsSettings"/> object.</returns>
        public TranscriptionsSettings Clone() => new TranscriptionsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TranscriptionsClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class TranscriptionsClientBuilder : enfgaxgrpc::ClientBuilderBase<TranscriptionsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TranscriptionsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TranscriptionsClientBuilder()
        {
            UseJwtAccessWithScopes = TranscriptionsClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref TranscriptionsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TranscriptionsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TranscriptionsClient Build()
        {
            TranscriptionsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TranscriptionsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TranscriptionsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TranscriptionsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TranscriptionsClient.Create(callInvoker, Settings);
        }

        private async stt::Task<TranscriptionsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TranscriptionsClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => TranscriptionsClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => TranscriptionsClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override enfgaxgrpc::ChannelPool GetChannelPool() => TranscriptionsClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>Transcriptions client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages Transcriptions.
    /// </remarks>
    public abstract partial class TranscriptionsClient
    {
        /// <summary>
        /// The default endpoint for the Transcriptions service, which is a host of "voice.api.enfonica.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "voice.api.enfonica.com:443";

        /// <summary>The default Transcriptions scopes.</summary>
        /// <remarks>
        /// The default Transcriptions scopes are:
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
        /// Asynchronously creates a <see cref="TranscriptionsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TranscriptionsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TranscriptionsClient"/>.</returns>
        public static stt::Task<TranscriptionsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TranscriptionsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TranscriptionsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TranscriptionsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TranscriptionsClient"/>.</returns>
        public static TranscriptionsClient Create() => new TranscriptionsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TranscriptionsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TranscriptionsSettings"/>.</param>
        /// <returns>The created <see cref="TranscriptionsClient"/>.</returns>
        internal static TranscriptionsClient Create(grpccore::CallInvoker callInvoker, TranscriptionsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Transcriptions.TranscriptionsClient grpcClient = new Transcriptions.TranscriptionsClient(callInvoker);
            return new TranscriptionsClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC Transcriptions client</summary>
        public virtual Transcriptions.TranscriptionsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a Transcription identified by the supplied resource name.
        /// 
        /// The caller must have `voice.transcriptions.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Transcription GetTranscription(GetTranscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a Transcription identified by the supplied resource name.
        /// 
        /// The caller must have `voice.transcriptions.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transcription> GetTranscriptionAsync(GetTranscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a Transcription identified by the supplied resource name.
        /// 
        /// The caller must have `voice.transcriptions.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transcription> GetTranscriptionAsync(GetTranscriptionRequest request, st::CancellationToken cancellationToken) =>
            GetTranscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a Transcription identified by the supplied resource name.
        /// 
        /// The caller must have `voice.transcriptions.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Transcription to retrieve.
        /// Must be of the form `projects/*/calls/*/transcriptions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Transcription GetTranscription(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTranscription(new GetTranscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Transcription identified by the supplied resource name.
        /// 
        /// The caller must have `voice.transcriptions.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Transcription to retrieve.
        /// Must be of the form `projects/*/calls/*/transcriptions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transcription> GetTranscriptionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTranscriptionAsync(new GetTranscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Transcription identified by the supplied resource name.
        /// 
        /// The caller must have `voice.transcriptions.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Transcription to retrieve.
        /// Must be of the form `projects/*/calls/*/transcriptions/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transcription> GetTranscriptionAsync(string name, st::CancellationToken cancellationToken) =>
            GetTranscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a Transcription identified by the supplied resource name.
        /// 
        /// The caller must have `voice.transcriptions.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Transcription to retrieve.
        /// Must be of the form `projects/*/calls/*/transcriptions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Transcription GetTranscription(TranscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTranscription(new GetTranscriptionRequest
            {
                TranscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Transcription identified by the supplied resource name.
        /// 
        /// The caller must have `voice.transcriptions.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Transcription to retrieve.
        /// Must be of the form `projects/*/calls/*/transcriptions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transcription> GetTranscriptionAsync(TranscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTranscriptionAsync(new GetTranscriptionRequest
            {
                TranscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Transcription identified by the supplied resource name.
        /// 
        /// The caller must have `voice.transcriptions.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Transcription to retrieve.
        /// Must be of the form `projects/*/calls/*/transcriptions/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transcription> GetTranscriptionAsync(TranscriptionName name, st::CancellationToken cancellationToken) =>
            GetTranscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the Transcriptions of the specified project.
        /// List returns Transcriptions sorted by create_time descending.
        /// 
        /// The caller must have `voice.transcriptions.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Transcription"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTranscriptionsResponse, Transcription> ListTranscriptions(ListTranscriptionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Transcriptions of the specified project.
        /// List returns Transcriptions sorted by create_time descending.
        /// 
        /// The caller must have `voice.transcriptions.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Transcription"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTranscriptionsResponse, Transcription> ListTranscriptionsAsync(ListTranscriptionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Transcriptions of the specified project.
        /// List returns Transcriptions sorted by create_time descending.
        /// 
        /// The caller must have `voice.transcriptions.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the parent of which to list transcriptions.
        /// May be of the form `projects/*/calls/*` to list the transcriptions of that
        /// specific call, or `projects/*` to list transcriptions across the entire project,
        /// which maps to `projects/*/calls/-`.
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
        /// <returns>A pageable sequence of <see cref="Transcription"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTranscriptionsResponse, Transcription> ListTranscriptions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTranscriptions(new ListTranscriptionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the Transcriptions of the specified project.
        /// List returns Transcriptions sorted by create_time descending.
        /// 
        /// The caller must have `voice.transcriptions.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the parent of which to list transcriptions.
        /// May be of the form `projects/*/calls/*` to list the transcriptions of that
        /// specific call, or `projects/*` to list transcriptions across the entire project,
        /// which maps to `projects/*/calls/-`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Transcription"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTranscriptionsResponse, Transcription> ListTranscriptionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTranscriptionsAsync(new ListTranscriptionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the Transcriptions of the specified project.
        /// List returns Transcriptions sorted by create_time descending.
        /// 
        /// The caller must have `voice.transcriptions.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the parent of which to list transcriptions.
        /// May be of the form `projects/*/calls/*` to list the transcriptions of that
        /// specific call, or `projects/*` to list transcriptions across the entire project,
        /// which maps to `projects/*/calls/-`.
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
        /// <returns>A pageable sequence of <see cref="Transcription"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTranscriptionsResponse, Transcription> ListTranscriptions(CallName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTranscriptions(new ListTranscriptionsRequest
            {
                ParentAsCallName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the Transcriptions of the specified project.
        /// List returns Transcriptions sorted by create_time descending.
        /// 
        /// The caller must have `voice.transcriptions.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the parent of which to list transcriptions.
        /// May be of the form `projects/*/calls/*` to list the transcriptions of that
        /// specific call, or `projects/*` to list transcriptions across the entire project,
        /// which maps to `projects/*/calls/-`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Transcription"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTranscriptionsResponse, Transcription> ListTranscriptionsAsync(CallName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTranscriptionsAsync(new ListTranscriptionsRequest
            {
                ParentAsCallName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes a transcription.
        /// 
        /// The caller must have `voice.transcriptions.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTranscription(DeleteTranscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a transcription.
        /// 
        /// The caller must have `voice.transcriptions.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTranscriptionAsync(DeleteTranscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a transcription.
        /// 
        /// The caller must have `voice.transcriptions.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTranscriptionAsync(DeleteTranscriptionRequest request, st::CancellationToken cancellationToken) =>
            DeleteTranscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a transcription.
        /// 
        /// The caller must have `voice.transcriptions.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Transcription to be deleted.
        /// Must be of the form `projects/*/calls/*/transcription/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTranscription(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTranscription(new DeleteTranscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a transcription.
        /// 
        /// The caller must have `voice.transcriptions.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Transcription to be deleted.
        /// Must be of the form `projects/*/calls/*/transcription/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTranscriptionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTranscriptionAsync(new DeleteTranscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a transcription.
        /// 
        /// The caller must have `voice.transcriptions.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Transcription to be deleted.
        /// Must be of the form `projects/*/calls/*/transcription/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTranscriptionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTranscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a transcription.
        /// 
        /// The caller must have `voice.transcriptions.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Transcription to be deleted.
        /// Must be of the form `projects/*/calls/*/transcription/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTranscription(TranscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTranscription(new DeleteTranscriptionRequest
            {
                TranscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a transcription.
        /// 
        /// The caller must have `voice.transcriptions.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Transcription to be deleted.
        /// Must be of the form `projects/*/calls/*/transcription/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTranscriptionAsync(TranscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTranscriptionAsync(new DeleteTranscriptionRequest
            {
                TranscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a transcription.
        /// 
        /// The caller must have `voice.transcriptions.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Transcription to be deleted.
        /// Must be of the form `projects/*/calls/*/transcription/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTranscriptionAsync(TranscriptionName name, st::CancellationToken cancellationToken) =>
            DeleteTranscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Transcriptions client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages Transcriptions.
    /// </remarks>
    public sealed partial class TranscriptionsClientImpl : TranscriptionsClient
    {
        private readonly gaxgrpc::ApiCall<GetTranscriptionRequest, Transcription> _callGetTranscription;

        private readonly gaxgrpc::ApiCall<ListTranscriptionsRequest, ListTranscriptionsResponse> _callListTranscriptions;

        private readonly gaxgrpc::ApiCall<DeleteTranscriptionRequest, wkt::Empty> _callDeleteTranscription;

        /// <summary>
        /// Constructs a client wrapper for the Transcriptions service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TranscriptionsSettings"/> used within this client.</param>
        public TranscriptionsClientImpl(Transcriptions.TranscriptionsClient grpcClient, TranscriptionsSettings settings)
        {
            GrpcClient = grpcClient;
            TranscriptionsSettings effectiveSettings = settings ?? TranscriptionsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetTranscription = clientHelper.BuildApiCall<GetTranscriptionRequest, Transcription>(grpcClient.GetTranscriptionAsync, grpcClient.GetTranscription, effectiveSettings.GetTranscriptionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTranscription);
            Modify_GetTranscriptionApiCall(ref _callGetTranscription);
            _callListTranscriptions = clientHelper.BuildApiCall<ListTranscriptionsRequest, ListTranscriptionsResponse>(grpcClient.ListTranscriptionsAsync, grpcClient.ListTranscriptions, effectiveSettings.ListTranscriptionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTranscriptions);
            Modify_ListTranscriptionsApiCall(ref _callListTranscriptions);
            _callDeleteTranscription = clientHelper.BuildApiCall<DeleteTranscriptionRequest, wkt::Empty>(grpcClient.DeleteTranscriptionAsync, grpcClient.DeleteTranscription, effectiveSettings.DeleteTranscriptionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTranscription);
            Modify_DeleteTranscriptionApiCall(ref _callDeleteTranscription);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetTranscriptionApiCall(ref gaxgrpc::ApiCall<GetTranscriptionRequest, Transcription> call);

        partial void Modify_ListTranscriptionsApiCall(ref gaxgrpc::ApiCall<ListTranscriptionsRequest, ListTranscriptionsResponse> call);

        partial void Modify_DeleteTranscriptionApiCall(ref gaxgrpc::ApiCall<DeleteTranscriptionRequest, wkt::Empty> call);

        partial void OnConstruction(Transcriptions.TranscriptionsClient grpcClient, TranscriptionsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Transcriptions client</summary>
        public override Transcriptions.TranscriptionsClient GrpcClient { get; }

        partial void Modify_GetTranscriptionRequest(ref GetTranscriptionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTranscriptionsRequest(ref ListTranscriptionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTranscriptionRequest(ref DeleteTranscriptionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a Transcription identified by the supplied resource name.
        /// 
        /// The caller must have `voice.transcriptions.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Transcription GetTranscription(GetTranscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTranscriptionRequest(ref request, ref callSettings);
            return _callGetTranscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a Transcription identified by the supplied resource name.
        /// 
        /// The caller must have `voice.transcriptions.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Transcription> GetTranscriptionAsync(GetTranscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTranscriptionRequest(ref request, ref callSettings);
            return _callGetTranscription.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the Transcriptions of the specified project.
        /// List returns Transcriptions sorted by create_time descending.
        /// 
        /// The caller must have `voice.transcriptions.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Transcription"/> resources.</returns>
        public override gax::PagedEnumerable<ListTranscriptionsResponse, Transcription> ListTranscriptions(ListTranscriptionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTranscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTranscriptionsRequest, ListTranscriptionsResponse, Transcription>(_callListTranscriptions, request, callSettings);
        }

        /// <summary>
        /// Lists the Transcriptions of the specified project.
        /// List returns Transcriptions sorted by create_time descending.
        /// 
        /// The caller must have `voice.transcriptions.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Transcription"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTranscriptionsResponse, Transcription> ListTranscriptionsAsync(ListTranscriptionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTranscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTranscriptionsRequest, ListTranscriptionsResponse, Transcription>(_callListTranscriptions, request, callSettings);
        }

        /// <summary>
        /// Deletes a transcription.
        /// 
        /// The caller must have `voice.transcriptions.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTranscription(DeleteTranscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTranscriptionRequest(ref request, ref callSettings);
            _callDeleteTranscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a transcription.
        /// 
        /// The caller must have `voice.transcriptions.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTranscriptionAsync(DeleteTranscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTranscriptionRequest(ref request, ref callSettings);
            return _callDeleteTranscription.Async(request, callSettings);
        }
    }

    public partial class ListTranscriptionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTranscriptionsResponse : gaxgrpc::IPageResponse<Transcription>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Transcription> GetEnumerator() => Transcriptions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
