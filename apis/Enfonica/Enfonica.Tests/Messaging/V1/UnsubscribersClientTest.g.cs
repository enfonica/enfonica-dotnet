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
                Parent = "parent7858e4d0",
                Unsubscriber = new Unsubscriber(),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                Name = "name1c9368b0",
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unknown,
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
                Parent = "parent7858e4d0",
                Unsubscriber = new Unsubscriber(),
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                Name = "name1c9368b0",
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unknown,
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
        public void GetUnsubscriberRequestObject()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            GetUnsubscriberRequest request = new GetUnsubscriberRequest
            {
                Name = "name1c9368b0",
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                Name = "name1c9368b0",
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unknown,
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
                Name = "name1c9368b0",
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                Name = "name1c9368b0",
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unknown,
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
                Name = "name1c9368b0",
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unknown,
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
                Name = "name1c9368b0",
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unknown,
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
        public void DeleteUnsubscriberRequestObject()
        {
            moq::Mock<Unsubscribers.UnsubscribersClient> mockGrpcClient = new moq::Mock<Unsubscribers.UnsubscribersClient>(moq::MockBehavior.Strict);
            DeleteUnsubscriberRequest request = new DeleteUnsubscriberRequest
            {
                Name = "name1c9368b0",
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                Name = "name1c9368b0",
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unknown,
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
                Name = "name1c9368b0",
            };
            Unsubscriber expectedResponse = new Unsubscriber
            {
                Name = "name1c9368b0",
                Phone = "phonee72fa4f7",
                UnsubscribeMethod = Unsubscriber.Types.UnsubscribeMethod.Unknown,
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
    }
}
