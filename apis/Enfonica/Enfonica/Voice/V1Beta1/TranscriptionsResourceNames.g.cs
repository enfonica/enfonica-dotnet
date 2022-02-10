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
    /// <summary>Resource name for the <c>Transcription</c> resource.</summary>
    public sealed partial class TranscriptionName : gax::IResourceName, sys::IEquatable<TranscriptionName>
    {
        /// <summary>The possible contents of <see cref="TranscriptionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/calls/{call}/transcriptions/{transcription}</c>.
            /// </summary>
            ProjectCallTranscription = 1,
        }

        private static gax::PathTemplate s_projectCallTranscription = new gax::PathTemplate("projects/{project}/calls/{call}/transcriptions/{transcription}");

        /// <summary>Creates a <see cref="TranscriptionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TranscriptionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TranscriptionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TranscriptionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TranscriptionName"/> with the pattern
        /// <c>projects/{project}/calls/{call}/transcriptions/{transcription}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="callId">The <c>Call</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transcriptionId">The <c>Transcription</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TranscriptionName"/> constructed from the provided ids.</returns>
        public static TranscriptionName FromProjectCallTranscription(string projectId, string callId, string transcriptionId) =>
            new TranscriptionName(ResourceNameType.ProjectCallTranscription, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), callId: gax::GaxPreconditions.CheckNotNullOrEmpty(callId, nameof(callId)), transcriptionId: gax::GaxPreconditions.CheckNotNullOrEmpty(transcriptionId, nameof(transcriptionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TranscriptionName"/> with pattern
        /// <c>projects/{project}/calls/{call}/transcriptions/{transcription}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="callId">The <c>Call</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transcriptionId">The <c>Transcription</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TranscriptionName"/> with pattern
        /// <c>projects/{project}/calls/{call}/transcriptions/{transcription}</c>.
        /// </returns>
        public static string Format(string projectId, string callId, string transcriptionId) =>
            FormatProjectCallTranscription(projectId, callId, transcriptionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TranscriptionName"/> with pattern
        /// <c>projects/{project}/calls/{call}/transcriptions/{transcription}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="callId">The <c>Call</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transcriptionId">The <c>Transcription</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TranscriptionName"/> with pattern
        /// <c>projects/{project}/calls/{call}/transcriptions/{transcription}</c>.
        /// </returns>
        public static string FormatProjectCallTranscription(string projectId, string callId, string transcriptionId) =>
            s_projectCallTranscription.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(callId, nameof(callId)), gax::GaxPreconditions.CheckNotNullOrEmpty(transcriptionId, nameof(transcriptionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TranscriptionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/calls/{call}/transcriptions/{transcription}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="transcriptionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TranscriptionName"/> if successful.</returns>
        public static TranscriptionName Parse(string transcriptionName) => Parse(transcriptionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TranscriptionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/calls/{call}/transcriptions/{transcription}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="transcriptionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TranscriptionName"/> if successful.</returns>
        public static TranscriptionName Parse(string transcriptionName, bool allowUnparsed) =>
            TryParse(transcriptionName, allowUnparsed, out TranscriptionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TranscriptionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/calls/{call}/transcriptions/{transcription}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="transcriptionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TranscriptionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string transcriptionName, out TranscriptionName result) =>
            TryParse(transcriptionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TranscriptionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/calls/{call}/transcriptions/{transcription}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="transcriptionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TranscriptionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string transcriptionName, bool allowUnparsed, out TranscriptionName result)
        {
            gax::GaxPreconditions.CheckNotNull(transcriptionName, nameof(transcriptionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectCallTranscription.TryParseName(transcriptionName, out resourceName))
            {
                result = FromProjectCallTranscription(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(transcriptionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TranscriptionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string callId = null, string projectId = null, string transcriptionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CallId = callId;
            ProjectId = projectId;
            TranscriptionId = transcriptionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TranscriptionName"/> class from the component parts of pattern
        /// <c>projects/{project}/calls/{call}/transcriptions/{transcription}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="callId">The <c>Call</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transcriptionId">The <c>Transcription</c> ID. Must not be <c>null</c> or empty.</param>
        public TranscriptionName(string projectId, string callId, string transcriptionId) : this(ResourceNameType.ProjectCallTranscription, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), callId: gax::GaxPreconditions.CheckNotNullOrEmpty(callId, nameof(callId)), transcriptionId: gax::GaxPreconditions.CheckNotNullOrEmpty(transcriptionId, nameof(transcriptionId)))
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
        /// The <c>Transcription</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string TranscriptionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectCallTranscription: return s_projectCallTranscription.Expand(ProjectId, CallId, TranscriptionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TranscriptionName);

        /// <inheritdoc/>
        public bool Equals(TranscriptionName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(TranscriptionName a, TranscriptionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(TranscriptionName a, TranscriptionName b) => !(a == b);
    }

    public partial class Transcription
    {
        /// <summary>
        /// <see cref="evv::TranscriptionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public evv::TranscriptionName TranscriptionName
        {
            get => string.IsNullOrEmpty(Name) ? null : evv::TranscriptionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetTranscriptionRequest
    {
        /// <summary>
        /// <see cref="evv::TranscriptionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public evv::TranscriptionName TranscriptionName
        {
            get => string.IsNullOrEmpty(Name) ? null : evv::TranscriptionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTranscriptionsRequest
    {
        /// <summary><see cref="CallName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public CallName ParentAsCallName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CallName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTranscriptionRequest
    {
        /// <summary>
        /// <see cref="evv::TranscriptionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public evv::TranscriptionName TranscriptionName
        {
            get => string.IsNullOrEmpty(Name) ? null : evv::TranscriptionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
