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
    internal class PreRulestackRuleOperationSource : IOperationSource<PreRulestackRuleResource>
    {
        private readonly ArmClient _client;

        internal PreRulestackRuleOperationSource(ArmClient client)
        {
            _client = client;
        }

        PreRulestackRuleResource IOperationSource<PreRulestackRuleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<PreRulestackRuleData>(response.Content);
            return new PreRulestackRuleResource(_client, data);
        }

        async ValueTask<PreRulestackRuleResource> IOperationSource<PreRulestackRuleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<PreRulestackRuleData>(response.Content);
            return await Task.FromResult(new PreRulestackRuleResource(_client, data)).ConfigureAwait(false);
        }
    }
}
