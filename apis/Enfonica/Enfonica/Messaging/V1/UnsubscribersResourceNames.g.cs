// Copyright 2021 Enfonica Pty Ltd
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

using emv = Enfonica.Messaging.V1;
using gax = Google.Api.Gax;
using sys = System;

namespace Enfonica.Messaging.V1
{
    /// <summary>Resource name for the <c>Unsubscriber</c> resource.</summary>
    public sealed partial class UnsubscriberName : gax::IResourceName, sys::IEquatable<UnsubscriberName>
    {
        /// <summary>The possible contents of <see cref="UnsubscriberName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/unsubscribers/{unsubscriber}</c>.</summary>
            ProjectUnsubscriber = 1,
        }

        private static gax::PathTemplate s_projectUnsubscriber = new gax::PathTemplate("projects/{project}/unsubscribers/{unsubscriber}");

        /// <summary>Creates a <see cref="UnsubscriberName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="UnsubscriberName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static UnsubscriberName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new UnsubscriberName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="UnsubscriberName"/> with the pattern <c>projects/{project}/unsubscribers/{unsubscriber}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="unsubscriberId">The <c>Unsubscriber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="UnsubscriberName"/> constructed from the provided ids.</returns>
        public static UnsubscriberName FromProjectUnsubscriber(string projectId, string unsubscriberId) =>
            new UnsubscriberName(ResourceNameType.ProjectUnsubscriber, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), unsubscriberId: gax::GaxPreconditions.CheckNotNullOrEmpty(unsubscriberId, nameof(unsubscriberId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UnsubscriberName"/> with pattern
        /// <c>projects/{project}/unsubscribers/{unsubscriber}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="unsubscriberId">The <c>Unsubscriber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UnsubscriberName"/> with pattern
        /// <c>projects/{project}/unsubscribers/{unsubscriber}</c>.
        /// </returns>
        public static string Format(string projectId, string unsubscriberId) =>
            FormatProjectUnsubscriber(projectId, unsubscriberId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UnsubscriberName"/> with pattern
        /// <c>projects/{project}/unsubscribers/{unsubscriber}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="unsubscriberId">The <c>Unsubscriber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UnsubscriberName"/> with pattern
        /// <c>projects/{project}/unsubscribers/{unsubscriber}</c>.
        /// </returns>
        public static string FormatProjectUnsubscriber(string projectId, string unsubscriberId) =>
            s_projectUnsubscriber.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(unsubscriberId, nameof(unsubscriberId)));

        /// <summary>Parses the given resource name string into a new <see cref="UnsubscriberName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/unsubscribers/{unsubscriber}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="unsubscriberName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UnsubscriberName"/> if successful.</returns>
        public static UnsubscriberName Parse(string unsubscriberName) => Parse(unsubscriberName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UnsubscriberName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/unsubscribers/{unsubscriber}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="unsubscriberName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="UnsubscriberName"/> if successful.</returns>
        public static UnsubscriberName Parse(string unsubscriberName, bool allowUnparsed) =>
            TryParse(unsubscriberName, allowUnparsed, out UnsubscriberName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UnsubscriberName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/unsubscribers/{unsubscriber}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="unsubscriberName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UnsubscriberName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string unsubscriberName, out UnsubscriberName result) =>
            TryParse(unsubscriberName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UnsubscriberName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/unsubscribers/{unsubscriber}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="unsubscriberName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UnsubscriberName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string unsubscriberName, bool allowUnparsed, out UnsubscriberName result)
        {
            gax::GaxPreconditions.CheckNotNull(unsubscriberName, nameof(unsubscriberName));
            gax::TemplatedResourceName resourceName;
            if (s_projectUnsubscriber.TryParseName(unsubscriberName, out resourceName))
            {
                result = FromProjectUnsubscriber(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(unsubscriberName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private UnsubscriberName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string unsubscriberId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            UnsubscriberId = unsubscriberId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="UnsubscriberName"/> class from the component parts of pattern
        /// <c>projects/{project}/unsubscribers/{unsubscriber}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="unsubscriberId">The <c>Unsubscriber</c> ID. Must not be <c>null</c> or empty.</param>
        public UnsubscriberName(string projectId, string unsubscriberId) : this(ResourceNameType.ProjectUnsubscriber, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), unsubscriberId: gax::GaxPreconditions.CheckNotNullOrEmpty(unsubscriberId, nameof(unsubscriberId)))
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
        /// The <c>Unsubscriber</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string UnsubscriberId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectUnsubscriber: return s_projectUnsubscriber.Expand(ProjectId, UnsubscriberId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as UnsubscriberName);

        /// <inheritdoc/>
        public bool Equals(UnsubscriberName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(UnsubscriberName a, UnsubscriberName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(UnsubscriberName a, UnsubscriberName b) => !(a == b);
    }

    public partial class Unsubscriber
    {
        /// <summary>
        /// <see cref="emv::UnsubscriberName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public emv::UnsubscriberName UnsubscriberName
        {
            get => string.IsNullOrEmpty(Name) ? null : emv::UnsubscriberName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateUnsubscriberRequest
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

    public partial class GetUnsubscriberRequest
    {
        /// <summary>
        /// <see cref="emv::UnsubscriberName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public emv::UnsubscriberName UnsubscriberName
        {
            get => string.IsNullOrEmpty(Name) ? null : emv::UnsubscriberName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListUnsubscribersRequest
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

    public partial class DeleteUnsubscriberRequest
    {
        /// <summary>
        /// <see cref="emv::UnsubscriberName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public emv::UnsubscriberName UnsubscriberName
        {
            get => string.IsNullOrEmpty(Name) ? null : emv::UnsubscriberName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
