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
using wkt = Google.Protobuf.WellKnownTypes;
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
    /// <summary>Settings for <see cref="PhoneNumberInstancesClient"/> instances.</summary>
    public sealed partial class PhoneNumberInstancesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PhoneNumberInstancesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PhoneNumberInstancesSettings"/>.</returns>
        public static PhoneNumberInstancesSettings GetDefault() => new PhoneNumberInstancesSettings();

        /// <summary>Constructs a new <see cref="PhoneNumberInstancesSettings"/> object with default settings.</summary>
        public PhoneNumberInstancesSettings()
        {
        }

        private PhoneNumberInstancesSettings(PhoneNumberInstancesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreatePhoneNumberInstanceSettings = existing.CreatePhoneNumberInstanceSettings;
            GetPhoneNumberInstanceSettings = existing.GetPhoneNumberInstanceSettings;
            ListPhoneNumberInstancesSettings = existing.ListPhoneNumberInstancesSettings;
            UpdatePhoneNumberInstanceSettings = existing.UpdatePhoneNumberInstanceSettings;
            DeletePhoneNumberInstanceSettings = existing.DeletePhoneNumberInstanceSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PhoneNumberInstancesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PhoneNumberInstancesClient.CreatePhoneNumberInstance</c> and
        /// <c>PhoneNumberInstancesClient.CreatePhoneNumberInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePhoneNumberInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PhoneNumberInstancesClient.GetPhoneNumberInstance</c> and
        /// <c>PhoneNumberInstancesClient.GetPhoneNumberInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPhoneNumberInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PhoneNumberInstancesClient.ListPhoneNumberInstances</c> and
        /// <c>PhoneNumberInstancesClient.ListPhoneNumberInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPhoneNumberInstancesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PhoneNumberInstancesClient.UpdatePhoneNumberInstance</c> and
        /// <c>PhoneNumberInstancesClient.UpdatePhoneNumberInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePhoneNumberInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PhoneNumberInstancesClient.DeletePhoneNumberInstance</c> and
        /// <c>PhoneNumberInstancesClient.DeletePhoneNumberInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePhoneNumberInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PhoneNumberInstancesSettings"/> object.</returns>
        public PhoneNumberInstancesSettings Clone() => new PhoneNumberInstancesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PhoneNumberInstancesClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class PhoneNumberInstancesClientBuilder : enfgaxgrpc::ClientBuilderBase<PhoneNumberInstancesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PhoneNumberInstancesSettings Settings { get; set; }

        partial void InterceptBuild(ref PhoneNumberInstancesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PhoneNumberInstancesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PhoneNumberInstancesClient Build()
        {
            PhoneNumberInstancesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PhoneNumberInstancesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PhoneNumberInstancesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PhoneNumberInstancesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PhoneNumberInstancesClient.Create(callInvoker, Settings);
        }

        private async stt::Task<PhoneNumberInstancesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PhoneNumberInstancesClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => PhoneNumberInstancesClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => PhoneNumberInstancesClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override enfgaxgrpc::ChannelPool GetChannelPool() => PhoneNumberInstancesClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>PhoneNumberInstances client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages PhoneNumberInstances.
    /// </remarks>
    public abstract partial class PhoneNumberInstancesClient
    {
        /// <summary>
        /// The default endpoint for the PhoneNumberInstances service, which is a host of "numbering.api.enfonica.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "numbering.api.enfonica.com:443";

        /// <summary>The default PhoneNumberInstances scopes.</summary>
        /// <remarks>
        /// The default PhoneNumberInstances scopes are:
        /// <list type="bullet"><item><description>https://api.enfonica.com/auth/numbering</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://api.enfonica.com/auth/numbering",
        });

        internal static enfgaxgrpc::ChannelPool ChannelPool { get; } = new enfgaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="PhoneNumberInstancesClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="PhoneNumberInstancesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PhoneNumberInstancesClient"/>.</returns>
        public static stt::Task<PhoneNumberInstancesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PhoneNumberInstancesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PhoneNumberInstancesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="PhoneNumberInstancesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PhoneNumberInstancesClient"/>.</returns>
        public static PhoneNumberInstancesClient Create() => new PhoneNumberInstancesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PhoneNumberInstancesClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PhoneNumberInstancesSettings"/>.</param>
        /// <returns>The created <see cref="PhoneNumberInstancesClient"/>.</returns>
        internal static PhoneNumberInstancesClient Create(grpccore::CallInvoker callInvoker, PhoneNumberInstancesSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PhoneNumberInstances.PhoneNumberInstancesClient grpcClient = new PhoneNumberInstances.PhoneNumberInstancesClient(callInvoker);
            return new PhoneNumberInstancesClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC PhoneNumberInstances client</summary>
        public virtual PhoneNumberInstances.PhoneNumberInstancesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumberInstance CreatePhoneNumberInstance(CreatePhoneNumberInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> CreatePhoneNumberInstanceAsync(CreatePhoneNumberInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> CreatePhoneNumberInstanceAsync(CreatePhoneNumberInstanceRequest request, st::CancellationToken cancellationToken) =>
            CreatePhoneNumberInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to create the phone number instance
        /// in the form `projects/*`.
        /// </param>
        /// <param name="phoneNumberInstance">
        /// The phone number resource to be created.
        /// At minimum, you must supply `phone_number.phone_number`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumberInstance CreatePhoneNumberInstance(string parent, PhoneNumberInstance phoneNumberInstance, gaxgrpc::CallSettings callSettings = null) =>
            CreatePhoneNumberInstance(new CreatePhoneNumberInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PhoneNumberInstance = gax::GaxPreconditions.CheckNotNull(phoneNumberInstance, nameof(phoneNumberInstance)),
            }, callSettings);

        /// <summary>
        /// Creates a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to create the phone number instance
        /// in the form `projects/*`.
        /// </param>
        /// <param name="phoneNumberInstance">
        /// The phone number resource to be created.
        /// At minimum, you must supply `phone_number.phone_number`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> CreatePhoneNumberInstanceAsync(string parent, PhoneNumberInstance phoneNumberInstance, gaxgrpc::CallSettings callSettings = null) =>
            CreatePhoneNumberInstanceAsync(new CreatePhoneNumberInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PhoneNumberInstance = gax::GaxPreconditions.CheckNotNull(phoneNumberInstance, nameof(phoneNumberInstance)),
            }, callSettings);

        /// <summary>
        /// Creates a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to create the phone number instance
        /// in the form `projects/*`.
        /// </param>
        /// <param name="phoneNumberInstance">
        /// The phone number resource to be created.
        /// At minimum, you must supply `phone_number.phone_number`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> CreatePhoneNumberInstanceAsync(string parent, PhoneNumberInstance phoneNumberInstance, st::CancellationToken cancellationToken) =>
            CreatePhoneNumberInstanceAsync(parent, phoneNumberInstance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to create the phone number instance
        /// in the form `projects/*`.
        /// </param>
        /// <param name="phoneNumberInstance">
        /// The phone number resource to be created.
        /// At minimum, you must supply `phone_number.phone_number`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumberInstance CreatePhoneNumberInstance(ProjectName parent, PhoneNumberInstance phoneNumberInstance, gaxgrpc::CallSettings callSettings = null) =>
            CreatePhoneNumberInstance(new CreatePhoneNumberInstanceRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PhoneNumberInstance = gax::GaxPreconditions.CheckNotNull(phoneNumberInstance, nameof(phoneNumberInstance)),
            }, callSettings);

        /// <summary>
        /// Creates a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to create the phone number instance
        /// in the form `projects/*`.
        /// </param>
        /// <param name="phoneNumberInstance">
        /// The phone number resource to be created.
        /// At minimum, you must supply `phone_number.phone_number`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> CreatePhoneNumberInstanceAsync(ProjectName parent, PhoneNumberInstance phoneNumberInstance, gaxgrpc::CallSettings callSettings = null) =>
            CreatePhoneNumberInstanceAsync(new CreatePhoneNumberInstanceRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PhoneNumberInstance = gax::GaxPreconditions.CheckNotNull(phoneNumberInstance, nameof(phoneNumberInstance)),
            }, callSettings);

        /// <summary>
        /// Creates a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.create` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to create the phone number instance
        /// in the form `projects/*`.
        /// </param>
        /// <param name="phoneNumberInstance">
        /// The phone number resource to be created.
        /// At minimum, you must supply `phone_number.phone_number`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> CreatePhoneNumberInstanceAsync(ProjectName parent, PhoneNumberInstance phoneNumberInstance, st::CancellationToken cancellationToken) =>
            CreatePhoneNumberInstanceAsync(parent, phoneNumberInstance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a phone number instance identified by the supplied resource name.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumberInstance GetPhoneNumberInstance(GetPhoneNumberInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a phone number instance identified by the supplied resource name.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> GetPhoneNumberInstanceAsync(GetPhoneNumberInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a phone number instance identified by the supplied resource name.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> GetPhoneNumberInstanceAsync(GetPhoneNumberInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetPhoneNumberInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a phone number instance identified by the supplied resource name.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the phone number instance to retrieve.
        /// Must be of the form `projects/*/phoneNumberInstances/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumberInstance GetPhoneNumberInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhoneNumberInstance(new GetPhoneNumberInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a phone number instance identified by the supplied resource name.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the phone number instance to retrieve.
        /// Must be of the form `projects/*/phoneNumberInstances/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> GetPhoneNumberInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhoneNumberInstanceAsync(new GetPhoneNumberInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a phone number instance identified by the supplied resource name.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the phone number instance to retrieve.
        /// Must be of the form `projects/*/phoneNumberInstances/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> GetPhoneNumberInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            GetPhoneNumberInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a phone number instance identified by the supplied resource name.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the phone number instance to retrieve.
        /// Must be of the form `projects/*/phoneNumberInstances/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumberInstance GetPhoneNumberInstance(PhoneNumberInstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhoneNumberInstance(new GetPhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a phone number instance identified by the supplied resource name.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the phone number instance to retrieve.
        /// Must be of the form `projects/*/phoneNumberInstances/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> GetPhoneNumberInstanceAsync(PhoneNumberInstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhoneNumberInstanceAsync(new GetPhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a phone number instance identified by the supplied resource name.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.get` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the phone number instance to retrieve.
        /// Must be of the form `projects/*/phoneNumberInstances/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> GetPhoneNumberInstanceAsync(PhoneNumberInstanceName name, st::CancellationToken cancellationToken) =>
            GetPhoneNumberInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all PhoneNumberInstances.
        /// List returns phone number instance sorted by create_time descending.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PhoneNumberInstance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPhoneNumberInstancesResponse, PhoneNumberInstance> ListPhoneNumberInstances(ListPhoneNumberInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all PhoneNumberInstances.
        /// List returns phone number instance sorted by create_time descending.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PhoneNumberInstance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPhoneNumberInstancesResponse, PhoneNumberInstance> ListPhoneNumberInstancesAsync(ListPhoneNumberInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all PhoneNumberInstances.
        /// List returns phone number instance sorted by create_time descending.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to list phone number instance, in the form `projects/*`.
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
        /// <returns>A pageable sequence of <see cref="PhoneNumberInstance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPhoneNumberInstancesResponse, PhoneNumberInstance> ListPhoneNumberInstances(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPhoneNumberInstances(new ListPhoneNumberInstancesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all PhoneNumberInstances.
        /// List returns phone number instance sorted by create_time descending.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to list phone number instance, in the form `projects/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PhoneNumberInstance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPhoneNumberInstancesResponse, PhoneNumberInstance> ListPhoneNumberInstancesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPhoneNumberInstancesAsync(new ListPhoneNumberInstancesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all PhoneNumberInstances.
        /// List returns phone number instance sorted by create_time descending.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to list phone number instance, in the form `projects/*`.
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
        /// <returns>A pageable sequence of <see cref="PhoneNumberInstance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPhoneNumberInstancesResponse, PhoneNumberInstance> ListPhoneNumberInstances(ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPhoneNumberInstances(new ListPhoneNumberInstancesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all PhoneNumberInstances.
        /// List returns phone number instance sorted by create_time descending.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.list` permission on the project.
        /// </summary>
        /// <param name="parent">
        /// The project under which to list phone number instance, in the form `projects/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PhoneNumberInstance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPhoneNumberInstancesResponse, PhoneNumberInstance> ListPhoneNumberInstancesAsync(ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPhoneNumberInstancesAsync(new ListPhoneNumberInstancesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Updates a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.update` permission on the project.
        /// (-- api-linter: core::0134::http-uri-name=disabled
        /// aip.dev/not-precedent: Update has `name` in the request message in this beta. --)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumberInstance UpdatePhoneNumberInstance(UpdatePhoneNumberInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.update` permission on the project.
        /// (-- api-linter: core::0134::http-uri-name=disabled
        /// aip.dev/not-precedent: Update has `name` in the request message in this beta. --)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> UpdatePhoneNumberInstanceAsync(UpdatePhoneNumberInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.update` permission on the project.
        /// (-- api-linter: core::0134::http-uri-name=disabled
        /// aip.dev/not-precedent: Update has `name` in the request message in this beta. --)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> UpdatePhoneNumberInstanceAsync(UpdatePhoneNumberInstanceRequest request, st::CancellationToken cancellationToken) =>
            UpdatePhoneNumberInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.update` permission on the project.
        /// (-- api-linter: core::0134::http-uri-name=disabled
        /// aip.dev/not-precedent: Update has `name` in the request message in this beta. --)
        /// </summary>
        /// <param name="name">
        /// The name of the phone number instance to be updated.
        /// Must be of the form `projects/*/phoneNumberInstances/*`.
        /// (-- api-linter: core::0134::request-unknown-fields=disabled
        /// aip.dev/not-precedent: Update has `name` in the request message in this beta. --)
        /// </param>
        /// <param name="phoneNumberInstance">
        /// The new definition of the PhoneNumberInstance.
        /// </param>
        /// <param name="updateMask">
        /// Fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumberInstance UpdatePhoneNumberInstance(string name, PhoneNumberInstance phoneNumberInstance, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePhoneNumberInstance(new UpdatePhoneNumberInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                PhoneNumberInstance = gax::GaxPreconditions.CheckNotNull(phoneNumberInstance, nameof(phoneNumberInstance)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.update` permission on the project.
        /// (-- api-linter: core::0134::http-uri-name=disabled
        /// aip.dev/not-precedent: Update has `name` in the request message in this beta. --)
        /// </summary>
        /// <param name="name">
        /// The name of the phone number instance to be updated.
        /// Must be of the form `projects/*/phoneNumberInstances/*`.
        /// (-- api-linter: core::0134::request-unknown-fields=disabled
        /// aip.dev/not-precedent: Update has `name` in the request message in this beta. --)
        /// </param>
        /// <param name="phoneNumberInstance">
        /// The new definition of the PhoneNumberInstance.
        /// </param>
        /// <param name="updateMask">
        /// Fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> UpdatePhoneNumberInstanceAsync(string name, PhoneNumberInstance phoneNumberInstance, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePhoneNumberInstanceAsync(new UpdatePhoneNumberInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                PhoneNumberInstance = gax::GaxPreconditions.CheckNotNull(phoneNumberInstance, nameof(phoneNumberInstance)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.update` permission on the project.
        /// (-- api-linter: core::0134::http-uri-name=disabled
        /// aip.dev/not-precedent: Update has `name` in the request message in this beta. --)
        /// </summary>
        /// <param name="name">
        /// The name of the phone number instance to be updated.
        /// Must be of the form `projects/*/phoneNumberInstances/*`.
        /// (-- api-linter: core::0134::request-unknown-fields=disabled
        /// aip.dev/not-precedent: Update has `name` in the request message in this beta. --)
        /// </param>
        /// <param name="phoneNumberInstance">
        /// The new definition of the PhoneNumberInstance.
        /// </param>
        /// <param name="updateMask">
        /// Fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> UpdatePhoneNumberInstanceAsync(string name, PhoneNumberInstance phoneNumberInstance, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePhoneNumberInstanceAsync(name, phoneNumberInstance, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.update` permission on the project.
        /// (-- api-linter: core::0134::http-uri-name=disabled
        /// aip.dev/not-precedent: Update has `name` in the request message in this beta. --)
        /// </summary>
        /// <param name="name">
        /// The name of the phone number instance to be updated.
        /// Must be of the form `projects/*/phoneNumberInstances/*`.
        /// (-- api-linter: core::0134::request-unknown-fields=disabled
        /// aip.dev/not-precedent: Update has `name` in the request message in this beta. --)
        /// </param>
        /// <param name="phoneNumberInstance">
        /// The new definition of the PhoneNumberInstance.
        /// </param>
        /// <param name="updateMask">
        /// Fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumberInstance UpdatePhoneNumberInstance(PhoneNumberInstanceName name, PhoneNumberInstance phoneNumberInstance, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePhoneNumberInstance(new UpdatePhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                PhoneNumberInstance = gax::GaxPreconditions.CheckNotNull(phoneNumberInstance, nameof(phoneNumberInstance)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.update` permission on the project.
        /// (-- api-linter: core::0134::http-uri-name=disabled
        /// aip.dev/not-precedent: Update has `name` in the request message in this beta. --)
        /// </summary>
        /// <param name="name">
        /// The name of the phone number instance to be updated.
        /// Must be of the form `projects/*/phoneNumberInstances/*`.
        /// (-- api-linter: core::0134::request-unknown-fields=disabled
        /// aip.dev/not-precedent: Update has `name` in the request message in this beta. --)
        /// </param>
        /// <param name="phoneNumberInstance">
        /// The new definition of the PhoneNumberInstance.
        /// </param>
        /// <param name="updateMask">
        /// Fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> UpdatePhoneNumberInstanceAsync(PhoneNumberInstanceName name, PhoneNumberInstance phoneNumberInstance, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePhoneNumberInstanceAsync(new UpdatePhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                PhoneNumberInstance = gax::GaxPreconditions.CheckNotNull(phoneNumberInstance, nameof(phoneNumberInstance)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.update` permission on the project.
        /// (-- api-linter: core::0134::http-uri-name=disabled
        /// aip.dev/not-precedent: Update has `name` in the request message in this beta. --)
        /// </summary>
        /// <param name="name">
        /// The name of the phone number instance to be updated.
        /// Must be of the form `projects/*/phoneNumberInstances/*`.
        /// (-- api-linter: core::0134::request-unknown-fields=disabled
        /// aip.dev/not-precedent: Update has `name` in the request message in this beta. --)
        /// </param>
        /// <param name="phoneNumberInstance">
        /// The new definition of the PhoneNumberInstance.
        /// </param>
        /// <param name="updateMask">
        /// Fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> UpdatePhoneNumberInstanceAsync(PhoneNumberInstanceName name, PhoneNumberInstance phoneNumberInstance, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePhoneNumberInstanceAsync(name, phoneNumberInstance, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumberInstance DeletePhoneNumberInstance(DeletePhoneNumberInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> DeletePhoneNumberInstanceAsync(DeletePhoneNumberInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> DeletePhoneNumberInstanceAsync(DeletePhoneNumberInstanceRequest request, st::CancellationToken cancellationToken) =>
            DeletePhoneNumberInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the phone number instance to be deleted.
        /// Must be of the form `projects/*/phoneNumberInstances/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumberInstance DeletePhoneNumberInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhoneNumberInstance(new DeletePhoneNumberInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the phone number instance to be deleted.
        /// Must be of the form `projects/*/phoneNumberInstances/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> DeletePhoneNumberInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhoneNumberInstanceAsync(new DeletePhoneNumberInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the phone number instance to be deleted.
        /// Must be of the form `projects/*/phoneNumberInstances/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> DeletePhoneNumberInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePhoneNumberInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the phone number instance to be deleted.
        /// Must be of the form `projects/*/phoneNumberInstances/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumberInstance DeletePhoneNumberInstance(PhoneNumberInstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhoneNumberInstance(new DeletePhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the phone number instance to be deleted.
        /// Must be of the form `projects/*/phoneNumberInstances/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> DeletePhoneNumberInstanceAsync(PhoneNumberInstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhoneNumberInstanceAsync(new DeletePhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.delete` permission on the project.
        /// </summary>
        /// <param name="name">
        /// The resource name of the phone number instance to be deleted.
        /// Must be of the form `projects/*/phoneNumberInstances/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumberInstance> DeletePhoneNumberInstanceAsync(PhoneNumberInstanceName name, st::CancellationToken cancellationToken) =>
            DeletePhoneNumberInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PhoneNumberInstances client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages PhoneNumberInstances.
    /// </remarks>
    public sealed partial class PhoneNumberInstancesClientImpl : PhoneNumberInstancesClient
    {
        private readonly gaxgrpc::ApiCall<CreatePhoneNumberInstanceRequest, PhoneNumberInstance> _callCreatePhoneNumberInstance;

        private readonly gaxgrpc::ApiCall<GetPhoneNumberInstanceRequest, PhoneNumberInstance> _callGetPhoneNumberInstance;

        private readonly gaxgrpc::ApiCall<ListPhoneNumberInstancesRequest, ListPhoneNumberInstancesResponse> _callListPhoneNumberInstances;

        private readonly gaxgrpc::ApiCall<UpdatePhoneNumberInstanceRequest, PhoneNumberInstance> _callUpdatePhoneNumberInstance;

        private readonly gaxgrpc::ApiCall<DeletePhoneNumberInstanceRequest, PhoneNumberInstance> _callDeletePhoneNumberInstance;

        /// <summary>
        /// Constructs a client wrapper for the PhoneNumberInstances service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PhoneNumberInstancesSettings"/> used within this client.</param>
        public PhoneNumberInstancesClientImpl(PhoneNumberInstances.PhoneNumberInstancesClient grpcClient, PhoneNumberInstancesSettings settings)
        {
            GrpcClient = grpcClient;
            PhoneNumberInstancesSettings effectiveSettings = settings ?? PhoneNumberInstancesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreatePhoneNumberInstance = clientHelper.BuildApiCall<CreatePhoneNumberInstanceRequest, PhoneNumberInstance>(grpcClient.CreatePhoneNumberInstanceAsync, grpcClient.CreatePhoneNumberInstance, effectiveSettings.CreatePhoneNumberInstanceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePhoneNumberInstance);
            Modify_CreatePhoneNumberInstanceApiCall(ref _callCreatePhoneNumberInstance);
            _callGetPhoneNumberInstance = clientHelper.BuildApiCall<GetPhoneNumberInstanceRequest, PhoneNumberInstance>(grpcClient.GetPhoneNumberInstanceAsync, grpcClient.GetPhoneNumberInstance, effectiveSettings.GetPhoneNumberInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPhoneNumberInstance);
            Modify_GetPhoneNumberInstanceApiCall(ref _callGetPhoneNumberInstance);
            _callListPhoneNumberInstances = clientHelper.BuildApiCall<ListPhoneNumberInstancesRequest, ListPhoneNumberInstancesResponse>(grpcClient.ListPhoneNumberInstancesAsync, grpcClient.ListPhoneNumberInstances, effectiveSettings.ListPhoneNumberInstancesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPhoneNumberInstances);
            Modify_ListPhoneNumberInstancesApiCall(ref _callListPhoneNumberInstances);
            _callUpdatePhoneNumberInstance = clientHelper.BuildApiCall<UpdatePhoneNumberInstanceRequest, PhoneNumberInstance>(grpcClient.UpdatePhoneNumberInstanceAsync, grpcClient.UpdatePhoneNumberInstance, effectiveSettings.UpdatePhoneNumberInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdatePhoneNumberInstance);
            Modify_UpdatePhoneNumberInstanceApiCall(ref _callUpdatePhoneNumberInstance);
            _callDeletePhoneNumberInstance = clientHelper.BuildApiCall<DeletePhoneNumberInstanceRequest, PhoneNumberInstance>(grpcClient.DeletePhoneNumberInstanceAsync, grpcClient.DeletePhoneNumberInstance, effectiveSettings.DeletePhoneNumberInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePhoneNumberInstance);
            Modify_DeletePhoneNumberInstanceApiCall(ref _callDeletePhoneNumberInstance);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreatePhoneNumberInstanceApiCall(ref gaxgrpc::ApiCall<CreatePhoneNumberInstanceRequest, PhoneNumberInstance> call);

        partial void Modify_GetPhoneNumberInstanceApiCall(ref gaxgrpc::ApiCall<GetPhoneNumberInstanceRequest, PhoneNumberInstance> call);

        partial void Modify_ListPhoneNumberInstancesApiCall(ref gaxgrpc::ApiCall<ListPhoneNumberInstancesRequest, ListPhoneNumberInstancesResponse> call);

        partial void Modify_UpdatePhoneNumberInstanceApiCall(ref gaxgrpc::ApiCall<UpdatePhoneNumberInstanceRequest, PhoneNumberInstance> call);

        partial void Modify_DeletePhoneNumberInstanceApiCall(ref gaxgrpc::ApiCall<DeletePhoneNumberInstanceRequest, PhoneNumberInstance> call);

        partial void OnConstruction(PhoneNumberInstances.PhoneNumberInstancesClient grpcClient, PhoneNumberInstancesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PhoneNumberInstances client</summary>
        public override PhoneNumberInstances.PhoneNumberInstancesClient GrpcClient { get; }

        partial void Modify_CreatePhoneNumberInstanceRequest(ref CreatePhoneNumberInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPhoneNumberInstanceRequest(ref GetPhoneNumberInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPhoneNumberInstancesRequest(ref ListPhoneNumberInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePhoneNumberInstanceRequest(ref UpdatePhoneNumberInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePhoneNumberInstanceRequest(ref DeletePhoneNumberInstanceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PhoneNumberInstance CreatePhoneNumberInstance(CreatePhoneNumberInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePhoneNumberInstanceRequest(ref request, ref callSettings);
            return _callCreatePhoneNumberInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.create` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PhoneNumberInstance> CreatePhoneNumberInstanceAsync(CreatePhoneNumberInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePhoneNumberInstanceRequest(ref request, ref callSettings);
            return _callCreatePhoneNumberInstance.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a phone number instance identified by the supplied resource name.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PhoneNumberInstance GetPhoneNumberInstance(GetPhoneNumberInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPhoneNumberInstanceRequest(ref request, ref callSettings);
            return _callGetPhoneNumberInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a phone number instance identified by the supplied resource name.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.get` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PhoneNumberInstance> GetPhoneNumberInstanceAsync(GetPhoneNumberInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPhoneNumberInstanceRequest(ref request, ref callSettings);
            return _callGetPhoneNumberInstance.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all PhoneNumberInstances.
        /// List returns phone number instance sorted by create_time descending.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PhoneNumberInstance"/> resources.</returns>
        public override gax::PagedEnumerable<ListPhoneNumberInstancesResponse, PhoneNumberInstance> ListPhoneNumberInstances(ListPhoneNumberInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPhoneNumberInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPhoneNumberInstancesRequest, ListPhoneNumberInstancesResponse, PhoneNumberInstance>(_callListPhoneNumberInstances, request, callSettings);
        }

        /// <summary>
        /// Lists all PhoneNumberInstances.
        /// List returns phone number instance sorted by create_time descending.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.list` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PhoneNumberInstance"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPhoneNumberInstancesResponse, PhoneNumberInstance> ListPhoneNumberInstancesAsync(ListPhoneNumberInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPhoneNumberInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPhoneNumberInstancesRequest, ListPhoneNumberInstancesResponse, PhoneNumberInstance>(_callListPhoneNumberInstances, request, callSettings);
        }

        /// <summary>
        /// Updates a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.update` permission on the project.
        /// (-- api-linter: core::0134::http-uri-name=disabled
        /// aip.dev/not-precedent: Update has `name` in the request message in this beta. --)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PhoneNumberInstance UpdatePhoneNumberInstance(UpdatePhoneNumberInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePhoneNumberInstanceRequest(ref request, ref callSettings);
            return _callUpdatePhoneNumberInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.update` permission on the project.
        /// (-- api-linter: core::0134::http-uri-name=disabled
        /// aip.dev/not-precedent: Update has `name` in the request message in this beta. --)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PhoneNumberInstance> UpdatePhoneNumberInstanceAsync(UpdatePhoneNumberInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePhoneNumberInstanceRequest(ref request, ref callSettings);
            return _callUpdatePhoneNumberInstance.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PhoneNumberInstance DeletePhoneNumberInstance(DeletePhoneNumberInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePhoneNumberInstanceRequest(ref request, ref callSettings);
            return _callDeletePhoneNumberInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a phone number instance.
        /// 
        /// The caller must have `numbering.phoneNumberInstances.delete` permission on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PhoneNumberInstance> DeletePhoneNumberInstanceAsync(DeletePhoneNumberInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePhoneNumberInstanceRequest(ref request, ref callSettings);
            return _callDeletePhoneNumberInstance.Async(request, callSettings);
        }
    }

    public partial class ListPhoneNumberInstancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPhoneNumberInstancesResponse : gaxgrpc::IPageResponse<PhoneNumberInstance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PhoneNumberInstance> GetEnumerator() => PhoneNumberInstances.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
