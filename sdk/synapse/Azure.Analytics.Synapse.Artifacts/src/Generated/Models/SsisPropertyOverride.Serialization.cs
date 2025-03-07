// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SsisPropertyOverrideConverter))]
    public partial class SsisPropertyOverride : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteObjectValue<object>(Value);
            if (Optional.IsDefined(IsSensitive))
            {
                writer.WritePropertyName("isSensitive"u8);
                writer.WriteBooleanValue(IsSensitive.Value);
            }
            writer.WriteEndObject();
        }

        internal static SsisPropertyOverride DeserializeSsisPropertyOverride(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object value = default;
            bool? isSensitive = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("isSensitive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSensitive = property.Value.GetBoolean();
                    continue;
                }
            }
            return new SsisPropertyOverride(value, isSensitive);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SsisPropertyOverride FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeSsisPropertyOverride(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class SsisPropertyOverrideConverter : JsonConverter<SsisPropertyOverride>
        {
            public override void Write(Utf8JsonWriter writer, SsisPropertyOverride model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override SsisPropertyOverride Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSsisPropertyOverride(document.RootElement);
            }
        }
    }
}
