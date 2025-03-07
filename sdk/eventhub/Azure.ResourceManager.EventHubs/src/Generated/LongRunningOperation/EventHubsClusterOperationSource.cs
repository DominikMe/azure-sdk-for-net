// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs
{
    internal class EventHubsClusterOperationSource : IOperationSource<EventHubsClusterResource>
    {
        private readonly ArmClient _client;

        internal EventHubsClusterOperationSource(ArmClient client)
        {
            _client = client;
        }

        EventHubsClusterResource IOperationSource<EventHubsClusterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<EventHubsClusterData>(response.Content);
            return new EventHubsClusterResource(_client, data);
        }

        async ValueTask<EventHubsClusterResource> IOperationSource<EventHubsClusterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<EventHubsClusterData>(response.Content);
            return await Task.FromResult(new EventHubsClusterResource(_client, data)).ConfigureAwait(false);
        }
    }
}
