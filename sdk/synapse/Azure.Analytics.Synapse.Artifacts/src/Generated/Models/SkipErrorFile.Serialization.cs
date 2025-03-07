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
    [JsonConverter(typeof(SkipErrorFileConverter))]
    public partial class SkipErrorFile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FileMissing))
            {
                writer.WritePropertyName("fileMissing"u8);
                writer.WriteObjectValue<object>(FileMissing);
            }
            if (Optional.IsDefined(DataInconsistency))
            {
                writer.WritePropertyName("dataInconsistency"u8);
                writer.WriteObjectValue<object>(DataInconsistency);
            }
            writer.WriteEndObject();
        }

        internal static SkipErrorFile DeserializeSkipErrorFile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object fileMissing = default;
            object dataInconsistency = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileMissing"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileMissing = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("dataInconsistency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataInconsistency = property.Value.GetObject();
                    continue;
                }
            }
            return new SkipErrorFile(fileMissing, dataInconsistency);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SkipErrorFile FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeSkipErrorFile(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class SkipErrorFileConverter : JsonConverter<SkipErrorFile>
        {
            public override void Write(Utf8JsonWriter writer, SkipErrorFile model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override SkipErrorFile Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSkipErrorFile(document.RootElement);
            }
        }
    }
}
