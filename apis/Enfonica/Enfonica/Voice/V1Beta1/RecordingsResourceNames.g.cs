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
    /// <summary>Resource name for the <c>Recording</c> resource.</summary>
    public sealed partial class RecordingName : gax::IResourceName, sys::IEquatable<RecordingName>
    {
        /// <summary>The possible contents of <see cref="RecordingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/calls/{call}/recordings/{recording}</c>.
            /// </summary>
            ProjectCallRecording = 1,
        }

        private static gax::PathTemplate s_projectCallRecording = new gax::PathTemplate("projects/{project}/calls/{call}/recordings/{recording}");

        /// <summary>Creates a <see cref="RecordingName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RecordingName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RecordingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RecordingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RecordingName"/> with the pattern
        /// <c>projects/{project}/calls/{call}/recordings/{recording}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="callId">The <c>Call</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recordingId">The <c>Recording</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RecordingName"/> constructed from the provided ids.</returns>
        public static RecordingName FromProjectCallRecording(string projectId, string callId, string recordingId) =>
            new RecordingName(ResourceNameType.ProjectCallRecording, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), callId: gax::GaxPreconditions.CheckNotNullOrEmpty(callId, nameof(callId)), recordingId: gax::GaxPreconditions.CheckNotNullOrEmpty(recordingId, nameof(recordingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RecordingName"/> with pattern
        /// <c>projects/{project}/calls/{call}/recordings/{recording}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="callId">The <c>Call</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recordingId">The <c>Recording</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RecordingName"/> with pattern
        /// <c>projects/{project}/calls/{call}/recordings/{recording}</c>.
        /// </returns>
        public static string Format(string projectId, string callId, string recordingId) =>
            FormatProjectCallRecording(projectId, callId, recordingId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RecordingName"/> with pattern
        /// <c>projects/{project}/calls/{call}/recordings/{recording}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="callId">The <c>Call</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recordingId">The <c>Recording</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RecordingName"/> with pattern
        /// <c>projects/{project}/calls/{call}/recordings/{recording}</c>.
        /// </returns>
        public static string FormatProjectCallRecording(string projectId, string callId, string recordingId) =>
            s_projectCallRecording.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(callId, nameof(callId)), gax::GaxPreconditions.CheckNotNullOrEmpty(recordingId, nameof(recordingId)));

        /// <summary>Parses the given resource name string into a new <see cref="RecordingName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/calls/{call}/recordings/{recording}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="recordingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RecordingName"/> if successful.</returns>
        public static RecordingName Parse(string recordingName) => Parse(recordingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RecordingName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/calls/{call}/recordings/{recording}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="recordingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RecordingName"/> if successful.</returns>
        public static RecordingName Parse(string recordingName, bool allowUnparsed) =>
            TryParse(recordingName, allowUnparsed, out RecordingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RecordingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/calls/{call}/recordings/{recording}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="recordingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RecordingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string recordingName, out RecordingName result) => TryParse(recordingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RecordingName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/calls/{call}/recordings/{recording}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="recordingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RecordingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string recordingName, bool allowUnparsed, out RecordingName result)
        {
            gax::GaxPreconditions.CheckNotNull(recordingName, nameof(recordingName));
            gax::TemplatedResourceName resourceName;
            if (s_projectCallRecording.TryParseName(recordingName, out resourceName))
            {
                result = FromProjectCallRecording(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(recordingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RecordingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string callId = null, string projectId = null, string recordingId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CallId = callId;
            ProjectId = projectId;
            RecordingId = recordingId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RecordingName"/> class from the component parts of pattern
        /// <c>projects/{project}/calls/{call}/recordings/{recording}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="callId">The <c>Call</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recordingId">The <c>Recording</c> ID. Must not be <c>null</c> or empty.</param>
        public RecordingName(string projectId, string callId, string recordingId) : this(ResourceNameType.ProjectCallRecording, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), callId: gax::GaxPreconditions.CheckNotNullOrEmpty(callId, nameof(callId)), recordingId: gax::GaxPreconditions.CheckNotNullOrEmpty(recordingId, nameof(recordingId)))
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

        /// <summary>
        /// The <c>Recording</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RecordingId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectCallRecording: return s_projectCallRecording.Expand(ProjectId, CallId, RecordingId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RecordingName);

        /// <inheritdoc/>
        public bool Equals(RecordingName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(RecordingName a, RecordingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(RecordingName a, RecordingName b) => !(a == b);
    }

    public partial class Recording
    {
        /// <summary>
        /// <see cref="evv::RecordingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public evv::RecordingName RecordingName
        {
            get => string.IsNullOrEmpty(Name) ? null : evv::RecordingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetRecordingRequest
    {
        /// <summary>
        /// <see cref="evv::RecordingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public evv::RecordingName RecordingName
        {
            get => string.IsNullOrEmpty(Name) ? null : evv::RecordingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRecordingsRequest
    {
        /// <summary><see cref="CallName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public CallName ParentAsCallName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CallName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteRecordingRequest
    {
        /// <summary>
        /// <see cref="evv::RecordingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public evv::RecordingName RecordingName
        {
            get => string.IsNullOrEmpty(Name) ? null : evv::RecordingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
