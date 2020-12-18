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

namespace Enfonica.Numbering.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedPhoneNumbersClientTest
    {
        [xunit::FactAttribute]
        public void CreatePhoneNumberRequestObject()
        {
            moq::Mock<PhoneNumbers.PhoneNumbersClient> mockGrpcClient = new moq::Mock<PhoneNumbers.PhoneNumbersClient>(moq::MockBehavior.Strict);
            CreatePhoneNumberRequest request = new CreatePhoneNumberRequest
            {
                PhoneNumber = new PhoneNumber(),
            };
            PhoneNumber expectedResponse = new PhoneNumber
            {
                Name = "name1c9368b0",
                PhoneNumber_ = "phone_number9ebac341",
                Capabilities =
                {
                    PhoneNumber.Types.PhoneNumberCapability.Voice,
                },
                Sku = "skufd61c4f8",
                Carrier = "carrierc4c35ed4",
                NumberType = PhoneNumber.Types.PhoneNumberType.Mobile,
                CountryCode = "country_code8debec55",
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                State = PhoneNumber.Types.PhoneNumberState.Quarantined,
                LocalAccessArea = "local_access_area18be0d20",
            };
            mockGrpcClient.Setup(x => x.CreatePhoneNumber(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PhoneNumbersClient client = new PhoneNumbersClientImpl(mockGrpcClient.Object, null);
            PhoneNumber response = client.CreatePhoneNumber(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePhoneNumberRequestObjectAsync()
        {
            moq::Mock<PhoneNumbers.PhoneNumbersClient> mockGrpcClient = new moq::Mock<PhoneNumbers.PhoneNumbersClient>(moq::MockBehavior.Strict);
            CreatePhoneNumberRequest request = new CreatePhoneNumberRequest
            {
                PhoneNumber = new PhoneNumber(),
            };
            PhoneNumber expectedResponse = new PhoneNumber
            {
                Name = "name1c9368b0",
                PhoneNumber_ = "phone_number9ebac341",
                Capabilities =
                {
                    PhoneNumber.Types.PhoneNumberCapability.Voice,
                },
                Sku = "skufd61c4f8",
                Carrier = "carrierc4c35ed4",
                NumberType = PhoneNumber.Types.PhoneNumberType.Mobile,
                CountryCode = "country_code8debec55",
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                State = PhoneNumber.Types.PhoneNumberState.Quarantined,
                LocalAccessArea = "local_access_area18be0d20",
            };
            mockGrpcClient.Setup(x => x.CreatePhoneNumberAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhoneNumber>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PhoneNumbersClient client = new PhoneNumbersClientImpl(mockGrpcClient.Object, null);
            PhoneNumber responseCallSettings = await client.CreatePhoneNumberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhoneNumber responseCancellationToken = await client.CreatePhoneNumberAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPhoneNumberRequestObject()
        {
            moq::Mock<PhoneNumbers.PhoneNumbersClient> mockGrpcClient = new moq::Mock<PhoneNumbers.PhoneNumbersClient>(moq::MockBehavior.Strict);
            GetPhoneNumberRequest request = new GetPhoneNumberRequest
            {
                Name = "name1c9368b0",
            };
            PhoneNumber expectedResponse = new PhoneNumber
            {
                Name = "name1c9368b0",
                PhoneNumber_ = "phone_number9ebac341",
                Capabilities =
                {
                    PhoneNumber.Types.PhoneNumberCapability.Voice,
                },
                Sku = "skufd61c4f8",
                Carrier = "carrierc4c35ed4",
                NumberType = PhoneNumber.Types.PhoneNumberType.Mobile,
                CountryCode = "country_code8debec55",
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                State = PhoneNumber.Types.PhoneNumberState.Quarantined,
                LocalAccessArea = "local_access_area18be0d20",
            };
            mockGrpcClient.Setup(x => x.GetPhoneNumber(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PhoneNumbersClient client = new PhoneNumbersClientImpl(mockGrpcClient.Object, null);
            PhoneNumber response = client.GetPhoneNumber(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPhoneNumberRequestObjectAsync()
        {
            moq::Mock<PhoneNumbers.PhoneNumbersClient> mockGrpcClient = new moq::Mock<PhoneNumbers.PhoneNumbersClient>(moq::MockBehavior.Strict);
            GetPhoneNumberRequest request = new GetPhoneNumberRequest
            {
                Name = "name1c9368b0",
            };
            PhoneNumber expectedResponse = new PhoneNumber
            {
                Name = "name1c9368b0",
                PhoneNumber_ = "phone_number9ebac341",
                Capabilities =
                {
                    PhoneNumber.Types.PhoneNumberCapability.Voice,
                },
                Sku = "skufd61c4f8",
                Carrier = "carrierc4c35ed4",
                NumberType = PhoneNumber.Types.PhoneNumberType.Mobile,
                CountryCode = "country_code8debec55",
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                State = PhoneNumber.Types.PhoneNumberState.Quarantined,
                LocalAccessArea = "local_access_area18be0d20",
            };
            mockGrpcClient.Setup(x => x.GetPhoneNumberAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhoneNumber>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PhoneNumbersClient client = new PhoneNumbersClientImpl(mockGrpcClient.Object, null);
            PhoneNumber responseCallSettings = await client.GetPhoneNumberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhoneNumber responseCancellationToken = await client.GetPhoneNumberAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePhoneNumberRequestObject()
        {
            moq::Mock<PhoneNumbers.PhoneNumbersClient> mockGrpcClient = new moq::Mock<PhoneNumbers.PhoneNumbersClient>(moq::MockBehavior.Strict);
            UpdatePhoneNumberRequest request = new UpdatePhoneNumberRequest
            {
                Name = "name1c9368b0",
                PhoneNumber = new PhoneNumber(),
                UpdateMask = new wkt::FieldMask(),
            };
            PhoneNumber expectedResponse = new PhoneNumber
            {
                Name = "name1c9368b0",
                PhoneNumber_ = "phone_number9ebac341",
                Capabilities =
                {
                    PhoneNumber.Types.PhoneNumberCapability.Voice,
                },
                Sku = "skufd61c4f8",
                Carrier = "carrierc4c35ed4",
                NumberType = PhoneNumber.Types.PhoneNumberType.Mobile,
                CountryCode = "country_code8debec55",
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                State = PhoneNumber.Types.PhoneNumberState.Quarantined,
                LocalAccessArea = "local_access_area18be0d20",
            };
            mockGrpcClient.Setup(x => x.UpdatePhoneNumber(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PhoneNumbersClient client = new PhoneNumbersClientImpl(mockGrpcClient.Object, null);
            PhoneNumber response = client.UpdatePhoneNumber(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePhoneNumberRequestObjectAsync()
        {
            moq::Mock<PhoneNumbers.PhoneNumbersClient> mockGrpcClient = new moq::Mock<PhoneNumbers.PhoneNumbersClient>(moq::MockBehavior.Strict);
            UpdatePhoneNumberRequest request = new UpdatePhoneNumberRequest
            {
                Name = "name1c9368b0",
                PhoneNumber = new PhoneNumber(),
                UpdateMask = new wkt::FieldMask(),
            };
            PhoneNumber expectedResponse = new PhoneNumber
            {
                Name = "name1c9368b0",
                PhoneNumber_ = "phone_number9ebac341",
                Capabilities =
                {
                    PhoneNumber.Types.PhoneNumberCapability.Voice,
                },
                Sku = "skufd61c4f8",
                Carrier = "carrierc4c35ed4",
                NumberType = PhoneNumber.Types.PhoneNumberType.Mobile,
                CountryCode = "country_code8debec55",
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                State = PhoneNumber.Types.PhoneNumberState.Quarantined,
                LocalAccessArea = "local_access_area18be0d20",
            };
            mockGrpcClient.Setup(x => x.UpdatePhoneNumberAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhoneNumber>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PhoneNumbersClient client = new PhoneNumbersClientImpl(mockGrpcClient.Object, null);
            PhoneNumber responseCallSettings = await client.UpdatePhoneNumberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhoneNumber responseCancellationToken = await client.UpdatePhoneNumberAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePhoneNumberRequestObject()
        {
            moq::Mock<PhoneNumbers.PhoneNumbersClient> mockGrpcClient = new moq::Mock<PhoneNumbers.PhoneNumbersClient>(moq::MockBehavior.Strict);
            DeletePhoneNumberRequest request = new DeletePhoneNumberRequest
            {
                Name = "name1c9368b0",
            };
            PhoneNumber expectedResponse = new PhoneNumber
            {
                Name = "name1c9368b0",
                PhoneNumber_ = "phone_number9ebac341",
                Capabilities =
                {
                    PhoneNumber.Types.PhoneNumberCapability.Voice,
                },
                Sku = "skufd61c4f8",
                Carrier = "carrierc4c35ed4",
                NumberType = PhoneNumber.Types.PhoneNumberType.Mobile,
                CountryCode = "country_code8debec55",
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                State = PhoneNumber.Types.PhoneNumberState.Quarantined,
                LocalAccessArea = "local_access_area18be0d20",
            };
            mockGrpcClient.Setup(x => x.DeletePhoneNumber(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PhoneNumbersClient client = new PhoneNumbersClientImpl(mockGrpcClient.Object, null);
            PhoneNumber response = client.DeletePhoneNumber(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePhoneNumberRequestObjectAsync()
        {
            moq::Mock<PhoneNumbers.PhoneNumbersClient> mockGrpcClient = new moq::Mock<PhoneNumbers.PhoneNumbersClient>(moq::MockBehavior.Strict);
            DeletePhoneNumberRequest request = new DeletePhoneNumberRequest
            {
                Name = "name1c9368b0",
            };
            PhoneNumber expectedResponse = new PhoneNumber
            {
                Name = "name1c9368b0",
                PhoneNumber_ = "phone_number9ebac341",
                Capabilities =
                {
                    PhoneNumber.Types.PhoneNumberCapability.Voice,
                },
                Sku = "skufd61c4f8",
                Carrier = "carrierc4c35ed4",
                NumberType = PhoneNumber.Types.PhoneNumberType.Mobile,
                CountryCode = "country_code8debec55",
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                State = PhoneNumber.Types.PhoneNumberState.Quarantined,
                LocalAccessArea = "local_access_area18be0d20",
            };
            mockGrpcClient.Setup(x => x.DeletePhoneNumberAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhoneNumber>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PhoneNumbersClient client = new PhoneNumbersClientImpl(mockGrpcClient.Object, null);
            PhoneNumber responseCallSettings = await client.DeletePhoneNumberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhoneNumber responseCancellationToken = await client.DeletePhoneNumberAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
