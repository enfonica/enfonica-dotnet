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

namespace Enfonica.Numbering.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedRegulatoryListingsClientTest
    {
        [xunit::FactAttribute]
        public void CreateRegulatoryListingRequestObject()
        {
            moq::Mock<RegulatoryListings.RegulatoryListingsClient> mockGrpcClient = new moq::Mock<RegulatoryListings.RegulatoryListingsClient>(moq::MockBehavior.Strict);
            CreateRegulatoryListingRequest request = new CreateRegulatoryListingRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                RegulatoryListing = new RegulatoryListing(),
            };
            RegulatoryListing expectedResponse = new RegulatoryListing
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
                DisplayName = "display_name137f65c2",
                Address = new GenericAddress(),
                Person = new PersonDetails(),
                Business = new BusinessDetails(),
                CreateTime = new wkt::Timestamp(),
                Valid = false,
                Verified = true,
            };
            mockGrpcClient.Setup(x => x.CreateRegulatoryListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegulatoryListingsClient client = new RegulatoryListingsClientImpl(mockGrpcClient.Object, null);
            RegulatoryListing response = client.CreateRegulatoryListing(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateRegulatoryListingRequestObjectAsync()
        {
            moq::Mock<RegulatoryListings.RegulatoryListingsClient> mockGrpcClient = new moq::Mock<RegulatoryListings.RegulatoryListingsClient>(moq::MockBehavior.Strict);
            CreateRegulatoryListingRequest request = new CreateRegulatoryListingRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                RegulatoryListing = new RegulatoryListing(),
            };
            RegulatoryListing expectedResponse = new RegulatoryListing
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
                DisplayName = "display_name137f65c2",
                Address = new GenericAddress(),
                Person = new PersonDetails(),
                Business = new BusinessDetails(),
                CreateTime = new wkt::Timestamp(),
                Valid = false,
                Verified = true,
            };
            mockGrpcClient.Setup(x => x.CreateRegulatoryListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegulatoryListing>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegulatoryListingsClient client = new RegulatoryListingsClientImpl(mockGrpcClient.Object, null);
            RegulatoryListing responseCallSettings = await client.CreateRegulatoryListingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegulatoryListing responseCancellationToken = await client.CreateRegulatoryListingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateRegulatoryListing()
        {
            moq::Mock<RegulatoryListings.RegulatoryListingsClient> mockGrpcClient = new moq::Mock<RegulatoryListings.RegulatoryListingsClient>(moq::MockBehavior.Strict);
            CreateRegulatoryListingRequest request = new CreateRegulatoryListingRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                RegulatoryListing = new RegulatoryListing(),
            };
            RegulatoryListing expectedResponse = new RegulatoryListing
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
                DisplayName = "display_name137f65c2",
                Address = new GenericAddress(),
                Person = new PersonDetails(),
                Business = new BusinessDetails(),
                CreateTime = new wkt::Timestamp(),
                Valid = false,
                Verified = true,
            };
            mockGrpcClient.Setup(x => x.CreateRegulatoryListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegulatoryListingsClient client = new RegulatoryListingsClientImpl(mockGrpcClient.Object, null);
            RegulatoryListing response = client.CreateRegulatoryListing(request.Parent, request.RegulatoryListing);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateRegulatoryListingAsync()
        {
            moq::Mock<RegulatoryListings.RegulatoryListingsClient> mockGrpcClient = new moq::Mock<RegulatoryListings.RegulatoryListingsClient>(moq::MockBehavior.Strict);
            CreateRegulatoryListingRequest request = new CreateRegulatoryListingRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                RegulatoryListing = new RegulatoryListing(),
            };
            RegulatoryListing expectedResponse = new RegulatoryListing
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
                DisplayName = "display_name137f65c2",
                Address = new GenericAddress(),
                Person = new PersonDetails(),
                Business = new BusinessDetails(),
                CreateTime = new wkt::Timestamp(),
                Valid = false,
                Verified = true,
            };
            mockGrpcClient.Setup(x => x.CreateRegulatoryListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegulatoryListing>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegulatoryListingsClient client = new RegulatoryListingsClientImpl(mockGrpcClient.Object, null);
            RegulatoryListing responseCallSettings = await client.CreateRegulatoryListingAsync(request.Parent, request.RegulatoryListing, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegulatoryListing responseCancellationToken = await client.CreateRegulatoryListingAsync(request.Parent, request.RegulatoryListing, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateRegulatoryListingResourceNames()
        {
            moq::Mock<RegulatoryListings.RegulatoryListingsClient> mockGrpcClient = new moq::Mock<RegulatoryListings.RegulatoryListingsClient>(moq::MockBehavior.Strict);
            CreateRegulatoryListingRequest request = new CreateRegulatoryListingRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                RegulatoryListing = new RegulatoryListing(),
            };
            RegulatoryListing expectedResponse = new RegulatoryListing
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
                DisplayName = "display_name137f65c2",
                Address = new GenericAddress(),
                Person = new PersonDetails(),
                Business = new BusinessDetails(),
                CreateTime = new wkt::Timestamp(),
                Valid = false,
                Verified = true,
            };
            mockGrpcClient.Setup(x => x.CreateRegulatoryListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegulatoryListingsClient client = new RegulatoryListingsClientImpl(mockGrpcClient.Object, null);
            RegulatoryListing response = client.CreateRegulatoryListing(request.ParentAsProjectName, request.RegulatoryListing);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateRegulatoryListingResourceNamesAsync()
        {
            moq::Mock<RegulatoryListings.RegulatoryListingsClient> mockGrpcClient = new moq::Mock<RegulatoryListings.RegulatoryListingsClient>(moq::MockBehavior.Strict);
            CreateRegulatoryListingRequest request = new CreateRegulatoryListingRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                RegulatoryListing = new RegulatoryListing(),
            };
            RegulatoryListing expectedResponse = new RegulatoryListing
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
                DisplayName = "display_name137f65c2",
                Address = new GenericAddress(),
                Person = new PersonDetails(),
                Business = new BusinessDetails(),
                CreateTime = new wkt::Timestamp(),
                Valid = false,
                Verified = true,
            };
            mockGrpcClient.Setup(x => x.CreateRegulatoryListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegulatoryListing>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegulatoryListingsClient client = new RegulatoryListingsClientImpl(mockGrpcClient.Object, null);
            RegulatoryListing responseCallSettings = await client.CreateRegulatoryListingAsync(request.ParentAsProjectName, request.RegulatoryListing, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegulatoryListing responseCancellationToken = await client.CreateRegulatoryListingAsync(request.ParentAsProjectName, request.RegulatoryListing, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRegulatoryListingRequestObject()
        {
            moq::Mock<RegulatoryListings.RegulatoryListingsClient> mockGrpcClient = new moq::Mock<RegulatoryListings.RegulatoryListingsClient>(moq::MockBehavior.Strict);
            GetRegulatoryListingRequest request = new GetRegulatoryListingRequest
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
            };
            RegulatoryListing expectedResponse = new RegulatoryListing
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
                DisplayName = "display_name137f65c2",
                Address = new GenericAddress(),
                Person = new PersonDetails(),
                Business = new BusinessDetails(),
                CreateTime = new wkt::Timestamp(),
                Valid = false,
                Verified = true,
            };
            mockGrpcClient.Setup(x => x.GetRegulatoryListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegulatoryListingsClient client = new RegulatoryListingsClientImpl(mockGrpcClient.Object, null);
            RegulatoryListing response = client.GetRegulatoryListing(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRegulatoryListingRequestObjectAsync()
        {
            moq::Mock<RegulatoryListings.RegulatoryListingsClient> mockGrpcClient = new moq::Mock<RegulatoryListings.RegulatoryListingsClient>(moq::MockBehavior.Strict);
            GetRegulatoryListingRequest request = new GetRegulatoryListingRequest
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
            };
            RegulatoryListing expectedResponse = new RegulatoryListing
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
                DisplayName = "display_name137f65c2",
                Address = new GenericAddress(),
                Person = new PersonDetails(),
                Business = new BusinessDetails(),
                CreateTime = new wkt::Timestamp(),
                Valid = false,
                Verified = true,
            };
            mockGrpcClient.Setup(x => x.GetRegulatoryListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegulatoryListing>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegulatoryListingsClient client = new RegulatoryListingsClientImpl(mockGrpcClient.Object, null);
            RegulatoryListing responseCallSettings = await client.GetRegulatoryListingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegulatoryListing responseCancellationToken = await client.GetRegulatoryListingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRegulatoryListing()
        {
            moq::Mock<RegulatoryListings.RegulatoryListingsClient> mockGrpcClient = new moq::Mock<RegulatoryListings.RegulatoryListingsClient>(moq::MockBehavior.Strict);
            GetRegulatoryListingRequest request = new GetRegulatoryListingRequest
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
            };
            RegulatoryListing expectedResponse = new RegulatoryListing
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
                DisplayName = "display_name137f65c2",
                Address = new GenericAddress(),
                Person = new PersonDetails(),
                Business = new BusinessDetails(),
                CreateTime = new wkt::Timestamp(),
                Valid = false,
                Verified = true,
            };
            mockGrpcClient.Setup(x => x.GetRegulatoryListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegulatoryListingsClient client = new RegulatoryListingsClientImpl(mockGrpcClient.Object, null);
            RegulatoryListing response = client.GetRegulatoryListing(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRegulatoryListingAsync()
        {
            moq::Mock<RegulatoryListings.RegulatoryListingsClient> mockGrpcClient = new moq::Mock<RegulatoryListings.RegulatoryListingsClient>(moq::MockBehavior.Strict);
            GetRegulatoryListingRequest request = new GetRegulatoryListingRequest
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
            };
            RegulatoryListing expectedResponse = new RegulatoryListing
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
                DisplayName = "display_name137f65c2",
                Address = new GenericAddress(),
                Person = new PersonDetails(),
                Business = new BusinessDetails(),
                CreateTime = new wkt::Timestamp(),
                Valid = false,
                Verified = true,
            };
            mockGrpcClient.Setup(x => x.GetRegulatoryListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegulatoryListing>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegulatoryListingsClient client = new RegulatoryListingsClientImpl(mockGrpcClient.Object, null);
            RegulatoryListing responseCallSettings = await client.GetRegulatoryListingAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegulatoryListing responseCancellationToken = await client.GetRegulatoryListingAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRegulatoryListingResourceNames()
        {
            moq::Mock<RegulatoryListings.RegulatoryListingsClient> mockGrpcClient = new moq::Mock<RegulatoryListings.RegulatoryListingsClient>(moq::MockBehavior.Strict);
            GetRegulatoryListingRequest request = new GetRegulatoryListingRequest
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
            };
            RegulatoryListing expectedResponse = new RegulatoryListing
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
                DisplayName = "display_name137f65c2",
                Address = new GenericAddress(),
                Person = new PersonDetails(),
                Business = new BusinessDetails(),
                CreateTime = new wkt::Timestamp(),
                Valid = false,
                Verified = true,
            };
            mockGrpcClient.Setup(x => x.GetRegulatoryListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegulatoryListingsClient client = new RegulatoryListingsClientImpl(mockGrpcClient.Object, null);
            RegulatoryListing response = client.GetRegulatoryListing(request.RegulatoryListingName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRegulatoryListingResourceNamesAsync()
        {
            moq::Mock<RegulatoryListings.RegulatoryListingsClient> mockGrpcClient = new moq::Mock<RegulatoryListings.RegulatoryListingsClient>(moq::MockBehavior.Strict);
            GetRegulatoryListingRequest request = new GetRegulatoryListingRequest
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
            };
            RegulatoryListing expectedResponse = new RegulatoryListing
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
                DisplayName = "display_name137f65c2",
                Address = new GenericAddress(),
                Person = new PersonDetails(),
                Business = new BusinessDetails(),
                CreateTime = new wkt::Timestamp(),
                Valid = false,
                Verified = true,
            };
            mockGrpcClient.Setup(x => x.GetRegulatoryListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegulatoryListing>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegulatoryListingsClient client = new RegulatoryListingsClientImpl(mockGrpcClient.Object, null);
            RegulatoryListing responseCallSettings = await client.GetRegulatoryListingAsync(request.RegulatoryListingName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegulatoryListing responseCancellationToken = await client.GetRegulatoryListingAsync(request.RegulatoryListingName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateRegulatoryListingRequestObject()
        {
            moq::Mock<RegulatoryListings.RegulatoryListingsClient> mockGrpcClient = new moq::Mock<RegulatoryListings.RegulatoryListingsClient>(moq::MockBehavior.Strict);
            UpdateRegulatoryListingRequest request = new UpdateRegulatoryListingRequest
            {
                RegulatoryListing = new RegulatoryListing(),
                UpdateMask = new wkt::FieldMask(),
            };
            RegulatoryListing expectedResponse = new RegulatoryListing
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
                DisplayName = "display_name137f65c2",
                Address = new GenericAddress(),
                Person = new PersonDetails(),
                Business = new BusinessDetails(),
                CreateTime = new wkt::Timestamp(),
                Valid = false,
                Verified = true,
            };
            mockGrpcClient.Setup(x => x.UpdateRegulatoryListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegulatoryListingsClient client = new RegulatoryListingsClientImpl(mockGrpcClient.Object, null);
            RegulatoryListing response = client.UpdateRegulatoryListing(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateRegulatoryListingRequestObjectAsync()
        {
            moq::Mock<RegulatoryListings.RegulatoryListingsClient> mockGrpcClient = new moq::Mock<RegulatoryListings.RegulatoryListingsClient>(moq::MockBehavior.Strict);
            UpdateRegulatoryListingRequest request = new UpdateRegulatoryListingRequest
            {
                RegulatoryListing = new RegulatoryListing(),
                UpdateMask = new wkt::FieldMask(),
            };
            RegulatoryListing expectedResponse = new RegulatoryListing
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
                DisplayName = "display_name137f65c2",
                Address = new GenericAddress(),
                Person = new PersonDetails(),
                Business = new BusinessDetails(),
                CreateTime = new wkt::Timestamp(),
                Valid = false,
                Verified = true,
            };
            mockGrpcClient.Setup(x => x.UpdateRegulatoryListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegulatoryListing>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegulatoryListingsClient client = new RegulatoryListingsClientImpl(mockGrpcClient.Object, null);
            RegulatoryListing responseCallSettings = await client.UpdateRegulatoryListingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegulatoryListing responseCancellationToken = await client.UpdateRegulatoryListingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateRegulatoryListing()
        {
            moq::Mock<RegulatoryListings.RegulatoryListingsClient> mockGrpcClient = new moq::Mock<RegulatoryListings.RegulatoryListingsClient>(moq::MockBehavior.Strict);
            UpdateRegulatoryListingRequest request = new UpdateRegulatoryListingRequest
            {
                RegulatoryListing = new RegulatoryListing(),
                UpdateMask = new wkt::FieldMask(),
            };
            RegulatoryListing expectedResponse = new RegulatoryListing
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
                DisplayName = "display_name137f65c2",
                Address = new GenericAddress(),
                Person = new PersonDetails(),
                Business = new BusinessDetails(),
                CreateTime = new wkt::Timestamp(),
                Valid = false,
                Verified = true,
            };
            mockGrpcClient.Setup(x => x.UpdateRegulatoryListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegulatoryListingsClient client = new RegulatoryListingsClientImpl(mockGrpcClient.Object, null);
            RegulatoryListing response = client.UpdateRegulatoryListing(request.RegulatoryListing, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateRegulatoryListingAsync()
        {
            moq::Mock<RegulatoryListings.RegulatoryListingsClient> mockGrpcClient = new moq::Mock<RegulatoryListings.RegulatoryListingsClient>(moq::MockBehavior.Strict);
            UpdateRegulatoryListingRequest request = new UpdateRegulatoryListingRequest
            {
                RegulatoryListing = new RegulatoryListing(),
                UpdateMask = new wkt::FieldMask(),
            };
            RegulatoryListing expectedResponse = new RegulatoryListing
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
                DisplayName = "display_name137f65c2",
                Address = new GenericAddress(),
                Person = new PersonDetails(),
                Business = new BusinessDetails(),
                CreateTime = new wkt::Timestamp(),
                Valid = false,
                Verified = true,
            };
            mockGrpcClient.Setup(x => x.UpdateRegulatoryListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegulatoryListing>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegulatoryListingsClient client = new RegulatoryListingsClientImpl(mockGrpcClient.Object, null);
            RegulatoryListing responseCallSettings = await client.UpdateRegulatoryListingAsync(request.RegulatoryListing, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegulatoryListing responseCancellationToken = await client.UpdateRegulatoryListingAsync(request.RegulatoryListing, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRegulatoryListingRequestObject()
        {
            moq::Mock<RegulatoryListings.RegulatoryListingsClient> mockGrpcClient = new moq::Mock<RegulatoryListings.RegulatoryListingsClient>(moq::MockBehavior.Strict);
            DeleteRegulatoryListingRequest request = new DeleteRegulatoryListingRequest
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteRegulatoryListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegulatoryListingsClient client = new RegulatoryListingsClientImpl(mockGrpcClient.Object, null);
            client.DeleteRegulatoryListing(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRegulatoryListingRequestObjectAsync()
        {
            moq::Mock<RegulatoryListings.RegulatoryListingsClient> mockGrpcClient = new moq::Mock<RegulatoryListings.RegulatoryListingsClient>(moq::MockBehavior.Strict);
            DeleteRegulatoryListingRequest request = new DeleteRegulatoryListingRequest
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteRegulatoryListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegulatoryListingsClient client = new RegulatoryListingsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteRegulatoryListingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteRegulatoryListingAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRegulatoryListing()
        {
            moq::Mock<RegulatoryListings.RegulatoryListingsClient> mockGrpcClient = new moq::Mock<RegulatoryListings.RegulatoryListingsClient>(moq::MockBehavior.Strict);
            DeleteRegulatoryListingRequest request = new DeleteRegulatoryListingRequest
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteRegulatoryListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegulatoryListingsClient client = new RegulatoryListingsClientImpl(mockGrpcClient.Object, null);
            client.DeleteRegulatoryListing(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRegulatoryListingAsync()
        {
            moq::Mock<RegulatoryListings.RegulatoryListingsClient> mockGrpcClient = new moq::Mock<RegulatoryListings.RegulatoryListingsClient>(moq::MockBehavior.Strict);
            DeleteRegulatoryListingRequest request = new DeleteRegulatoryListingRequest
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteRegulatoryListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegulatoryListingsClient client = new RegulatoryListingsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteRegulatoryListingAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteRegulatoryListingAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRegulatoryListingResourceNames()
        {
            moq::Mock<RegulatoryListings.RegulatoryListingsClient> mockGrpcClient = new moq::Mock<RegulatoryListings.RegulatoryListingsClient>(moq::MockBehavior.Strict);
            DeleteRegulatoryListingRequest request = new DeleteRegulatoryListingRequest
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteRegulatoryListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegulatoryListingsClient client = new RegulatoryListingsClientImpl(mockGrpcClient.Object, null);
            client.DeleteRegulatoryListing(request.RegulatoryListingName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRegulatoryListingResourceNamesAsync()
        {
            moq::Mock<RegulatoryListings.RegulatoryListingsClient> mockGrpcClient = new moq::Mock<RegulatoryListings.RegulatoryListingsClient>(moq::MockBehavior.Strict);
            DeleteRegulatoryListingRequest request = new DeleteRegulatoryListingRequest
            {
                RegulatoryListingName = RegulatoryListingName.FromProjectRegulatoryListing("[PROJECT]", "[REGULATORY_LISTING]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteRegulatoryListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegulatoryListingsClient client = new RegulatoryListingsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteRegulatoryListingAsync(request.RegulatoryListingName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteRegulatoryListingAsync(request.RegulatoryListingName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
