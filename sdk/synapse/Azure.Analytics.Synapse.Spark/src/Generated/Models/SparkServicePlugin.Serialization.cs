// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;

namespace Azure.Analytics.Synapse.Spark.Models
{
    public partial class SparkServicePlugin
    {
        internal static SparkServicePlugin DeserializeSparkServicePlugin(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? preparationStartedAt = default;
            DateTimeOffset? resourceAcquisitionStartedAt = default;
            DateTimeOffset? submissionStartedAt = default;
            DateTimeOffset? monitoringStartedAt = default;
            DateTimeOffset? cleanupStartedAt = default;
            PluginCurrentState? currentState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preparationStartedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        preparationStartedAt = null;
                        continue;
                    }
                    preparationStartedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("resourceAcquisitionStartedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceAcquisitionStartedAt = null;
                        continue;
                    }
                    resourceAcquisitionStartedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("submissionStartedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        submissionStartedAt = null;
                        continue;
                    }
                    submissionStartedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("monitoringStartedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        monitoringStartedAt = null;
                        continue;
                    }
                    monitoringStartedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cleanupStartedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cleanupStartedAt = null;
                        continue;
                    }
                    cleanupStartedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentState = new PluginCurrentState(property.Value.GetString());
                    continue;
                }
            }
            return new SparkServicePlugin(
                preparationStartedAt,
                resourceAcquisitionStartedAt,
                submissionStartedAt,
                monitoringStartedAt,
                cleanupStartedAt,
                currentState);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SparkServicePlugin FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeSparkServicePlugin(document.RootElement);
        }
    }
}
