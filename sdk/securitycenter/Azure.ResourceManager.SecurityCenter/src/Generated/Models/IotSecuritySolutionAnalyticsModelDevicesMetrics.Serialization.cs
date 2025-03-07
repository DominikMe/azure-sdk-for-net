// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class IotSecuritySolutionAnalyticsModelDevicesMetrics : IUtf8JsonSerializable, IJsonModel<IotSecuritySolutionAnalyticsModelDevicesMetrics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotSecuritySolutionAnalyticsModelDevicesMetrics>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IotSecuritySolutionAnalyticsModelDevicesMetrics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecuritySolutionAnalyticsModelDevicesMetrics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotSecuritySolutionAnalyticsModelDevicesMetrics)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Date))
            {
                writer.WritePropertyName("date"u8);
                writer.WriteStringValue(Date.Value, "O");
            }
            if (Optional.IsDefined(DevicesMetrics))
            {
                writer.WritePropertyName("devicesMetrics"u8);
                writer.WriteObjectValue(DevicesMetrics, options);
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

        IotSecuritySolutionAnalyticsModelDevicesMetrics IJsonModel<IotSecuritySolutionAnalyticsModelDevicesMetrics>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecuritySolutionAnalyticsModelDevicesMetrics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotSecuritySolutionAnalyticsModelDevicesMetrics)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotSecuritySolutionAnalyticsModelDevicesMetrics(document.RootElement, options);
        }

        internal static IotSecuritySolutionAnalyticsModelDevicesMetrics DeserializeIotSecuritySolutionAnalyticsModelDevicesMetrics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? date = default;
            IotSeverityMetrics devicesMetrics = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("date"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    date = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("devicesMetrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    devicesMetrics = IotSeverityMetrics.DeserializeIotSeverityMetrics(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IotSecuritySolutionAnalyticsModelDevicesMetrics(date, devicesMetrics, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotSecuritySolutionAnalyticsModelDevicesMetrics>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecuritySolutionAnalyticsModelDevicesMetrics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IotSecuritySolutionAnalyticsModelDevicesMetrics)} does not support writing '{options.Format}' format.");
            }
        }

        IotSecuritySolutionAnalyticsModelDevicesMetrics IPersistableModel<IotSecuritySolutionAnalyticsModelDevicesMetrics>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSecuritySolutionAnalyticsModelDevicesMetrics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeIotSecuritySolutionAnalyticsModelDevicesMetrics(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotSecuritySolutionAnalyticsModelDevicesMetrics)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotSecuritySolutionAnalyticsModelDevicesMetrics>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
