// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.OracleDatabase.Models;

namespace Azure.ResourceManager.OracleDatabase
{
    internal class CloudAccountActivationLinksOperationSource : IOperationSource<CloudAccountActivationLinks>
    {
        CloudAccountActivationLinks IOperationSource<CloudAccountActivationLinks>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return CloudAccountActivationLinks.DeserializeCloudAccountActivationLinks(document.RootElement);
        }

        async ValueTask<CloudAccountActivationLinks> IOperationSource<CloudAccountActivationLinks>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return CloudAccountActivationLinks.DeserializeCloudAccountActivationLinks(document.RootElement);
        }
    }
}
