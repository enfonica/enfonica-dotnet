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

using gax = Google.Api.Gax;
using sys = System;

namespace Enfonica.Voice.V1Beta1
{
    /// <summary>Resource name for the <c>Stream</c> resource.</summary>
    public sealed partial class StreamName : gax::IResourceName, sys::IEquatable<StreamName>
    {
        /// <summary>The possible contents of <see cref="StreamName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/streams/{streams}</c>.</summary>
            ProjectStreams = 1,
        }

        private static gax::PathTemplate s_projectStreams = new gax::PathTemplate("projects/{project}/streams/{streams}");

        /// <summary>Creates a <see cref="StreamName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="StreamName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static StreamName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new StreamName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="StreamName"/> with the pattern <c>projects/{project}/streams/{streams}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamsId">The <c>Streams</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="StreamName"/> constructed from the provided ids.</returns>
        public static StreamName FromProjectStreams(string projectId, string streamsId) =>
            new StreamName(ResourceNameType.ProjectStreams, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), streamsId: gax::GaxPreconditions.CheckNotNullOrEmpty(streamsId, nameof(streamsId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StreamName"/> with pattern
        /// <c>projects/{project}/streams/{streams}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamsId">The <c>Streams</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StreamName"/> with pattern
        /// <c>projects/{project}/streams/{streams}</c>.
        /// </returns>
        public static string Format(string projectId, string streamsId) => FormatProjectStreams(projectId, streamsId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StreamName"/> with pattern
        /// <c>projects/{project}/streams/{streams}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamsId">The <c>Streams</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StreamName"/> with pattern
        /// <c>projects/{project}/streams/{streams}</c>.
        /// </returns>
        public static string FormatProjectStreams(string projectId, string streamsId) =>
            s_projectStreams.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(streamsId, nameof(streamsId)));

        /// <summary>Parses the given resource name string into a new <see cref="StreamName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/streams/{streams}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="streamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="StreamName"/> if successful.</returns>
        public static StreamName Parse(string streamName) => Parse(streamName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="StreamName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/streams/{streams}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="streamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="StreamName"/> if successful.</returns>
        public static StreamName Parse(string streamName, bool allowUnparsed) =>
            TryParse(streamName, allowUnparsed, out StreamName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StreamName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/streams/{streams}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="streamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StreamName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string streamName, out StreamName result) => TryParse(streamName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StreamName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/streams/{streams}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="streamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StreamName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string streamName, bool allowUnparsed, out StreamName result)
        {
            gax::GaxPreconditions.CheckNotNull(streamName, nameof(streamName));
            gax::TemplatedResourceName resourceName;
            if (s_projectStreams.TryParseName(streamName, out resourceName))
            {
                result = FromProjectStreams(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(streamName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private StreamName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string streamsId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            StreamsId = streamsId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="StreamName"/> class from the component parts of pattern
        /// <c>projects/{project}/streams/{streams}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamsId">The <c>Streams</c> ID. Must not be <c>null</c> or empty.</param>
        public StreamName(string projectId, string streamsId) : this(ResourceNameType.ProjectStreams, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), streamsId: gax::GaxPreconditions.CheckNotNullOrEmpty(streamsId, nameof(streamsId)))
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
        /// The <c>Streams</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string StreamsId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectStreams: return s_projectStreams.Expand(ProjectId, StreamsId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as StreamName);

        /// <inheritdoc/>
        public bool Equals(StreamName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(StreamName a, StreamName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(StreamName a, StreamName b) => !(a == b);
    }

    public partial class StreamSetup
    {
        /// <summary><see cref="StreamName"/>-typed view over the <see cref="Stream"/> resource name property.</summary>
        public StreamName StreamAsStreamName
        {
            get => string.IsNullOrEmpty(Stream) ? null : StreamName.Parse(Stream, allowUnparsed: true);
            set => Stream = value?.ToString() ?? "";
        }
    }

    public partial class CallConnectedEvent
    {
        /// <summary><see cref="CallName"/>-typed view over the <see cref="Call"/> resource name property.</summary>
        public CallName CallAsCallName
        {
            get => string.IsNullOrEmpty(Call) ? null : CallName.Parse(Call, allowUnparsed: true);
            set => Call = value?.ToString() ?? "";
        }
    }
}
