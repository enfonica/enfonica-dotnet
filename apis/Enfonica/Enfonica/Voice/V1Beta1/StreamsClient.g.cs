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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Enfonica.Voice.V1Beta1
{
    /// <summary>Settings for <see cref="StreamsClient"/> instances.</summary>
    public sealed partial class StreamsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="StreamsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="StreamsSettings"/>.</returns>
        public static StreamsSettings GetDefault() => new StreamsSettings();

        /// <summary>Constructs a new <see cref="StreamsSettings"/> object with default settings.</summary>
        public StreamsSettings()
        {
        }

        private StreamsSettings(StreamsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            StreamCallSettings = existing.StreamCallSettings;
            StreamCallStreamingSettings = existing.StreamCallStreamingSettings;
            OnCopy(existing);
        }

        partial void OnCopy(StreamsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StreamsClient.StreamCall</c>
        ///  and <c>StreamsClient.StreamCallAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StreamCallSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to <c>StreamsClient.StreamCall</c> and
        /// <c>StreamsClient.StreamCallAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings StreamCallStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="StreamsSettings"/> object.</returns>
        public StreamsSettings Clone() => new StreamsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="StreamsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class StreamsClientBuilder : enfgaxgrpc::ClientBuilderBase<StreamsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public StreamsSettings Settings { get; set; }

        partial void InterceptBuild(ref StreamsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<StreamsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override StreamsClient Build()
        {
            StreamsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<StreamsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<StreamsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private StreamsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return StreamsClient.Create(callInvoker, Settings);
        }

        private async stt::Task<StreamsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return StreamsClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => StreamsClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => StreamsClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override enfgaxgrpc::ChannelPool GetChannelPool() => StreamsClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>Streams client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A stream is a two-way audio bridge with a call. You operate a stream with the
    /// [StreamCall][enfonica.voice.v1beta1.Streams.StreamCall] method. You supply a
    /// unique, user-generated stream resource name, and then bridge a call to the stream
    /// using the Stream VoiceML action.
    /// </remarks>
    public abstract partial class StreamsClient
    {
        /// <summary>
        /// The default endpoint for the Streams service, which is a host of "voice.api.enfonica.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "voice.api.enfonica.com:443";

        /// <summary>The default Streams scopes.</summary>
        /// <remarks>
        /// The default Streams scopes are:
        /// <list type="bullet"><item><description>https://api.enfonica.com/auth/voice</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://api.enfonica.com/auth/voice",
        });

        internal static enfgaxgrpc::ChannelPool ChannelPool { get; } = new enfgaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="StreamsClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="StreamsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="StreamsClient"/>.</returns>
        public static stt::Task<StreamsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new StreamsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="StreamsClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="StreamsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="StreamsClient"/>.</returns>
        public static StreamsClient Create() => new StreamsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="StreamsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="StreamsSettings"/>.</param>
        /// <returns>The created <see cref="StreamsClient"/>.</returns>
        internal static StreamsClient Create(grpccore::CallInvoker callInvoker, StreamsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Streams.StreamsClient grpcClient = new Streams.StreamsClient(callInvoker);
            return new StreamsClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC Streams client</summary>
        public virtual Streams.StreamsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="StreamCall(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class StreamCallStream : gaxgrpc::BidirectionalStreamingBase<StreamCallRequest, StreamCallResponse>
        {
        }

        /// <summary>
        /// Operates a stream which can be bridged to by a call. This allows bi-directional
        /// audio to be passed. This method is only available via the gRPC API (not REST).
        /// If the stream is not connected to a call within 30 seconds of establishment,
        /// this method will fail.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual StreamCallStream StreamCall(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>Streams client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A stream is a two-way audio bridge with a call. You operate a stream with the
    /// [StreamCall][enfonica.voice.v1beta1.Streams.StreamCall] method. You supply a
    /// unique, user-generated stream resource name, and then bridge a call to the stream
    /// using the Stream VoiceML action.
    /// </remarks>
    public sealed partial class StreamsClientImpl : StreamsClient
    {
        private readonly gaxgrpc::ApiBidirectionalStreamingCall<StreamCallRequest, StreamCallResponse> _callStreamCall;

        /// <summary>
        /// Constructs a client wrapper for the Streams service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="StreamsSettings"/> used within this client.</param>
        public StreamsClientImpl(Streams.StreamsClient grpcClient, StreamsSettings settings)
        {
            GrpcClient = grpcClient;
            StreamsSettings effectiveSettings = settings ?? StreamsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callStreamCall = clientHelper.BuildApiCall<StreamCallRequest, StreamCallResponse>(grpcClient.StreamCall, effectiveSettings.StreamCallSettings, effectiveSettings.StreamCallStreamingSettings);
            Modify_ApiCall(ref _callStreamCall);
            Modify_StreamCallApiCall(ref _callStreamCall);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_StreamCallApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<StreamCallRequest, StreamCallResponse> call);

        partial void OnConstruction(Streams.StreamsClient grpcClient, StreamsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Streams client</summary>
        public override Streams.StreamsClient GrpcClient { get; }

        partial void Modify_StreamCallRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamCallRequestRequest(ref StreamCallRequest request);

        internal sealed partial class StreamCallStreamImpl : StreamCallStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>StreamCall</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{StreamCallRequest}"/> instance associated with this
            /// streaming call.
            /// </param>
            public StreamCallStreamImpl(StreamsClientImpl service, grpccore::AsyncDuplexStreamingCall<StreamCallRequest, StreamCallResponse> call, gaxgrpc::BufferedClientStreamWriter<StreamCallRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private StreamsClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<StreamCallRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<StreamCallRequest, StreamCallResponse> GrpcCall { get; }

            private StreamCallRequest ModifyRequest(StreamCallRequest request)
            {
                _service.Modify_StreamCallRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(StreamCallRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(StreamCallRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(StreamCallRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(StreamCallRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Operates a stream which can be bridged to by a call. This allows bi-directional
        /// audio to be passed. This method is only available via the gRPC API (not REST).
        /// If the stream is not connected to a call within 30 seconds of establishment,
        /// this method will fail.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override StreamsClient.StreamCallStream StreamCall(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_StreamCallRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callStreamCall.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<StreamCallRequest, StreamCallResponse> call = _callStreamCall.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<StreamCallRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<StreamCallRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new StreamCallStreamImpl(this, call, writeBuffer);
        }
    }
}
