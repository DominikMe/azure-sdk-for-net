// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Rooms
{
    /// <summary> Request payload for updating a room. </summary>
    internal partial class UpdateRoomRequest
    {
        /// <summary> Initializes a new instance of UpdateRoomRequest. </summary>
        public UpdateRoomRequest()
        {
            Participants = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> The timestamp from when the room is open for joining. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </summary>
        public DateTimeOffset? ValidFrom { get; set; }
        /// <summary> The timestamp from when the room can no longer be joined. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </summary>
        public DateTimeOffset? ValidUntil { get; set; }
        /// <summary> (Optional) Collection of identities invited to the room. </summary>
        public IDictionary<string, object> Participants { get; }
    }
}
