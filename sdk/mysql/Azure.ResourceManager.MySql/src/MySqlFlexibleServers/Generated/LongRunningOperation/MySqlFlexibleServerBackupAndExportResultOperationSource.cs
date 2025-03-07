// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.MySql.FlexibleServers.Models;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    internal class MySqlFlexibleServerBackupAndExportResultOperationSource : IOperationSource<MySqlFlexibleServerBackupAndExportResult>
    {
        MySqlFlexibleServerBackupAndExportResult IOperationSource<MySqlFlexibleServerBackupAndExportResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return MySqlFlexibleServerBackupAndExportResult.DeserializeMySqlFlexibleServerBackupAndExportResult(document.RootElement);
        }

        async ValueTask<MySqlFlexibleServerBackupAndExportResult> IOperationSource<MySqlFlexibleServerBackupAndExportResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return MySqlFlexibleServerBackupAndExportResult.DeserializeMySqlFlexibleServerBackupAndExportResult(document.RootElement);
        }
    }
}
