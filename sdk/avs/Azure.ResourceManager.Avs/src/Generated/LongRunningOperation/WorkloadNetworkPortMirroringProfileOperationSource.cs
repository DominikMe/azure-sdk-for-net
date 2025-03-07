// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Avs
{
    internal class WorkloadNetworkPortMirroringProfileOperationSource : IOperationSource<WorkloadNetworkPortMirroringProfileResource>
    {
        private readonly ArmClient _client;

        internal WorkloadNetworkPortMirroringProfileOperationSource(ArmClient client)
        {
            _client = client;
        }

        WorkloadNetworkPortMirroringProfileResource IOperationSource<WorkloadNetworkPortMirroringProfileResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<WorkloadNetworkPortMirroringProfileData>(response.Content);
            return new WorkloadNetworkPortMirroringProfileResource(_client, data);
        }

        async ValueTask<WorkloadNetworkPortMirroringProfileResource> IOperationSource<WorkloadNetworkPortMirroringProfileResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<WorkloadNetworkPortMirroringProfileData>(response.Content);
            return await Task.FromResult(new WorkloadNetworkPortMirroringProfileResource(_client, data)).ConfigureAwait(false);
        }
    }
}
