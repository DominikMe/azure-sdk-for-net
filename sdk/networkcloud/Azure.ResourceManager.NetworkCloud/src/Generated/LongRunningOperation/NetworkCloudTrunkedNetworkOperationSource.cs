// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud
{
    internal class NetworkCloudTrunkedNetworkOperationSource : IOperationSource<NetworkCloudTrunkedNetworkResource>
    {
        private readonly ArmClient _client;

        internal NetworkCloudTrunkedNetworkOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkCloudTrunkedNetworkResource IOperationSource<NetworkCloudTrunkedNetworkResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NetworkCloudTrunkedNetworkData>(response.Content);
            return new NetworkCloudTrunkedNetworkResource(_client, data);
        }

        async ValueTask<NetworkCloudTrunkedNetworkResource> IOperationSource<NetworkCloudTrunkedNetworkResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NetworkCloudTrunkedNetworkData>(response.Content);
            return await Task.FromResult(new NetworkCloudTrunkedNetworkResource(_client, data)).ConfigureAwait(false);
        }
    }
}
