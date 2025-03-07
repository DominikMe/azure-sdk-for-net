// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.TextAnalytics.Legacy
{
    internal partial class HealthcareTaskResult
    {
        internal static HealthcareTaskResult DeserializeHealthcareTaskResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HealthcareResult results = default;
            IReadOnlyList<TextAnalyticsError> errors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    results = HealthcareResult.DeserializeHealthcareResult(property.Value);
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TextAnalyticsError> array = new List<TextAnalyticsError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextAnalyticsError.DeserializeTextAnalyticsError(item));
                    }
                    errors = array;
                    continue;
                }
            }
            return new HealthcareTaskResult(results, errors ?? new ChangeTrackingList<TextAnalyticsError>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static HealthcareTaskResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeHealthcareTaskResult(document.RootElement);
        }
    }
}
