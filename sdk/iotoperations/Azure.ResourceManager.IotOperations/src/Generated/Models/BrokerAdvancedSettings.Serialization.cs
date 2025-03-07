// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotOperations.Models
{
    public partial class BrokerAdvancedSettings : IUtf8JsonSerializable, IJsonModel<BrokerAdvancedSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BrokerAdvancedSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BrokerAdvancedSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BrokerAdvancedSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BrokerAdvancedSettings)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Clients))
            {
                writer.WritePropertyName("clients"u8);
                writer.WriteObjectValue(Clients, options);
            }
            if (Optional.IsDefined(EncryptInternalTraffic))
            {
                writer.WritePropertyName("encryptInternalTraffic"u8);
                writer.WriteStringValue(EncryptInternalTraffic.Value.ToString());
            }
            if (Optional.IsDefined(InternalCerts))
            {
                writer.WritePropertyName("internalCerts"u8);
                writer.WriteObjectValue(InternalCerts, options);
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

        BrokerAdvancedSettings IJsonModel<BrokerAdvancedSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BrokerAdvancedSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BrokerAdvancedSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBrokerAdvancedSettings(document.RootElement, options);
        }

        internal static BrokerAdvancedSettings DeserializeBrokerAdvancedSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BrokerClientConfig clients = default;
            IotOperationsOperationalMode? encryptInternalTraffic = default;
            CertManagerCertConfig internalCerts = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clients"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clients = BrokerClientConfig.DeserializeBrokerClientConfig(property.Value, options);
                    continue;
                }
                if (property.NameEquals("encryptInternalTraffic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptInternalTraffic = new IotOperationsOperationalMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("internalCerts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    internalCerts = CertManagerCertConfig.DeserializeCertManagerCertConfig(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BrokerAdvancedSettings(clients, encryptInternalTraffic, internalCerts, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BrokerAdvancedSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BrokerAdvancedSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BrokerAdvancedSettings)} does not support writing '{options.Format}' format.");
            }
        }

        BrokerAdvancedSettings IPersistableModel<BrokerAdvancedSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BrokerAdvancedSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBrokerAdvancedSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BrokerAdvancedSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BrokerAdvancedSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
