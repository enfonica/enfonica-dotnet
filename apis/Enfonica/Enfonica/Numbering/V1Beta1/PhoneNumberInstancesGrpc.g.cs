// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: enfonica/numbering/v1beta1/phone_number_instances.proto
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

namespace Enfonica.Numbering.V1Beta1 {
  /// <summary>
  /// Manages PhoneNumberInstances.
  /// </summary>
  public static partial class PhoneNumberInstances
  {
    static readonly string __ServiceName = "enfonica.numbering.v1beta1.PhoneNumberInstances";

    static readonly grpc::Marshaller<global::Enfonica.Numbering.V1Beta1.CreatePhoneNumberInstanceRequest> __Marshaller_enfonica_numbering_v1beta1_CreatePhoneNumberInstanceRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Enfonica.Numbering.V1Beta1.CreatePhoneNumberInstanceRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance> __Marshaller_enfonica_numbering_v1beta1_PhoneNumberInstance = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Enfonica.Numbering.V1Beta1.GetPhoneNumberInstanceRequest> __Marshaller_enfonica_numbering_v1beta1_GetPhoneNumberInstanceRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Enfonica.Numbering.V1Beta1.GetPhoneNumberInstanceRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Enfonica.Numbering.V1Beta1.ListPhoneNumberInstancesRequest> __Marshaller_enfonica_numbering_v1beta1_ListPhoneNumberInstancesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Enfonica.Numbering.V1Beta1.ListPhoneNumberInstancesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Enfonica.Numbering.V1Beta1.ListPhoneNumberInstancesResponse> __Marshaller_enfonica_numbering_v1beta1_ListPhoneNumberInstancesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Enfonica.Numbering.V1Beta1.ListPhoneNumberInstancesResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Enfonica.Numbering.V1Beta1.UpdatePhoneNumberInstanceRequest> __Marshaller_enfonica_numbering_v1beta1_UpdatePhoneNumberInstanceRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Enfonica.Numbering.V1Beta1.UpdatePhoneNumberInstanceRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Enfonica.Numbering.V1Beta1.DeletePhoneNumberInstanceRequest> __Marshaller_enfonica_numbering_v1beta1_DeletePhoneNumberInstanceRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Enfonica.Numbering.V1Beta1.DeletePhoneNumberInstanceRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::Enfonica.Numbering.V1Beta1.CreatePhoneNumberInstanceRequest, global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance> __Method_CreatePhoneNumberInstance = new grpc::Method<global::Enfonica.Numbering.V1Beta1.CreatePhoneNumberInstanceRequest, global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreatePhoneNumberInstance",
        __Marshaller_enfonica_numbering_v1beta1_CreatePhoneNumberInstanceRequest,
        __Marshaller_enfonica_numbering_v1beta1_PhoneNumberInstance);

    static readonly grpc::Method<global::Enfonica.Numbering.V1Beta1.GetPhoneNumberInstanceRequest, global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance> __Method_GetPhoneNumberInstance = new grpc::Method<global::Enfonica.Numbering.V1Beta1.GetPhoneNumberInstanceRequest, global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPhoneNumberInstance",
        __Marshaller_enfonica_numbering_v1beta1_GetPhoneNumberInstanceRequest,
        __Marshaller_enfonica_numbering_v1beta1_PhoneNumberInstance);

    static readonly grpc::Method<global::Enfonica.Numbering.V1Beta1.ListPhoneNumberInstancesRequest, global::Enfonica.Numbering.V1Beta1.ListPhoneNumberInstancesResponse> __Method_ListPhoneNumberInstances = new grpc::Method<global::Enfonica.Numbering.V1Beta1.ListPhoneNumberInstancesRequest, global::Enfonica.Numbering.V1Beta1.ListPhoneNumberInstancesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListPhoneNumberInstances",
        __Marshaller_enfonica_numbering_v1beta1_ListPhoneNumberInstancesRequest,
        __Marshaller_enfonica_numbering_v1beta1_ListPhoneNumberInstancesResponse);

    static readonly grpc::Method<global::Enfonica.Numbering.V1Beta1.UpdatePhoneNumberInstanceRequest, global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance> __Method_UpdatePhoneNumberInstance = new grpc::Method<global::Enfonica.Numbering.V1Beta1.UpdatePhoneNumberInstanceRequest, global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdatePhoneNumberInstance",
        __Marshaller_enfonica_numbering_v1beta1_UpdatePhoneNumberInstanceRequest,
        __Marshaller_enfonica_numbering_v1beta1_PhoneNumberInstance);

    static readonly grpc::Method<global::Enfonica.Numbering.V1Beta1.DeletePhoneNumberInstanceRequest, global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance> __Method_DeletePhoneNumberInstance = new grpc::Method<global::Enfonica.Numbering.V1Beta1.DeletePhoneNumberInstanceRequest, global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeletePhoneNumberInstance",
        __Marshaller_enfonica_numbering_v1beta1_DeletePhoneNumberInstanceRequest,
        __Marshaller_enfonica_numbering_v1beta1_PhoneNumberInstance);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Enfonica.Numbering.V1Beta1.PhoneNumberInstancesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PhoneNumberInstances</summary>
    [grpc::BindServiceMethod(typeof(PhoneNumberInstances), "BindService")]
    public abstract partial class PhoneNumberInstancesBase
    {
      /// <summary>
      /// Creates a phone number instance.
      ///
      /// The caller must have `numbering.phoneNumberInstances.create` permission on the project.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance> CreatePhoneNumberInstance(global::Enfonica.Numbering.V1Beta1.CreatePhoneNumberInstanceRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Retrieves a phone number instance identified by the supplied resource name.
      ///
      /// The caller must have `numbering.phoneNumberInstances.get` permission on the project.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance> GetPhoneNumberInstance(global::Enfonica.Numbering.V1Beta1.GetPhoneNumberInstanceRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Lists all PhoneNumberInstances.
      /// List returns phone number instance sorted by create_time descending.
      ///
      /// The caller must have `numbering.phoneNumberInstances.list` permission on the project.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Enfonica.Numbering.V1Beta1.ListPhoneNumberInstancesResponse> ListPhoneNumberInstances(global::Enfonica.Numbering.V1Beta1.ListPhoneNumberInstancesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates a phone number instance.
      ///
      /// The caller must have `numbering.phoneNumberInstances.update` permission on the project.
      /// (-- api-linter: core::0134::http-uri-name=disabled
      ///     aip.dev/not-precedent: Update has `name` in the request message in this beta. --)
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance> UpdatePhoneNumberInstance(global::Enfonica.Numbering.V1Beta1.UpdatePhoneNumberInstanceRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes a phone number instance.
      ///
      /// The caller must have `numbering.phoneNumberInstances.delete` permission on the project.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance> DeletePhoneNumberInstance(global::Enfonica.Numbering.V1Beta1.DeletePhoneNumberInstanceRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PhoneNumberInstances</summary>
    public partial class PhoneNumberInstancesClient : grpc::ClientBase<PhoneNumberInstancesClient>
    {
      /// <summary>Creates a new client for PhoneNumberInstances</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PhoneNumberInstancesClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PhoneNumberInstances that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PhoneNumberInstancesClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PhoneNumberInstancesClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PhoneNumberInstancesClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Creates a phone number instance.
      ///
      /// The caller must have `numbering.phoneNumberInstances.create` permission on the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance CreatePhoneNumberInstance(global::Enfonica.Numbering.V1Beta1.CreatePhoneNumberInstanceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreatePhoneNumberInstance(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a phone number instance.
      ///
      /// The caller must have `numbering.phoneNumberInstances.create` permission on the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance CreatePhoneNumberInstance(global::Enfonica.Numbering.V1Beta1.CreatePhoneNumberInstanceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreatePhoneNumberInstance, null, options, request);
      }
      /// <summary>
      /// Creates a phone number instance.
      ///
      /// The caller must have `numbering.phoneNumberInstances.create` permission on the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance> CreatePhoneNumberInstanceAsync(global::Enfonica.Numbering.V1Beta1.CreatePhoneNumberInstanceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreatePhoneNumberInstanceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a phone number instance.
      ///
      /// The caller must have `numbering.phoneNumberInstances.create` permission on the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance> CreatePhoneNumberInstanceAsync(global::Enfonica.Numbering.V1Beta1.CreatePhoneNumberInstanceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreatePhoneNumberInstance, null, options, request);
      }
      /// <summary>
      /// Retrieves a phone number instance identified by the supplied resource name.
      ///
      /// The caller must have `numbering.phoneNumberInstances.get` permission on the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance GetPhoneNumberInstance(global::Enfonica.Numbering.V1Beta1.GetPhoneNumberInstanceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPhoneNumberInstance(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves a phone number instance identified by the supplied resource name.
      ///
      /// The caller must have `numbering.phoneNumberInstances.get` permission on the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance GetPhoneNumberInstance(global::Enfonica.Numbering.V1Beta1.GetPhoneNumberInstanceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPhoneNumberInstance, null, options, request);
      }
      /// <summary>
      /// Retrieves a phone number instance identified by the supplied resource name.
      ///
      /// The caller must have `numbering.phoneNumberInstances.get` permission on the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance> GetPhoneNumberInstanceAsync(global::Enfonica.Numbering.V1Beta1.GetPhoneNumberInstanceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPhoneNumberInstanceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves a phone number instance identified by the supplied resource name.
      ///
      /// The caller must have `numbering.phoneNumberInstances.get` permission on the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance> GetPhoneNumberInstanceAsync(global::Enfonica.Numbering.V1Beta1.GetPhoneNumberInstanceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPhoneNumberInstance, null, options, request);
      }
      /// <summary>
      /// Lists all PhoneNumberInstances.
      /// List returns phone number instance sorted by create_time descending.
      ///
      /// The caller must have `numbering.phoneNumberInstances.list` permission on the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Enfonica.Numbering.V1Beta1.ListPhoneNumberInstancesResponse ListPhoneNumberInstances(global::Enfonica.Numbering.V1Beta1.ListPhoneNumberInstancesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListPhoneNumberInstances(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists all PhoneNumberInstances.
      /// List returns phone number instance sorted by create_time descending.
      ///
      /// The caller must have `numbering.phoneNumberInstances.list` permission on the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Enfonica.Numbering.V1Beta1.ListPhoneNumberInstancesResponse ListPhoneNumberInstances(global::Enfonica.Numbering.V1Beta1.ListPhoneNumberInstancesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListPhoneNumberInstances, null, options, request);
      }
      /// <summary>
      /// Lists all PhoneNumberInstances.
      /// List returns phone number instance sorted by create_time descending.
      ///
      /// The caller must have `numbering.phoneNumberInstances.list` permission on the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Enfonica.Numbering.V1Beta1.ListPhoneNumberInstancesResponse> ListPhoneNumberInstancesAsync(global::Enfonica.Numbering.V1Beta1.ListPhoneNumberInstancesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListPhoneNumberInstancesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists all PhoneNumberInstances.
      /// List returns phone number instance sorted by create_time descending.
      ///
      /// The caller must have `numbering.phoneNumberInstances.list` permission on the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Enfonica.Numbering.V1Beta1.ListPhoneNumberInstancesResponse> ListPhoneNumberInstancesAsync(global::Enfonica.Numbering.V1Beta1.ListPhoneNumberInstancesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListPhoneNumberInstances, null, options, request);
      }
      /// <summary>
      /// Updates a phone number instance.
      ///
      /// The caller must have `numbering.phoneNumberInstances.update` permission on the project.
      /// (-- api-linter: core::0134::http-uri-name=disabled
      ///     aip.dev/not-precedent: Update has `name` in the request message in this beta. --)
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance UpdatePhoneNumberInstance(global::Enfonica.Numbering.V1Beta1.UpdatePhoneNumberInstanceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdatePhoneNumberInstance(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates a phone number instance.
      ///
      /// The caller must have `numbering.phoneNumberInstances.update` permission on the project.
      /// (-- api-linter: core::0134::http-uri-name=disabled
      ///     aip.dev/not-precedent: Update has `name` in the request message in this beta. --)
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance UpdatePhoneNumberInstance(global::Enfonica.Numbering.V1Beta1.UpdatePhoneNumberInstanceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdatePhoneNumberInstance, null, options, request);
      }
      /// <summary>
      /// Updates a phone number instance.
      ///
      /// The caller must have `numbering.phoneNumberInstances.update` permission on the project.
      /// (-- api-linter: core::0134::http-uri-name=disabled
      ///     aip.dev/not-precedent: Update has `name` in the request message in this beta. --)
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance> UpdatePhoneNumberInstanceAsync(global::Enfonica.Numbering.V1Beta1.UpdatePhoneNumberInstanceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdatePhoneNumberInstanceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates a phone number instance.
      ///
      /// The caller must have `numbering.phoneNumberInstances.update` permission on the project.
      /// (-- api-linter: core::0134::http-uri-name=disabled
      ///     aip.dev/not-precedent: Update has `name` in the request message in this beta. --)
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance> UpdatePhoneNumberInstanceAsync(global::Enfonica.Numbering.V1Beta1.UpdatePhoneNumberInstanceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdatePhoneNumberInstance, null, options, request);
      }
      /// <summary>
      /// Deletes a phone number instance.
      ///
      /// The caller must have `numbering.phoneNumberInstances.delete` permission on the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance DeletePhoneNumberInstance(global::Enfonica.Numbering.V1Beta1.DeletePhoneNumberInstanceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeletePhoneNumberInstance(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a phone number instance.
      ///
      /// The caller must have `numbering.phoneNumberInstances.delete` permission on the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance DeletePhoneNumberInstance(global::Enfonica.Numbering.V1Beta1.DeletePhoneNumberInstanceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeletePhoneNumberInstance, null, options, request);
      }
      /// <summary>
      /// Deletes a phone number instance.
      ///
      /// The caller must have `numbering.phoneNumberInstances.delete` permission on the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance> DeletePhoneNumberInstanceAsync(global::Enfonica.Numbering.V1Beta1.DeletePhoneNumberInstanceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeletePhoneNumberInstanceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a phone number instance.
      ///
      /// The caller must have `numbering.phoneNumberInstances.delete` permission on the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance> DeletePhoneNumberInstanceAsync(global::Enfonica.Numbering.V1Beta1.DeletePhoneNumberInstanceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeletePhoneNumberInstance, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PhoneNumberInstancesClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PhoneNumberInstancesClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PhoneNumberInstancesBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreatePhoneNumberInstance, serviceImpl.CreatePhoneNumberInstance)
          .AddMethod(__Method_GetPhoneNumberInstance, serviceImpl.GetPhoneNumberInstance)
          .AddMethod(__Method_ListPhoneNumberInstances, serviceImpl.ListPhoneNumberInstances)
          .AddMethod(__Method_UpdatePhoneNumberInstance, serviceImpl.UpdatePhoneNumberInstance)
          .AddMethod(__Method_DeletePhoneNumberInstance, serviceImpl.DeletePhoneNumberInstance).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PhoneNumberInstancesBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreatePhoneNumberInstance, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Enfonica.Numbering.V1Beta1.CreatePhoneNumberInstanceRequest, global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance>(serviceImpl.CreatePhoneNumberInstance));
      serviceBinder.AddMethod(__Method_GetPhoneNumberInstance, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Enfonica.Numbering.V1Beta1.GetPhoneNumberInstanceRequest, global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance>(serviceImpl.GetPhoneNumberInstance));
      serviceBinder.AddMethod(__Method_ListPhoneNumberInstances, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Enfonica.Numbering.V1Beta1.ListPhoneNumberInstancesRequest, global::Enfonica.Numbering.V1Beta1.ListPhoneNumberInstancesResponse>(serviceImpl.ListPhoneNumberInstances));
      serviceBinder.AddMethod(__Method_UpdatePhoneNumberInstance, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Enfonica.Numbering.V1Beta1.UpdatePhoneNumberInstanceRequest, global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance>(serviceImpl.UpdatePhoneNumberInstance));
      serviceBinder.AddMethod(__Method_DeletePhoneNumberInstance, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Enfonica.Numbering.V1Beta1.DeletePhoneNumberInstanceRequest, global::Enfonica.Numbering.V1Beta1.PhoneNumberInstance>(serviceImpl.DeletePhoneNumberInstance));
    }

  }
}
#endregion
