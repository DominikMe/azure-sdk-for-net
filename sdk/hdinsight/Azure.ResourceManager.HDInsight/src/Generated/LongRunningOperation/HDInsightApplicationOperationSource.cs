// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight
{
    internal class HDInsightApplicationOperationSource : IOperationSource<HDInsightApplicationResource>
    {
        private readonly ArmClient _client;

        internal HDInsightApplicationOperationSource(ArmClient client)
        {
            _client = client;
        }

        HDInsightApplicationResource IOperationSource<HDInsightApplicationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<HDInsightApplicationData>(response.Content);
            return new HDInsightApplicationResource(_client, data);
        }

        async ValueTask<HDInsightApplicationResource> IOperationSource<HDInsightApplicationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<HDInsightApplicationData>(response.Content);
            return await Task.FromResult(new HDInsightApplicationResource(_client, data)).ConfigureAwait(false);
        }
    }
}
