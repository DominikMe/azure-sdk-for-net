// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Subscription
{
    internal class SubscriptionAliasOperationSource : IOperationSource<SubscriptionAliasResource>
    {
        private readonly ArmClient _client;

        internal SubscriptionAliasOperationSource(ArmClient client)
        {
            _client = client;
        }

        SubscriptionAliasResource IOperationSource<SubscriptionAliasResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SubscriptionAliasData>(response.Content);
            return new SubscriptionAliasResource(_client, data);
        }

        async ValueTask<SubscriptionAliasResource> IOperationSource<SubscriptionAliasResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SubscriptionAliasData>(response.Content);
            return await Task.FromResult(new SubscriptionAliasResource(_client, data)).ConfigureAwait(false);
        }
    }
}
