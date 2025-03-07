// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Resources
{
    internal class ArmDeploymentScriptOperationSource : IOperationSource<ArmDeploymentScriptResource>
    {
        private readonly ArmClient _client;

        internal ArmDeploymentScriptOperationSource(ArmClient client)
        {
            _client = client;
        }

        ArmDeploymentScriptResource IOperationSource<ArmDeploymentScriptResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ArmDeploymentScriptData>(response.Content);
            return new ArmDeploymentScriptResource(_client, data);
        }

        async ValueTask<ArmDeploymentScriptResource> IOperationSource<ArmDeploymentScriptResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ArmDeploymentScriptData>(response.Content);
            return await Task.FromResult(new ArmDeploymentScriptResource(_client, data)).ConfigureAwait(false);
        }
    }
}
