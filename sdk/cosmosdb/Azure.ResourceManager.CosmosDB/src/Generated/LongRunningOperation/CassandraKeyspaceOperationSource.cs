// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB
{
    internal class CassandraKeyspaceOperationSource : IOperationSource<CassandraKeyspaceResource>
    {
        private readonly ArmClient _client;

        internal CassandraKeyspaceOperationSource(ArmClient client)
        {
            _client = client;
        }

        CassandraKeyspaceResource IOperationSource<CassandraKeyspaceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<CassandraKeyspaceData>(response.Content);
            return new CassandraKeyspaceResource(_client, data);
        }

        async ValueTask<CassandraKeyspaceResource> IOperationSource<CassandraKeyspaceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<CassandraKeyspaceData>(response.Content);
            return await Task.FromResult(new CassandraKeyspaceResource(_client, data)).ConfigureAwait(false);
        }
    }
}
