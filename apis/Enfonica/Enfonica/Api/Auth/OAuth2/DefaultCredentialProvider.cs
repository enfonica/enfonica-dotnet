/*
Copyright 2020 Enfonica Pty Ltd
Modified: changed namespace and modified to support Enfonica auth.

Copyright 2015 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Google;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Json;
using Google.Apis.Logging;

namespace Enfonica.Api.Auth.OAuth2
{
    // TODO(jtattermusch): look into getting rid of DefaultCredentialProvider and moving
    // the logic into GoogleCredential.

    /// <summary>
    /// Provides the Application Default Credential from the environment. 
    /// An instance of this class represents the per-process state used to get and cache 
    /// the credential and allows overriding the state and environment for testing purposes.
    /// </summary>
    internal class DefaultCredentialProvider
    {
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<DefaultCredentialProvider>();

        /// <summary>
        /// Environment variable override which stores the default application credentials file path.
        /// </summary>
        public const string CredentialEnvironmentVariable = "ENFONICA_APPLICATION_CREDENTIALS";

        /// <summary>Help link to the application default credentials feature.</summary>
        private const string HelpPermalink = 
            "https://developers.google.com/accounts/docs/application-default-credentials"; // todo: change

        /// <summary>Caches result from first call to <c>GetApplicationDefaultCredentialAsync</c> </summary>
        private readonly Lazy<Task<EnfonicaCredential>> cachedCredentialTask;

        /// <summary>Constructs a new default credential provider.</summary>
        public DefaultCredentialProvider()
        {
            cachedCredentialTask = new Lazy<Task<EnfonicaCredential>>(CreateDefaultCredentialAsync);
        }

        /// <summary>
        /// Returns the Application Default Credentials. Subsequent invocations return cached value from
        /// first invocation.
        /// See <see cref="M:Google.Apis.Auth.OAuth2.GoogleCredential.GetApplicationDefaultAsync"/> for details.
        /// </summary>
        public Task<EnfonicaCredential> GetDefaultCredentialAsync() => cachedCredentialTask.Value;

        /// <summary>Creates a new default credential.</summary>
        private Task<EnfonicaCredential> CreateDefaultCredentialAsync()
        {
            // 1. First try the environment variable.
            string credentialPath = GetEnvironmentVariable(CredentialEnvironmentVariable);
            if (!String.IsNullOrWhiteSpace(credentialPath))
            {
                try
                {
                    return Task.FromResult(CreateDefaultCredentialFromFile(credentialPath));
                }
                catch (Exception e)
                {
                    // Catching generic exception type because any corrupted file could manifest in different ways
                    // including but not limited to the System, System.IO or from the Newtonsoft.Json namespace.
                    throw new InvalidOperationException(
                        String.Format("Error reading credential file from location {0}: {1}"
                            + "\nPlease check the value of the Environment Variable {2}",
                            credentialPath,
                            e.Message,
                            CredentialEnvironmentVariable), e);
                }
            }

            // If everything we tried has failed, throw an exception.
            throw new InvalidOperationException(
                String.Format("The Application Default Credentials are not available."
                    + " The environment variable {0} must be defined"
                    + " pointing to a file defining the credentials. See {1} for more information.",
                    CredentialEnvironmentVariable,
                    HelpPermalink));
        }

        /// <summary>Creates a default credential from a JSON file.</summary>
        private EnfonicaCredential CreateDefaultCredentialFromFile(string credentialPath)
        {
            Logger.Debug("Loading Credential from file {0}", credentialPath);

            using (Stream stream = GetStream(credentialPath))
            {
                return CreateDefaultCredentialFromStream(stream);
            }
        }

        /// <summary>Creates a default credential from a stream that contains JSON credential data.</summary>
        internal EnfonicaCredential CreateDefaultCredentialFromStream(Stream stream)
        {
            JsonCredentialParameters credentialParameters;
            try
            {
                credentialParameters = NewtonsoftJsonSerializer.Instance.Deserialize<JsonCredentialParameters>(stream);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error deserializing JSON credential data.", e);
            }
            return CreateDefaultCredentialFromParameters(credentialParameters);
        }

        /// <summary>Creates a default credential from a stream that contains JSON credential data.</summary>
        internal async Task<EnfonicaCredential> CreateDefaultCredentialFromStreamAsync(Stream stream, CancellationToken cancellationToken)
        {
            JsonCredentialParameters credentialParameters;
            try
            {
                credentialParameters = await NewtonsoftJsonSerializer.Instance
                    .DeserializeAsync<JsonCredentialParameters>(stream, cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error deserializing JSON credential data.", e);
            }
            return CreateDefaultCredentialFromParameters(credentialParameters);
        }

        /// <summary>Creates a default credential from a string that contains JSON credential data.</summary>
        internal EnfonicaCredential CreateDefaultCredentialFromJson(string json)
        {
            JsonCredentialParameters credentialParameters;
            try
            {
                credentialParameters = NewtonsoftJsonSerializer.Instance.Deserialize<JsonCredentialParameters>(json);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error deserializing JSON credential data.", e);
            }
            return CreateDefaultCredentialFromParameters(credentialParameters);
        }


        /// <summary>Creates a default credential from JSON data.</summary>
        private static EnfonicaCredential CreateDefaultCredentialFromParameters(JsonCredentialParameters credentialParameters)
        {
            switch (credentialParameters.Type)
            {
                case JsonCredentialParameters.ServiceAccountCredentialType:
                    return EnfonicaCredential.FromServiceAccountCredential(
                        CreateServiceAccountCredentialFromParameters(credentialParameters));
                default:
                    throw new InvalidOperationException(
                        String.Format("Error creating credential from JSON. Unrecognized credential type {0}.", 
                            credentialParameters.Type));
            }
        }

        /// <summary>Creates a <see cref="ServiceAccountCredential"/> from JSON data.</summary>
        private static ServiceAccountCredential CreateServiceAccountCredentialFromParameters(
            JsonCredentialParameters credentialParameters)
        {
            if (credentialParameters.Type != JsonCredentialParameters.ServiceAccountCredentialType ||
                string.IsNullOrEmpty(credentialParameters.ClientEmail) ||
                string.IsNullOrEmpty(credentialParameters.PrivateKey))
            {
                throw new InvalidOperationException("JSON data does not represent a valid service account credential.");
            }
            var initializer = new ServiceAccountCredential.Initializer(credentialParameters.ClientEmail)
            {
                ProjectId = credentialParameters.ProjectId,
                QuotaProject = credentialParameters.QuotaProject, // todo: remove
                KeyId = credentialParameters.PrivateKeyId
            };
            return new ServiceAccountCredential(initializer.FromPrivateKey(credentialParameters.PrivateKey));
        }

        /// <summary>
        /// Gets the environment variable. 
        /// This method is protected so it could be overriden for testing purposes only.
        /// </summary>
        protected virtual string GetEnvironmentVariable(string variableName)
        {
            return Environment.GetEnvironmentVariable(variableName);
        }

        /// <summary>
        /// Opens file as a stream.
        /// This method is protected so it could be overriden for testing purposes only.
        /// </summary>
        protected virtual Stream GetStream(string filePath)
        {
            return new FileStream(filePath, FileMode.Open, FileAccess.Read);
        }
    }
}
