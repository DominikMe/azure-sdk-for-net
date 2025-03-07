// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    internal partial class TimelineResultsMetadata : IUtf8JsonSerializable, IJsonModel<TimelineResultsMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TimelineResultsMetadata>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TimelineResultsMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TimelineResultsMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TimelineResultsMetadata)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("totalCount"u8);
            writer.WriteNumberValue(TotalCount);
            writer.WritePropertyName("aggregations"u8);
            writer.WriteStartArray();
            foreach (var item in Aggregations)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        TimelineResultsMetadata IJsonModel<TimelineResultsMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TimelineResultsMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TimelineResultsMetadata)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTimelineResultsMetadata(document.RootElement, options);
        }

        internal static TimelineResultsMetadata DeserializeTimelineResultsMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int totalCount = default;
            IReadOnlyList<TimelineAggregation> aggregations = default;
            IReadOnlyList<TimelineError> errors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalCount"u8))
                {
                    totalCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("aggregations"u8))
                {
                    List<TimelineAggregation> array = new List<TimelineAggregation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimelineAggregation.DeserializeTimelineAggregation(item, options));
                    }
                    aggregations = array;
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TimelineError> array = new List<TimelineError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimelineError.DeserializeTimelineError(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TimelineResultsMetadata(totalCount, aggregations, errors ?? new ChangeTrackingList<TimelineError>(), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TotalCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  totalCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  totalCount: ");
                builder.AppendLine($"{TotalCount}");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Aggregations), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  aggregations: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Aggregations))
                {
                    if (Aggregations.Any())
                    {
                        builder.Append("  aggregations: ");
                        builder.AppendLine("[");
                        foreach (var item in Aggregations)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  aggregations: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Errors), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  errors: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Errors))
                {
                    if (Errors.Any())
                    {
                        builder.Append("  errors: ");
                        builder.AppendLine("[");
                        foreach (var item in Errors)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  errors: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<TimelineResultsMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TimelineResultsMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(TimelineResultsMetadata)} does not support writing '{options.Format}' format.");
            }
        }

        TimelineResultsMetadata IPersistableModel<TimelineResultsMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TimelineResultsMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeTimelineResultsMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TimelineResultsMetadata)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TimelineResultsMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
