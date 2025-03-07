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
    internal class AppCertificateOperationSource : IOperationSource<AppCertificateResource>
    {
        private readonly ArmClient _client;

        internal AppCertificateOperationSource(ArmClient client)
        {
            _client = client;
        }

        AppCertificateResource IOperationSource<AppCertificateResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<AppCertificateData>(response.Content);
            return new AppCertificateResource(_client, data);
        }

        async ValueTask<AppCertificateResource> IOperationSource<AppCertificateResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<AppCertificateData>(response.Content);
            return await Task.FromResult(new AppCertificateResource(_client, data)).ConfigureAwait(false);
        }
    }
}
