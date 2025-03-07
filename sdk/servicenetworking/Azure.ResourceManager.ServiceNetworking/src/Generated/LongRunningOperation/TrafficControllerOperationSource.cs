// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ServiceNetworking
{
    internal class TrafficControllerOperationSource : IOperationSource<TrafficControllerResource>
    {
        private readonly ArmClient _client;

        internal TrafficControllerOperationSource(ArmClient client)
        {
            _client = client;
        }

        TrafficControllerResource IOperationSource<TrafficControllerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<TrafficControllerData>(response.Content);
            return new TrafficControllerResource(_client, data);
        }

        async ValueTask<TrafficControllerResource> IOperationSource<TrafficControllerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<TrafficControllerData>(response.Content);
            return await Task.FromResult(new TrafficControllerResource(_client, data)).ConfigureAwait(false);
        }
    }
}
