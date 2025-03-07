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
    internal class PublishingUserOperationSource : IOperationSource<PublishingUserResource>
    {
        private readonly ArmClient _client;

        internal PublishingUserOperationSource(ArmClient client)
        {
            _client = client;
        }

        PublishingUserResource IOperationSource<PublishingUserResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<PublishingUserData>(response.Content);
            return new PublishingUserResource(_client, data);
        }

        async ValueTask<PublishingUserResource> IOperationSource<PublishingUserResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<PublishingUserData>(response.Content);
            return await Task.FromResult(new PublishingUserResource(_client, data)).ConfigureAwait(false);
        }
    }
}
