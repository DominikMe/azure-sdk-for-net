// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.DataFactory.Models;

namespace Azure.ResourceManager.DataFactory
{
    internal class DataFactoryIntegrationRuntimeStatusResultOperationSource : IOperationSource<DataFactoryIntegrationRuntimeStatusResult>
    {
        DataFactoryIntegrationRuntimeStatusResult IOperationSource<DataFactoryIntegrationRuntimeStatusResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return DataFactoryIntegrationRuntimeStatusResult.DeserializeDataFactoryIntegrationRuntimeStatusResult(document.RootElement);
        }

        async ValueTask<DataFactoryIntegrationRuntimeStatusResult> IOperationSource<DataFactoryIntegrationRuntimeStatusResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return DataFactoryIntegrationRuntimeStatusResult.DeserializeDataFactoryIntegrationRuntimeStatusResult(document.RootElement);
        }
    }
}
