// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class VectorizableImageBinaryQuery : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Base64Image))
            {
                writer.WritePropertyName("base64Image"u8);
                writer.WriteStringValue(Base64Image);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(KNearestNeighborsCount))
            {
                writer.WritePropertyName("k"u8);
                writer.WriteNumberValue(KNearestNeighborsCount.Value);
            }
            if (Optional.IsDefined(FieldsRaw))
            {
                writer.WritePropertyName("fields"u8);
                writer.WriteStringValue(FieldsRaw);
            }
            if (Optional.IsDefined(Exhaustive))
            {
                writer.WritePropertyName("exhaustive"u8);
                writer.WriteBooleanValue(Exhaustive.Value);
            }
            if (Optional.IsDefined(Oversampling))
            {
                writer.WritePropertyName("oversampling"u8);
                writer.WriteNumberValue(Oversampling.Value);
            }
            if (Optional.IsDefined(Weight))
            {
                writer.WritePropertyName("weight"u8);
                writer.WriteNumberValue(Weight.Value);
            }
            if (Optional.IsDefined(Threshold))
            {
                writer.WritePropertyName("threshold"u8);
                writer.WriteObjectValue(Threshold);
            }
            if (Optional.IsDefined(FilterOverride))
            {
                writer.WritePropertyName("filterOverride"u8);
                writer.WriteStringValue(FilterOverride);
            }
            writer.WriteEndObject();
        }

        internal static VectorizableImageBinaryQuery DeserializeVectorizableImageBinaryQuery(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string base64Image = default;
            VectorQueryKind kind = default;
            int? k = default;
            string fields = default;
            bool? exhaustive = default;
            double? oversampling = default;
            float? weight = default;
            VectorThreshold threshold = default;
            string filterOverride = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("base64Image"u8))
                {
                    base64Image = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new VectorQueryKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("k"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    k = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("fields"u8))
                {
                    fields = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("exhaustive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exhaustive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("oversampling"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    oversampling = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("weight"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    weight = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("threshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    threshold = VectorThreshold.DeserializeVectorThreshold(property.Value);
                    continue;
                }
                if (property.NameEquals("filterOverride"u8))
                {
                    filterOverride = property.Value.GetString();
                    continue;
                }
            }
            return new VectorizableImageBinaryQuery(
                kind,
                k,
                fields,
                exhaustive,
                oversampling,
                weight,
                threshold,
                filterOverride,
                base64Image);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new VectorizableImageBinaryQuery FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeVectorizableImageBinaryQuery(document.RootElement);
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
