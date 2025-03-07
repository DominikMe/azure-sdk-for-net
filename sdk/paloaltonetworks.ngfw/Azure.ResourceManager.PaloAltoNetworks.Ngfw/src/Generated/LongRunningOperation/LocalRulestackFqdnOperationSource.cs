// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    internal class LocalRulestackFqdnOperationSource : IOperationSource<LocalRulestackFqdnResource>
    {
        private readonly ArmClient _client;

        internal LocalRulestackFqdnOperationSource(ArmClient client)
        {
            _client = client;
        }

        LocalRulestackFqdnResource IOperationSource<LocalRulestackFqdnResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<LocalRulestackFqdnData>(response.Content);
            return new LocalRulestackFqdnResource(_client, data);
        }

        async ValueTask<LocalRulestackFqdnResource> IOperationSource<LocalRulestackFqdnResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<LocalRulestackFqdnData>(response.Content);
            return await Task.FromResult(new LocalRulestackFqdnResource(_client, data)).ConfigureAwait(false);
        }
    }
}
