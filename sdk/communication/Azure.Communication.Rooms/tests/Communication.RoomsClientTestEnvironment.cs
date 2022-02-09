// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.Communication.Rooms.Tests
{
    public class Communication.RoomsClientTestEnvironment : TestEnvironment
    {
        public string Endpoint => GetRecordedVariable("Communication.Rooms_ENDPOINT");

        // Add other client paramters here as above.
    }
}
