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
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Enfonica.Voice.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSipInfoServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetSipInfoRequestObject()
        {
            moq::Mock<SipInfoService.SipInfoServiceClient> mockGrpcClient = new moq::Mock<SipInfoService.SipInfoServiceClient>(moq::MockBehavior.Strict);
            GetSipInfoRequest request = new GetSipInfoRequest
            {
                SipInfoName = SipInfoName.FromProjectCall("[PROJECT]", "[CALL]"),
            };
            SipInfo expectedResponse = new SipInfo
            {
                SipInfoName = SipInfoName.FromProjectCall("[PROJECT]", "[CALL]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                Messages = { new SipMessage(), },
                SipCallId = "sip_call_ide9ff1d69",
                Pcap = proto::ByteString.CopyFromUtf8("pcap69e05e10"),
            };
            mockGrpcClient.Setup(x => x.GetSipInfo(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SipInfoServiceClient client = new SipInfoServiceClientImpl(mockGrpcClient.Object, null);
            SipInfo response = client.GetSipInfo(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSipInfoRequestObjectAsync()
        {
            moq::Mock<SipInfoService.SipInfoServiceClient> mockGrpcClient = new moq::Mock<SipInfoService.SipInfoServiceClient>(moq::MockBehavior.Strict);
            GetSipInfoRequest request = new GetSipInfoRequest
            {
                SipInfoName = SipInfoName.FromProjectCall("[PROJECT]", "[CALL]"),
            };
            SipInfo expectedResponse = new SipInfo
            {
                SipInfoName = SipInfoName.FromProjectCall("[PROJECT]", "[CALL]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                Messages = { new SipMessage(), },
                SipCallId = "sip_call_ide9ff1d69",
                Pcap = proto::ByteString.CopyFromUtf8("pcap69e05e10"),
            };
            mockGrpcClient.Setup(x => x.GetSipInfoAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SipInfo>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SipInfoServiceClient client = new SipInfoServiceClientImpl(mockGrpcClient.Object, null);
            SipInfo responseCallSettings = await client.GetSipInfoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SipInfo responseCancellationToken = await client.GetSipInfoAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSipInfo()
        {
            moq::Mock<SipInfoService.SipInfoServiceClient> mockGrpcClient = new moq::Mock<SipInfoService.SipInfoServiceClient>(moq::MockBehavior.Strict);
            GetSipInfoRequest request = new GetSipInfoRequest
            {
                SipInfoName = SipInfoName.FromProjectCall("[PROJECT]", "[CALL]"),
            };
            SipInfo expectedResponse = new SipInfo
            {
                SipInfoName = SipInfoName.FromProjectCall("[PROJECT]", "[CALL]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                Messages = { new SipMessage(), },
                SipCallId = "sip_call_ide9ff1d69",
                Pcap = proto::ByteString.CopyFromUtf8("pcap69e05e10"),
            };
            mockGrpcClient.Setup(x => x.GetSipInfo(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SipInfoServiceClient client = new SipInfoServiceClientImpl(mockGrpcClient.Object, null);
            SipInfo response = client.GetSipInfo(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSipInfoAsync()
        {
            moq::Mock<SipInfoService.SipInfoServiceClient> mockGrpcClient = new moq::Mock<SipInfoService.SipInfoServiceClient>(moq::MockBehavior.Strict);
            GetSipInfoRequest request = new GetSipInfoRequest
            {
                SipInfoName = SipInfoName.FromProjectCall("[PROJECT]", "[CALL]"),
            };
            SipInfo expectedResponse = new SipInfo
            {
                SipInfoName = SipInfoName.FromProjectCall("[PROJECT]", "[CALL]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                Messages = { new SipMessage(), },
                SipCallId = "sip_call_ide9ff1d69",
                Pcap = proto::ByteString.CopyFromUtf8("pcap69e05e10"),
            };
            mockGrpcClient.Setup(x => x.GetSipInfoAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SipInfo>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SipInfoServiceClient client = new SipInfoServiceClientImpl(mockGrpcClient.Object, null);
            SipInfo responseCallSettings = await client.GetSipInfoAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SipInfo responseCancellationToken = await client.GetSipInfoAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSipInfoResourceNames()
        {
            moq::Mock<SipInfoService.SipInfoServiceClient> mockGrpcClient = new moq::Mock<SipInfoService.SipInfoServiceClient>(moq::MockBehavior.Strict);
            GetSipInfoRequest request = new GetSipInfoRequest
            {
                SipInfoName = SipInfoName.FromProjectCall("[PROJECT]", "[CALL]"),
            };
            SipInfo expectedResponse = new SipInfo
            {
                SipInfoName = SipInfoName.FromProjectCall("[PROJECT]", "[CALL]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                Messages = { new SipMessage(), },
                SipCallId = "sip_call_ide9ff1d69",
                Pcap = proto::ByteString.CopyFromUtf8("pcap69e05e10"),
            };
            mockGrpcClient.Setup(x => x.GetSipInfo(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SipInfoServiceClient client = new SipInfoServiceClientImpl(mockGrpcClient.Object, null);
            SipInfo response = client.GetSipInfo(request.SipInfoName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSipInfoResourceNamesAsync()
        {
            moq::Mock<SipInfoService.SipInfoServiceClient> mockGrpcClient = new moq::Mock<SipInfoService.SipInfoServiceClient>(moq::MockBehavior.Strict);
            GetSipInfoRequest request = new GetSipInfoRequest
            {
                SipInfoName = SipInfoName.FromProjectCall("[PROJECT]", "[CALL]"),
            };
            SipInfo expectedResponse = new SipInfo
            {
                SipInfoName = SipInfoName.FromProjectCall("[PROJECT]", "[CALL]"),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                Messages = { new SipMessage(), },
                SipCallId = "sip_call_ide9ff1d69",
                Pcap = proto::ByteString.CopyFromUtf8("pcap69e05e10"),
            };
            mockGrpcClient.Setup(x => x.GetSipInfoAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SipInfo>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SipInfoServiceClient client = new SipInfoServiceClientImpl(mockGrpcClient.Object, null);
            SipInfo responseCallSettings = await client.GetSipInfoAsync(request.SipInfoName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SipInfo responseCancellationToken = await client.GetSipInfoAsync(request.SipInfoName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
