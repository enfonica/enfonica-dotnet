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

using env = Enfonica.Numbering.V1Beta1;
using gax = Google.Api.Gax;
using sys = System;

namespace Enfonica.Numbering.V1Beta1
{
    /// <summary>Resource name for the <c>PhoneNumberInstance</c> resource.</summary>
    public sealed partial class PhoneNumberInstanceName : gax::IResourceName, sys::IEquatable<PhoneNumberInstanceName>
    {
        /// <summary>The possible contents of <see cref="PhoneNumberInstanceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/phoneNumberInstances/{phone_number_instance}</c>.
            /// </summary>
            ProjectPhoneNumberInstance = 1,
        }

        private static gax::PathTemplate s_projectPhoneNumberInstance = new gax::PathTemplate("projects/{project}/phoneNumberInstances/{phone_number_instance}");

        /// <summary>Creates a <see cref="PhoneNumberInstanceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PhoneNumberInstanceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PhoneNumberInstanceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PhoneNumberInstanceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PhoneNumberInstanceName"/> with the pattern
        /// <c>projects/{project}/phoneNumberInstances/{phone_number_instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="phoneNumberInstanceId">
        /// The <c>PhoneNumberInstance</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="PhoneNumberInstanceName"/> constructed from the provided ids.
        /// </returns>
        public static PhoneNumberInstanceName FromProjectPhoneNumberInstance(string projectId, string phoneNumberInstanceId) =>
            new PhoneNumberInstanceName(ResourceNameType.ProjectPhoneNumberInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), phoneNumberInstanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(phoneNumberInstanceId, nameof(phoneNumberInstanceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PhoneNumberInstanceName"/> with pattern
        /// <c>projects/{project}/phoneNumberInstances/{phone_number_instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="phoneNumberInstanceId">
        /// The <c>PhoneNumberInstance</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="PhoneNumberInstanceName"/> with pattern
        /// <c>projects/{project}/phoneNumberInstances/{phone_number_instance}</c>.
        /// </returns>
        public static string Format(string projectId, string phoneNumberInstanceId) =>
            FormatProjectPhoneNumberInstance(projectId, phoneNumberInstanceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PhoneNumberInstanceName"/> with pattern
        /// <c>projects/{project}/phoneNumberInstances/{phone_number_instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="phoneNumberInstanceId">
        /// The <c>PhoneNumberInstance</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="PhoneNumberInstanceName"/> with pattern
        /// <c>projects/{project}/phoneNumberInstances/{phone_number_instance}</c>.
        /// </returns>
        public static string FormatProjectPhoneNumberInstance(string projectId, string phoneNumberInstanceId) =>
            s_projectPhoneNumberInstance.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(phoneNumberInstanceId, nameof(phoneNumberInstanceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PhoneNumberInstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/phoneNumberInstances/{phone_number_instance}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="phoneNumberInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PhoneNumberInstanceName"/> if successful.</returns>
        public static PhoneNumberInstanceName Parse(string phoneNumberInstanceName) => Parse(phoneNumberInstanceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PhoneNumberInstanceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/phoneNumberInstances/{phone_number_instance}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="phoneNumberInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PhoneNumberInstanceName"/> if successful.</returns>
        public static PhoneNumberInstanceName Parse(string phoneNumberInstanceName, bool allowUnparsed) =>
            TryParse(phoneNumberInstanceName, allowUnparsed, out PhoneNumberInstanceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PhoneNumberInstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/phoneNumberInstances/{phone_number_instance}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="phoneNumberInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PhoneNumberInstanceName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string phoneNumberInstanceName, out PhoneNumberInstanceName result) =>
            TryParse(phoneNumberInstanceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PhoneNumberInstanceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/phoneNumberInstances/{phone_number_instance}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="phoneNumberInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PhoneNumberInstanceName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string phoneNumberInstanceName, bool allowUnparsed, out PhoneNumberInstanceName result)
        {
            gax::GaxPreconditions.CheckNotNull(phoneNumberInstanceName, nameof(phoneNumberInstanceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectPhoneNumberInstance.TryParseName(phoneNumberInstanceName, out resourceName))
            {
                result = FromProjectPhoneNumberInstance(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(phoneNumberInstanceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PhoneNumberInstanceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string phoneNumberInstanceId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            PhoneNumberInstanceId = phoneNumberInstanceId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PhoneNumberInstanceName"/> class from the component parts of
        /// pattern <c>projects/{project}/phoneNumberInstances/{phone_number_instance}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="phoneNumberInstanceId">
        /// The <c>PhoneNumberInstance</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public PhoneNumberInstanceName(string projectId, string phoneNumberInstanceId) : this(ResourceNameType.ProjectPhoneNumberInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), phoneNumberInstanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(phoneNumberInstanceId, nameof(phoneNumberInstanceId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>PhoneNumberInstance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string PhoneNumberInstanceId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectPhoneNumberInstance: return s_projectPhoneNumberInstance.Expand(ProjectId, PhoneNumberInstanceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PhoneNumberInstanceName);

        /// <inheritdoc/>
        public bool Equals(PhoneNumberInstanceName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(PhoneNumberInstanceName a, PhoneNumberInstanceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(PhoneNumberInstanceName a, PhoneNumberInstanceName b) => !(a == b);
    }

    public partial class PhoneNumberInstance
    {
        /// <summary>
        /// <see cref="env::PhoneNumberInstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public env::PhoneNumberInstanceName PhoneNumberInstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : env::PhoneNumberInstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="RegulatoryListingName"/>-typed view over the <see cref="RegulatoryListing"/> resource name
        /// property.
        /// </summary>
        public RegulatoryListingName RegulatoryListingAsRegulatoryListingName
        {
            get => string.IsNullOrEmpty(RegulatoryListing) ? null : RegulatoryListingName.Parse(RegulatoryListing, allowUnparsed: true);
            set => RegulatoryListing = value?.ToString() ?? "";
        }
    }

    public partial class PhoneNumberRange
    {
        /// <summary>
        /// <see cref="PhoneNumberInstanceName"/>-typed view over the <see cref="PrimaryPhoneNumberInstance"/> resource
        /// name property.
        /// </summary>
        public PhoneNumberInstanceName PrimaryPhoneNumberInstanceAsPhoneNumberInstanceName
        {
            get => string.IsNullOrEmpty(PrimaryPhoneNumberInstance) ? null : PhoneNumberInstanceName.Parse(PrimaryPhoneNumberInstance, allowUnparsed: true);
            set => PrimaryPhoneNumberInstance = value?.ToString() ?? "";
        }
    }

    public partial class CreatePhoneNumberInstanceRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetPhoneNumberInstanceRequest
    {
        /// <summary>
        /// <see cref="env::PhoneNumberInstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public env::PhoneNumberInstanceName PhoneNumberInstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : env::PhoneNumberInstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPhoneNumberInstancesRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class UpdatePhoneNumberInstanceRequest
    {
        /// <summary>
        /// <see cref="env::PhoneNumberInstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public env::PhoneNumberInstanceName PhoneNumberInstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : env::PhoneNumberInstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeletePhoneNumberInstanceRequest
    {
        /// <summary>
        /// <see cref="env::PhoneNumberInstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public env::PhoneNumberInstanceName PhoneNumberInstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : env::PhoneNumberInstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MovePhoneNumberInstanceRequest
    {
        /// <summary>
        /// <see cref="env::PhoneNumberInstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public env::PhoneNumberInstanceName PhoneNumberInstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : env::PhoneNumberInstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="DestinationParent"/> resource name property.
        /// </summary>
        public ProjectName DestinationParentAsProjectName
        {
            get => string.IsNullOrEmpty(DestinationParent) ? null : ProjectName.Parse(DestinationParent, allowUnparsed: true);
            set => DestinationParent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="RegulatoryListingName"/>-typed view over the <see cref="RegulatoryListing"/> resource name
        /// property.
        /// </summary>
        public RegulatoryListingName RegulatoryListingAsRegulatoryListingName
        {
            get => string.IsNullOrEmpty(RegulatoryListing) ? null : RegulatoryListingName.Parse(RegulatoryListing, allowUnparsed: true);
            set => RegulatoryListing = value?.ToString() ?? "";
        }
    }

    public partial class SplitRangeRequest
    {
        /// <summary>
        /// <see cref="PhoneNumberInstanceName"/>-typed view over the <see cref="PhoneNumberInstance"/> resource name
        /// property.
        /// </summary>
        public PhoneNumberInstanceName PhoneNumberInstanceAsPhoneNumberInstanceName
        {
            get => string.IsNullOrEmpty(PhoneNumberInstance) ? null : PhoneNumberInstanceName.Parse(PhoneNumberInstance, allowUnparsed: true);
            set => PhoneNumberInstance = value?.ToString() ?? "";
        }
    }
}
