﻿/*
Copyright 2021 Enfonica Pty Ltd
Modified: changed namespace and modified to support Enfonica auth.

Copyright 2013 Google Inc

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

namespace Enfonica.Api.Auth.OAuth2
{
    /// <summary>
    /// Enfonica OAuth2 constants.
    /// </summary>
    internal static class EnfonicaAuthConsts
    {
        /// <summary>The OpenID Connect authorization token server URL.</summary>
        public static string OidcTokenUrl { get; internal set; } = "https://oauth2.api.enfonica.com/token";
    }
}