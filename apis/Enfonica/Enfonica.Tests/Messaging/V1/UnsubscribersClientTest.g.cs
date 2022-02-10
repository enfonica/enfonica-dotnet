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

using gaxgrpc = Google.Api.Gax.Grpc;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Enfonica.Messaging.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedUnsubscribersClientTest
    {
        [xunit::FactAttribute]
        public void CreateUnsubscriberRequestObject()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            CreateUnsubscriberRequest request = new CreateUnsubscriberRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Unsubscriber = new Unsubscriber(),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateUnsubscriber(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UnsubscribersClient client = new UnsubscribersClientImpl(mockGrpcClient.Object, null);
            Unsubscriber response = client.CreateUnsubscriber(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateUnsubscriberRequestObjectAsync()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            CreateUnsubscriberRequest request = new CreateUnsubscriberRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Unsubscriber = new Unsubscriber(),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateUnsubscriberAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Unsubscriber>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UnsubscribersClient client = new UnsubscribersClientImpl(mockGrpcClient.Object, null);
            Unsubscriber responseCallSettings = await client.CreateUnsubscriberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Unsubscriber responseCancellationToken = await client.CreateUnsubscriberAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateUnsubscriber()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            CreateUnsubscriberRequest request = new CreateUnsubscriberRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Unsubscriber = new Unsubscriber(),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateUnsubscriber(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UnsubscribersClient client = new UnsubscribersClientImpl(mockGrpcClient.Object, null);
            Unsubscriber response = client.CreateUnsubscriber(request.Parent, request.Unsubscriber);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateUnsubscriberAsync()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            CreateUnsubscriberRequest request = new CreateUnsubscriberRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Unsubscriber = new Unsubscriber(),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateUnsubscriberAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Unsubscriber>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UnsubscribersClient client = new UnsubscribersClientImpl(mockGrpcClient.Object, null);
            Unsubscriber responseCallSettings = await client.CreateUnsubscriberAsync(request.Parent, request.Unsubscriber, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Unsubscriber responseCancellationToken = await client.CreateUnsubscriberAsync(request.Parent, request.Unsubscriber, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateUnsubscriberResourceNames()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            CreateUnsubscriberRequest request = new CreateUnsubscriberRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Unsubscriber = new Unsubscriber(),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateUnsubscriber(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UnsubscribersClient client = new UnsubscribersClientImpl(mockGrpcClient.Object, null);
            Unsubscriber response = client.CreateUnsubscriber(request.ParentAsProjectName, request.Unsubscriber);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateUnsubscriberResourceNamesAsync()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            CreateUnsubscriberRequest request = new CreateUnsubscriberRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Unsubscriber = new Unsubscriber(),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateUnsubscriberAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Unsubscriber>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UnsubscribersClient client = new UnsubscribersClientImpl(mockGrpcClient.Object, null);
            Unsubscriber responseCallSettings = await client.CreateUnsubscriberAsync(request.ParentAsProjectName, request.Unsubscriber, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Unsubscriber responseCancellationToken = await client.CreateUnsubscriberAsync(request.ParentAsProjectName, request.Unsubscriber, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetUnsubscriberRequestObject()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            GetUnsubscriberRequest request = new GetUnsubscriberRequest
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetUnsubscriber(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UnsubscribersClient client = new UnsubscribersClientImpl(mockGrpcClient.Object, null);
            Unsubscriber response = client.GetUnsubscriber(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetUnsubscriberRequestObjectAsync()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            GetUnsubscriberRequest request = new GetUnsubscriberRequest
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetUnsubscriberAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Unsubscriber>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UnsubscribersClient client = new UnsubscribersClientImpl(mockGrpcClient.Object, null);
            Unsubscriber responseCallSettings = await client.GetUnsubscriberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Unsubscriber responseCancellationToken = await client.GetUnsubscriberAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetUnsubscriber()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            GetUnsubscriberRequest request = new GetUnsubscriberRequest
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetUnsubscriber(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UnsubscribersClient client = new UnsubscribersClientImpl(mockGrpcClient.Object, null);
            Unsubscriber response = client.GetUnsubscriber(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetUnsubscriberAsync()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            GetUnsubscriberRequest request = new GetUnsubscriberRequest
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetUnsubscriberAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Unsubscriber>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UnsubscribersClient client = new UnsubscribersClientImpl(mockGrpcClient.Object, null);
            Unsubscriber responseCallSettings = await client.GetUnsubscriberAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Unsubscriber responseCancellationToken = await client.GetUnsubscriberAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetUnsubscriberResourceNames()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            GetUnsubscriberRequest request = new GetUnsubscriberRequest
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetUnsubscriber(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UnsubscribersClient client = new UnsubscribersClientImpl(mockGrpcClient.Object, null);
            Unsubscriber response = client.GetUnsubscriber(request.UnsubscriberName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetUnsubscriberResourceNamesAsync()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            GetUnsubscriberRequest request = new GetUnsubscriberRequest
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetUnsubscriberAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Unsubscriber>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UnsubscribersClient client = new UnsubscribersClientImpl(mockGrpcClient.Object, null);
            Unsubscriber responseCallSettings = await client.GetUnsubscriberAsync(request.UnsubscriberName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Unsubscriber responseCancellationToken = await client.GetUnsubscriberAsync(request.UnsubscriberName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateUnsubscriberRequestObject()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            UpdateUnsubscriberRequest request = new UpdateUnsubscriberRequest
            {
                Unsubscriber = new Unsubscriber(),
                UpdateMask = new wkt::FieldMask(),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateUnsubscriber(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UnsubscribersClient client = new UnsubscribersClientImpl(mockGrpcClient.Object, null);
            Unsubscriber response = client.UpdateUnsubscriber(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateUnsubscriberRequestObjectAsync()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            UpdateUnsubscriberRequest request = new UpdateUnsubscriberRequest
            {
                Unsubscriber = new Unsubscriber(),
                UpdateMask = new wkt::FieldMask(),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateUnsubscriberAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Unsubscriber>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UnsubscribersClient client = new UnsubscribersClientImpl(mockGrpcClient.Object, null);
            Unsubscriber responseCallSettings = await client.UpdateUnsubscriberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Unsubscriber responseCancellationToken = await client.UpdateUnsubscriberAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateUnsubscriber()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            UpdateUnsubscriberRequest request = new UpdateUnsubscriberRequest
            {
                Unsubscriber = new Unsubscriber(),
                UpdateMask = new wkt::FieldMask(),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateUnsubscriber(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UnsubscribersClient client = new UnsubscribersClientImpl(mockGrpcClient.Object, null);
            Unsubscriber response = client.UpdateUnsubscriber(request.Unsubscriber, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateUnsubscriberAsync()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            UpdateUnsubscriberRequest request = new UpdateUnsubscriberRequest
            {
                Unsubscriber = new Unsubscriber(),
                UpdateMask = new wkt::FieldMask(),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateUnsubscriberAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Unsubscriber>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UnsubscribersClient client = new UnsubscribersClientImpl(mockGrpcClient.Object, null);
            Unsubscriber responseCallSettings = await client.UpdateUnsubscriberAsync(request.Unsubscriber, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Unsubscriber responseCancellationToken = await client.UpdateUnsubscriberAsync(request.Unsubscriber, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteUnsubscriberRequestObject()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            DeleteUnsubscriberRequest request = new DeleteUnsubscriberRequest
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.DeleteUnsubscriber(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UnsubscribersClient client = new UnsubscribersClientImpl(mockGrpcClient.Object, null);
            Unsubscriber response = client.DeleteUnsubscriber(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteUnsubscriberRequestObjectAsync()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            DeleteUnsubscriberRequest request = new DeleteUnsubscriberRequest
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.DeleteUnsubscriberAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Unsubscriber>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UnsubscribersClient client = new UnsubscribersClientImpl(mockGrpcClient.Object, null);
            Unsubscriber responseCallSettings = await client.DeleteUnsubscriberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Unsubscriber responseCancellationToken = await client.DeleteUnsubscriberAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteUnsubscriber()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            DeleteUnsubscriberRequest request = new DeleteUnsubscriberRequest
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.DeleteUnsubscriber(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UnsubscribersClient client = new UnsubscribersClientImpl(mockGrpcClient.Object, null);
            Unsubscriber response = client.DeleteUnsubscriber(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteUnsubscriberAsync()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            DeleteUnsubscriberRequest request = new DeleteUnsubscriberRequest
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.DeleteUnsubscriberAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Unsubscriber>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UnsubscribersClient client = new UnsubscribersClientImpl(mockGrpcClient.Object, null);
            Unsubscriber responseCallSettings = await client.DeleteUnsubscriberAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Unsubscriber responseCancellationToken = await client.DeleteUnsubscriberAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteUnsubscriberResourceNames()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            DeleteUnsubscriberRequest request = new DeleteUnsubscriberRequest
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.DeleteUnsubscriber(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UnsubscribersClient client = new UnsubscribersClientImpl(mockGrpcClient.Object, null);
            Unsubscriber response = client.DeleteUnsubscriber(request.UnsubscriberName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteUnsubscriberResourceNamesAsync()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            DeleteUnsubscriberRequest request = new DeleteUnsubscriberRequest
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                UnsubscriberName = UnsubscriberName.FromProjectUnsubscriber("[PROJECT]", "[UNSUBSCRIBER]"),
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.DeleteUnsubscriberAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Unsubscriber>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UnsubscribersClient client = new UnsubscribersClientImpl(mockGrpcClient.Object, null);
            Unsubscriber responseCallSettings = await client.DeleteUnsubscriberAsync(request.UnsubscriberName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Unsubscriber responseCancellationToken = await client.DeleteUnsubscriberAsync(request.UnsubscriberName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
