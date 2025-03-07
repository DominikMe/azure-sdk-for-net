// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class PercentileMetricValue : IUtf8JsonSerializable, IJsonModel<PercentileMetricValue>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PercentileMetricValue>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PercentileMetricValue>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PercentileMetricValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PercentileMetricValue)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(P10))
            {
                writer.WritePropertyName("P10"u8);
                writer.WriteNumberValue(P10.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(P25))
            {
                writer.WritePropertyName("P25"u8);
                writer.WriteNumberValue(P25.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(P50))
            {
                writer.WritePropertyName("P50"u8);
                writer.WriteNumberValue(P50.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(P75))
            {
                writer.WritePropertyName("P75"u8);
                writer.WriteNumberValue(P75.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(P90))
            {
                writer.WritePropertyName("P90"u8);
                writer.WriteNumberValue(P90.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(P95))
            {
                writer.WritePropertyName("P95"u8);
                writer.WriteNumberValue(P95.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(P99))
            {
                writer.WritePropertyName("P99"u8);
                writer.WriteNumberValue(P99.Value);
            }
        }

        PercentileMetricValue IJsonModel<PercentileMetricValue>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PercentileMetricValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PercentileMetricValue)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePercentileMetricValue(document.RootElement, options);
        }

        internal static PercentileMetricValue DeserializePercentileMetricValue(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double? p10 = default;
            double? p25 = default;
            double? p50 = default;
            double? p75 = default;
            double? p90 = default;
            double? p95 = default;
            double? p99 = default;
            int? count = default;
            double? average = default;
            double? maximum = default;
            double? minimum = default;
            DateTimeOffset? timestamp = default;
            double? total = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("P10"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    p10 = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("P25"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    p25 = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("P50"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    p50 = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("P75"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    p75 = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("P90"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    p90 = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("P95"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    p95 = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("P99"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    p99 = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("_count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("average"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    average = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("maximum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximum = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("minimum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimum = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("total"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    total = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PercentileMetricValue(
                count,
                average,
                maximum,
                minimum,
                timestamp,
                total,
                serializedAdditionalRawData,
                p10,
                p25,
                p50,
                p75,
                p90,
                p95,
                p99);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(P10), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  P10: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(P10))
                {
                    builder.Append("  P10: ");
                    builder.AppendLine($"'{P10.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(P25), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  P25: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(P25))
                {
                    builder.Append("  P25: ");
                    builder.AppendLine($"'{P25.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(P50), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  P50: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(P50))
                {
                    builder.Append("  P50: ");
                    builder.AppendLine($"'{P50.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(P75), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  P75: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(P75))
                {
                    builder.Append("  P75: ");
                    builder.AppendLine($"'{P75.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(P90), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  P90: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(P90))
                {
                    builder.Append("  P90: ");
                    builder.AppendLine($"'{P90.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(P95), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  P95: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(P95))
                {
                    builder.Append("  P95: ");
                    builder.AppendLine($"'{P95.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(P99), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  P99: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(P99))
                {
                    builder.Append("  P99: ");
                    builder.AppendLine($"'{P99.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Count), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  _count: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Count))
                {
                    builder.Append("  _count: ");
                    builder.AppendLine($"{Count.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Average), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  average: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Average))
                {
                    builder.Append("  average: ");
                    builder.AppendLine($"'{Average.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Maximum), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  maximum: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Maximum))
                {
                    builder.Append("  maximum: ");
                    builder.AppendLine($"'{Maximum.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Minimum), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  minimum: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Minimum))
                {
                    builder.Append("  minimum: ");
                    builder.AppendLine($"'{Minimum.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Timestamp), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  timestamp: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Timestamp))
                {
                    builder.Append("  timestamp: ");
                    var formattedDateTimeString = TypeFormatters.ToString(Timestamp.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Total), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  total: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Total))
                {
                    builder.Append("  total: ");
                    builder.AppendLine($"'{Total.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<PercentileMetricValue>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PercentileMetricValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PercentileMetricValue)} does not support writing '{options.Format}' format.");
            }
        }

        PercentileMetricValue IPersistableModel<PercentileMetricValue>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PercentileMetricValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePercentileMetricValue(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PercentileMetricValue)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PercentileMetricValue>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
