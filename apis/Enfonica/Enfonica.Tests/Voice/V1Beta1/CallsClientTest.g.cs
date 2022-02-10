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
using gt = Google.Type;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Enfonica.Voice.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCallsClientTest
    {
        [xunit::FactAttribute]
        public void CreateCallRequestObject()
        {
            moq::Mock<Calls.CallsClient> mockGrpcClient = new moq::Mock<Calls.CallsClient>(moq::MockBehavior.Strict);
            CreateCallRequest request = new CreateCallRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Call = new Call(),
            };
            Call expectedResponse = new Call
            {
                CallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
                To = "to03e2b601",
                From = "fromf8078ad9",
                IsPrivate = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Transport = Call.Types.Transport.Sip,
                Direction = Call.Types.Direction.Incoming,
                ErrorCode = "error_code42bd958e",
                ErrorMessage = "error_messaged73952bd",
                Price = new gt::Money(),
                State = Call.Types.State.Busy,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                RingTime = new wkt::Timestamp(),
                AnswerTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                Bridged = true,
                OriginatingCall = "originating_call9e182b53",
                CreateMethod = Call.Types.CreateMethod.Api,
                Options = new Call.Types.ApiCallOptions(),
                FromLocation = new NumberLocation(),
                FromZone = "from_zone76a01c8c",
                SipCallId = "sip_call_ide9ff1d69",
                AnswerDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateCall(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CallsClient client = new CallsClientImpl(mockGrpcClient.Object, null);
            Call response = client.CreateCall(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCallRequestObjectAsync()
        {
            moq::Mock<Calls.CallsClient> mockGrpcClient = new moq::Mock<Calls.CallsClient>(moq::MockBehavior.Strict);
            CreateCallRequest request = new CreateCallRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Call = new Call(),
            };
            Call expectedResponse = new Call
            {
                CallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
                To = "to03e2b601",
                From = "fromf8078ad9",
                IsPrivate = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Transport = Call.Types.Transport.Sip,
                Direction = Call.Types.Direction.Incoming,
                ErrorCode = "error_code42bd958e",
                ErrorMessage = "error_messaged73952bd",
                Price = new gt::Money(),
                State = Call.Types.State.Busy,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                RingTime = new wkt::Timestamp(),
                AnswerTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                Bridged = true,
                OriginatingCall = "originating_call9e182b53",
                CreateMethod = Call.Types.CreateMethod.Api,
                Options = new Call.Types.ApiCallOptions(),
                FromLocation = new NumberLocation(),
                FromZone = "from_zone76a01c8c",
                SipCallId = "sip_call_ide9ff1d69",
                AnswerDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateCallAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Call>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CallsClient client = new CallsClientImpl(mockGrpcClient.Object, null);
            Call responseCallSettings = await client.CreateCallAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Call responseCancellationToken = await client.CreateCallAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCall()
        {
            moq::Mock<Calls.CallsClient> mockGrpcClient = new moq::Mock<Calls.CallsClient>(moq::MockBehavior.Strict);
            CreateCallRequest request = new CreateCallRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Call = new Call(),
            };
            Call expectedResponse = new Call
            {
                CallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
                To = "to03e2b601",
                From = "fromf8078ad9",
                IsPrivate = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Transport = Call.Types.Transport.Sip,
                Direction = Call.Types.Direction.Incoming,
                ErrorCode = "error_code42bd958e",
                ErrorMessage = "error_messaged73952bd",
                Price = new gt::Money(),
                State = Call.Types.State.Busy,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                RingTime = new wkt::Timestamp(),
                AnswerTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                Bridged = true,
                OriginatingCall = "originating_call9e182b53",
                CreateMethod = Call.Types.CreateMethod.Api,
                Options = new Call.Types.ApiCallOptions(),
                FromLocation = new NumberLocation(),
                FromZone = "from_zone76a01c8c",
                SipCallId = "sip_call_ide9ff1d69",
                AnswerDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateCall(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CallsClient client = new CallsClientImpl(mockGrpcClient.Object, null);
            Call response = client.CreateCall(request.Parent, request.Call);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCallAsync()
        {
            moq::Mock<Calls.CallsClient> mockGrpcClient = new moq::Mock<Calls.CallsClient>(moq::MockBehavior.Strict);
            CreateCallRequest request = new CreateCallRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Call = new Call(),
            };
            Call expectedResponse = new Call
            {
                CallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
                To = "to03e2b601",
                From = "fromf8078ad9",
                IsPrivate = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Transport = Call.Types.Transport.Sip,
                Direction = Call.Types.Direction.Incoming,
                ErrorCode = "error_code42bd958e",
                ErrorMessage = "error_messaged73952bd",
                Price = new gt::Money(),
                State = Call.Types.State.Busy,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                RingTime = new wkt::Timestamp(),
                AnswerTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                Bridged = true,
                OriginatingCall = "originating_call9e182b53",
                CreateMethod = Call.Types.CreateMethod.Api,
                Options = new Call.Types.ApiCallOptions(),
                FromLocation = new NumberLocation(),
                FromZone = "from_zone76a01c8c",
                SipCallId = "sip_call_ide9ff1d69",
                AnswerDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateCallAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Call>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CallsClient client = new CallsClientImpl(mockGrpcClient.Object, null);
            Call responseCallSettings = await client.CreateCallAsync(request.Parent, request.Call, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Call responseCancellationToken = await client.CreateCallAsync(request.Parent, request.Call, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCallResourceNames()
        {
            moq::Mock<Calls.CallsClient> mockGrpcClient = new moq::Mock<Calls.CallsClient>(moq::MockBehavior.Strict);
            CreateCallRequest request = new CreateCallRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Call = new Call(),
            };
            Call expectedResponse = new Call
            {
                CallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
                To = "to03e2b601",
                From = "fromf8078ad9",
                IsPrivate = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Transport = Call.Types.Transport.Sip,
                Direction = Call.Types.Direction.Incoming,
                ErrorCode = "error_code42bd958e",
                ErrorMessage = "error_messaged73952bd",
                Price = new gt::Money(),
                State = Call.Types.State.Busy,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                RingTime = new wkt::Timestamp(),
                AnswerTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                Bridged = true,
                OriginatingCall = "originating_call9e182b53",
                CreateMethod = Call.Types.CreateMethod.Api,
                Options = new Call.Types.ApiCallOptions(),
                FromLocation = new NumberLocation(),
                FromZone = "from_zone76a01c8c",
                SipCallId = "sip_call_ide9ff1d69",
                AnswerDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateCall(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CallsClient client = new CallsClientImpl(mockGrpcClient.Object, null);
            Call response = client.CreateCall(request.ParentAsProjectName, request.Call);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCallResourceNamesAsync()
        {
            moq::Mock<Calls.CallsClient> mockGrpcClient = new moq::Mock<Calls.CallsClient>(moq::MockBehavior.Strict);
            CreateCallRequest request = new CreateCallRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Call = new Call(),
            };
            Call expectedResponse = new Call
            {
                CallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
                To = "to03e2b601",
                From = "fromf8078ad9",
                IsPrivate = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Transport = Call.Types.Transport.Sip,
                Direction = Call.Types.Direction.Incoming,
                ErrorCode = "error_code42bd958e",
                ErrorMessage = "error_messaged73952bd",
                Price = new gt::Money(),
                State = Call.Types.State.Busy,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                RingTime = new wkt::Timestamp(),
                AnswerTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                Bridged = true,
                OriginatingCall = "originating_call9e182b53",
                CreateMethod = Call.Types.CreateMethod.Api,
                Options = new Call.Types.ApiCallOptions(),
                FromLocation = new NumberLocation(),
                FromZone = "from_zone76a01c8c",
                SipCallId = "sip_call_ide9ff1d69",
                AnswerDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateCallAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Call>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CallsClient client = new CallsClientImpl(mockGrpcClient.Object, null);
            Call responseCallSettings = await client.CreateCallAsync(request.ParentAsProjectName, request.Call, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Call responseCancellationToken = await client.CreateCallAsync(request.ParentAsProjectName, request.Call, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCallRequestObject()
        {
            moq::Mock<Calls.CallsClient> mockGrpcClient = new moq::Mock<Calls.CallsClient>(moq::MockBehavior.Strict);
            GetCallRequest request = new GetCallRequest
            {
                CallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
            };
            Call expectedResponse = new Call
            {
                CallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
                To = "to03e2b601",
                From = "fromf8078ad9",
                IsPrivate = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Transport = Call.Types.Transport.Sip,
                Direction = Call.Types.Direction.Incoming,
                ErrorCode = "error_code42bd958e",
                ErrorMessage = "error_messaged73952bd",
                Price = new gt::Money(),
                State = Call.Types.State.Busy,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                RingTime = new wkt::Timestamp(),
                AnswerTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                Bridged = true,
                OriginatingCall = "originating_call9e182b53",
                CreateMethod = Call.Types.CreateMethod.Api,
                Options = new Call.Types.ApiCallOptions(),
                FromLocation = new NumberLocation(),
                FromZone = "from_zone76a01c8c",
                SipCallId = "sip_call_ide9ff1d69",
                AnswerDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetCall(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CallsClient client = new CallsClientImpl(mockGrpcClient.Object, null);
            Call response = client.GetCall(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCallRequestObjectAsync()
        {
            moq::Mock<Calls.CallsClient> mockGrpcClient = new moq::Mock<Calls.CallsClient>(moq::MockBehavior.Strict);
            GetCallRequest request = new GetCallRequest
            {
                CallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
            };
            Call expectedResponse = new Call
            {
                CallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
                To = "to03e2b601",
                From = "fromf8078ad9",
                IsPrivate = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Transport = Call.Types.Transport.Sip,
                Direction = Call.Types.Direction.Incoming,
                ErrorCode = "error_code42bd958e",
                ErrorMessage = "error_messaged73952bd",
                Price = new gt::Money(),
                State = Call.Types.State.Busy,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                RingTime = new wkt::Timestamp(),
                AnswerTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                Bridged = true,
                OriginatingCall = "originating_call9e182b53",
                CreateMethod = Call.Types.CreateMethod.Api,
                Options = new Call.Types.ApiCallOptions(),
                FromLocation = new NumberLocation(),
                FromZone = "from_zone76a01c8c",
                SipCallId = "sip_call_ide9ff1d69",
                AnswerDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetCallAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Call>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CallsClient client = new CallsClientImpl(mockGrpcClient.Object, null);
            Call responseCallSettings = await client.GetCallAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Call responseCancellationToken = await client.GetCallAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCall()
        {
            moq::Mock<Calls.CallsClient> mockGrpcClient = new moq::Mock<Calls.CallsClient>(moq::MockBehavior.Strict);
            GetCallRequest request = new GetCallRequest
            {
                CallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
            };
            Call expectedResponse = new Call
            {
                CallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
                To = "to03e2b601",
                From = "fromf8078ad9",
                IsPrivate = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Transport = Call.Types.Transport.Sip,
                Direction = Call.Types.Direction.Incoming,
                ErrorCode = "error_code42bd958e",
                ErrorMessage = "error_messaged73952bd",
                Price = new gt::Money(),
                State = Call.Types.State.Busy,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                RingTime = new wkt::Timestamp(),
                AnswerTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                Bridged = true,
                OriginatingCall = "originating_call9e182b53",
                CreateMethod = Call.Types.CreateMethod.Api,
                Options = new Call.Types.ApiCallOptions(),
                FromLocation = new NumberLocation(),
                FromZone = "from_zone76a01c8c",
                SipCallId = "sip_call_ide9ff1d69",
                AnswerDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetCall(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CallsClient client = new CallsClientImpl(mockGrpcClient.Object, null);
            Call response = client.GetCall(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCallAsync()
        {
            moq::Mock<Calls.CallsClient> mockGrpcClient = new moq::Mock<Calls.CallsClient>(moq::MockBehavior.Strict);
            GetCallRequest request = new GetCallRequest
            {
                CallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
            };
            Call expectedResponse = new Call
            {
                CallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
                To = "to03e2b601",
                From = "fromf8078ad9",
                IsPrivate = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Transport = Call.Types.Transport.Sip,
                Direction = Call.Types.Direction.Incoming,
                ErrorCode = "error_code42bd958e",
                ErrorMessage = "error_messaged73952bd",
                Price = new gt::Money(),
                State = Call.Types.State.Busy,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                RingTime = new wkt::Timestamp(),
                AnswerTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                Bridged = true,
                OriginatingCall = "originating_call9e182b53",
                CreateMethod = Call.Types.CreateMethod.Api,
                Options = new Call.Types.ApiCallOptions(),
                FromLocation = new NumberLocation(),
                FromZone = "from_zone76a01c8c",
                SipCallId = "sip_call_ide9ff1d69",
                AnswerDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetCallAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Call>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CallsClient client = new CallsClientImpl(mockGrpcClient.Object, null);
            Call responseCallSettings = await client.GetCallAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Call responseCancellationToken = await client.GetCallAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCallResourceNames()
        {
            moq::Mock<Calls.CallsClient> mockGrpcClient = new moq::Mock<Calls.CallsClient>(moq::MockBehavior.Strict);
            GetCallRequest request = new GetCallRequest
            {
                CallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
            };
            Call expectedResponse = new Call
            {
                CallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
                To = "to03e2b601",
                From = "fromf8078ad9",
                IsPrivate = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Transport = Call.Types.Transport.Sip,
                Direction = Call.Types.Direction.Incoming,
                ErrorCode = "error_code42bd958e",
                ErrorMessage = "error_messaged73952bd",
                Price = new gt::Money(),
                State = Call.Types.State.Busy,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                RingTime = new wkt::Timestamp(),
                AnswerTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                Bridged = true,
                OriginatingCall = "originating_call9e182b53",
                CreateMethod = Call.Types.CreateMethod.Api,
                Options = new Call.Types.ApiCallOptions(),
                FromLocation = new NumberLocation(),
                FromZone = "from_zone76a01c8c",
                SipCallId = "sip_call_ide9ff1d69",
                AnswerDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetCall(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CallsClient client = new CallsClientImpl(mockGrpcClient.Object, null);
            Call response = client.GetCall(request.CallName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCallResourceNamesAsync()
        {
            moq::Mock<Calls.CallsClient> mockGrpcClient = new moq::Mock<Calls.CallsClient>(moq::MockBehavior.Strict);
            GetCallRequest request = new GetCallRequest
            {
                CallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
            };
            Call expectedResponse = new Call
            {
                CallName = CallName.FromProjectCall("[PROJECT]", "[CALL]"),
                To = "to03e2b601",
                From = "fromf8078ad9",
                IsPrivate = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Transport = Call.Types.Transport.Sip,
                Direction = Call.Types.Direction.Incoming,
                ErrorCode = "error_code42bd958e",
                ErrorMessage = "error_messaged73952bd",
                Price = new gt::Money(),
                State = Call.Types.State.Busy,
                CreateTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                RingTime = new wkt::Timestamp(),
                AnswerTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                Bridged = true,
                OriginatingCall = "originating_call9e182b53",
                CreateMethod = Call.Types.CreateMethod.Api,
                Options = new Call.Types.ApiCallOptions(),
                FromLocation = new NumberLocation(),
                FromZone = "from_zone76a01c8c",
                SipCallId = "sip_call_ide9ff1d69",
                AnswerDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetCallAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Call>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CallsClient client = new CallsClientImpl(mockGrpcClient.Object, null);
            Call responseCallSettings = await client.GetCallAsync(request.CallName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Call responseCancellationToken = await client.GetCallAsync(request.CallName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
