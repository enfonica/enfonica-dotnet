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
    /// <summary>Resource name for the <c>SipInfo</c> resource.</summary>
    public sealed partial class SipInfoName : gax::IResourceName, sys::IEquatable<SipInfoName>
    {
        /// <summary>The possible contents of <see cref="SipInfoName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/calls/{call}/sipInfo</c>.</summary>
            ProjectCall = 1,
        }

        private static gax::PathTemplate s_projectCall = new gax::PathTemplate("projects/{project}/calls/{call}/sipInfo");

        /// <summary>Creates a <see cref="SipInfoName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SipInfoName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SipInfoName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SipInfoName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SipInfoName"/> with the pattern <c>projects/{project}/calls/{call}/sipInfo</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="callId">The <c>Call</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SipInfoName"/> constructed from the provided ids.</returns>
        public static SipInfoName FromProjectCall(string projectId, string callId) =>
            new SipInfoName(ResourceNameType.ProjectCall, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), callId: gax::GaxPreconditions.CheckNotNullOrEmpty(callId, nameof(callId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SipInfoName"/> with pattern
        /// <c>projects/{project}/calls/{call}/sipInfo</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="callId">The <c>Call</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SipInfoName"/> with pattern
        /// <c>projects/{project}/calls/{call}/sipInfo</c>.
        /// </returns>
        public static string Format(string projectId, string callId) => FormatProjectCall(projectId, callId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SipInfoName"/> with pattern
        /// <c>projects/{project}/calls/{call}/sipInfo</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="callId">The <c>Call</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SipInfoName"/> with pattern
        /// <c>projects/{project}/calls/{call}/sipInfo</c>.
        /// </returns>
        public static string FormatProjectCall(string projectId, string callId) =>
            s_projectCall.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(callId, nameof(callId)));

        /// <summary>Parses the given resource name string into a new <see cref="SipInfoName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/calls/{call}/sipInfo</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="sipInfoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SipInfoName"/> if successful.</returns>
        public static SipInfoName Parse(string sipInfoName) => Parse(sipInfoName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SipInfoName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/calls/{call}/sipInfo</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sipInfoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SipInfoName"/> if successful.</returns>
        public static SipInfoName Parse(string sipInfoName, bool allowUnparsed) =>
            TryParse(sipInfoName, allowUnparsed, out SipInfoName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SipInfoName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/calls/{call}/sipInfo</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="sipInfoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SipInfoName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sipInfoName, out SipInfoName result) => TryParse(sipInfoName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SipInfoName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/calls/{call}/sipInfo</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sipInfoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SipInfoName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sipInfoName, bool allowUnparsed, out SipInfoName result)
        {
            gax::GaxPreconditions.CheckNotNull(sipInfoName, nameof(sipInfoName));
            gax::TemplatedResourceName resourceName;
            if (s_projectCall.TryParseName(sipInfoName, out resourceName))
            {
                result = FromProjectCall(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sipInfoName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SipInfoName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string callId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CallId = callId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SipInfoName"/> class from the component parts of pattern
        /// <c>projects/{project}/calls/{call}/sipInfo</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="callId">The <c>Call</c> ID. Must not be <c>null</c> or empty.</param>
        public SipInfoName(string projectId, string callId) : this(ResourceNameType.ProjectCall, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), callId: gax::GaxPreconditions.CheckNotNullOrEmpty(callId, nameof(callId)))
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
        /// The <c>Call</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CallId { get; }

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
                case ResourceNameType.ProjectCall: return s_projectCall.Expand(ProjectId, CallId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SipInfoName);

        /// <inheritdoc/>
        public bool Equals(SipInfoName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(SipInfoName a, SipInfoName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(SipInfoName a, SipInfoName b) => !(a == b);
    }

    public partial class SipInfo
    {
        /// <summary>
        /// <see cref="evv::SipInfoName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public evv::SipInfoName SipInfoName
        {
            get => string.IsNullOrEmpty(Name) ? null : evv::SipInfoName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetSipInfoRequest
    {
        /// <summary>
        /// <see cref="evv::SipInfoName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public evv::SipInfoName SipInfoName
        {
            get => string.IsNullOrEmpty(Name) ? null : evv::SipInfoName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
