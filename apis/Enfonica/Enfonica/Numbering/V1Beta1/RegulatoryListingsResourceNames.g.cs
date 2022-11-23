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
    /// <summary>Resource name for the <c>RegulatoryListing</c> resource.</summary>
    public sealed partial class RegulatoryListingName : gax::IResourceName, sys::IEquatable<RegulatoryListingName>
    {
        /// <summary>The possible contents of <see cref="RegulatoryListingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/regulatoryListings/{regulatory_listing}</c>.
            /// </summary>
            ProjectRegulatoryListing = 1,
        }

        private static gax::PathTemplate s_projectRegulatoryListing = new gax::PathTemplate("projects/{project}/regulatoryListings/{regulatory_listing}");

        /// <summary>Creates a <see cref="RegulatoryListingName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RegulatoryListingName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RegulatoryListingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RegulatoryListingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RegulatoryListingName"/> with the pattern
        /// <c>projects/{project}/regulatoryListings/{regulatory_listing}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regulatoryListingId">The <c>RegulatoryListing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RegulatoryListingName"/> constructed from the provided ids.</returns>
        public static RegulatoryListingName FromProjectRegulatoryListing(string projectId, string regulatoryListingId) =>
            new RegulatoryListingName(ResourceNameType.ProjectRegulatoryListing, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regulatoryListingId: gax::GaxPreconditions.CheckNotNullOrEmpty(regulatoryListingId, nameof(regulatoryListingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RegulatoryListingName"/> with pattern
        /// <c>projects/{project}/regulatoryListings/{regulatory_listing}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regulatoryListingId">The <c>RegulatoryListing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RegulatoryListingName"/> with pattern
        /// <c>projects/{project}/regulatoryListings/{regulatory_listing}</c>.
        /// </returns>
        public static string Format(string projectId, string regulatoryListingId) =>
            FormatProjectRegulatoryListing(projectId, regulatoryListingId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RegulatoryListingName"/> with pattern
        /// <c>projects/{project}/regulatoryListings/{regulatory_listing}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regulatoryListingId">The <c>RegulatoryListing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RegulatoryListingName"/> with pattern
        /// <c>projects/{project}/regulatoryListings/{regulatory_listing}</c>.
        /// </returns>
        public static string FormatProjectRegulatoryListing(string projectId, string regulatoryListingId) =>
            s_projectRegulatoryListing.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regulatoryListingId, nameof(regulatoryListingId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RegulatoryListingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regulatoryListings/{regulatory_listing}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="regulatoryListingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RegulatoryListingName"/> if successful.</returns>
        public static RegulatoryListingName Parse(string regulatoryListingName) => Parse(regulatoryListingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RegulatoryListingName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regulatoryListings/{regulatory_listing}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="regulatoryListingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RegulatoryListingName"/> if successful.</returns>
        public static RegulatoryListingName Parse(string regulatoryListingName, bool allowUnparsed) =>
            TryParse(regulatoryListingName, allowUnparsed, out RegulatoryListingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RegulatoryListingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regulatoryListings/{regulatory_listing}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="regulatoryListingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RegulatoryListingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string regulatoryListingName, out RegulatoryListingName result) =>
            TryParse(regulatoryListingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RegulatoryListingName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regulatoryListings/{regulatory_listing}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="regulatoryListingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RegulatoryListingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string regulatoryListingName, bool allowUnparsed, out RegulatoryListingName result)
        {
            gax::GaxPreconditions.CheckNotNull(regulatoryListingName, nameof(regulatoryListingName));
            gax::TemplatedResourceName resourceName;
            if (s_projectRegulatoryListing.TryParseName(regulatoryListingName, out resourceName))
            {
                result = FromProjectRegulatoryListing(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(regulatoryListingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RegulatoryListingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string regulatoryListingId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            RegulatoryListingId = regulatoryListingId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RegulatoryListingName"/> class from the component parts of pattern
        /// <c>projects/{project}/regulatoryListings/{regulatory_listing}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regulatoryListingId">The <c>RegulatoryListing</c> ID. Must not be <c>null</c> or empty.</param>
        public RegulatoryListingName(string projectId, string regulatoryListingId) : this(ResourceNameType.ProjectRegulatoryListing, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regulatoryListingId: gax::GaxPreconditions.CheckNotNullOrEmpty(regulatoryListingId, nameof(regulatoryListingId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>RegulatoryListing</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string RegulatoryListingId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectRegulatoryListing: return s_projectRegulatoryListing.Expand(ProjectId, RegulatoryListingId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RegulatoryListingName);

        /// <inheritdoc/>
        public bool Equals(RegulatoryListingName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(RegulatoryListingName a, RegulatoryListingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(RegulatoryListingName a, RegulatoryListingName b) => !(a == b);
    }

    public partial class RegulatoryListing
    {
        /// <summary>
        /// <see cref="env::RegulatoryListingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public env::RegulatoryListingName RegulatoryListingName
        {
            get => string.IsNullOrEmpty(Name) ? null : env::RegulatoryListingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateRegulatoryListingRequest
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

    public partial class GetRegulatoryListingRequest
    {
        /// <summary>
        /// <see cref="env::RegulatoryListingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public env::RegulatoryListingName RegulatoryListingName
        {
            get => string.IsNullOrEmpty(Name) ? null : env::RegulatoryListingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRegulatoryListingsRequest
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

    public partial class DeleteRegulatoryListingRequest
    {
        /// <summary>
        /// <see cref="env::RegulatoryListingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public env::RegulatoryListingName RegulatoryListingName
        {
            get => string.IsNullOrEmpty(Name) ? null : env::RegulatoryListingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SearchRegulatoryListingsRequest
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
}
