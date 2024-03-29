// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: enfonica/voice/v1beta1/streams.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Enfonica Pty Ltd
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Enfonica.Voice.V1Beta1 {
  /// <summary>
  /// A stream is a two-way audio bridge with a call. You operate a stream with the
  /// [StreamCall][enfonica.voice.v1beta1.Streams.StreamCall] method. You supply a
  /// unique, user-generated stream resource name, and then bridge a call to the stream
  /// using the Stream VoiceML action.
  /// </summary>
  public static partial class Streams
  {
    static readonly string __ServiceName = "enfonica.voice.v1beta1.Streams";

    static readonly grpc::Marshaller<global::Enfonica.Voice.V1Beta1.StreamCallRequest> __Marshaller_enfonica_voice_v1beta1_StreamCallRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Enfonica.Voice.V1Beta1.StreamCallRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Enfonica.Voice.V1Beta1.StreamCallResponse> __Marshaller_enfonica_voice_v1beta1_StreamCallResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Enfonica.Voice.V1Beta1.StreamCallResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Enfonica.Voice.V1Beta1.StreamCallRequest, global::Enfonica.Voice.V1Beta1.StreamCallResponse> __Method_StreamCall = new grpc::Method<global::Enfonica.Voice.V1Beta1.StreamCallRequest, global::Enfonica.Voice.V1Beta1.StreamCallResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "StreamCall",
        __Marshaller_enfonica_voice_v1beta1_StreamCallRequest,
        __Marshaller_enfonica_voice_v1beta1_StreamCallResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Enfonica.Voice.V1Beta1.StreamsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Streams</summary>
    [grpc::BindServiceMethod(typeof(Streams), "BindService")]
    public abstract partial class StreamsBase
    {
      /// <summary>
      /// Operates a stream which can be bridged to by a call. This allows bi-directional
      /// audio to be passed. This method is only available via the gRPC API (not REST).
      /// If the stream is not connected to a call within 30 seconds of establishment,
      /// this method will fail.
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task StreamCall(grpc::IAsyncStreamReader<global::Enfonica.Voice.V1Beta1.StreamCallRequest> requestStream, grpc::IServerStreamWriter<global::Enfonica.Voice.V1Beta1.StreamCallResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Streams</summary>
    public partial class StreamsClient : grpc::ClientBase<StreamsClient>
    {
      /// <summary>Creates a new client for Streams</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public StreamsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Streams that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public StreamsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected StreamsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected StreamsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Operates a stream which can be bridged to by a call. This allows bi-directional
      /// audio to be passed. This method is only available via the gRPC API (not REST).
      /// If the stream is not connected to a call within 30 seconds of establishment,
      /// this method will fail.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::Enfonica.Voice.V1Beta1.StreamCallRequest, global::Enfonica.Voice.V1Beta1.StreamCallResponse> StreamCall(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StreamCall(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Operates a stream which can be bridged to by a call. This allows bi-directional
      /// audio to be passed. This method is only available via the gRPC API (not REST).
      /// If the stream is not connected to a call within 30 seconds of establishment,
      /// this method will fail.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::Enfonica.Voice.V1Beta1.StreamCallRequest, global::Enfonica.Voice.V1Beta1.StreamCallResponse> StreamCall(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_StreamCall, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override StreamsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new StreamsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(StreamsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_StreamCall, serviceImpl.StreamCall).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, StreamsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_StreamCall, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Enfonica.Voice.V1Beta1.StreamCallRequest, global::Enfonica.Voice.V1Beta1.StreamCallResponse>(serviceImpl.StreamCall));
    }

  }
}
#endregion
