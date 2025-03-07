// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class EntityLinkingLROResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("results"u8);
            writer.WriteObjectValue(Results);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(TaskName))
            {
                writer.WritePropertyName("taskName"u8);
                writer.WriteStringValue(TaskName);
            }
            writer.WritePropertyName("lastUpdateDateTime"u8);
            writer.WriteStringValue(LastUpdateDateTime, "O");
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            writer.WriteEndObject();
        }

        internal static EntityLinkingLROResult DeserializeEntityLinkingLROResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EntityLinkingResult results = default;
            AnalyzeTextLROResultsKind kind = default;
            string taskName = default;
            DateTimeOffset lastUpdateDateTime = default;
            TextAnalyticsOperationStatus status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"u8))
                {
                    results = EntityLinkingResult.DeserializeEntityLinkingResult(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new AnalyzeTextLROResultsKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("taskName"u8))
                {
                    taskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"u8))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new TextAnalyticsOperationStatus(property.Value.GetString());
                    continue;
                }
            }
            return new EntityLinkingLROResult(lastUpdateDateTime, status, kind, taskName, results);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new EntityLinkingLROResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeEntityLinkingLROResult(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
