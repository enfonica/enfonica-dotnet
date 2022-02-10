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
    public sealed class GeneratedAliasesClientTest
    {
        [xunit::FactAttribute]
        public void CreateAliasRequestObject()
        {
            moq::Mock<Aliases.AliasesClient> mockGrpcClient = new moq::Mock<Aliases.AliasesClient>(moq::MockBehavior.Strict);
            CreateAliasRequest request = new CreateAliasRequest
            {
                ParentAsSipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                Alias = new Alias(),
                AliasId = "alias_id3e822e7c",
            };
            Alias expectedResponse = new Alias
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
                AliasId = "alias_id3e822e7c",
                DisplayName = "display_name137f65c2",
                LoadBalancerConfig = new LoadBalancerConfig(),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateAlias(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AliasesClient client = new AliasesClientImpl(mockGrpcClient.Object, null);
            Alias response = client.CreateAlias(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAliasRequestObjectAsync()
        {
            moq::Mock<Aliases.AliasesClient> mockGrpcClient = new moq::Mock<Aliases.AliasesClient>(moq::MockBehavior.Strict);
            CreateAliasRequest request = new CreateAliasRequest
            {
                ParentAsSipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                Alias = new Alias(),
                AliasId = "alias_id3e822e7c",
            };
            Alias expectedResponse = new Alias
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
                AliasId = "alias_id3e822e7c",
                DisplayName = "display_name137f65c2",
                LoadBalancerConfig = new LoadBalancerConfig(),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateAliasAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Alias>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AliasesClient client = new AliasesClientImpl(mockGrpcClient.Object, null);
            Alias responseCallSettings = await client.CreateAliasAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Alias responseCancellationToken = await client.CreateAliasAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAlias()
        {
            moq::Mock<Aliases.AliasesClient> mockGrpcClient = new moq::Mock<Aliases.AliasesClient>(moq::MockBehavior.Strict);
            CreateAliasRequest request = new CreateAliasRequest
            {
                ParentAsSipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                Alias = new Alias(),
                AliasId = "alias_id3e822e7c",
            };
            Alias expectedResponse = new Alias
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
                AliasId = "alias_id3e822e7c",
                DisplayName = "display_name137f65c2",
                LoadBalancerConfig = new LoadBalancerConfig(),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateAlias(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AliasesClient client = new AliasesClientImpl(mockGrpcClient.Object, null);
            Alias response = client.CreateAlias(request.Parent, request.Alias, request.AliasId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAliasAsync()
        {
            moq::Mock<Aliases.AliasesClient> mockGrpcClient = new moq::Mock<Aliases.AliasesClient>(moq::MockBehavior.Strict);
            CreateAliasRequest request = new CreateAliasRequest
            {
                ParentAsSipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                Alias = new Alias(),
                AliasId = "alias_id3e822e7c",
            };
            Alias expectedResponse = new Alias
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
                AliasId = "alias_id3e822e7c",
                DisplayName = "display_name137f65c2",
                LoadBalancerConfig = new LoadBalancerConfig(),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateAliasAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Alias>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AliasesClient client = new AliasesClientImpl(mockGrpcClient.Object, null);
            Alias responseCallSettings = await client.CreateAliasAsync(request.Parent, request.Alias, request.AliasId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Alias responseCancellationToken = await client.CreateAliasAsync(request.Parent, request.Alias, request.AliasId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAliasResourceNames()
        {
            moq::Mock<Aliases.AliasesClient> mockGrpcClient = new moq::Mock<Aliases.AliasesClient>(moq::MockBehavior.Strict);
            CreateAliasRequest request = new CreateAliasRequest
            {
                ParentAsSipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                Alias = new Alias(),
                AliasId = "alias_id3e822e7c",
            };
            Alias expectedResponse = new Alias
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
                AliasId = "alias_id3e822e7c",
                DisplayName = "display_name137f65c2",
                LoadBalancerConfig = new LoadBalancerConfig(),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateAlias(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AliasesClient client = new AliasesClientImpl(mockGrpcClient.Object, null);
            Alias response = client.CreateAlias(request.ParentAsSipDomainName, request.Alias, request.AliasId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAliasResourceNamesAsync()
        {
            moq::Mock<Aliases.AliasesClient> mockGrpcClient = new moq::Mock<Aliases.AliasesClient>(moq::MockBehavior.Strict);
            CreateAliasRequest request = new CreateAliasRequest
            {
                ParentAsSipDomainName = SipDomainName.FromProjectSipDomain("[PROJECT]", "[SIP_DOMAIN]"),
                Alias = new Alias(),
                AliasId = "alias_id3e822e7c",
            };
            Alias expectedResponse = new Alias
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
                AliasId = "alias_id3e822e7c",
                DisplayName = "display_name137f65c2",
                LoadBalancerConfig = new LoadBalancerConfig(),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateAliasAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Alias>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AliasesClient client = new AliasesClientImpl(mockGrpcClient.Object, null);
            Alias responseCallSettings = await client.CreateAliasAsync(request.ParentAsSipDomainName, request.Alias, request.AliasId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Alias responseCancellationToken = await client.CreateAliasAsync(request.ParentAsSipDomainName, request.Alias, request.AliasId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAliasRequestObject()
        {
            moq::Mock<Aliases.AliasesClient> mockGrpcClient = new moq::Mock<Aliases.AliasesClient>(moq::MockBehavior.Strict);
            GetAliasRequest request = new GetAliasRequest
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
            };
            Alias expectedResponse = new Alias
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
                AliasId = "alias_id3e822e7c",
                DisplayName = "display_name137f65c2",
                LoadBalancerConfig = new LoadBalancerConfig(),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetAlias(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AliasesClient client = new AliasesClientImpl(mockGrpcClient.Object, null);
            Alias response = client.GetAlias(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAliasRequestObjectAsync()
        {
            moq::Mock<Aliases.AliasesClient> mockGrpcClient = new moq::Mock<Aliases.AliasesClient>(moq::MockBehavior.Strict);
            GetAliasRequest request = new GetAliasRequest
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
            };
            Alias expectedResponse = new Alias
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
                AliasId = "alias_id3e822e7c",
                DisplayName = "display_name137f65c2",
                LoadBalancerConfig = new LoadBalancerConfig(),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetAliasAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Alias>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AliasesClient client = new AliasesClientImpl(mockGrpcClient.Object, null);
            Alias responseCallSettings = await client.GetAliasAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Alias responseCancellationToken = await client.GetAliasAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAlias()
        {
            moq::Mock<Aliases.AliasesClient> mockGrpcClient = new moq::Mock<Aliases.AliasesClient>(moq::MockBehavior.Strict);
            GetAliasRequest request = new GetAliasRequest
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
            };
            Alias expectedResponse = new Alias
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
                AliasId = "alias_id3e822e7c",
                DisplayName = "display_name137f65c2",
                LoadBalancerConfig = new LoadBalancerConfig(),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetAlias(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AliasesClient client = new AliasesClientImpl(mockGrpcClient.Object, null);
            Alias response = client.GetAlias(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAliasAsync()
        {
            moq::Mock<Aliases.AliasesClient> mockGrpcClient = new moq::Mock<Aliases.AliasesClient>(moq::MockBehavior.Strict);
            GetAliasRequest request = new GetAliasRequest
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
            };
            Alias expectedResponse = new Alias
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
                AliasId = "alias_id3e822e7c",
                DisplayName = "display_name137f65c2",
                LoadBalancerConfig = new LoadBalancerConfig(),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetAliasAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Alias>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AliasesClient client = new AliasesClientImpl(mockGrpcClient.Object, null);
            Alias responseCallSettings = await client.GetAliasAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Alias responseCancellationToken = await client.GetAliasAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAliasResourceNames()
        {
            moq::Mock<Aliases.AliasesClient> mockGrpcClient = new moq::Mock<Aliases.AliasesClient>(moq::MockBehavior.Strict);
            GetAliasRequest request = new GetAliasRequest
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
            };
            Alias expectedResponse = new Alias
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
                AliasId = "alias_id3e822e7c",
                DisplayName = "display_name137f65c2",
                LoadBalancerConfig = new LoadBalancerConfig(),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetAlias(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AliasesClient client = new AliasesClientImpl(mockGrpcClient.Object, null);
            Alias response = client.GetAlias(request.AliasName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAliasResourceNamesAsync()
        {
            moq::Mock<Aliases.AliasesClient> mockGrpcClient = new moq::Mock<Aliases.AliasesClient>(moq::MockBehavior.Strict);
            GetAliasRequest request = new GetAliasRequest
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
            };
            Alias expectedResponse = new Alias
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
                AliasId = "alias_id3e822e7c",
                DisplayName = "display_name137f65c2",
                LoadBalancerConfig = new LoadBalancerConfig(),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetAliasAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Alias>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AliasesClient client = new AliasesClientImpl(mockGrpcClient.Object, null);
            Alias responseCallSettings = await client.GetAliasAsync(request.AliasName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Alias responseCancellationToken = await client.GetAliasAsync(request.AliasName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateAliasRequestObject()
        {
            moq::Mock<Aliases.AliasesClient> mockGrpcClient = new moq::Mock<Aliases.AliasesClient>(moq::MockBehavior.Strict);
            UpdateAliasRequest request = new UpdateAliasRequest
            {
                Alias = new Alias(),
                UpdateMask = new wkt::FieldMask(),
            };
            Alias expectedResponse = new Alias
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
                AliasId = "alias_id3e822e7c",
                DisplayName = "display_name137f65c2",
                LoadBalancerConfig = new LoadBalancerConfig(),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateAlias(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AliasesClient client = new AliasesClientImpl(mockGrpcClient.Object, null);
            Alias response = client.UpdateAlias(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAliasRequestObjectAsync()
        {
            moq::Mock<Aliases.AliasesClient> mockGrpcClient = new moq::Mock<Aliases.AliasesClient>(moq::MockBehavior.Strict);
            UpdateAliasRequest request = new UpdateAliasRequest
            {
                Alias = new Alias(),
                UpdateMask = new wkt::FieldMask(),
            };
            Alias expectedResponse = new Alias
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
                AliasId = "alias_id3e822e7c",
                DisplayName = "display_name137f65c2",
                LoadBalancerConfig = new LoadBalancerConfig(),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateAliasAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Alias>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AliasesClient client = new AliasesClientImpl(mockGrpcClient.Object, null);
            Alias responseCallSettings = await client.UpdateAliasAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Alias responseCancellationToken = await client.UpdateAliasAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateAlias()
        {
            moq::Mock<Aliases.AliasesClient> mockGrpcClient = new moq::Mock<Aliases.AliasesClient>(moq::MockBehavior.Strict);
            UpdateAliasRequest request = new UpdateAliasRequest
            {
                Alias = new Alias(),
                UpdateMask = new wkt::FieldMask(),
            };
            Alias expectedResponse = new Alias
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
                AliasId = "alias_id3e822e7c",
                DisplayName = "display_name137f65c2",
                LoadBalancerConfig = new LoadBalancerConfig(),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateAlias(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AliasesClient client = new AliasesClientImpl(mockGrpcClient.Object, null);
            Alias response = client.UpdateAlias(request.Alias, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAliasAsync()
        {
            moq::Mock<Aliases.AliasesClient> mockGrpcClient = new moq::Mock<Aliases.AliasesClient>(moq::MockBehavior.Strict);
            UpdateAliasRequest request = new UpdateAliasRequest
            {
                Alias = new Alias(),
                UpdateMask = new wkt::FieldMask(),
            };
            Alias expectedResponse = new Alias
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
                AliasId = "alias_id3e822e7c",
                DisplayName = "display_name137f65c2",
                LoadBalancerConfig = new LoadBalancerConfig(),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateAliasAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Alias>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AliasesClient client = new AliasesClientImpl(mockGrpcClient.Object, null);
            Alias responseCallSettings = await client.UpdateAliasAsync(request.Alias, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Alias responseCancellationToken = await client.UpdateAliasAsync(request.Alias, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAliasRequestObject()
        {
            moq::Mock<Aliases.AliasesClient> mockGrpcClient = new moq::Mock<Aliases.AliasesClient>(moq::MockBehavior.Strict);
            DeleteAliasRequest request = new DeleteAliasRequest
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAlias(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AliasesClient client = new AliasesClientImpl(mockGrpcClient.Object, null);
            client.DeleteAlias(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAliasRequestObjectAsync()
        {
            moq::Mock<Aliases.AliasesClient> mockGrpcClient = new moq::Mock<Aliases.AliasesClient>(moq::MockBehavior.Strict);
            DeleteAliasRequest request = new DeleteAliasRequest
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAliasAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AliasesClient client = new AliasesClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAliasAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAliasAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAlias()
        {
            moq::Mock<Aliases.AliasesClient> mockGrpcClient = new moq::Mock<Aliases.AliasesClient>(moq::MockBehavior.Strict);
            DeleteAliasRequest request = new DeleteAliasRequest
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAlias(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AliasesClient client = new AliasesClientImpl(mockGrpcClient.Object, null);
            client.DeleteAlias(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAliasAsync()
        {
            moq::Mock<Aliases.AliasesClient> mockGrpcClient = new moq::Mock<Aliases.AliasesClient>(moq::MockBehavior.Strict);
            DeleteAliasRequest request = new DeleteAliasRequest
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAliasAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AliasesClient client = new AliasesClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAliasAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAliasAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAliasResourceNames()
        {
            moq::Mock<Aliases.AliasesClient> mockGrpcClient = new moq::Mock<Aliases.AliasesClient>(moq::MockBehavior.Strict);
            DeleteAliasRequest request = new DeleteAliasRequest
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAlias(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AliasesClient client = new AliasesClientImpl(mockGrpcClient.Object, null);
            client.DeleteAlias(request.AliasName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAliasResourceNamesAsync()
        {
            moq::Mock<Aliases.AliasesClient> mockGrpcClient = new moq::Mock<Aliases.AliasesClient>(moq::MockBehavior.Strict);
            DeleteAliasRequest request = new DeleteAliasRequest
            {
                AliasName = AliasName.FromProjectSipDomainAlias("[PROJECT]", "[SIP_DOMAIN]", "[ALIAS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAliasAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AliasesClient client = new AliasesClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAliasAsync(request.AliasName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAliasAsync(request.AliasName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
