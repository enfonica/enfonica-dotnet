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

namespace Enfonica.Voice.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedRecordingsClientTest
    {
        [xunit::FactAttribute]
        public void GetRecordingRequestObject()
        {
            moq::Mock<Recordings.RecordingsClient> mockGrpcClient = new moq::Mock<Recordings.RecordingsClient>(moq::MockBehavior.Strict);
            GetRecordingRequest request = new GetRecordingRequest
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
                View = RecordingView.Basic,
            };
            Recording expectedResponse = new Recording
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
                State = Recording.Types.State.Empty,
                Source = Recording.Types.Source.Unspecified,
                Duration = new wkt::Duration(),
                ChannelCount = 613767397,
                PostProcessing =
                {
                    Recording.Types.PostProcessing.TrimSilence,
                },
                ErrorCode = Recording.Types.ErrorCode.Unspecified,
                Audio =
                {
                    new RecordingAudio(),
                },
                StartTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                ReadyUri = "ready_urid8761d7d",
            };
            mockGrpcClient.Setup(x => x.GetRecording(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecordingsClient client = new RecordingsClientImpl(mockGrpcClient.Object, null);
            Recording response = client.GetRecording(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRecordingRequestObjectAsync()
        {
            moq::Mock<Recordings.RecordingsClient> mockGrpcClient = new moq::Mock<Recordings.RecordingsClient>(moq::MockBehavior.Strict);
            GetRecordingRequest request = new GetRecordingRequest
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
                View = RecordingView.Basic,
            };
            Recording expectedResponse = new Recording
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
                State = Recording.Types.State.Empty,
                Source = Recording.Types.Source.Unspecified,
                Duration = new wkt::Duration(),
                ChannelCount = 613767397,
                PostProcessing =
                {
                    Recording.Types.PostProcessing.TrimSilence,
                },
                ErrorCode = Recording.Types.ErrorCode.Unspecified,
                Audio =
                {
                    new RecordingAudio(),
                },
                StartTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                ReadyUri = "ready_urid8761d7d",
            };
            mockGrpcClient.Setup(x => x.GetRecordingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Recording>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecordingsClient client = new RecordingsClientImpl(mockGrpcClient.Object, null);
            Recording responseCallSettings = await client.GetRecordingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Recording responseCancellationToken = await client.GetRecordingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRecording()
        {
            moq::Mock<Recordings.RecordingsClient> mockGrpcClient = new moq::Mock<Recordings.RecordingsClient>(moq::MockBehavior.Strict);
            GetRecordingRequest request = new GetRecordingRequest
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
            };
            Recording expectedResponse = new Recording
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
                State = Recording.Types.State.Empty,
                Source = Recording.Types.Source.Unspecified,
                Duration = new wkt::Duration(),
                ChannelCount = 613767397,
                PostProcessing =
                {
                    Recording.Types.PostProcessing.TrimSilence,
                },
                ErrorCode = Recording.Types.ErrorCode.Unspecified,
                Audio =
                {
                    new RecordingAudio(),
                },
                StartTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                ReadyUri = "ready_urid8761d7d",
            };
            mockGrpcClient.Setup(x => x.GetRecording(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecordingsClient client = new RecordingsClientImpl(mockGrpcClient.Object, null);
            Recording response = client.GetRecording(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRecordingAsync()
        {
            moq::Mock<Recordings.RecordingsClient> mockGrpcClient = new moq::Mock<Recordings.RecordingsClient>(moq::MockBehavior.Strict);
            GetRecordingRequest request = new GetRecordingRequest
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
            };
            Recording expectedResponse = new Recording
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
                State = Recording.Types.State.Empty,
                Source = Recording.Types.Source.Unspecified,
                Duration = new wkt::Duration(),
                ChannelCount = 613767397,
                PostProcessing =
                {
                    Recording.Types.PostProcessing.TrimSilence,
                },
                ErrorCode = Recording.Types.ErrorCode.Unspecified,
                Audio =
                {
                    new RecordingAudio(),
                },
                StartTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                ReadyUri = "ready_urid8761d7d",
            };
            mockGrpcClient.Setup(x => x.GetRecordingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Recording>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecordingsClient client = new RecordingsClientImpl(mockGrpcClient.Object, null);
            Recording responseCallSettings = await client.GetRecordingAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Recording responseCancellationToken = await client.GetRecordingAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRecordingResourceNames()
        {
            moq::Mock<Recordings.RecordingsClient> mockGrpcClient = new moq::Mock<Recordings.RecordingsClient>(moq::MockBehavior.Strict);
            GetRecordingRequest request = new GetRecordingRequest
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
            };
            Recording expectedResponse = new Recording
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
                State = Recording.Types.State.Empty,
                Source = Recording.Types.Source.Unspecified,
                Duration = new wkt::Duration(),
                ChannelCount = 613767397,
                PostProcessing =
                {
                    Recording.Types.PostProcessing.TrimSilence,
                },
                ErrorCode = Recording.Types.ErrorCode.Unspecified,
                Audio =
                {
                    new RecordingAudio(),
                },
                StartTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                ReadyUri = "ready_urid8761d7d",
            };
            mockGrpcClient.Setup(x => x.GetRecording(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecordingsClient client = new RecordingsClientImpl(mockGrpcClient.Object, null);
            Recording response = client.GetRecording(request.RecordingName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRecordingResourceNamesAsync()
        {
            moq::Mock<Recordings.RecordingsClient> mockGrpcClient = new moq::Mock<Recordings.RecordingsClient>(moq::MockBehavior.Strict);
            GetRecordingRequest request = new GetRecordingRequest
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
            };
            Recording expectedResponse = new Recording
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
                State = Recording.Types.State.Empty,
                Source = Recording.Types.Source.Unspecified,
                Duration = new wkt::Duration(),
                ChannelCount = 613767397,
                PostProcessing =
                {
                    Recording.Types.PostProcessing.TrimSilence,
                },
                ErrorCode = Recording.Types.ErrorCode.Unspecified,
                Audio =
                {
                    new RecordingAudio(),
                },
                StartTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                ReadyUri = "ready_urid8761d7d",
            };
            mockGrpcClient.Setup(x => x.GetRecordingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Recording>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecordingsClient client = new RecordingsClientImpl(mockGrpcClient.Object, null);
            Recording responseCallSettings = await client.GetRecordingAsync(request.RecordingName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Recording responseCancellationToken = await client.GetRecordingAsync(request.RecordingName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRecordingRequestObject()
        {
            moq::Mock<Recordings.RecordingsClient> mockGrpcClient = new moq::Mock<Recordings.RecordingsClient>(moq::MockBehavior.Strict);
            DeleteRecordingRequest request = new DeleteRecordingRequest
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
            };
            Recording expectedResponse = new Recording
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
                State = Recording.Types.State.Empty,
                Source = Recording.Types.Source.Unspecified,
                Duration = new wkt::Duration(),
                ChannelCount = 613767397,
                PostProcessing =
                {
                    Recording.Types.PostProcessing.TrimSilence,
                },
                ErrorCode = Recording.Types.ErrorCode.Unspecified,
                Audio =
                {
                    new RecordingAudio(),
                },
                StartTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                ReadyUri = "ready_urid8761d7d",
            };
            mockGrpcClient.Setup(x => x.DeleteRecording(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecordingsClient client = new RecordingsClientImpl(mockGrpcClient.Object, null);
            Recording response = client.DeleteRecording(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRecordingRequestObjectAsync()
        {
            moq::Mock<Recordings.RecordingsClient> mockGrpcClient = new moq::Mock<Recordings.RecordingsClient>(moq::MockBehavior.Strict);
            DeleteRecordingRequest request = new DeleteRecordingRequest
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
            };
            Recording expectedResponse = new Recording
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
                State = Recording.Types.State.Empty,
                Source = Recording.Types.Source.Unspecified,
                Duration = new wkt::Duration(),
                ChannelCount = 613767397,
                PostProcessing =
                {
                    Recording.Types.PostProcessing.TrimSilence,
                },
                ErrorCode = Recording.Types.ErrorCode.Unspecified,
                Audio =
                {
                    new RecordingAudio(),
                },
                StartTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                ReadyUri = "ready_urid8761d7d",
            };
            mockGrpcClient.Setup(x => x.DeleteRecordingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Recording>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecordingsClient client = new RecordingsClientImpl(mockGrpcClient.Object, null);
            Recording responseCallSettings = await client.DeleteRecordingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Recording responseCancellationToken = await client.DeleteRecordingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRecording()
        {
            moq::Mock<Recordings.RecordingsClient> mockGrpcClient = new moq::Mock<Recordings.RecordingsClient>(moq::MockBehavior.Strict);
            DeleteRecordingRequest request = new DeleteRecordingRequest
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
            };
            Recording expectedResponse = new Recording
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
                State = Recording.Types.State.Empty,
                Source = Recording.Types.Source.Unspecified,
                Duration = new wkt::Duration(),
                ChannelCount = 613767397,
                PostProcessing =
                {
                    Recording.Types.PostProcessing.TrimSilence,
                },
                ErrorCode = Recording.Types.ErrorCode.Unspecified,
                Audio =
                {
                    new RecordingAudio(),
                },
                StartTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                ReadyUri = "ready_urid8761d7d",
            };
            mockGrpcClient.Setup(x => x.DeleteRecording(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecordingsClient client = new RecordingsClientImpl(mockGrpcClient.Object, null);
            Recording response = client.DeleteRecording(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRecordingAsync()
        {
            moq::Mock<Recordings.RecordingsClient> mockGrpcClient = new moq::Mock<Recordings.RecordingsClient>(moq::MockBehavior.Strict);
            DeleteRecordingRequest request = new DeleteRecordingRequest
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
            };
            Recording expectedResponse = new Recording
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
                State = Recording.Types.State.Empty,
                Source = Recording.Types.Source.Unspecified,
                Duration = new wkt::Duration(),
                ChannelCount = 613767397,
                PostProcessing =
                {
                    Recording.Types.PostProcessing.TrimSilence,
                },
                ErrorCode = Recording.Types.ErrorCode.Unspecified,
                Audio =
                {
                    new RecordingAudio(),
                },
                StartTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                ReadyUri = "ready_urid8761d7d",
            };
            mockGrpcClient.Setup(x => x.DeleteRecordingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Recording>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecordingsClient client = new RecordingsClientImpl(mockGrpcClient.Object, null);
            Recording responseCallSettings = await client.DeleteRecordingAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Recording responseCancellationToken = await client.DeleteRecordingAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRecordingResourceNames()
        {
            moq::Mock<Recordings.RecordingsClient> mockGrpcClient = new moq::Mock<Recordings.RecordingsClient>(moq::MockBehavior.Strict);
            DeleteRecordingRequest request = new DeleteRecordingRequest
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
            };
            Recording expectedResponse = new Recording
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
                State = Recording.Types.State.Empty,
                Source = Recording.Types.Source.Unspecified,
                Duration = new wkt::Duration(),
                ChannelCount = 613767397,
                PostProcessing =
                {
                    Recording.Types.PostProcessing.TrimSilence,
                },
                ErrorCode = Recording.Types.ErrorCode.Unspecified,
                Audio =
                {
                    new RecordingAudio(),
                },
                StartTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                ReadyUri = "ready_urid8761d7d",
            };
            mockGrpcClient.Setup(x => x.DeleteRecording(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecordingsClient client = new RecordingsClientImpl(mockGrpcClient.Object, null);
            Recording response = client.DeleteRecording(request.RecordingName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRecordingResourceNamesAsync()
        {
            moq::Mock<Recordings.RecordingsClient> mockGrpcClient = new moq::Mock<Recordings.RecordingsClient>(moq::MockBehavior.Strict);
            DeleteRecordingRequest request = new DeleteRecordingRequest
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
            };
            Recording expectedResponse = new Recording
            {
                RecordingName = RecordingName.FromProjectCallRecording("[PROJECT]", "[CALL]", "[RECORDING]"),
                State = Recording.Types.State.Empty,
                Source = Recording.Types.Source.Unspecified,
                Duration = new wkt::Duration(),
                ChannelCount = 613767397,
                PostProcessing =
                {
                    Recording.Types.PostProcessing.TrimSilence,
                },
                ErrorCode = Recording.Types.ErrorCode.Unspecified,
                Audio =
                {
                    new RecordingAudio(),
                },
                StartTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                ReadyUri = "ready_urid8761d7d",
            };
            mockGrpcClient.Setup(x => x.DeleteRecordingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Recording>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecordingsClient client = new RecordingsClientImpl(mockGrpcClient.Object, null);
            Recording responseCallSettings = await client.DeleteRecordingAsync(request.RecordingName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Recording responseCancellationToken = await client.DeleteRecordingAsync(request.RecordingName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
