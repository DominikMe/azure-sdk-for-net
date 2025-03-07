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
    internal class NetworkFabricAccessControlListOperationSource : IOperationSource<NetworkFabricAccessControlListResource>
    {
        private readonly ArmClient _client;

        internal NetworkFabricAccessControlListOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkFabricAccessControlListResource IOperationSource<NetworkFabricAccessControlListResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NetworkFabricAccessControlListData>(response.Content);
            return new NetworkFabricAccessControlListResource(_client, data);
        }

        async ValueTask<NetworkFabricAccessControlListResource> IOperationSource<NetworkFabricAccessControlListResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NetworkFabricAccessControlListData>(response.Content);
            return await Task.FromResult(new NetworkFabricAccessControlListResource(_client, data)).ConfigureAwait(false);
        }
    }
}
