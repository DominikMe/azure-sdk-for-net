// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesBackup.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    internal class TieringCostInfoOperationSource : IOperationSource<TieringCostInfo>
    {
        TieringCostInfo IOperationSource<TieringCostInfo>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return TieringCostInfo.DeserializeTieringCostInfo(document.RootElement);
        }

        async ValueTask<TieringCostInfo> IOperationSource<TieringCostInfo>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return TieringCostInfo.DeserializeTieringCostInfo(document.RootElement);
        }
    }
}
