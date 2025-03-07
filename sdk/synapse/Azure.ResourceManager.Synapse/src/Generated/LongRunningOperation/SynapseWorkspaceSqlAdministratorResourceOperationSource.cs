// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Synapse
{
    internal class SynapseWorkspaceSqlAdministratorResourceOperationSource : IOperationSource<SynapseWorkspaceSqlAdministratorResource>
    {
        private readonly ArmClient _client;

        internal SynapseWorkspaceSqlAdministratorResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        SynapseWorkspaceSqlAdministratorResource IOperationSource<SynapseWorkspaceSqlAdministratorResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SynapseWorkspaceAadAdminInfoData>(response.Content);
            return new SynapseWorkspaceSqlAdministratorResource(_client, data);
        }

        async ValueTask<SynapseWorkspaceSqlAdministratorResource> IOperationSource<SynapseWorkspaceSqlAdministratorResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SynapseWorkspaceAadAdminInfoData>(response.Content);
            return await Task.FromResult(new SynapseWorkspaceSqlAdministratorResource(_client, data)).ConfigureAwait(false);
        }
    }
}
