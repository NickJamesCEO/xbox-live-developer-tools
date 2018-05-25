﻿// Copyright (c) Microsoft Corporation
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Xbox.Services.DevTools.XblConfig
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Represents a web service entry associated with an account.
    /// </summary>
    public class WebService
    {
        /// <summary>
        /// Gets or sets the account ID associated with the web service.
        /// </summary>
        [Display(Omit = true, ListOmit = true)]
        public Guid AccountId { get; set; }

        /// <summary>
        /// Gets or sets the name of the web service.
        /// </summary>
        [Display(Name = "Name", Order = 1, ListOrder = 1)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the service ID of the web service.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name = "Service ID", Order = 2, ListOrder = 2)]
        public Guid ServiceId { get; set; }

        /// <summary>
        /// Gets or sets a boolean value which enables your service to retrieve game telemetry data for any of your games.
        /// </summary>
        [Display(Name = "Telemetry Access", Order = 3, ListOrder = 3)]
        public bool TelemetryAccess { get; set; }

        /// <summary>
        /// Gets or sets a boolean value which gives the media provider owning the service the authority to programmatically publish app channels for consumption on console through the OneGuide twist.
        /// </summary>
        [Display(Name = "App Channels Access", Order = 4, ListOrder = 4)]
        public bool AppChannelsAccess { get; set; }
    }
}
