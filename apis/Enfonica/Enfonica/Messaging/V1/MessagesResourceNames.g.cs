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

using emv = Enfonica.Messaging.V1;
using gax = Google.Api.Gax;
using sys = System;

namespace Enfonica.Messaging.V1
{
    /// <summary>Resource name for the <c>Message</c> resource.</summary>
    public sealed partial class MessageName : gax::IResourceName, sys::IEquatable<MessageName>
    {
        /// <summary>The possible contents of <see cref="MessageName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/messages/{message}</c>.</summary>
            ProjectMessage = 1,
        }

        private static gax::PathTemplate s_projectMessage = new gax::PathTemplate("projects/{project}/messages/{message}");

        /// <summary>Creates a <see cref="MessageName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MessageName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MessageName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MessageName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MessageName"/> with the pattern <c>projects/{project}/messages/{message}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MessageName"/> constructed from the provided ids.</returns>
        public static MessageName FromProjectMessage(string projectId, string messageId) =>
            new MessageName(ResourceNameType.ProjectMessage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), messageId: gax::GaxPreconditions.CheckNotNullOrEmpty(messageId, nameof(messageId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MessageName"/> with pattern
        /// <c>projects/{project}/messages/{message}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MessageName"/> with pattern
        /// <c>projects/{project}/messages/{message}</c>.
        /// </returns>
        public static string Format(string projectId, string messageId) => FormatProjectMessage(projectId, messageId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MessageName"/> with pattern
        /// <c>projects/{project}/messages/{message}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MessageName"/> with pattern
        /// <c>projects/{project}/messages/{message}</c>.
        /// </returns>
        public static string FormatProjectMessage(string projectId, string messageId) =>
            s_projectMessage.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(messageId, nameof(messageId)));

        /// <summary>Parses the given resource name string into a new <see cref="MessageName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/messages/{message}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="messageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MessageName"/> if successful.</returns>
        public static MessageName Parse(string messageName) => Parse(messageName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MessageName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/messages/{message}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="messageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MessageName"/> if successful.</returns>
        public static MessageName Parse(string messageName, bool allowUnparsed) =>
            TryParse(messageName, allowUnparsed, out MessageName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MessageName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/messages/{message}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="messageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MessageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string messageName, out MessageName result) => TryParse(messageName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MessageName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/messages/{message}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="messageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MessageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string messageName, bool allowUnparsed, out MessageName result)
        {
            gax::GaxPreconditions.CheckNotNull(messageName, nameof(messageName));
            gax::TemplatedResourceName resourceName;
            if (s_projectMessage.TryParseName(messageName, out resourceName))
            {
                result = FromProjectMessage(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(messageName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MessageName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string messageId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            MessageId = messageId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MessageName"/> class from the component parts of pattern
        /// <c>projects/{project}/messages/{message}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        public MessageName(string projectId, string messageId) : this(ResourceNameType.ProjectMessage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), messageId: gax::GaxPreconditions.CheckNotNullOrEmpty(messageId, nameof(messageId)))
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
        /// The <c>Message</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MessageId { get; }

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
                case ResourceNameType.ProjectMessage: return s_projectMessage.Expand(ProjectId, MessageId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MessageName);

        /// <inheritdoc/>
        public bool Equals(MessageName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(MessageName a, MessageName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(MessageName a, MessageName b) => !(a == b);
    }

    public partial class Message
    {
        /// <summary>
        /// <see cref="emv::MessageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public emv::MessageName MessageName
        {
            get => string.IsNullOrEmpty(Name) ? null : emv::MessageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateMessageRequest
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

    public partial class GetMessageRequest
    {
        /// <summary>
        /// <see cref="emv::MessageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public emv::MessageName MessageName
        {
            get => string.IsNullOrEmpty(Name) ? null : emv::MessageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListMessagesRequest
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
