// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Json-serialized array of User subscription quota response. </summary>
    internal partial class UserSubscriptionQuotaListResult
    {
        /// <summary> Initializes a new instance of UserSubscriptionQuotaListResult. </summary>
        internal UserSubscriptionQuotaListResult()
        {
            Value = new ChangeTrackingList<UserSubscriptionQuota>();
        }

        /// <summary> Initializes a new instance of UserSubscriptionQuotaListResult. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        internal UserSubscriptionQuotaListResult(IReadOnlyList<UserSubscriptionQuota> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<UserSubscriptionQuota> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
