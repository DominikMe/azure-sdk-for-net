// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    internal class SiteRecoveryVCenterOperationSource : IOperationSource<SiteRecoveryVCenterResource>
    {
        private readonly ArmClient _client;

        internal SiteRecoveryVCenterOperationSource(ArmClient client)
        {
            _client = client;
        }

        SiteRecoveryVCenterResource IOperationSource<SiteRecoveryVCenterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SiteRecoveryVCenterData>(response.Content);
            return new SiteRecoveryVCenterResource(_client, data);
        }

        async ValueTask<SiteRecoveryVCenterResource> IOperationSource<SiteRecoveryVCenterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SiteRecoveryVCenterData>(response.Content);
            return await Task.FromResult(new SiteRecoveryVCenterResource(_client, data)).ConfigureAwait(false);
        }
    }
}
