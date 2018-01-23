﻿// Copyright (c) Microsoft Corporation
// Licensed under the MIT license. See LICENSE file in the project root for full license information.


using System;
using System.Runtime.Serialization;

namespace SessionHistoryViewer
{
    [DataContract]
    public class SessionHistoryQueryByGamertagRequest
    {
        [DataMember(EmitDefaultValue = false)]
        public string gamertag { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime startAt { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime endAt { get; set; }
    }
}