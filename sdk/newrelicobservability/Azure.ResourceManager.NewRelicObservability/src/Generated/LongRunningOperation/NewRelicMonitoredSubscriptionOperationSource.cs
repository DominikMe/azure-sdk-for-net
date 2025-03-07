// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability
{
    internal class NewRelicMonitoredSubscriptionOperationSource : IOperationSource<NewRelicMonitoredSubscriptionResource>
    {
        private readonly ArmClient _client;

        internal NewRelicMonitoredSubscriptionOperationSource(ArmClient client)
        {
            _client = client;
        }

        NewRelicMonitoredSubscriptionResource IOperationSource<NewRelicMonitoredSubscriptionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NewRelicMonitoredSubscriptionData>(response.Content);
            return new NewRelicMonitoredSubscriptionResource(_client, data);
        }

        async ValueTask<NewRelicMonitoredSubscriptionResource> IOperationSource<NewRelicMonitoredSubscriptionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NewRelicMonitoredSubscriptionData>(response.Content);
            return await Task.FromResult(new NewRelicMonitoredSubscriptionResource(_client, data)).ConfigureAwait(false);
        }
    }
}
