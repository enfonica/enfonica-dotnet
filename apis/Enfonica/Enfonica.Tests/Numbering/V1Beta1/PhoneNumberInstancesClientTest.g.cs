// Copyright 2020 Google LLC
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
                Parent = "parent7858e4d0",
                PhoneNumberInstance = new PhoneNumberInstance(),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                Name = "name1c9368b0",
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
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unknown,
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
                Parent = "parent7858e4d0",
                PhoneNumberInstance = new PhoneNumberInstance(),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                Name = "name1c9368b0",
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
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unknown,
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
        public void GetPhoneNumberInstanceRequestObject()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            GetPhoneNumberInstanceRequest request = new GetPhoneNumberInstanceRequest
            {
                Name = "name1c9368b0",
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                Name = "name1c9368b0",
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
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unknown,
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
                Name = "name1c9368b0",
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                Name = "name1c9368b0",
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
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unknown,
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
        public void UpdatePhoneNumberInstanceRequestObject()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            UpdatePhoneNumberInstanceRequest request = new UpdatePhoneNumberInstanceRequest
            {
                Name = "name1c9368b0",
                PhoneNumberInstance = new PhoneNumberInstance(),
                UpdateMask = new wkt::FieldMask(),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                Name = "name1c9368b0",
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
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unknown,
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
                Name = "name1c9368b0",
                PhoneNumberInstance = new PhoneNumberInstance(),
                UpdateMask = new wkt::FieldMask(),
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                Name = "name1c9368b0",
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
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unknown,
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
        public void DeletePhoneNumberInstanceRequestObject()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            DeletePhoneNumberInstanceRequest request = new DeletePhoneNumberInstanceRequest
            {
                Name = "name1c9368b0",
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                Name = "name1c9368b0",
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
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unknown,
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
                Name = "name1c9368b0",
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                Name = "name1c9368b0",
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
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unknown,
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
        public void GetProvisionedPhoneNumberInstanceRequestObject()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            GetProvisionedPhoneNumberInstanceRequest request = new GetProvisionedPhoneNumberInstanceRequest
            {
                Parent = "parent7858e4d0",
                PhoneNumber = "phone_number9ebac341",
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                Name = "name1c9368b0",
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
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unknown,
            };
            mockGrpcClient.Setup(x => x.GetProvisionedPhoneNumberInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance response = client.GetProvisionedPhoneNumberInstance(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetProvisionedPhoneNumberInstanceRequestObjectAsync()
        {
            moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient> mockGrpcClient = new moq::Mock<PhoneNumberInstances.PhoneNumberInstancesClient>(moq::MockBehavior.Strict);
            GetProvisionedPhoneNumberInstanceRequest request = new GetProvisionedPhoneNumberInstanceRequest
            {
                Parent = "parent7858e4d0",
                PhoneNumber = "phone_number9ebac341",
            };
            PhoneNumberInstance expectedResponse = new PhoneNumberInstance
            {
                Name = "name1c9368b0",
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
                LifecycleState = PhoneNumberInstance.Types.LifecycleState.Unknown,
            };
            mockGrpcClient.Setup(x => x.GetProvisionedPhoneNumberInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhoneNumberInstance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PhoneNumberInstancesClient client = new PhoneNumberInstancesClientImpl(mockGrpcClient.Object, null);
            PhoneNumberInstance responseCallSettings = await client.GetProvisionedPhoneNumberInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhoneNumberInstance responseCancellationToken = await client.GetProvisionedPhoneNumberInstanceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
