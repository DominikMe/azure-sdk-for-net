// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Health.Insights.RadiologyInsights
{
    public partial class RadiologyInsightsInferenceOptions : IUtf8JsonSerializable, IJsonModel<RadiologyInsightsInferenceOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RadiologyInsightsInferenceOptions>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RadiologyInsightsInferenceOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RadiologyInsightsInferenceOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RadiologyInsightsInferenceOptions)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(FollowupRecommendationOptions))
            {
                writer.WritePropertyName("followupRecommendationOptions"u8);
                writer.WriteObjectValue(FollowupRecommendationOptions, options);
            }
            if (Optional.IsDefined(FindingOptions))
            {
                writer.WritePropertyName("findingOptions"u8);
                writer.WriteObjectValue(FindingOptions, options);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        RadiologyInsightsInferenceOptions IJsonModel<RadiologyInsightsInferenceOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RadiologyInsightsInferenceOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RadiologyInsightsInferenceOptions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRadiologyInsightsInferenceOptions(document.RootElement, options);
        }

        internal static RadiologyInsightsInferenceOptions DeserializeRadiologyInsightsInferenceOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FollowupRecommendationOptions followupRecommendationOptions = default;
            FindingOptions findingOptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("followupRecommendationOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    followupRecommendationOptions = FollowupRecommendationOptions.DeserializeFollowupRecommendationOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("findingOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    findingOptions = FindingOptions.DeserializeFindingOptions(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RadiologyInsightsInferenceOptions(followupRecommendationOptions, findingOptions, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RadiologyInsightsInferenceOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RadiologyInsightsInferenceOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RadiologyInsightsInferenceOptions)} does not support writing '{options.Format}' format.");
            }
        }

        RadiologyInsightsInferenceOptions IPersistableModel<RadiologyInsightsInferenceOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RadiologyInsightsInferenceOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRadiologyInsightsInferenceOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RadiologyInsightsInferenceOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RadiologyInsightsInferenceOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RadiologyInsightsInferenceOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeRadiologyInsightsInferenceOptions(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
