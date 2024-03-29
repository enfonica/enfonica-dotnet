﻿/*
Copyright 2022 Enfonica Pty Ltd
Copyright 2010 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

Modified to support functionality.
*/

using System;
using Google.Apis.Util;

namespace Enfonica.Api
{
    /// <summary>Represents an exception thrown by an API Service.</summary>
    public class EnfonicaApiException : Exception
    {
        private readonly string serviceName;

        /// <summary>Gets the service name which related to this exception.</summary>
        public string ServiceName
        {
            get { return serviceName; }
        }

        /// <summary>Creates an API Service exception.</summary>
        public EnfonicaApiException(string serviceName, string message, Exception inner)
            : base(message, inner)
        {
            serviceName.ThrowIfNull("serviceName");
            this.serviceName = serviceName;
        }

        /// <summary>Creates an API Service exception.</summary>
        public EnfonicaApiException(string serviceName, string message) : this(serviceName, message, null) { }

        /// <summary>
        /// Returns a summary of this exception.
        /// </summary>
        /// <returns>A summary of this exception.</returns>
        public override string ToString()
        {
            return string.Format("The service {1} has thrown an exception: {0}", base.ToString(), serviceName);
        }
    }
}
