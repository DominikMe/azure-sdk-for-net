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
    internal class AppServiceCertificateOperationSource : IOperationSource<AppServiceCertificateResource>
    {
        private readonly ArmClient _client;

        internal AppServiceCertificateOperationSource(ArmClient client)
        {
            _client = client;
        }

        AppServiceCertificateResource IOperationSource<AppServiceCertificateResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<AppServiceCertificateData>(response.Content);
            return new AppServiceCertificateResource(_client, data);
        }

        async ValueTask<AppServiceCertificateResource> IOperationSource<AppServiceCertificateResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<AppServiceCertificateData>(response.Content);
            return await Task.FromResult(new AppServiceCertificateResource(_client, data)).ConfigureAwait(false);
        }
    }
}
