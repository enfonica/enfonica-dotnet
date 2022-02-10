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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Enfonica.Voice.V1Beta1
{
    /// <summary>Settings for <see cref="RecordingsClient"/> instances.</summary>
    public sealed partial class RecordingsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RecordingsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RecordingsSettings"/>.</returns>
        public static RecordingsSettings GetDefault() => new RecordingsSettings();

        /// <summary>Constructs a new <see cref="RecordingsSettings"/> object with default settings.</summary>
        public RecordingsSettings()
        {
        }

        private RecordingsSettings(RecordingsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetRecordingSettings = existing.GetRecordingSettings;
            ListRecordingsSettings = existing.ListRecordingsSettings;
            DeleteRecordingSettings = existing.DeleteRecordingSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RecordingsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecordingsClient.GetRecording</c> and <c>RecordingsClient.GetRecordingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRecordingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecordingsClient.ListRecordings</c> and <c>RecordingsClient.ListRecordingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRecordingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecordingsClient.DeleteRecording</c> and <c>RecordingsClient.DeleteRecordingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRecordingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RecordingsSettings"/> object.</returns>
        public RecordingsSettings Clone() => new RecordingsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RecordingsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class RecordingsClientBuilder : enfgaxgrpc::ClientBuilderBase<RecordingsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RecordingsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RecordingsClientBuilder()
        {
            UseJwtAccessWithScopes = RecordingsClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref RecordingsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RecordingsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RecordingsClient Build()
        {
            RecordingsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RecordingsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RecordingsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RecordingsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RecordingsClient.Create(callInvoker, Settings);
        }

        private async stt::Task<RecordingsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RecordingsClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => RecordingsClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => RecordingsClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override enfgaxgrpc::ChannelPool GetChannelPool() => RecordingsClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>Recordings client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages Recordings.
    /// </remarks>
    public abstract partial class RecordingsClient
    {
        /// <summary>
        /// The default endpoint for the Recordings service, which is a host of "voice.api.enfonica.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "voice.api.enfonica.com:443";

        /// <summary>The default Recordings scopes.</summary>
        /// <remarks>
        /// The default Recordings scopes are:
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
        /// Asynchronously creates a <see cref="RecordingsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RecordingsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RecordingsClient"/>.</returns>
        public static stt::Task<RecordingsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RecordingsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RecordingsClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="RecordingsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RecordingsClient"/>.</returns>
        public static RecordingsClient Create() => new RecordingsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RecordingsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RecordingsSettings"/>.</param>
        /// <returns>The created <see cref="RecordingsClient"/>.</returns>
        internal static RecordingsClient Create(grpccore::CallInvoker callInvoker, RecordingsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Recordings.RecordingsClient grpcClient = new Recordings.RecordingsClient(callInvoker);
            return new RecordingsClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC Recordings client</summary>
        public virtual Recordings.RecordingsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a Recording identified by the supplied resource name.
        /// 
        /// The caller must have `voice.recordings.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recording GetRecording(GetRecordingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a Recording identified by the supplied resource name.
        /// 
        /// The caller must have `voice.recordings.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recording> GetRecordingAsync(GetRecordingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a Recording identified by the supplied resource name.
        /// 
        /// The caller must have `voice.recordings.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recording> GetRecordingAsync(GetRecordingRequest request, st::CancellationToken cancellationToken) =>
            GetRecordingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a Recording identified by the supplied resource name.
        /// 
        /// The caller must have `voice.recordings.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Recording to retrieve.
        /// Must be of the form `projects/*/calls/*/recordings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recording GetRecording(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecording(new GetRecordingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Recording identified by the supplied resource name.
        /// 
        /// The caller must have `voice.recordings.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Recording to retrieve.
        /// Must be of the form `projects/*/calls/*/recordings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recording> GetRecordingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecordingAsync(new GetRecordingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Recording identified by the supplied resource name.
        /// 
        /// The caller must have `voice.recordings.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Recording to retrieve.
        /// Must be of the form `projects/*/calls/*/recordings/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recording> GetRecordingAsync(string name, st::CancellationToken cancellationToken) =>
            GetRecordingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a Recording identified by the supplied resource name.
        /// 
        /// The caller must have `voice.recordings.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Recording to retrieve.
        /// Must be of the form `projects/*/calls/*/recordings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recording GetRecording(RecordingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecording(new GetRecordingRequest
            {
                RecordingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Recording identified by the supplied resource name.
        /// 
        /// The caller must have `voice.recordings.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Recording to retrieve.
        /// Must be of the form `projects/*/calls/*/recordings/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recording> GetRecordingAsync(RecordingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecordingAsync(new GetRecordingRequest
            {
                RecordingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Recording identified by the supplied resource name.
        /// 
        /// The caller must have `voice.recordings.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Recording to retrieve.
        /// Must be of the form `projects/*/calls/*/recordings/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recording> GetRecordingAsync(RecordingName name, st::CancellationToken cancellationToken) =>
            GetRecordingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the Recordings of the specified project.
        /// List returns Recordings sorted by create_time descending.
        /// 
        /// The caller must have `voice.recordings.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Recording"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRecordingsResponse, Recording> ListRecordings(ListRecordingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Recordings of the specified project.
        /// List returns Recordings sorted by create_time descending.
        /// 
        /// The caller must have `voice.recordings.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Recording"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRecordingsResponse, Recording> ListRecordingsAsync(ListRecordingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Recordings of the specified project.
        /// List returns Recordings sorted by create_time descending.
        /// 
        /// The caller must have `voice.recordings.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the parent of which to list recordings.
        /// May be of the form `projects/*/calls/*` to list the recordings of that
        /// specific call, or `projects/*` to list recordings across the entire project,
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
        /// <returns>A pageable sequence of <see cref="Recording"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRecordingsResponse, Recording> ListRecordings(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRecordings(new ListRecordingsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the Recordings of the specified project.
        /// List returns Recordings sorted by create_time descending.
        /// 
        /// The caller must have `voice.recordings.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the parent of which to list recordings.
        /// May be of the form `projects/*/calls/*` to list the recordings of that
        /// specific call, or `projects/*` to list recordings across the entire project,
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
        /// <returns>A pageable asynchronous sequence of <see cref="Recording"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRecordingsResponse, Recording> ListRecordingsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRecordingsAsync(new ListRecordingsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the Recordings of the specified project.
        /// List returns Recordings sorted by create_time descending.
        /// 
        /// The caller must have `voice.recordings.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the parent of which to list recordings.
        /// May be of the form `projects/*/calls/*` to list the recordings of that
        /// specific call, or `projects/*` to list recordings across the entire project,
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
        /// <returns>A pageable sequence of <see cref="Recording"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRecordingsResponse, Recording> ListRecordings(CallName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRecordings(new ListRecordingsRequest
            {
                ParentAsCallName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the Recordings of the specified project.
        /// List returns Recordings sorted by create_time descending.
        /// 
        /// The caller must have `voice.recordings.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the parent of which to list recordings.
        /// May be of the form `projects/*/calls/*` to list the recordings of that
        /// specific call, or `projects/*` to list recordings across the entire project,
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
        /// <returns>A pageable asynchronous sequence of <see cref="Recording"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRecordingsResponse, Recording> ListRecordingsAsync(CallName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRecordingsAsync(new ListRecordingsRequest
            {
                ParentAsCallName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes a recording.
        /// 
        /// The caller must have `voice.recordings.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recording DeleteRecording(DeleteRecordingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a recording.
        /// 
        /// The caller must have `voice.recordings.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recording> DeleteRecordingAsync(DeleteRecordingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a recording.
        /// 
        /// The caller must have `voice.recordings.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recording> DeleteRecordingAsync(DeleteRecordingRequest request, st::CancellationToken cancellationToken) =>
            DeleteRecordingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a recording.
        /// 
        /// The caller must have `voice.recordings.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Recording to be deleted.
        /// Must be of the form `projects/*/calls/*/recording/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recording DeleteRecording(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRecording(new DeleteRecordingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a recording.
        /// 
        /// The caller must have `voice.recordings.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Recording to be deleted.
        /// Must be of the form `projects/*/calls/*/recording/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recording> DeleteRecordingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRecordingAsync(new DeleteRecordingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a recording.
        /// 
        /// The caller must have `voice.recordings.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Recording to be deleted.
        /// Must be of the form `projects/*/calls/*/recording/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recording> DeleteRecordingAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRecordingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a recording.
        /// 
        /// The caller must have `voice.recordings.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Recording to be deleted.
        /// Must be of the form `projects/*/calls/*/recording/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recording DeleteRecording(RecordingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRecording(new DeleteRecordingRequest
            {
                RecordingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a recording.
        /// 
        /// The caller must have `voice.recordings.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Recording to be deleted.
        /// Must be of the form `projects/*/calls/*/recording/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recording> DeleteRecordingAsync(RecordingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRecordingAsync(new DeleteRecordingRequest
            {
                RecordingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a recording.
        /// 
        /// The caller must have `voice.recordings.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Recording to be deleted.
        /// Must be of the form `projects/*/calls/*/recording/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recording> DeleteRecordingAsync(RecordingName name, st::CancellationToken cancellationToken) =>
            DeleteRecordingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Recordings client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages Recordings.
    /// </remarks>
    public sealed partial class RecordingsClientImpl : RecordingsClient
    {
        private readonly gaxgrpc::ApiCall<GetRecordingRequest, Recording> _callGetRecording;

        private readonly gaxgrpc::ApiCall<ListRecordingsRequest, ListRecordingsResponse> _callListRecordings;

        private readonly gaxgrpc::ApiCall<DeleteRecordingRequest, Recording> _callDeleteRecording;

        /// <summary>
        /// Constructs a client wrapper for the Recordings service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RecordingsSettings"/> used within this client.</param>
        public RecordingsClientImpl(Recordings.RecordingsClient grpcClient, RecordingsSettings settings)
        {
            GrpcClient = grpcClient;
            RecordingsSettings effectiveSettings = settings ?? RecordingsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetRecording = clientHelper.BuildApiCall<GetRecordingRequest, Recording>(grpcClient.GetRecordingAsync, grpcClient.GetRecording, effectiveSettings.GetRecordingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRecording);
            Modify_GetRecordingApiCall(ref _callGetRecording);
            _callListRecordings = clientHelper.BuildApiCall<ListRecordingsRequest, ListRecordingsResponse>(grpcClient.ListRecordingsAsync, grpcClient.ListRecordings, effectiveSettings.ListRecordingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRecordings);
            Modify_ListRecordingsApiCall(ref _callListRecordings);
            _callDeleteRecording = clientHelper.BuildApiCall<DeleteRecordingRequest, Recording>(grpcClient.DeleteRecordingAsync, grpcClient.DeleteRecording, effectiveSettings.DeleteRecordingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRecording);
            Modify_DeleteRecordingApiCall(ref _callDeleteRecording);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetRecordingApiCall(ref gaxgrpc::ApiCall<GetRecordingRequest, Recording> call);

        partial void Modify_ListRecordingsApiCall(ref gaxgrpc::ApiCall<ListRecordingsRequest, ListRecordingsResponse> call);

        partial void Modify_DeleteRecordingApiCall(ref gaxgrpc::ApiCall<DeleteRecordingRequest, Recording> call);

        partial void OnConstruction(Recordings.RecordingsClient grpcClient, RecordingsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Recordings client</summary>
        public override Recordings.RecordingsClient GrpcClient { get; }

        partial void Modify_GetRecordingRequest(ref GetRecordingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRecordingsRequest(ref ListRecordingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRecordingRequest(ref DeleteRecordingRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a Recording identified by the supplied resource name.
        /// 
        /// The caller must have `voice.recordings.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Recording GetRecording(GetRecordingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRecordingRequest(ref request, ref callSettings);
            return _callGetRecording.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a Recording identified by the supplied resource name.
        /// 
        /// The caller must have `voice.recordings.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Recording> GetRecordingAsync(GetRecordingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRecordingRequest(ref request, ref callSettings);
            return _callGetRecording.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the Recordings of the specified project.
        /// List returns Recordings sorted by create_time descending.
        /// 
        /// The caller must have `voice.recordings.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Recording"/> resources.</returns>
        public override gax::PagedEnumerable<ListRecordingsResponse, Recording> ListRecordings(ListRecordingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRecordingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRecordingsRequest, ListRecordingsResponse, Recording>(_callListRecordings, request, callSettings);
        }

        /// <summary>
        /// Lists the Recordings of the specified project.
        /// List returns Recordings sorted by create_time descending.
        /// 
        /// The caller must have `voice.recordings.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Recording"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRecordingsResponse, Recording> ListRecordingsAsync(ListRecordingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRecordingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRecordingsRequest, ListRecordingsResponse, Recording>(_callListRecordings, request, callSettings);
        }

        /// <summary>
        /// Deletes a recording.
        /// 
        /// The caller must have `voice.recordings.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Recording DeleteRecording(DeleteRecordingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRecordingRequest(ref request, ref callSettings);
            return _callDeleteRecording.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a recording.
        /// 
        /// The caller must have `voice.recordings.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Recording> DeleteRecordingAsync(DeleteRecordingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRecordingRequest(ref request, ref callSettings);
            return _callDeleteRecording.Async(request, callSettings);
        }
    }

    public partial class ListRecordingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRecordingsResponse : gaxgrpc::IPageResponse<Recording>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Recording> GetEnumerator() => Recordings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
