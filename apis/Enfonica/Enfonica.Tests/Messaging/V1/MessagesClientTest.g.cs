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
using gt = Google.Type;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Enfonica.Messaging.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedMessagesClientTest
    {
        [xunit::FactAttribute]
        public void CreateMessageRequestObject()
        {
            moq::Mock<Messages.MessagesClient> mockGrpcClient = new moq::Mock<Messages.MessagesClient>(moq::MockBehavior.Strict);
            CreateMessageRequest request = new CreateMessageRequest
            {
                Parent = "parent7858e4d0",
                Message = new Message(),
            };
            Message expectedResponse = new Message
            {
                Name = "name1c9368b0",
                To = "to03e2b601",
                From = "fromf8078ad9",
                Body = "body682d1a84",
                StatusUpdateUrl = "status_update_url6240cc54",
                ReplyUrl = "reply_urla9dcb82b",
                ValidityPeriodSeconds = 1525204720,
                SmartEncoding = true,
                Direction = Message.Types.Direction.Incoming,
                ErrorCode = "error_code42bd958e",
                ErrorMessage = "error_messaged73952bd",
                SegmentCount = 45476232,
                Price = new gt::Money(),
                Status = Message.Types.Status.Sending,
                CreateIdentity = "create_identityc92d734f",
                CreateTime = new wkt::Timestamp(),
                SendTime = new wkt::Timestamp(),
                DeliverTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Classification = Message.Types.MessageClassification.Marketing,
                UnsubscribeContentBehavior = Message.Types.UnsubscribeContentBehavior.AppendUrl,
                Encoding = Message.Types.MessageEncoding.Gsm7,
            };
            mockGrpcClient.Setup(x => x.CreateMessage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MessagesClient client = new MessagesClientImpl(mockGrpcClient.Object, null);
            Message response = client.CreateMessage(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMessageRequestObjectAsync()
        {
            moq::Mock<Messages.MessagesClient> mockGrpcClient = new moq::Mock<Messages.MessagesClient>(moq::MockBehavior.Strict);
            CreateMessageRequest request = new CreateMessageRequest
            {
                Parent = "parent7858e4d0",
                Message = new Message(),
            };
            Message expectedResponse = new Message
            {
                Name = "name1c9368b0",
                To = "to03e2b601",
                From = "fromf8078ad9",
                Body = "body682d1a84",
                StatusUpdateUrl = "status_update_url6240cc54",
                ReplyUrl = "reply_urla9dcb82b",
                ValidityPeriodSeconds = 1525204720,
                SmartEncoding = true,
                Direction = Message.Types.Direction.Incoming,
                ErrorCode = "error_code42bd958e",
                ErrorMessage = "error_messaged73952bd",
                SegmentCount = 45476232,
                Price = new gt::Money(),
                Status = Message.Types.Status.Sending,
                CreateIdentity = "create_identityc92d734f",
                CreateTime = new wkt::Timestamp(),
                SendTime = new wkt::Timestamp(),
                DeliverTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Classification = Message.Types.MessageClassification.Marketing,
                UnsubscribeContentBehavior = Message.Types.UnsubscribeContentBehavior.AppendUrl,
                Encoding = Message.Types.MessageEncoding.Gsm7,
            };
            mockGrpcClient.Setup(x => x.CreateMessageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Message>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MessagesClient client = new MessagesClientImpl(mockGrpcClient.Object, null);
            Message responseCallSettings = await client.CreateMessageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Message responseCancellationToken = await client.CreateMessageAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMessageRequestObject()
        {
            moq::Mock<Messages.MessagesClient> mockGrpcClient = new moq::Mock<Messages.MessagesClient>(moq::MockBehavior.Strict);
            GetMessageRequest request = new GetMessageRequest
            {
                Name = "name1c9368b0",
            };
            Message expectedResponse = new Message
            {
                Name = "name1c9368b0",
                To = "to03e2b601",
                From = "fromf8078ad9",
                Body = "body682d1a84",
                StatusUpdateUrl = "status_update_url6240cc54",
                ReplyUrl = "reply_urla9dcb82b",
                ValidityPeriodSeconds = 1525204720,
                SmartEncoding = true,
                Direction = Message.Types.Direction.Incoming,
                ErrorCode = "error_code42bd958e",
                ErrorMessage = "error_messaged73952bd",
                SegmentCount = 45476232,
                Price = new gt::Money(),
                Status = Message.Types.Status.Sending,
                CreateIdentity = "create_identityc92d734f",
                CreateTime = new wkt::Timestamp(),
                SendTime = new wkt::Timestamp(),
                DeliverTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Classification = Message.Types.MessageClassification.Marketing,
                UnsubscribeContentBehavior = Message.Types.UnsubscribeContentBehavior.AppendUrl,
                Encoding = Message.Types.MessageEncoding.Gsm7,
            };
            mockGrpcClient.Setup(x => x.GetMessage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MessagesClient client = new MessagesClientImpl(mockGrpcClient.Object, null);
            Message response = client.GetMessage(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMessageRequestObjectAsync()
        {
            moq::Mock<Messages.MessagesClient> mockGrpcClient = new moq::Mock<Messages.MessagesClient>(moq::MockBehavior.Strict);
            GetMessageRequest request = new GetMessageRequest
            {
                Name = "name1c9368b0",
            };
            Message expectedResponse = new Message
            {
                Name = "name1c9368b0",
                To = "to03e2b601",
                From = "fromf8078ad9",
                Body = "body682d1a84",
                StatusUpdateUrl = "status_update_url6240cc54",
                ReplyUrl = "reply_urla9dcb82b",
                ValidityPeriodSeconds = 1525204720,
                SmartEncoding = true,
                Direction = Message.Types.Direction.Incoming,
                ErrorCode = "error_code42bd958e",
                ErrorMessage = "error_messaged73952bd",
                SegmentCount = 45476232,
                Price = new gt::Money(),
                Status = Message.Types.Status.Sending,
                CreateIdentity = "create_identityc92d734f",
                CreateTime = new wkt::Timestamp(),
                SendTime = new wkt::Timestamp(),
                DeliverTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Classification = Message.Types.MessageClassification.Marketing,
                UnsubscribeContentBehavior = Message.Types.UnsubscribeContentBehavior.AppendUrl,
                Encoding = Message.Types.MessageEncoding.Gsm7,
            };
            mockGrpcClient.Setup(x => x.GetMessageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Message>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MessagesClient client = new MessagesClientImpl(mockGrpcClient.Object, null);
            Message responseCallSettings = await client.GetMessageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Message responseCancellationToken = await client.GetMessageAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMessage()
        {
            moq::Mock<Messages.MessagesClient> mockGrpcClient = new moq::Mock<Messages.MessagesClient>(moq::MockBehavior.Strict);
            GetMessageRequest request = new GetMessageRequest
            {
                Name = "name1c9368b0",
            };
            Message expectedResponse = new Message
            {
                Name = "name1c9368b0",
                To = "to03e2b601",
                From = "fromf8078ad9",
                Body = "body682d1a84",
                StatusUpdateUrl = "status_update_url6240cc54",
                ReplyUrl = "reply_urla9dcb82b",
                ValidityPeriodSeconds = 1525204720,
                SmartEncoding = true,
                Direction = Message.Types.Direction.Incoming,
                ErrorCode = "error_code42bd958e",
                ErrorMessage = "error_messaged73952bd",
                SegmentCount = 45476232,
                Price = new gt::Money(),
                Status = Message.Types.Status.Sending,
                CreateIdentity = "create_identityc92d734f",
                CreateTime = new wkt::Timestamp(),
                SendTime = new wkt::Timestamp(),
                DeliverTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Classification = Message.Types.MessageClassification.Marketing,
                UnsubscribeContentBehavior = Message.Types.UnsubscribeContentBehavior.AppendUrl,
                Encoding = Message.Types.MessageEncoding.Gsm7,
            };
            mockGrpcClient.Setup(x => x.GetMessage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MessagesClient client = new MessagesClientImpl(mockGrpcClient.Object, null);
            Message response = client.GetMessage(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMessageAsync()
        {
            moq::Mock<Messages.MessagesClient> mockGrpcClient = new moq::Mock<Messages.MessagesClient>(moq::MockBehavior.Strict);
            GetMessageRequest request = new GetMessageRequest
            {
                Name = "name1c9368b0",
            };
            Message expectedResponse = new Message
            {
                Name = "name1c9368b0",
                To = "to03e2b601",
                From = "fromf8078ad9",
                Body = "body682d1a84",
                StatusUpdateUrl = "status_update_url6240cc54",
                ReplyUrl = "reply_urla9dcb82b",
                ValidityPeriodSeconds = 1525204720,
                SmartEncoding = true,
                Direction = Message.Types.Direction.Incoming,
                ErrorCode = "error_code42bd958e",
                ErrorMessage = "error_messaged73952bd",
                SegmentCount = 45476232,
                Price = new gt::Money(),
                Status = Message.Types.Status.Sending,
                CreateIdentity = "create_identityc92d734f",
                CreateTime = new wkt::Timestamp(),
                SendTime = new wkt::Timestamp(),
                DeliverTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Classification = Message.Types.MessageClassification.Marketing,
                UnsubscribeContentBehavior = Message.Types.UnsubscribeContentBehavior.AppendUrl,
                Encoding = Message.Types.MessageEncoding.Gsm7,
            };
            mockGrpcClient.Setup(x => x.GetMessageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Message>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MessagesClient client = new MessagesClientImpl(mockGrpcClient.Object, null);
            Message responseCallSettings = await client.GetMessageAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Message responseCancellationToken = await client.GetMessageAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
