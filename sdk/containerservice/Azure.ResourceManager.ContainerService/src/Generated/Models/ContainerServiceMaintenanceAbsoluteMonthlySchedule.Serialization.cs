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

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceMaintenanceAbsoluteMonthlySchedule : IUtf8JsonSerializable, IJsonModel<ContainerServiceMaintenanceAbsoluteMonthlySchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerServiceMaintenanceAbsoluteMonthlySchedule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerServiceMaintenanceAbsoluteMonthlySchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceAbsoluteMonthlySchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceMaintenanceAbsoluteMonthlySchedule)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("intervalMonths"u8);
            writer.WriteNumberValue(IntervalMonths);
            writer.WritePropertyName("dayOfMonth"u8);
            writer.WriteNumberValue(DayOfMonth);
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

        ContainerServiceMaintenanceAbsoluteMonthlySchedule IJsonModel<ContainerServiceMaintenanceAbsoluteMonthlySchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceAbsoluteMonthlySchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceMaintenanceAbsoluteMonthlySchedule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceMaintenanceAbsoluteMonthlySchedule(document.RootElement, options);
        }

        internal static ContainerServiceMaintenanceAbsoluteMonthlySchedule DeserializeContainerServiceMaintenanceAbsoluteMonthlySchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int intervalMonths = default;
            int dayOfMonth = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("intervalMonths"u8))
                {
                    intervalMonths = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dayOfMonth"u8))
                {
                    dayOfMonth = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerServiceMaintenanceAbsoluteMonthlySchedule(intervalMonths, dayOfMonth, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IntervalMonths), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  intervalMonths: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  intervalMonths: ");
                builder.AppendLine($"{IntervalMonths}");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DayOfMonth), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dayOfMonth: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  dayOfMonth: ");
                builder.AppendLine($"{DayOfMonth}");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerServiceMaintenanceAbsoluteMonthlySchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceAbsoluteMonthlySchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceMaintenanceAbsoluteMonthlySchedule)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerServiceMaintenanceAbsoluteMonthlySchedule IPersistableModel<ContainerServiceMaintenanceAbsoluteMonthlySchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceAbsoluteMonthlySchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerServiceMaintenanceAbsoluteMonthlySchedule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceMaintenanceAbsoluteMonthlySchedule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerServiceMaintenanceAbsoluteMonthlySchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
