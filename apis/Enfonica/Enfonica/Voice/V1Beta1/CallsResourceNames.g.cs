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

using evv = Enfonica.Voice.V1Beta1;
using gax = Google.Api.Gax;
using sys = System;

namespace Enfonica.Voice.V1Beta1
{
    /// <summary>Resource name for the <c>Call</c> resource.</summary>
    public sealed partial class CallName : gax::IResourceName, sys::IEquatable<CallName>
    {
        /// <summary>The possible contents of <see cref="CallName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/calls/{call}</c>.</summary>
            ProjectCall = 1,
        }

        private static gax::PathTemplate s_projectCall = new gax::PathTemplate("projects/{project}/calls/{call}");

        /// <summary>Creates a <see cref="CallName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CallName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CallName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CallName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="CallName"/> with the pattern <c>projects/{project}/calls/{call}</c>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="callId">The <c>Call</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CallName"/> constructed from the provided ids.</returns>
        public static CallName FromProjectCall(string projectId, string callId) =>
            new CallName(ResourceNameType.ProjectCall, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), callId: gax::GaxPreconditions.CheckNotNullOrEmpty(callId, nameof(callId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CallName"/> with pattern
        /// <c>projects/{project}/calls/{call}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="callId">The <c>Call</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CallName"/> with pattern <c>projects/{project}/calls/{call}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string callId) => FormatProjectCall(projectId, callId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CallName"/> with pattern
        /// <c>projects/{project}/calls/{call}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="callId">The <c>Call</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CallName"/> with pattern <c>projects/{project}/calls/{call}</c>
        /// .
        /// </returns>
        public static string FormatProjectCall(string projectId, string callId) =>
            s_projectCall.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(callId, nameof(callId)));

        /// <summary>Parses the given resource name string into a new <see cref="CallName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/calls/{call}</c></description></item></list>
        /// </remarks>
        /// <param name="callName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CallName"/> if successful.</returns>
        public static CallName Parse(string callName) => Parse(callName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CallName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/calls/{call}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="callName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CallName"/> if successful.</returns>
        public static CallName Parse(string callName, bool allowUnparsed) =>
            TryParse(callName, allowUnparsed, out CallName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="CallName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/calls/{call}</c></description></item></list>
        /// </remarks>
        /// <param name="callName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CallName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string callName, out CallName result) => TryParse(callName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CallName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/calls/{call}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="callName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CallName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string callName, bool allowUnparsed, out CallName result)
        {
            gax::GaxPreconditions.CheckNotNull(callName, nameof(callName));
            gax::TemplatedResourceName resourceName;
            if (s_projectCall.TryParseName(callName, out resourceName))
            {
                result = FromProjectCall(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(callName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CallName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string callId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CallId = callId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CallName"/> class from the component parts of pattern
        /// <c>projects/{project}/calls/{call}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="callId">The <c>Call</c> ID. Must not be <c>null</c> or empty.</param>
        public CallName(string projectId, string callId) : this(ResourceNameType.ProjectCall, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), callId: gax::GaxPreconditions.CheckNotNullOrEmpty(callId, nameof(callId)))
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
        public override bool Equals(object obj) => Equals(obj as CallName);

        /// <inheritdoc/>
        public bool Equals(CallName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CallName a, CallName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CallName a, CallName b) => !(a == b);
    }

    public partial class Call
    {
        /// <summary>
        /// <see cref="evv::CallName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public evv::CallName CallName
        {
            get => string.IsNullOrEmpty(Name) ? null : evv::CallName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetCallRequest
    {
        /// <summary>
        /// <see cref="evv::CallName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public evv::CallName CallName
        {
            get => string.IsNullOrEmpty(Name) ? null : evv::CallName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCallsRequest
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
