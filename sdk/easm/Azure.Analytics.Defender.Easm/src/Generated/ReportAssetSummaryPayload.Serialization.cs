// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    public partial class ReportAssetSummaryPayload : IUtf8JsonSerializable, IJsonModel<ReportAssetSummaryPayload>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReportAssetSummaryPayload>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ReportAssetSummaryPayload>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportAssetSummaryPayload>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReportAssetSummaryPayload)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(MetricCategories))
            {
                writer.WritePropertyName("metricCategories"u8);
                writer.WriteStartArray();
                foreach (var item in MetricCategories)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Metrics))
            {
                writer.WritePropertyName("metrics"u8);
                writer.WriteStartArray();
                foreach (var item in Metrics)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Filters))
            {
                writer.WritePropertyName("filters"u8);
                writer.WriteStartArray();
                foreach (var item in Filters)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(GroupBy))
            {
                writer.WritePropertyName("groupBy"u8);
                writer.WriteStringValue(GroupBy);
            }
            if (Optional.IsDefined(SegmentBy))
            {
                writer.WritePropertyName("segmentBy"u8);
                writer.WriteStringValue(SegmentBy);
            }
            if (Optional.IsDefined(LabelName))
            {
                writer.WritePropertyName("labelName"u8);
                writer.WriteStringValue(LabelName);
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

        ReportAssetSummaryPayload IJsonModel<ReportAssetSummaryPayload>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportAssetSummaryPayload>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReportAssetSummaryPayload)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReportAssetSummaryPayload(document.RootElement, options);
        }

        internal static ReportAssetSummaryPayload DeserializeReportAssetSummaryPayload(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> metricCategories = default;
            IList<string> metrics = default;
            IList<string> filters = default;
            string groupBy = default;
            string segmentBy = default;
            string labelName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricCategories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    metricCategories = array;
                    continue;
                }
                if (property.NameEquals("metrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    metrics = array;
                    continue;
                }
                if (property.NameEquals("filters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    filters = array;
                    continue;
                }
                if (property.NameEquals("groupBy"u8))
                {
                    groupBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("segmentBy"u8))
                {
                    segmentBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labelName"u8))
                {
                    labelName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ReportAssetSummaryPayload(
                metricCategories ?? new ChangeTrackingList<string>(),
                metrics ?? new ChangeTrackingList<string>(),
                filters ?? new ChangeTrackingList<string>(),
                groupBy,
                segmentBy,
                labelName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReportAssetSummaryPayload>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportAssetSummaryPayload>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReportAssetSummaryPayload)} does not support writing '{options.Format}' format.");
            }
        }

        ReportAssetSummaryPayload IPersistableModel<ReportAssetSummaryPayload>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportAssetSummaryPayload>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeReportAssetSummaryPayload(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReportAssetSummaryPayload)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReportAssetSummaryPayload>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ReportAssetSummaryPayload FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeReportAssetSummaryPayload(document.RootElement);
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
