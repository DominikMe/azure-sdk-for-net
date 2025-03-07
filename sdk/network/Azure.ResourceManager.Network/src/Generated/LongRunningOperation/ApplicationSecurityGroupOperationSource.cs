// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Network
{
    internal class ApplicationSecurityGroupOperationSource : IOperationSource<ApplicationSecurityGroupResource>
    {
        private readonly ArmClient _client;

        internal ApplicationSecurityGroupOperationSource(ArmClient client)
        {
            _client = client;
        }

        ApplicationSecurityGroupResource IOperationSource<ApplicationSecurityGroupResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ApplicationSecurityGroupData>(response.Content);
            return new ApplicationSecurityGroupResource(_client, data);
        }

        async ValueTask<ApplicationSecurityGroupResource> IOperationSource<ApplicationSecurityGroupResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ApplicationSecurityGroupData>(response.Content);
            return await Task.FromResult(new ApplicationSecurityGroupResource(_client, data)).ConfigureAwait(false);
        }
    }
}
