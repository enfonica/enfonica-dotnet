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

using gaxgrpc = Google.Api.Gax.Grpc;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Enfonica.Numbering.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedPhoneNumberInstancesClientTest
    {
        [xunit::FactAttribute]
        public void CreatePhoneNumberInstanceRequestObject()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            CreatePhoneNumberInstanceRequest request = new CreatePhoneNumberInstanceRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                PhoneNumberInstance = new PhoneNumberInstance(),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreatePhoneNumberInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance response = client.CreatePhoneNumberInstance(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePhoneNumberInstanceRequestObjectAsync()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            CreatePhoneNumberInstanceRequest request = new CreatePhoneNumberInstanceRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                PhoneNumberInstance = new PhoneNumberInstance(),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreatePhoneNumberInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhoneNumberInstance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance responseCallSettings = await client.CreatePhoneNumberInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhoneNumberInstance responseCancellationToken = await client.CreatePhoneNumberInstanceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePhoneNumberInstance()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            CreatePhoneNumberInstanceRequest request = new CreatePhoneNumberInstanceRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                PhoneNumberInstance = new PhoneNumberInstance(),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreatePhoneNumberInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance response = client.CreatePhoneNumberInstance(request.Parent, request.PhoneNumberInstance);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePhoneNumberInstanceAsync()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            CreatePhoneNumberInstanceRequest request = new CreatePhoneNumberInstanceRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                PhoneNumberInstance = new PhoneNumberInstance(),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreatePhoneNumberInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhoneNumberInstance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance responseCallSettings = await client.CreatePhoneNumberInstanceAsync(request.Parent, request.PhoneNumberInstance, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhoneNumberInstance responseCancellationToken = await client.CreatePhoneNumberInstanceAsync(request.Parent, request.PhoneNumberInstance, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePhoneNumberInstanceResourceNames()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            CreatePhoneNumberInstanceRequest request = new CreatePhoneNumberInstanceRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                PhoneNumberInstance = new PhoneNumberInstance(),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreatePhoneNumberInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance response = client.CreatePhoneNumberInstance(request.ParentAsProjectName, request.PhoneNumberInstance);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePhoneNumberInstanceResourceNamesAsync()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            CreatePhoneNumberInstanceRequest request = new CreatePhoneNumberInstanceRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                PhoneNumberInstance = new PhoneNumberInstance(),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreatePhoneNumberInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhoneNumberInstance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance responseCallSettings = await client.CreatePhoneNumberInstanceAsync(request.ParentAsProjectName, request.PhoneNumberInstance, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhoneNumberInstance responseCancellationToken = await client.CreatePhoneNumberInstanceAsync(request.ParentAsProjectName, request.PhoneNumberInstance, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPhoneNumberInstanceRequestObject()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            GetPhoneNumberInstanceRequest request = new GetPhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetPhoneNumberInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance response = client.GetPhoneNumberInstance(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPhoneNumberInstanceRequestObjectAsync()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            GetPhoneNumberInstanceRequest request = new GetPhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetPhoneNumberInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhoneNumberInstance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance responseCallSettings = await client.GetPhoneNumberInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhoneNumberInstance responseCancellationToken = await client.GetPhoneNumberInstanceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPhoneNumberInstance()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            GetPhoneNumberInstanceRequest request = new GetPhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetPhoneNumberInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance response = client.GetPhoneNumberInstance(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPhoneNumberInstanceAsync()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            GetPhoneNumberInstanceRequest request = new GetPhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetPhoneNumberInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhoneNumberInstance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance responseCallSettings = await client.GetPhoneNumberInstanceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhoneNumberInstance responseCancellationToken = await client.GetPhoneNumberInstanceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPhoneNumberInstanceResourceNames()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            GetPhoneNumberInstanceRequest request = new GetPhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetPhoneNumberInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance response = client.GetPhoneNumberInstance(request.PhoneNumberInstanceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPhoneNumberInstanceResourceNamesAsync()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            GetPhoneNumberInstanceRequest request = new GetPhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetPhoneNumberInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhoneNumberInstance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance responseCallSettings = await client.GetPhoneNumberInstanceAsync(request.PhoneNumberInstanceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhoneNumberInstance responseCancellationToken = await client.GetPhoneNumberInstanceAsync(request.PhoneNumberInstanceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePhoneNumberInstanceRequestObject()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            UpdatePhoneNumberInstanceRequest request = new UpdatePhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumberInstance = new PhoneNumberInstance(),
                UpdateMask = new wkt::FieldMask(),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.UpdatePhoneNumberInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance response = client.UpdatePhoneNumberInstance(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePhoneNumberInstanceRequestObjectAsync()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            UpdatePhoneNumberInstanceRequest request = new UpdatePhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumberInstance = new PhoneNumberInstance(),
                UpdateMask = new wkt::FieldMask(),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.UpdatePhoneNumberInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhoneNumberInstance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance responseCallSettings = await client.UpdatePhoneNumberInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhoneNumberInstance responseCancellationToken = await client.UpdatePhoneNumberInstanceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePhoneNumberInstance()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            UpdatePhoneNumberInstanceRequest request = new UpdatePhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumberInstance = new PhoneNumberInstance(),
                UpdateMask = new wkt::FieldMask(),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.UpdatePhoneNumberInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance response = client.UpdatePhoneNumberInstance(request.Name, request.PhoneNumberInstance, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePhoneNumberInstanceAsync()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            UpdatePhoneNumberInstanceRequest request = new UpdatePhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumberInstance = new PhoneNumberInstance(),
                UpdateMask = new wkt::FieldMask(),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.UpdatePhoneNumberInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhoneNumberInstance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance responseCallSettings = await client.UpdatePhoneNumberInstanceAsync(request.Name, request.PhoneNumberInstance, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhoneNumberInstance responseCancellationToken = await client.UpdatePhoneNumberInstanceAsync(request.Name, request.PhoneNumberInstance, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePhoneNumberInstanceResourceNames()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            UpdatePhoneNumberInstanceRequest request = new UpdatePhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumberInstance = new PhoneNumberInstance(),
                UpdateMask = new wkt::FieldMask(),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.UpdatePhoneNumberInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance response = client.UpdatePhoneNumberInstance(request.PhoneNumberInstanceName, request.PhoneNumberInstance, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePhoneNumberInstanceResourceNamesAsync()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            UpdatePhoneNumberInstanceRequest request = new UpdatePhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumberInstance = new PhoneNumberInstance(),
                UpdateMask = new wkt::FieldMask(),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.UpdatePhoneNumberInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhoneNumberInstance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance responseCallSettings = await client.UpdatePhoneNumberInstanceAsync(request.PhoneNumberInstanceName, request.PhoneNumberInstance, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhoneNumberInstance responseCancellationToken = await client.UpdatePhoneNumberInstanceAsync(request.PhoneNumberInstanceName, request.PhoneNumberInstance, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePhoneNumberInstanceRequestObject()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            DeletePhoneNumberInstanceRequest request = new DeletePhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.DeletePhoneNumberInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance response = client.DeletePhoneNumberInstance(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePhoneNumberInstanceRequestObjectAsync()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            DeletePhoneNumberInstanceRequest request = new DeletePhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.DeletePhoneNumberInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhoneNumberInstance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance responseCallSettings = await client.DeletePhoneNumberInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhoneNumberInstance responseCancellationToken = await client.DeletePhoneNumberInstanceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePhoneNumberInstance()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            DeletePhoneNumberInstanceRequest request = new DeletePhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.DeletePhoneNumberInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance response = client.DeletePhoneNumberInstance(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePhoneNumberInstanceAsync()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            DeletePhoneNumberInstanceRequest request = new DeletePhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.DeletePhoneNumberInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhoneNumberInstance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance responseCallSettings = await client.DeletePhoneNumberInstanceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhoneNumberInstance responseCancellationToken = await client.DeletePhoneNumberInstanceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePhoneNumberInstanceResourceNames()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            DeletePhoneNumberInstanceRequest request = new DeletePhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.DeletePhoneNumberInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance response = client.DeletePhoneNumberInstance(request.PhoneNumberInstanceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePhoneNumberInstanceResourceNamesAsync()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            DeletePhoneNumberInstanceRequest request = new DeletePhoneNumberInstanceRequest
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                PhoneNumberInstanceName = PhoneNumberInstanceName.FromProjectPhoneNumberInstance("[PROJECT]", "[PHONE_NUMBER_INSTANCE]"),
                PhoneNumber = new PhoneNumber(),
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                IncomingMessageHandlerUris =
                {
                    "incoming_message_handler_uris72108376",
                },
                IncomingCallHandlerUris =
                {
                    "incoming_call_handler_uris2053249d",
                },
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unspecified,
            };
            mockGrpcClient.Setup(x => x.DeletePhoneNumberInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhoneNumberInstance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance responseCallSettings = await client.DeletePhoneNumberInstanceAsync(request.PhoneNumberInstanceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhoneNumberInstance responseCancellationToken = await client.DeletePhoneNumberInstanceAsync(request.PhoneNumberInstanceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
