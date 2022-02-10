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

using evv = Enfonica.Voice.V1Beta1;
using gax = Google.Api.Gax;
using sys = System;

namespace Enfonica.Voice.V1Beta1
{
    /// <summary>Resource name for the <c>SipDomain</c> resource.</summary>
    public sealed partial class SipDomainName : gax::IResourceName, sys::IEquatable<SipDomainName>
    {
        /// <summary>The possible contents of <see cref="SipDomainName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/sipDomains/{sip_domain}</c>.</summary>
            ProjectSipDomain = 1,
        }

        private static gax::PathTemplate s_projectSipDomain = new gax::PathTemplate("projects/{project}/sipDomains/{sip_domain}");

        /// <summary>Creates a <see cref="SipDomainName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SipDomainName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SipDomainName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SipDomainName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SipDomainName"/> with the pattern <c>projects/{project}/sipDomains/{sip_domain}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sipDomainId">The <c>SipDomain</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SipDomainName"/> constructed from the provided ids.</returns>
        public static SipDomainName FromProjectSipDomain(string projectId, string sipDomainId) =>
            new SipDomainName(ResourceNameType.ProjectSipDomain, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), sipDomainId: gax::GaxPreconditions.CheckNotNullOrEmpty(sipDomainId, nameof(sipDomainId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SipDomainName"/> with pattern
        /// <c>projects/{project}/sipDomains/{sip_domain}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sipDomainId">The <c>SipDomain</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SipDomainName"/> with pattern
        /// <c>projects/{project}/sipDomains/{sip_domain}</c>.
        /// </returns>
        public static string Format(string projectId, string sipDomainId) => FormatProjectSipDomain(projectId, sipDomainId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SipDomainName"/> with pattern
        /// <c>projects/{project}/sipDomains/{sip_domain}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sipDomainId">The <c>SipDomain</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SipDomainName"/> with pattern
        /// <c>projects/{project}/sipDomains/{sip_domain}</c>.
        /// </returns>
        public static string FormatProjectSipDomain(string projectId, string sipDomainId) =>
            s_projectSipDomain.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sipDomainId, nameof(sipDomainId)));

        /// <summary>Parses the given resource name string into a new <see cref="SipDomainName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/sipDomains/{sip_domain}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="sipDomainName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SipDomainName"/> if successful.</returns>
        public static SipDomainName Parse(string sipDomainName) => Parse(sipDomainName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SipDomainName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/sipDomains/{sip_domain}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sipDomainName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SipDomainName"/> if successful.</returns>
        public static SipDomainName Parse(string sipDomainName, bool allowUnparsed) =>
            TryParse(sipDomainName, allowUnparsed, out SipDomainName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SipDomainName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/sipDomains/{sip_domain}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="sipDomainName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SipDomainName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sipDomainName, out SipDomainName result) => TryParse(sipDomainName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SipDomainName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/sipDomains/{sip_domain}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sipDomainName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SipDomainName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sipDomainName, bool allowUnparsed, out SipDomainName result)
        {
            gax::GaxPreconditions.CheckNotNull(sipDomainName, nameof(sipDomainName));
            gax::TemplatedResourceName resourceName;
            if (s_projectSipDomain.TryParseName(sipDomainName, out resourceName))
            {
                result = FromProjectSipDomain(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sipDomainName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SipDomainName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string sipDomainId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            SipDomainId = sipDomainId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SipDomainName"/> class from the component parts of pattern
        /// <c>projects/{project}/sipDomains/{sip_domain}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sipDomainId">The <c>SipDomain</c> ID. Must not be <c>null</c> or empty.</param>
        public SipDomainName(string projectId, string sipDomainId) : this(ResourceNameType.ProjectSipDomain, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), sipDomainId: gax::GaxPreconditions.CheckNotNullOrEmpty(sipDomainId, nameof(sipDomainId)))
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
        /// The <c>SipDomain</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SipDomainId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectSipDomain: return s_projectSipDomain.Expand(ProjectId, SipDomainId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SipDomainName);

        /// <inheritdoc/>
        public bool Equals(SipDomainName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(SipDomainName a, SipDomainName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(SipDomainName a, SipDomainName b) => !(a == b);
    }

    public partial class SipDomain
    {
        /// <summary>
        /// <see cref="evv::SipDomainName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public evv::SipDomainName SipDomainName
        {
            get => string.IsNullOrEmpty(Name) ? null : evv::SipDomainName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSipDomainRequest
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

    public partial class GetSipDomainRequest
    {
        /// <summary>
        /// <see cref="evv::SipDomainName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public evv::SipDomainName SipDomainName
        {
            get => string.IsNullOrEmpty(Name) ? null : evv::SipDomainName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSipDomainsRequest
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

    public partial class DeleteSipDomainRequest
    {
        /// <summary>
        /// <see cref="evv::SipDomainName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public evv::SipDomainName SipDomainName
        {
            get => string.IsNullOrEmpty(Name) ? null : evv::SipDomainName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
