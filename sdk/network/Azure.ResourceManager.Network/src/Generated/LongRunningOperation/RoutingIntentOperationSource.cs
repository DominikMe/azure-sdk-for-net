// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Network
{
    internal class RoutingIntentOperationSource : IOperationSource<RoutingIntentResource>
    {
        private readonly ArmClient _client;

        internal RoutingIntentOperationSource(ArmClient client)
        {
            _client = client;
        }

        RoutingIntentResource IOperationSource<RoutingIntentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<RoutingIntentData>(response.Content);
            return new RoutingIntentResource(_client, data);
        }

        async ValueTask<RoutingIntentResource> IOperationSource<RoutingIntentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<RoutingIntentData>(response.Content);
            return await Task.FromResult(new RoutingIntentResource(_client, data)).ConfigureAwait(false);
        }
    }
}
