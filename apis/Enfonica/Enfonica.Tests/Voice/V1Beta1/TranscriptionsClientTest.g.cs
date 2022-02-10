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

namespace Enfonica.Voice.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedTranscriptionsClientTest
    {
        [xunit::FactAttribute]
        public void GetTranscriptionRequestObject()
        {
            moq::Mock<Transcriptions.TranscriptionsClient> mockGrpcClient = new moq::Mock<Transcriptions.TranscriptionsClient>(moq::MockBehavior.Strict);
            GetTranscriptionRequest request = new GetTranscriptionRequest
            {
                TranscriptionName = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]"),
                View = TranscriptionView.Basic,
            };
            Transcription expectedResponse = new Transcription
            {
                TranscriptionName = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]"),
                Recording = "recordingc2b989fb",
                State = Transcription.Types.State.Completed,
                Duration = new wkt::Duration(),
                ChannelCount = 613767397,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ReadyUri = "ready_urid8761d7d",
                Utterances = { new Utterance(), },
            };
            mockGrpcClient.Setup(x => x.GetTranscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscriptionsClient client = new TranscriptionsClientImpl(mockGrpcClient.Object, null);
            Transcription response = client.GetTranscription(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTranscriptionRequestObjectAsync()
        {
            moq::Mock<Transcriptions.TranscriptionsClient> mockGrpcClient = new moq::Mock<Transcriptions.TranscriptionsClient>(moq::MockBehavior.Strict);
            GetTranscriptionRequest request = new GetTranscriptionRequest
            {
                TranscriptionName = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]"),
                View = TranscriptionView.Basic,
            };
            Transcription expectedResponse = new Transcription
            {
                TranscriptionName = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]"),
                Recording = "recordingc2b989fb",
                State = Transcription.Types.State.Completed,
                Duration = new wkt::Duration(),
                ChannelCount = 613767397,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ReadyUri = "ready_urid8761d7d",
                Utterances = { new Utterance(), },
            };
            mockGrpcClient.Setup(x => x.GetTranscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Transcription>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscriptionsClient client = new TranscriptionsClientImpl(mockGrpcClient.Object, null);
            Transcription responseCallSettings = await client.GetTranscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Transcription responseCancellationToken = await client.GetTranscriptionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTranscription()
        {
            moq::Mock<Transcriptions.TranscriptionsClient> mockGrpcClient = new moq::Mock<Transcriptions.TranscriptionsClient>(moq::MockBehavior.Strict);
            GetTranscriptionRequest request = new GetTranscriptionRequest
            {
                TranscriptionName = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]"),
            };
            Transcription expectedResponse = new Transcription
            {
                TranscriptionName = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]"),
                Recording = "recordingc2b989fb",
                State = Transcription.Types.State.Completed,
                Duration = new wkt::Duration(),
                ChannelCount = 613767397,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ReadyUri = "ready_urid8761d7d",
                Utterances = { new Utterance(), },
            };
            mockGrpcClient.Setup(x => x.GetTranscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscriptionsClient client = new TranscriptionsClientImpl(mockGrpcClient.Object, null);
            Transcription response = client.GetTranscription(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTranscriptionAsync()
        {
            moq::Mock<Transcriptions.TranscriptionsClient> mockGrpcClient = new moq::Mock<Transcriptions.TranscriptionsClient>(moq::MockBehavior.Strict);
            GetTranscriptionRequest request = new GetTranscriptionRequest
            {
                TranscriptionName = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]"),
            };
            Transcription expectedResponse = new Transcription
            {
                TranscriptionName = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]"),
                Recording = "recordingc2b989fb",
                State = Transcription.Types.State.Completed,
                Duration = new wkt::Duration(),
                ChannelCount = 613767397,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ReadyUri = "ready_urid8761d7d",
                Utterances = { new Utterance(), },
            };
            mockGrpcClient.Setup(x => x.GetTranscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Transcription>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscriptionsClient client = new TranscriptionsClientImpl(mockGrpcClient.Object, null);
            Transcription responseCallSettings = await client.GetTranscriptionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Transcription responseCancellationToken = await client.GetTranscriptionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTranscriptionResourceNames()
        {
            moq::Mock<Transcriptions.TranscriptionsClient> mockGrpcClient = new moq::Mock<Transcriptions.TranscriptionsClient>(moq::MockBehavior.Strict);
            GetTranscriptionRequest request = new GetTranscriptionRequest
            {
                TranscriptionName = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]"),
            };
            Transcription expectedResponse = new Transcription
            {
                TranscriptionName = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]"),
                Recording = "recordingc2b989fb",
                State = Transcription.Types.State.Completed,
                Duration = new wkt::Duration(),
                ChannelCount = 613767397,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ReadyUri = "ready_urid8761d7d",
                Utterances = { new Utterance(), },
            };
            mockGrpcClient.Setup(x => x.GetTranscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscriptionsClient client = new TranscriptionsClientImpl(mockGrpcClient.Object, null);
            Transcription response = client.GetTranscription(request.TranscriptionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTranscriptionResourceNamesAsync()
        {
            moq::Mock<Transcriptions.TranscriptionsClient> mockGrpcClient = new moq::Mock<Transcriptions.TranscriptionsClient>(moq::MockBehavior.Strict);
            GetTranscriptionRequest request = new GetTranscriptionRequest
            {
                TranscriptionName = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]"),
            };
            Transcription expectedResponse = new Transcription
            {
                TranscriptionName = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]"),
                Recording = "recordingc2b989fb",
                State = Transcription.Types.State.Completed,
                Duration = new wkt::Duration(),
                ChannelCount = 613767397,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ReadyUri = "ready_urid8761d7d",
                Utterances = { new Utterance(), },
            };
            mockGrpcClient.Setup(x => x.GetTranscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Transcription>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscriptionsClient client = new TranscriptionsClientImpl(mockGrpcClient.Object, null);
            Transcription responseCallSettings = await client.GetTranscriptionAsync(request.TranscriptionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Transcription responseCancellationToken = await client.GetTranscriptionAsync(request.TranscriptionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTranscriptionRequestObject()
        {
            moq::Mock<Transcriptions.TranscriptionsClient> mockGrpcClient = new moq::Mock<Transcriptions.TranscriptionsClient>(moq::MockBehavior.Strict);
            DeleteTranscriptionRequest request = new DeleteTranscriptionRequest
            {
                TranscriptionName = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTranscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscriptionsClient client = new TranscriptionsClientImpl(mockGrpcClient.Object, null);
            client.DeleteTranscription(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTranscriptionRequestObjectAsync()
        {
            moq::Mock<Transcriptions.TranscriptionsClient> mockGrpcClient = new moq::Mock<Transcriptions.TranscriptionsClient>(moq::MockBehavior.Strict);
            DeleteTranscriptionRequest request = new DeleteTranscriptionRequest
            {
                TranscriptionName = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTranscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscriptionsClient client = new TranscriptionsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTranscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTranscriptionAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTranscription()
        {
            moq::Mock<Transcriptions.TranscriptionsClient> mockGrpcClient = new moq::Mock<Transcriptions.TranscriptionsClient>(moq::MockBehavior.Strict);
            DeleteTranscriptionRequest request = new DeleteTranscriptionRequest
            {
                TranscriptionName = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTranscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscriptionsClient client = new TranscriptionsClientImpl(mockGrpcClient.Object, null);
            client.DeleteTranscription(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTranscriptionAsync()
        {
            moq::Mock<Transcriptions.TranscriptionsClient> mockGrpcClient = new moq::Mock<Transcriptions.TranscriptionsClient>(moq::MockBehavior.Strict);
            DeleteTranscriptionRequest request = new DeleteTranscriptionRequest
            {
                TranscriptionName = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTranscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscriptionsClient client = new TranscriptionsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTranscriptionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTranscriptionAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTranscriptionResourceNames()
        {
            moq::Mock<Transcriptions.TranscriptionsClient> mockGrpcClient = new moq::Mock<Transcriptions.TranscriptionsClient>(moq::MockBehavior.Strict);
            DeleteTranscriptionRequest request = new DeleteTranscriptionRequest
            {
                TranscriptionName = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTranscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscriptionsClient client = new TranscriptionsClientImpl(mockGrpcClient.Object, null);
            client.DeleteTranscription(request.TranscriptionName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTranscriptionResourceNamesAsync()
        {
            moq::Mock<Transcriptions.TranscriptionsClient> mockGrpcClient = new moq::Mock<Transcriptions.TranscriptionsClient>(moq::MockBehavior.Strict);
            DeleteTranscriptionRequest request = new DeleteTranscriptionRequest
            {
                TranscriptionName = TranscriptionName.FromProjectCallTranscription("[PROJECT]", "[CALL]", "[TRANSCRIPTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTranscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscriptionsClient client = new TranscriptionsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTranscriptionAsync(request.TranscriptionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTranscriptionAsync(request.TranscriptionName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
