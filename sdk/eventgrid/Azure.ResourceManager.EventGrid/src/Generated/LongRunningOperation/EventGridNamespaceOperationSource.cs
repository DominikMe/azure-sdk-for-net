// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid
{
    internal class EventGridNamespaceOperationSource : IOperationSource<EventGridNamespaceResource>
    {
        private readonly ArmClient _client;

        internal EventGridNamespaceOperationSource(ArmClient client)
        {
            _client = client;
        }

        EventGridNamespaceResource IOperationSource<EventGridNamespaceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<EventGridNamespaceData>(response.Content);
            return new EventGridNamespaceResource(_client, data);
        }

        async ValueTask<EventGridNamespaceResource> IOperationSource<EventGridNamespaceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<EventGridNamespaceData>(response.Content);
            return await Task.FromResult(new EventGridNamespaceResource(_client, data)).ConfigureAwait(false);
        }
    }
}
