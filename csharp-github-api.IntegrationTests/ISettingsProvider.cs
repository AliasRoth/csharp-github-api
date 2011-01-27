﻿//-----------------------------------------------------------------------
// <copyright file="ISettingsProvider.cs" company="TemporalCohesion.co.uk">
//     Copyright [2010] [Stuart Grassie]
//
//     Licensed under the Apache License, Version 2.0 (the "License");
//     you may not use this file except in compliance with the License.
//     You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//     Unless required by applicable law or agreed to in writing, software
//     distributed under the License is distributed on an "AS IS" BASIS,
//     WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//     See the License for the specific language governing permissions and
//     limitations under the License.
// </copyright>
//----------------------------------------------------------------------

using csharp_github_api.Framework;

namespace csharp_github_api.IntegrationTests
{
    /// <summary>
    /// Defines the interface for settings providers.
    /// </summary>
    public interface ISettingsProvider
    {
        /// <summary>
        /// Populates the settings object.
        /// </summary>
        /// <param name="settings">The <see cref="IGitHubApiSettings"/> object to pass to the API.</param>
        /// <returns>The populated <paramref name="settings"/> object.</returns>
        IGitHubApiSettings PopulateSettings(IGitHubApiSettings settings);
    }
}
