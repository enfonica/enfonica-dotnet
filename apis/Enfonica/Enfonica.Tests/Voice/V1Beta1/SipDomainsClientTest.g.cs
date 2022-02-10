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
    public sealed class GeneratedSipDomainsClientTest
    {
        [xunit::FactAttribute]
        public void CreateSipDomainRequestObject()
        {
            moq::Mock<SipDomains.SipDomainsClient> mockGrpcClient = new moq::Mock<SipDomains.SipDomainsClient>(moq::MockBehavior.Strict);
            CreateSipDomainRequest request = new CreateSipDomainRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                SipDomain = new SipDomain(),
                SipDomainId = "sip_domain_id8fe839a5",
            };
            SipDomain expectedResponse = new SipDomain
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                SipDomainId = "sip_domain_id8fe839a5",
                DisplayName = "display_name137f65c2",
                AllowRegister = true,
                CallTerminationMode = SipDomain.Types.TerminationMode.Programmable,
                CallTerminationHandlerUris =
                {
                    "call_termination_handler_uris0a68dfbe",
                },
                CidrBlocks = { new CidrBlock(), },
                CallRecording = new CallRecordingConfig(),
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateSipDomain(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SipDomainsClient client = new SipDomainsClientImpl(mockGrpcClient.Object, null);
            SipDomain response = client.CreateSipDomain(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSipDomainRequestObjectAsync()
        {
            moq::Mock<SipDomains.SipDomainsClient> mockGrpcClient = new moq::Mock<SipDomains.SipDomainsClient>(moq::MockBehavior.Strict);
            CreateSipDomainRequest request = new CreateSipDomainRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                SipDomain = new SipDomain(),
                SipDomainId = "sip_domain_id8fe839a5",
            };
            SipDomain expectedResponse = new SipDomain
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                SipDomainId = "sip_domain_id8fe839a5",
                DisplayName = "display_name137f65c2",
                AllowRegister = true,
                CallTerminationMode = SipDomain.Types.TerminationMode.Programmable,
                CallTerminationHandlerUris =
                {
                    "call_termination_handler_uris0a68dfbe",
                },
                CidrBlocks = { new CidrBlock(), },
                CallRecording = new CallRecordingConfig(),
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateSipDomainAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SipDomain>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SipDomainsClient client = new SipDomainsClientImpl(mockGrpcClient.Object, null);
            SipDomain responseCallSettings = await client.CreateSipDomainAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SipDomain responseCancellationToken = await client.CreateSipDomainAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSipDomain()
        {
            moq::Mock<SipDomains.SipDomainsClient> mockGrpcClient = new moq::Mock<SipDomains.SipDomainsClient>(moq::MockBehavior.Strict);
            CreateSipDomainRequest request = new CreateSipDomainRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                SipDomain = new SipDomain(),
                SipDomainId = "sip_domain_id8fe839a5",
            };
            SipDomain expectedResponse = new SipDomain
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                SipDomainId = "sip_domain_id8fe839a5",
                DisplayName = "display_name137f65c2",
                AllowRegister = true,
                CallTerminationMode = SipDomain.Types.TerminationMode.Programmable,
                CallTerminationHandlerUris =
                {
                    "call_termination_handler_uris0a68dfbe",
                },
                CidrBlocks = { new CidrBlock(), },
                CallRecording = new CallRecordingConfig(),
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateSipDomain(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SipDomainsClient client = new SipDomainsClientImpl(mockGrpcClient.Object, null);
            SipDomain response = client.CreateSipDomain(request.Parent, request.SipDomain, request.SipDomainId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSipDomainAsync()
        {
            moq::Mock<SipDomains.SipDomainsClient> mockGrpcClient = new moq::Mock<SipDomains.SipDomainsClient>(moq::MockBehavior.Strict);
            CreateSipDomainRequest request = new CreateSipDomainRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                SipDomain = new SipDomain(),
                SipDomainId = "sip_domain_id8fe839a5",
            };
            SipDomain expectedResponse = new SipDomain
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                SipDomainId = "sip_domain_id8fe839a5",
                DisplayName = "display_name137f65c2",
                AllowRegister = true,
                CallTerminationMode = SipDomain.Types.TerminationMode.Programmable,
                CallTerminationHandlerUris =
                {
                    "call_termination_handler_uris0a68dfbe",
                },
                CidrBlocks = { new CidrBlock(), },
                CallRecording = new CallRecordingConfig(),
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateSipDomainAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SipDomain>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SipDomainsClient client = new SipDomainsClientImpl(mockGrpcClient.Object, null);
            SipDomain responseCallSettings = await client.CreateSipDomainAsync(request.Parent, request.SipDomain, request.SipDomainId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SipDomain responseCancellationToken = await client.CreateSipDomainAsync(request.Parent, request.SipDomain, request.SipDomainId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSipDomainResourceNames()
        {
            moq::Mock<SipDomains.SipDomainsClient> mockGrpcClient = new moq::Mock<SipDomains.SipDomainsClient>(moq::MockBehavior.Strict);
            CreateSipDomainRequest request = new CreateSipDomainRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                SipDomain = new SipDomain(),
                SipDomainId = "sip_domain_id8fe839a5",
            };
            SipDomain expectedResponse = new SipDomain
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                SipDomainId = "sip_domain_id8fe839a5",
                DisplayName = "display_name137f65c2",
                AllowRegister = true,
                CallTerminationMode = SipDomain.Types.TerminationMode.Programmable,
                CallTerminationHandlerUris =
                {
                    "call_termination_handler_uris0a68dfbe",
                },
                CidrBlocks = { new CidrBlock(), },
                CallRecording = new CallRecordingConfig(),
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateSipDomain(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SipDomainsClient client = new SipDomainsClientImpl(mockGrpcClient.Object, null);
            SipDomain response = client.CreateSipDomain(request.ParentAsProjectName, request.SipDomain, request.SipDomainId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSipDomainResourceNamesAsync()
        {
            moq::Mock<SipDomains.SipDomainsClient> mockGrpcClient = new moq::Mock<SipDomains.SipDomainsClient>(moq::MockBehavior.Strict);
            CreateSipDomainRequest request = new CreateSipDomainRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                SipDomain = new SipDomain(),
                SipDomainId = "sip_domain_id8fe839a5",
            };
            SipDomain expectedResponse = new SipDomain
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                SipDomainId = "sip_domain_id8fe839a5",
                DisplayName = "display_name137f65c2",
                AllowRegister = true,
                CallTerminationMode = SipDomain.Types.TerminationMode.Programmable,
                CallTerminationHandlerUris =
                {
                    "call_termination_handler_uris0a68dfbe",
                },
                CidrBlocks = { new CidrBlock(), },
                CallRecording = new CallRecordingConfig(),
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateSipDomainAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SipDomain>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SipDomainsClient client = new SipDomainsClientImpl(mockGrpcClient.Object, null);
            SipDomain responseCallSettings = await client.CreateSipDomainAsync(request.ParentAsProjectName, request.SipDomain, request.SipDomainId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SipDomain responseCancellationToken = await client.CreateSipDomainAsync(request.ParentAsProjectName, request.SipDomain, request.SipDomainId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSipDomainRequestObject()
        {
            moq::Mock<SipDomains.SipDomainsClient> mockGrpcClient = new moq::Mock<SipDomains.SipDomainsClient>(moq::MockBehavior.Strict);
            GetSipDomainRequest request = new GetSipDomainRequest
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
            };
            SipDomain expectedResponse = new SipDomain
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                SipDomainId = "sip_domain_id8fe839a5",
                DisplayName = "display_name137f65c2",
                AllowRegister = true,
                CallTerminationMode = SipDomain.Types.TerminationMode.Programmable,
                CallTerminationHandlerUris =
                {
                    "call_termination_handler_uris0a68dfbe",
                },
                CidrBlocks = { new CidrBlock(), },
                CallRecording = new CallRecordingConfig(),
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetSipDomain(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SipDomainsClient client = new SipDomainsClientImpl(mockGrpcClient.Object, null);
            SipDomain response = client.GetSipDomain(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSipDomainRequestObjectAsync()
        {
            moq::Mock<SipDomains.SipDomainsClient> mockGrpcClient = new moq::Mock<SipDomains.SipDomainsClient>(moq::MockBehavior.Strict);
            GetSipDomainRequest request = new GetSipDomainRequest
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
            };
            SipDomain expectedResponse = new SipDomain
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                SipDomainId = "sip_domain_id8fe839a5",
                DisplayName = "display_name137f65c2",
                AllowRegister = true,
                CallTerminationMode = SipDomain.Types.TerminationMode.Programmable,
                CallTerminationHandlerUris =
                {
                    "call_termination_handler_uris0a68dfbe",
                },
                CidrBlocks = { new CidrBlock(), },
                CallRecording = new CallRecordingConfig(),
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetSipDomainAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SipDomain>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SipDomainsClient client = new SipDomainsClientImpl(mockGrpcClient.Object, null);
            SipDomain responseCallSettings = await client.GetSipDomainAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SipDomain responseCancellationToken = await client.GetSipDomainAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSipDomain()
        {
            moq::Mock<SipDomains.SipDomainsClient> mockGrpcClient = new moq::Mock<SipDomains.SipDomainsClient>(moq::MockBehavior.Strict);
            GetSipDomainRequest request = new GetSipDomainRequest
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
            };
            SipDomain expectedResponse = new SipDomain
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                SipDomainId = "sip_domain_id8fe839a5",
                DisplayName = "display_name137f65c2",
                AllowRegister = true,
                CallTerminationMode = SipDomain.Types.TerminationMode.Programmable,
                CallTerminationHandlerUris =
                {
                    "call_termination_handler_uris0a68dfbe",
                },
                CidrBlocks = { new CidrBlock(), },
                CallRecording = new CallRecordingConfig(),
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetSipDomain(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SipDomainsClient client = new SipDomainsClientImpl(mockGrpcClient.Object, null);
            SipDomain response = client.GetSipDomain(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSipDomainAsync()
        {
            moq::Mock<SipDomains.SipDomainsClient> mockGrpcClient = new moq::Mock<SipDomains.SipDomainsClient>(moq::MockBehavior.Strict);
            GetSipDomainRequest request = new GetSipDomainRequest
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
            };
            SipDomain expectedResponse = new SipDomain
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                SipDomainId = "sip_domain_id8fe839a5",
                DisplayName = "display_name137f65c2",
                AllowRegister = true,
                CallTerminationMode = SipDomain.Types.TerminationMode.Programmable,
                CallTerminationHandlerUris =
                {
                    "call_termination_handler_uris0a68dfbe",
                },
                CidrBlocks = { new CidrBlock(), },
                CallRecording = new CallRecordingConfig(),
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetSipDomainAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SipDomain>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SipDomainsClient client = new SipDomainsClientImpl(mockGrpcClient.Object, null);
            SipDomain responseCallSettings = await client.GetSipDomainAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SipDomain responseCancellationToken = await client.GetSipDomainAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSipDomainResourceNames()
        {
            moq::Mock<SipDomains.SipDomainsClient> mockGrpcClient = new moq::Mock<SipDomains.SipDomainsClient>(moq::MockBehavior.Strict);
            GetSipDomainRequest request = new GetSipDomainRequest
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
            };
            SipDomain expectedResponse = new SipDomain
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                SipDomainId = "sip_domain_id8fe839a5",
                DisplayName = "display_name137f65c2",
                AllowRegister = true,
                CallTerminationMode = SipDomain.Types.TerminationMode.Programmable,
                CallTerminationHandlerUris =
                {
                    "call_termination_handler_uris0a68dfbe",
                },
                CidrBlocks = { new CidrBlock(), },
                CallRecording = new CallRecordingConfig(),
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetSipDomain(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SipDomainsClient client = new SipDomainsClientImpl(mockGrpcClient.Object, null);
            SipDomain response = client.GetSipDomain(request.SipDomainName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSipDomainResourceNamesAsync()
        {
            moq::Mock<SipDomains.SipDomainsClient> mockGrpcClient = new moq::Mock<SipDomains.SipDomainsClient>(moq::MockBehavior.Strict);
            GetSipDomainRequest request = new GetSipDomainRequest
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
            };
            SipDomain expectedResponse = new SipDomain
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                SipDomainId = "sip_domain_id8fe839a5",
                DisplayName = "display_name137f65c2",
                AllowRegister = true,
                CallTerminationMode = SipDomain.Types.TerminationMode.Programmable,
                CallTerminationHandlerUris =
                {
                    "call_termination_handler_uris0a68dfbe",
                },
                CidrBlocks = { new CidrBlock(), },
                CallRecording = new CallRecordingConfig(),
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetSipDomainAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SipDomain>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SipDomainsClient client = new SipDomainsClientImpl(mockGrpcClient.Object, null);
            SipDomain responseCallSettings = await client.GetSipDomainAsync(request.SipDomainName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SipDomain responseCancellationToken = await client.GetSipDomainAsync(request.SipDomainName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSipDomainRequestObject()
        {
            moq::Mock<SipDomains.SipDomainsClient> mockGrpcClient = new moq::Mock<SipDomains.SipDomainsClient>(moq::MockBehavior.Strict);
            UpdateSipDomainRequest request = new UpdateSipDomainRequest
            {
                SipDomain = new SipDomain(),
                UpdateMask = new wkt::FieldMask(),
            };
            SipDomain expectedResponse = new SipDomain
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                SipDomainId = "sip_domain_id8fe839a5",
                DisplayName = "display_name137f65c2",
                AllowRegister = true,
                CallTerminationMode = SipDomain.Types.TerminationMode.Programmable,
                CallTerminationHandlerUris =
                {
                    "call_termination_handler_uris0a68dfbe",
                },
                CidrBlocks = { new CidrBlock(), },
                CallRecording = new CallRecordingConfig(),
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateSipDomain(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SipDomainsClient client = new SipDomainsClientImpl(mockGrpcClient.Object, null);
            SipDomain response = client.UpdateSipDomain(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSipDomainRequestObjectAsync()
        {
            moq::Mock<SipDomains.SipDomainsClient> mockGrpcClient = new moq::Mock<SipDomains.SipDomainsClient>(moq::MockBehavior.Strict);
            UpdateSipDomainRequest request = new UpdateSipDomainRequest
            {
                SipDomain = new SipDomain(),
                UpdateMask = new wkt::FieldMask(),
            };
            SipDomain expectedResponse = new SipDomain
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                SipDomainId = "sip_domain_id8fe839a5",
                DisplayName = "display_name137f65c2",
                AllowRegister = true,
                CallTerminationMode = SipDomain.Types.TerminationMode.Programmable,
                CallTerminationHandlerUris =
                {
                    "call_termination_handler_uris0a68dfbe",
                },
                CidrBlocks = { new CidrBlock(), },
                CallRecording = new CallRecordingConfig(),
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateSipDomainAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SipDomain>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SipDomainsClient client = new SipDomainsClientImpl(mockGrpcClient.Object, null);
            SipDomain responseCallSettings = await client.UpdateSipDomainAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SipDomain responseCancellationToken = await client.UpdateSipDomainAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSipDomain()
        {
            moq::Mock<SipDomains.SipDomainsClient> mockGrpcClient = new moq::Mock<SipDomains.SipDomainsClient>(moq::MockBehavior.Strict);
            UpdateSipDomainRequest request = new UpdateSipDomainRequest
            {
                SipDomain = new SipDomain(),
                UpdateMask = new wkt::FieldMask(),
            };
            SipDomain expectedResponse = new SipDomain
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                SipDomainId = "sip_domain_id8fe839a5",
                DisplayName = "display_name137f65c2",
                AllowRegister = true,
                CallTerminationMode = SipDomain.Types.TerminationMode.Programmable,
                CallTerminationHandlerUris =
                {
                    "call_termination_handler_uris0a68dfbe",
                },
                CidrBlocks = { new CidrBlock(), },
                CallRecording = new CallRecordingConfig(),
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateSipDomain(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SipDomainsClient client = new SipDomainsClientImpl(mockGrpcClient.Object, null);
            SipDomain response = client.UpdateSipDomain(request.SipDomain, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSipDomainAsync()
        {
            moq::Mock<SipDomains.SipDomainsClient> mockGrpcClient = new moq::Mock<SipDomains.SipDomainsClient>(moq::MockBehavior.Strict);
            UpdateSipDomainRequest request = new UpdateSipDomainRequest
            {
                SipDomain = new SipDomain(),
                UpdateMask = new wkt::FieldMask(),
            };
            SipDomain expectedResponse = new SipDomain
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                SipDomainId = "sip_domain_id8fe839a5",
                DisplayName = "display_name137f65c2",
                AllowRegister = true,
                CallTerminationMode = SipDomain.Types.TerminationMode.Programmable,
                CallTerminationHandlerUris =
                {
                    "call_termination_handler_uris0a68dfbe",
                },
                CidrBlocks = { new CidrBlock(), },
                CallRecording = new CallRecordingConfig(),
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateSipDomainAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SipDomain>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SipDomainsClient client = new SipDomainsClientImpl(mockGrpcClient.Object, null);
            SipDomain responseCallSettings = await client.UpdateSipDomainAsync(request.SipDomain, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SipDomain responseCancellationToken = await client.UpdateSipDomainAsync(request.SipDomain, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSipDomainRequestObject()
        {
            moq::Mock<SipDomains.SipDomainsClient> mockGrpcClient = new moq::Mock<SipDomains.SipDomainsClient>(moq::MockBehavior.Strict);
            DeleteSipDomainRequest request = new DeleteSipDomainRequest
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
            };
            SipDomain expectedResponse = new SipDomain
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                SipDomainId = "sip_domain_id8fe839a5",
                DisplayName = "display_name137f65c2",
                AllowRegister = true,
                CallTerminationMode = SipDomain.Types.TerminationMode.Programmable,
                CallTerminationHandlerUris =
                {
                    "call_termination_handler_uris0a68dfbe",
                },
                CidrBlocks = { new CidrBlock(), },
                CallRecording = new CallRecordingConfig(),
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.DeleteSipDomain(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SipDomainsClient client = new SipDomainsClientImpl(mockGrpcClient.Object, null);
            SipDomain response = client.DeleteSipDomain(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSipDomainRequestObjectAsync()
        {
            moq::Mock<SipDomains.SipDomainsClient> mockGrpcClient = new moq::Mock<SipDomains.SipDomainsClient>(moq::MockBehavior.Strict);
            DeleteSipDomainRequest request = new DeleteSipDomainRequest
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
            };
            SipDomain expectedResponse = new SipDomain
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                SipDomainId = "sip_domain_id8fe839a5",
                DisplayName = "display_name137f65c2",
                AllowRegister = true,
                CallTerminationMode = SipDomain.Types.TerminationMode.Programmable,
                CallTerminationHandlerUris =
                {
                    "call_termination_handler_uris0a68dfbe",
                },
                CidrBlocks = { new CidrBlock(), },
                CallRecording = new CallRecordingConfig(),
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.DeleteSipDomainAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SipDomain>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SipDomainsClient client = new SipDomainsClientImpl(mockGrpcClient.Object, null);
            SipDomain responseCallSettings = await client.DeleteSipDomainAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SipDomain responseCancellationToken = await client.DeleteSipDomainAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSipDomain()
        {
            moq::Mock<SipDomains.SipDomainsClient> mockGrpcClient = new moq::Mock<SipDomains.SipDomainsClient>(moq::MockBehavior.Strict);
            DeleteSipDomainRequest request = new DeleteSipDomainRequest
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
            };
            SipDomain expectedResponse = new SipDomain
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                SipDomainId = "sip_domain_id8fe839a5",
                DisplayName = "display_name137f65c2",
                AllowRegister = true,
                CallTerminationMode = SipDomain.Types.TerminationMode.Programmable,
                CallTerminationHandlerUris =
                {
                    "call_termination_handler_uris0a68dfbe",
                },
                CidrBlocks = { new CidrBlock(), },
                CallRecording = new CallRecordingConfig(),
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.DeleteSipDomain(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SipDomainsClient client = new SipDomainsClientImpl(mockGrpcClient.Object, null);
            SipDomain response = client.DeleteSipDomain(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSipDomainAsync()
        {
            moq::Mock<SipDomains.SipDomainsClient> mockGrpcClient = new moq::Mock<SipDomains.SipDomainsClient>(moq::MockBehavior.Strict);
            DeleteSipDomainRequest request = new DeleteSipDomainRequest
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
            };
            SipDomain expectedResponse = new SipDomain
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                SipDomainId = "sip_domain_id8fe839a5",
                DisplayName = "display_name137f65c2",
                AllowRegister = true,
                CallTerminationMode = SipDomain.Types.TerminationMode.Programmable,
                CallTerminationHandlerUris =
                {
                    "call_termination_handler_uris0a68dfbe",
                },
                CidrBlocks = { new CidrBlock(), },
                CallRecording = new CallRecordingConfig(),
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.DeleteSipDomainAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SipDomain>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SipDomainsClient client = new SipDomainsClientImpl(mockGrpcClient.Object, null);
            SipDomain responseCallSettings = await client.DeleteSipDomainAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SipDomain responseCancellationToken = await client.DeleteSipDomainAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSipDomainResourceNames()
        {
            moq::Mock<SipDomains.SipDomainsClient> mockGrpcClient = new moq::Mock<SipDomains.SipDomainsClient>(moq::MockBehavior.Strict);
            DeleteSipDomainRequest request = new DeleteSipDomainRequest
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
            };
            SipDomain expectedResponse = new SipDomain
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                SipDomainId = "sip_domain_id8fe839a5",
                DisplayName = "display_name137f65c2",
                AllowRegister = true,
                CallTerminationMode = SipDomain.Types.TerminationMode.Programmable,
                CallTerminationHandlerUris =
                {
                    "call_termination_handler_uris0a68dfbe",
                },
                CidrBlocks = { new CidrBlock(), },
                CallRecording = new CallRecordingConfig(),
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.DeleteSipDomain(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SipDomainsClient client = new SipDomainsClientImpl(mockGrpcClient.Object, null);
            SipDomain response = client.DeleteSipDomain(request.SipDomainName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSipDomainResourceNamesAsync()
        {
            moq::Mock<SipDomains.SipDomainsClient> mockGrpcClient = new moq::Mock<SipDomains.SipDomainsClient>(moq::MockBehavior.Strict);
            DeleteSipDomainRequest request = new DeleteSipDomainRequest
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
            };
            SipDomain expectedResponse = new SipDomain
            {
                SipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                SipDomainId = "sip_domain_id8fe839a5",
                DisplayName = "display_name137f65c2",
                AllowRegister = true,
                CallTerminationMode = SipDomain.Types.TerminationMode.Programmable,
                CallTerminationHandlerUris =
                {
                    "call_termination_handler_uris0a68dfbe",
                },
                CidrBlocks = { new CidrBlock(), },
                CallRecording = new CallRecordingConfig(),
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.DeleteSipDomainAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SipDomain>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SipDomainsClient client = new SipDomainsClientImpl(mockGrpcClient.Object, null);
            SipDomain responseCallSettings = await client.DeleteSipDomainAsync(request.SipDomainName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SipDomain responseCancellationToken = await client.DeleteSipDomainAsync(request.SipDomainName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
