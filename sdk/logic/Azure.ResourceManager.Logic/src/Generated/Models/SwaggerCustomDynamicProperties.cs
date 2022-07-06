// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The swagger custom dynamic properties. </summary>
    public partial class SwaggerCustomDynamicProperties
    {
        /// <summary> Initializes a new instance of SwaggerCustomDynamicProperties. </summary>
        public SwaggerCustomDynamicProperties()
        {
            Parameters = new ChangeTrackingDictionary<string, SwaggerCustomDynamicProperties>();
        }

        /// <summary> Initializes a new instance of SwaggerCustomDynamicProperties. </summary>
        /// <param name="operationId"> The operation id to fetch dynamic schema. </param>
        /// <param name="valuePath"> Json pointer to the dynamic schema on the response body. </param>
        /// <param name="parameters"> The operation parameters. </param>
        internal SwaggerCustomDynamicProperties(string operationId, string valuePath, IDictionary<string, SwaggerCustomDynamicProperties> parameters)
        {
            OperationId = operationId;
            ValuePath = valuePath;
            Parameters = parameters;
        }

        /// <summary> The operation id to fetch dynamic schema. </summary>
        public string OperationId { get; set; }
        /// <summary> Json pointer to the dynamic schema on the response body. </summary>
        public string ValuePath { get; set; }
        /// <summary> The operation parameters. </summary>
        public IDictionary<string, SwaggerCustomDynamicProperties> Parameters { get; }
    }
}
