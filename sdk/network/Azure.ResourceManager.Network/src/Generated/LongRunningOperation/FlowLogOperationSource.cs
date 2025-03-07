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
    internal class FlowLogOperationSource : IOperationSource<FlowLogResource>
    {
        private readonly ArmClient _client;

        internal FlowLogOperationSource(ArmClient client)
        {
            _client = client;
        }

        FlowLogResource IOperationSource<FlowLogResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<FlowLogData>(response.Content);
            return new FlowLogResource(_client, data);
        }

        async ValueTask<FlowLogResource> IOperationSource<FlowLogResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<FlowLogData>(response.Content);
            return await Task.FromResult(new FlowLogResource(_client, data)).ConfigureAwait(false);
        }
    }
}
