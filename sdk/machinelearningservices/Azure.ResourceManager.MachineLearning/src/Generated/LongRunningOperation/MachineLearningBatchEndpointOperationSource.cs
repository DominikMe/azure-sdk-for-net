// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning
{
    internal class MachineLearningBatchEndpointOperationSource : IOperationSource<MachineLearningBatchEndpointResource>
    {
        private readonly ArmClient _client;

        internal MachineLearningBatchEndpointOperationSource(ArmClient client)
        {
            _client = client;
        }

        MachineLearningBatchEndpointResource IOperationSource<MachineLearningBatchEndpointResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<MachineLearningBatchEndpointData>(response.Content);
            return new MachineLearningBatchEndpointResource(_client, data);
        }

        async ValueTask<MachineLearningBatchEndpointResource> IOperationSource<MachineLearningBatchEndpointResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<MachineLearningBatchEndpointData>(response.Content);
            return await Task.FromResult(new MachineLearningBatchEndpointResource(_client, data)).ConfigureAwait(false);
        }
    }
}
