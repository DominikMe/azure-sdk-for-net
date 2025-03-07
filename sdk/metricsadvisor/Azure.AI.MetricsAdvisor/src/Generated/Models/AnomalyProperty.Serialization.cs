// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AnomalyProperty
    {
        internal static AnomalyProperty DeserializeAnomalyProperty(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AnomalySeverity anomalySeverity = default;
            AnomalyStatus? anomalyStatus = default;
            double value = default;
            double? expectedValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("anomalySeverity"u8))
                {
                    anomalySeverity = new AnomalySeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("anomalyStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    anomalyStatus = new AnomalyStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("expectedValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        expectedValue = null;
                        continue;
                    }
                    expectedValue = property.Value.GetDouble();
                    continue;
                }
            }
            return new AnomalyProperty(anomalySeverity, anomalyStatus, value, expectedValue);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AnomalyProperty FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAnomalyProperty(document.RootElement);
        }
    }
}
