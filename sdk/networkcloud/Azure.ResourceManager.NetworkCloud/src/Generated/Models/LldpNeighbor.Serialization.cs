// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class LldpNeighbor : IUtf8JsonSerializable, IJsonModel<LldpNeighbor>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LldpNeighbor>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LldpNeighbor>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LldpNeighbor>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LldpNeighbor)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(PortDescription))
            {
                writer.WritePropertyName("portDescription"u8);
                writer.WriteStringValue(PortDescription);
            }
            if (options.Format != "W" && Optional.IsDefined(PortName))
            {
                writer.WritePropertyName("portName"u8);
                writer.WriteStringValue(PortName);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemDescription))
            {
                writer.WritePropertyName("systemDescription"u8);
                writer.WriteStringValue(SystemDescription);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemName))
            {
                writer.WritePropertyName("systemName"u8);
                writer.WriteStringValue(SystemName);
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

        LldpNeighbor IJsonModel<LldpNeighbor>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LldpNeighbor>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LldpNeighbor)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLldpNeighbor(document.RootElement, options);
        }

        internal static LldpNeighbor DeserializeLldpNeighbor(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string portDescription = default;
            string portName = default;
            string systemDescription = default;
            string systemName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("portDescription"u8))
                {
                    portDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("portName"u8))
                {
                    portName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemDescription"u8))
                {
                    systemDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemName"u8))
                {
                    systemName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LldpNeighbor(portDescription, portName, systemDescription, systemName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LldpNeighbor>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LldpNeighbor>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LldpNeighbor)} does not support writing '{options.Format}' format.");
            }
        }

        LldpNeighbor IPersistableModel<LldpNeighbor>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LldpNeighbor>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeLldpNeighbor(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LldpNeighbor)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LldpNeighbor>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
