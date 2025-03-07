// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform
{
    internal class AppPlatformDeploymentOperationSource : IOperationSource<AppPlatformDeploymentResource>
    {
        private readonly ArmClient _client;

        internal AppPlatformDeploymentOperationSource(ArmClient client)
        {
            _client = client;
        }

        AppPlatformDeploymentResource IOperationSource<AppPlatformDeploymentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<AppPlatformDeploymentData>(response.Content);
            return new AppPlatformDeploymentResource(_client, data);
        }

        async ValueTask<AppPlatformDeploymentResource> IOperationSource<AppPlatformDeploymentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<AppPlatformDeploymentData>(response.Content);
            return await Task.FromResult(new AppPlatformDeploymentResource(_client, data)).ConfigureAwait(false);
        }
    }
}
