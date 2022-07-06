// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Error Body contract. </summary>
    public partial class ErrorResponseBody
    {
        /// <summary> Initializes a new instance of ErrorResponseBody. </summary>
        public ErrorResponseBody()
        {
            Details = new ChangeTrackingList<ErrorFieldContract>();
        }

        /// <summary> Initializes a new instance of ErrorResponseBody. </summary>
        /// <param name="code"> Service-defined error code. This code serves as a sub-status for the HTTP error code specified in the response. </param>
        /// <param name="message"> Human-readable representation of the error. </param>
        /// <param name="details"> The list of invalid fields send in request, in case of validation error. </param>
        internal ErrorResponseBody(string code, string message, IList<ErrorFieldContract> details)
        {
            Code = code;
            Message = message;
            Details = details;
        }

        /// <summary> Service-defined error code. This code serves as a sub-status for the HTTP error code specified in the response. </summary>
        public string Code { get; set; }
        /// <summary> Human-readable representation of the error. </summary>
        public string Message { get; set; }
        /// <summary> The list of invalid fields send in request, in case of validation error. </summary>
        public IList<ErrorFieldContract> Details { get; }
    }
}
