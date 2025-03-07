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
    internal class StaticSiteOperationSource : IOperationSource<StaticSiteResource>
    {
        private readonly ArmClient _client;

        internal StaticSiteOperationSource(ArmClient client)
        {
            _client = client;
        }

        StaticSiteResource IOperationSource<StaticSiteResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<StaticSiteData>(response.Content);
            return new StaticSiteResource(_client, data);
        }

        async ValueTask<StaticSiteResource> IOperationSource<StaticSiteResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<StaticSiteData>(response.Content);
            return await Task.FromResult(new StaticSiteResource(_client, data)).ConfigureAwait(false);
        }
    }
}
