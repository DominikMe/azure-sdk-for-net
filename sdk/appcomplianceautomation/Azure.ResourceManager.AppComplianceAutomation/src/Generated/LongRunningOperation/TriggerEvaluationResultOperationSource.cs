// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.AppComplianceAutomation.Models;

namespace Azure.ResourceManager.AppComplianceAutomation
{
    internal class TriggerEvaluationResultOperationSource : IOperationSource<TriggerEvaluationResult>
    {
        TriggerEvaluationResult IOperationSource<TriggerEvaluationResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return TriggerEvaluationResult.DeserializeTriggerEvaluationResult(document.RootElement);
        }

        async ValueTask<TriggerEvaluationResult> IOperationSource<TriggerEvaluationResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return TriggerEvaluationResult.DeserializeTriggerEvaluationResult(document.RootElement);
        }
    }
}
