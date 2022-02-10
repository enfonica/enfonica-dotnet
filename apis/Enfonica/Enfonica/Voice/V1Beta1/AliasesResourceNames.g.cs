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
    /// <summary>Resource name for the <c>Alias</c> resource.</summary>
    public sealed partial class AliasName : gax::IResourceName, sys::IEquatable<AliasName>
    {
        /// <summary>The possible contents of <see cref="AliasName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/sipDomains/{sip_domain}/aliases/{alias}</c>.
            /// </summary>
            ProjectSipDomainAlias = 1,
        }

        private static gax::PathTemplate s_projectSipDomainAlias = new gax::PathTemplate("projects/{project}/sipDomains/{sip_domain}/aliases/{alias}");

        /// <summary>Creates a <see cref="AliasName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AliasName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AliasName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AliasName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AliasName"/> with the pattern
        /// <c>projects/{project}/sipDomains/{sip_domain}/aliases/{alias}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sipDomainId">The <c>SipDomain</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="aliasId">The <c>Alias</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AliasName"/> constructed from the provided ids.</returns>
        public static AliasName FromProjectSipDomainAlias(string projectId, string sipDomainId, string aliasId) =>
            new AliasName(ResourceNameType.ProjectSipDomainAlias, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), sipDomainId: gax::GaxPreconditions.CheckNotNullOrEmpty(sipDomainId, nameof(sipDomainId)), aliasId: gax::GaxPreconditions.CheckNotNullOrEmpty(aliasId, nameof(aliasId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AliasName"/> with pattern
        /// <c>projects/{project}/sipDomains/{sip_domain}/aliases/{alias}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sipDomainId">The <c>SipDomain</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="aliasId">The <c>Alias</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AliasName"/> with pattern
        /// <c>projects/{project}/sipDomains/{sip_domain}/aliases/{alias}</c>.
        /// </returns>
        public static string Format(string projectId, string sipDomainId, string aliasId) =>
            FormatProjectSipDomainAlias(projectId, sipDomainId, aliasId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AliasName"/> with pattern
        /// <c>projects/{project}/sipDomains/{sip_domain}/aliases/{alias}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sipDomainId">The <c>SipDomain</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="aliasId">The <c>Alias</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AliasName"/> with pattern
        /// <c>projects/{project}/sipDomains/{sip_domain}/aliases/{alias}</c>.
        /// </returns>
        public static string FormatProjectSipDomainAlias(string projectId, string sipDomainId, string aliasId) =>
            s_projectSipDomainAlias.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sipDomainId, nameof(sipDomainId)), gax::GaxPreconditions.CheckNotNullOrEmpty(aliasId, nameof(aliasId)));

        /// <summary>Parses the given resource name string into a new <see cref="AliasName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/sipDomains/{sip_domain}/aliases/{alias}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="aliasName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AliasName"/> if successful.</returns>
        public static AliasName Parse(string aliasName) => Parse(aliasName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AliasName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/sipDomains/{sip_domain}/aliases/{alias}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="aliasName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AliasName"/> if successful.</returns>
        public static AliasName Parse(string aliasName, bool allowUnparsed) =>
            TryParse(aliasName, allowUnparsed, out AliasName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AliasName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/sipDomains/{sip_domain}/aliases/{alias}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="aliasName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AliasName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string aliasName, out AliasName result) => TryParse(aliasName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AliasName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/sipDomains/{sip_domain}/aliases/{alias}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="aliasName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AliasName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string aliasName, bool allowUnparsed, out AliasName result)
        {
            gax::GaxPreconditions.CheckNotNull(aliasName, nameof(aliasName));
            gax::TemplatedResourceName resourceName;
            if (s_projectSipDomainAlias.TryParseName(aliasName, out resourceName))
            {
                result = FromProjectSipDomainAlias(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(aliasName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AliasName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string aliasId = null, string projectId = null, string sipDomainId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AliasId = aliasId;
            ProjectId = projectId;
            SipDomainId = sipDomainId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AliasName"/> class from the component parts of pattern
        /// <c>projects/{project}/sipDomains/{sip_domain}/aliases/{alias}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sipDomainId">The <c>SipDomain</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="aliasId">The <c>Alias</c> ID. Must not be <c>null</c> or empty.</param>
        public AliasName(string projectId, string sipDomainId, string aliasId) : this(ResourceNameType.ProjectSipDomainAlias, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), sipDomainId: gax::GaxPreconditions.CheckNotNullOrEmpty(sipDomainId, nameof(sipDomainId)), aliasId: gax::GaxPreconditions.CheckNotNullOrEmpty(aliasId, nameof(aliasId)))
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
        /// The <c>Alias</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AliasId { get; }

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
                case ResourceNameType.ProjectSipDomainAlias: return s_projectSipDomainAlias.Expand(ProjectId, SipDomainId, AliasId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AliasName);

        /// <inheritdoc/>
        public bool Equals(AliasName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AliasName a, AliasName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AliasName a, AliasName b) => !(a == b);
    }

    public partial class Alias
    {
        /// <summary>
        /// <see cref="evv::AliasName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public evv::AliasName AliasName
        {
            get => string.IsNullOrEmpty(Name) ? null : evv::AliasName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAliasRequest
    {
        /// <summary>
        /// <see cref="SipDomainName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public SipDomainName ParentAsSipDomainName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SipDomainName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAliasRequest
    {
        /// <summary>
        /// <see cref="evv::AliasName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public evv::AliasName AliasName
        {
            get => string.IsNullOrEmpty(Name) ? null : evv::AliasName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAliasesRequest
    {
        /// <summary>
        /// <see cref="SipDomainName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public SipDomainName ParentAsSipDomainName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SipDomainName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAliasRequest
    {
        /// <summary>
        /// <see cref="evv::AliasName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public evv::AliasName AliasName
        {
            get => string.IsNullOrEmpty(Name) ? null : evv::AliasName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
