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

namespace Enfonica.Messaging.V1
{
    /// <summary>Settings for <see cref="MessagesClient"/> instances.</summary>
    public sealed partial class MessagesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MessagesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MessagesSettings"/>.</returns>
        public static MessagesSettings GetDefault() => new MessagesSettings();

        /// <summary>Constructs a new <see cref="MessagesSettings"/> object with default settings.</summary>
        public MessagesSettings()
        {
        }

        private MessagesSettings(MessagesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateMessageSettings = existing.CreateMessageSettings;
            GetMessageSettings = existing.GetMessageSettings;
            ListMessagesSettings = existing.ListMessagesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MessagesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MessagesClient.CreateMessage</c> and <c>MessagesClient.CreateMessageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMessageSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>MessagesClient.GetMessage</c>
        ///  and <c>MessagesClient.GetMessageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMessageSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>MessagesClient.ListMessages</c>
        ///  and <c>MessagesClient.ListMessagesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMessagesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MessagesSettings"/> object.</returns>
        public MessagesSettings Clone() => new MessagesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MessagesClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class MessagesClientBuilder : enfgaxgrpc::ClientBuilderBase<MessagesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MessagesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MessagesClientBuilder()
        {
            UseJwtAccessWithScopes = MessagesClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref MessagesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MessagesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MessagesClient Build()
        {
            MessagesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MessagesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MessagesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MessagesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MessagesClient.Create(callInvoker, Settings);
        }

        private async stt::Task<MessagesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MessagesClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => MessagesClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => MessagesClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override enfgaxgrpc::ChannelPool GetChannelPool() => MessagesClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>Messages client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages Messages.
    /// Messages can be SMS, whatsapp messages, etc.
    /// </remarks>
    public abstract partial class MessagesClient
    {
        /// <summary>
        /// The default endpoint for the Messages service, which is a host of "messaging.api.enfonica.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "messaging.api.enfonica.com:443";

        /// <summary>The default Messages scopes.</summary>
        /// <remarks>
        /// The default Messages scopes are:
        /// <list type="bullet"><item><description>https://api.enfonica.com/auth/messaging</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://api.enfonica.com/auth/messaging",
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
        /// Asynchronously creates a <see cref="MessagesClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="MessagesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MessagesClient"/>.</returns>
        public static stt::Task<MessagesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MessagesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MessagesClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="MessagesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MessagesClient"/>.</returns>
        public static MessagesClient Create() => new MessagesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MessagesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MessagesSettings"/>.</param>
        /// <returns>The created <see cref="MessagesClient"/>.</returns>
        internal static MessagesClient Create(grpccore::CallInvoker callInvoker, MessagesSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Messages.MessagesClient grpcClient = new Messages.MessagesClient(callInvoker);
            return new MessagesClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC Messages client</summary>
        public virtual Messages.MessagesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Message and queues it for sending.
        /// Returns the created message.
        /// 
        /// The caller must have `messaging.messages.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Message CreateMessage(CreateMessageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Message and queues it for sending.
        /// Returns the created message.
        /// 
        /// The caller must have `messaging.messages.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> CreateMessageAsync(CreateMessageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Message and queues it for sending.
        /// Returns the created message.
        /// 
        /// The caller must have `messaging.messages.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> CreateMessageAsync(CreateMessageRequest request, st::CancellationToken cancellationToken) =>
            CreateMessageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Message and queues it for sending.
        /// Returns the created message.
        /// 
        /// The caller must have `messaging.messages.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the parent project to create the message under.
        /// Must be of the form `projects/*`.
        /// </param>
        /// <param name="message">
        /// The message resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Message CreateMessage(string parent, Message message, gaxgrpc::CallSettings callSettings = null) =>
            CreateMessage(new CreateMessageRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Message = gax::GaxPreconditions.CheckNotNull(message, nameof(message)),
            }, callSettings);

        /// <summary>
        /// Creates a Message and queues it for sending.
        /// Returns the created message.
        /// 
        /// The caller must have `messaging.messages.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the parent project to create the message under.
        /// Must be of the form `projects/*`.
        /// </param>
        /// <param name="message">
        /// The message resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> CreateMessageAsync(string parent, Message message, gaxgrpc::CallSettings callSettings = null) =>
            CreateMessageAsync(new CreateMessageRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Message = gax::GaxPreconditions.CheckNotNull(message, nameof(message)),
            }, callSettings);

        /// <summary>
        /// Creates a Message and queues it for sending.
        /// Returns the created message.
        /// 
        /// The caller must have `messaging.messages.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the parent project to create the message under.
        /// Must be of the form `projects/*`.
        /// </param>
        /// <param name="message">
        /// The message resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> CreateMessageAsync(string parent, Message message, st::CancellationToken cancellationToken) =>
            CreateMessageAsync(parent, message, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Message and queues it for sending.
        /// Returns the created message.
        /// 
        /// The caller must have `messaging.messages.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the parent project to create the message under.
        /// Must be of the form `projects/*`.
        /// </param>
        /// <param name="message">
        /// The message resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Message CreateMessage(ProjectName parent, Message message, gaxgrpc::CallSettings callSettings = null) =>
            CreateMessage(new CreateMessageRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Message = gax::GaxPreconditions.CheckNotNull(message, nameof(message)),
            }, callSettings);

        /// <summary>
        /// Creates a Message and queues it for sending.
        /// Returns the created message.
        /// 
        /// The caller must have `messaging.messages.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the parent project to create the message under.
        /// Must be of the form `projects/*`.
        /// </param>
        /// <param name="message">
        /// The message resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> CreateMessageAsync(ProjectName parent, Message message, gaxgrpc::CallSettings callSettings = null) =>
            CreateMessageAsync(new CreateMessageRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Message = gax::GaxPreconditions.CheckNotNull(message, nameof(message)),
            }, callSettings);

        /// <summary>
        /// Creates a Message and queues it for sending.
        /// Returns the created message.
        /// 
        /// The caller must have `messaging.messages.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the parent project to create the message under.
        /// Must be of the form `projects/*`.
        /// </param>
        /// <param name="message">
        /// The message resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> CreateMessageAsync(ProjectName parent, Message message, st::CancellationToken cancellationToken) =>
            CreateMessageAsync(parent, message, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a Message identified by the supplied resource name.
        /// 
        /// The caller must have `messaging.messages.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Message GetMessage(GetMessageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a Message identified by the supplied resource name.
        /// 
        /// The caller must have `messaging.messages.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> GetMessageAsync(GetMessageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a Message identified by the supplied resource name.
        /// 
        /// The caller must have `messaging.messages.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> GetMessageAsync(GetMessageRequest request, st::CancellationToken cancellationToken) =>
            GetMessageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a Message identified by the supplied resource name.
        /// 
        /// The caller must have `messaging.messages.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Message to retrieve.
        /// Must be of the form `projects/*/messages/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Message GetMessage(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMessage(new GetMessageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Message identified by the supplied resource name.
        /// 
        /// The caller must have `messaging.messages.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Message to retrieve.
        /// Must be of the form `projects/*/messages/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> GetMessageAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMessageAsync(new GetMessageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Message identified by the supplied resource name.
        /// 
        /// The caller must have `messaging.messages.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Message to retrieve.
        /// Must be of the form `projects/*/messages/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> GetMessageAsync(string name, st::CancellationToken cancellationToken) =>
            GetMessageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a Message identified by the supplied resource name.
        /// 
        /// The caller must have `messaging.messages.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Message to retrieve.
        /// Must be of the form `projects/*/messages/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Message GetMessage(MessageName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMessage(new GetMessageRequest
            {
                MessageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Message identified by the supplied resource name.
        /// 
        /// The caller must have `messaging.messages.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Message to retrieve.
        /// Must be of the form `projects/*/messages/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> GetMessageAsync(MessageName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMessageAsync(new GetMessageRequest
            {
                MessageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Message identified by the supplied resource name.
        /// 
        /// The caller must have `messaging.messages.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Message to retrieve.
        /// Must be of the form `projects/*/messages/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> GetMessageAsync(MessageName name, st::CancellationToken cancellationToken) =>
            GetMessageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the Messages of the specified project.
        /// List returns Messages sorted by create_time descending.
        /// 
        /// The caller must have `messaging.messages.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Message"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMessagesResponse, Message> ListMessages(ListMessagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Messages of the specified project.
        /// List returns Messages sorted by create_time descending.
        /// 
        /// The caller must have `messaging.messages.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Message"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMessagesResponse, Message> ListMessagesAsync(ListMessagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Messages of the specified project.
        /// List returns Messages sorted by create_time descending.
        /// 
        /// The caller must have `messaging.messages.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the parent of which to list messages.
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
        /// <returns>A pageable sequence of <see cref="Message"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMessagesResponse, Message> ListMessages(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMessages(new ListMessagesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the Messages of the specified project.
        /// List returns Messages sorted by create_time descending.
        /// 
        /// The caller must have `messaging.messages.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the parent of which to list messages.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Message"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMessagesResponse, Message> ListMessagesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMessagesAsync(new ListMessagesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the Messages of the specified project.
        /// List returns Messages sorted by create_time descending.
        /// 
        /// The caller must have `messaging.messages.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the parent of which to list messages.
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
        /// <returns>A pageable sequence of <see cref="Message"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMessagesResponse, Message> ListMessages(ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMessages(new ListMessagesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the Messages of the specified project.
        /// List returns Messages sorted by create_time descending.
        /// 
        /// The caller must have `messaging.messages.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the parent of which to list messages.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Message"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMessagesResponse, Message> ListMessagesAsync(ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMessagesAsync(new ListMessagesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>Messages client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages Messages.
    /// Messages can be SMS, whatsapp messages, etc.
    /// </remarks>
    public sealed partial class MessagesClientImpl : MessagesClient
    {
        private readonly gaxgrpc::ApiCall<CreateMessageRequest, Message> _callCreateMessage;

        private readonly gaxgrpc::ApiCall<GetMessageRequest, Message> _callGetMessage;

        private readonly gaxgrpc::ApiCall<ListMessagesRequest, ListMessagesResponse> _callListMessages;

        /// <summary>
        /// Constructs a client wrapper for the Messages service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MessagesSettings"/> used within this client.</param>
        public MessagesClientImpl(Messages.MessagesClient grpcClient, MessagesSettings settings)
        {
            GrpcClient = grpcClient;
            MessagesSettings effectiveSettings = settings ?? MessagesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateMessage = clientHelper.BuildApiCall<CreateMessageRequest, Message>(grpcClient.CreateMessageAsync, grpcClient.CreateMessage, effectiveSettings.CreateMessageSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMessage);
            Modify_CreateMessageApiCall(ref _callCreateMessage);
            _callGetMessage = clientHelper.BuildApiCall<GetMessageRequest, Message>(grpcClient.GetMessageAsync, grpcClient.GetMessage, effectiveSettings.GetMessageSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMessage);
            Modify_GetMessageApiCall(ref _callGetMessage);
            _callListMessages = clientHelper.BuildApiCall<ListMessagesRequest, ListMessagesResponse>(grpcClient.ListMessagesAsync, grpcClient.ListMessages, effectiveSettings.ListMessagesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMessages);
            Modify_ListMessagesApiCall(ref _callListMessages);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateMessageApiCall(ref gaxgrpc::ApiCall<CreateMessageRequest, Message> call);

        partial void Modify_GetMessageApiCall(ref gaxgrpc::ApiCall<GetMessageRequest, Message> call);

        partial void Modify_ListMessagesApiCall(ref gaxgrpc::ApiCall<ListMessagesRequest, ListMessagesResponse> call);

        partial void OnConstruction(Messages.MessagesClient grpcClient, MessagesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Messages client</summary>
        public override Messages.MessagesClient GrpcClient { get; }

        partial void Modify_CreateMessageRequest(ref CreateMessageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMessageRequest(ref GetMessageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMessagesRequest(ref ListMessagesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a Message and queues it for sending.
        /// Returns the created message.
        /// 
        /// The caller must have `messaging.messages.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Message CreateMessage(CreateMessageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMessageRequest(ref request, ref callSettings);
            return _callCreateMessage.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a Message and queues it for sending.
        /// Returns the created message.
        /// 
        /// The caller must have `messaging.messages.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Message> CreateMessageAsync(CreateMessageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMessageRequest(ref request, ref callSettings);
            return _callCreateMessage.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a Message identified by the supplied resource name.
        /// 
        /// The caller must have `messaging.messages.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Message GetMessage(GetMessageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMessageRequest(ref request, ref callSettings);
            return _callGetMessage.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a Message identified by the supplied resource name.
        /// 
        /// The caller must have `messaging.messages.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Message> GetMessageAsync(GetMessageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMessageRequest(ref request, ref callSettings);
            return _callGetMessage.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the Messages of the specified project.
        /// List returns Messages sorted by create_time descending.
        /// 
        /// The caller must have `messaging.messages.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Message"/> resources.</returns>
        public override gax::PagedEnumerable<ListMessagesResponse, Message> ListMessages(ListMessagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMessagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMessagesRequest, ListMessagesResponse, Message>(_callListMessages, request, callSettings);
        }

        /// <summary>
        /// Lists the Messages of the specified project.
        /// List returns Messages sorted by create_time descending.
        /// 
        /// The caller must have `messaging.messages.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Message"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMessagesResponse, Message> ListMessagesAsync(ListMessagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMessagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMessagesRequest, ListMessagesResponse, Message>(_callListMessages, request, callSettings);
        }
    }

    public partial class ListMessagesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMessagesResponse : gaxgrpc::IPageResponse<Message>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Message> GetEnumerator() => Messages.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
