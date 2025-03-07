// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    internal class NetworkFabricOperationSource : IOperationSource<NetworkFabricResource>
    {
        private readonly ArmClient _client;

        internal NetworkFabricOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkFabricResource IOperationSource<NetworkFabricResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NetworkFabricData>(response.Content);
            return new NetworkFabricResource(_client, data);
        }

        async ValueTask<NetworkFabricResource> IOperationSource<NetworkFabricResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NetworkFabricData>(response.Content);
            return await Task.FromResult(new NetworkFabricResource(_client, data)).ConfigureAwait(false);
        }
    }
}
