// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.AppService
{
    internal class StaticSiteCustomDomainOverviewOperationSource : IOperationSource<StaticSiteCustomDomainOverviewResource>
    {
        private readonly ArmClient _client;

        internal StaticSiteCustomDomainOverviewOperationSource(ArmClient client)
        {
            _client = client;
        }

        StaticSiteCustomDomainOverviewResource IOperationSource<StaticSiteCustomDomainOverviewResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<StaticSiteCustomDomainOverviewData>(response.Content);
            return new StaticSiteCustomDomainOverviewResource(_client, data);
        }

        async ValueTask<StaticSiteCustomDomainOverviewResource> IOperationSource<StaticSiteCustomDomainOverviewResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<StaticSiteCustomDomainOverviewData>(response.Content);
            return await Task.FromResult(new StaticSiteCustomDomainOverviewResource(_client, data)).ConfigureAwait(false);
        }
    }
}
