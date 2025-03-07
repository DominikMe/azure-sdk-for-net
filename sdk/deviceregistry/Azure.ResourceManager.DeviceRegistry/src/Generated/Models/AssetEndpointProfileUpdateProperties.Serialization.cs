// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    public partial class AssetEndpointProfileUpdateProperties : IUtf8JsonSerializable, IJsonModel<AssetEndpointProfileUpdateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AssetEndpointProfileUpdateProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AssetEndpointProfileUpdateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssetEndpointProfileUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssetEndpointProfileUpdateProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(TargetAddress))
            {
                writer.WritePropertyName("targetAddress"u8);
                writer.WriteStringValue(TargetAddress.AbsoluteUri);
            }
            if (Optional.IsDefined(EndpointProfileType))
            {
                writer.WritePropertyName("endpointProfileType"u8);
                writer.WriteStringValue(EndpointProfileType);
            }
            if (Optional.IsDefined(Authentication))
            {
                writer.WritePropertyName("authentication"u8);
                writer.WriteObjectValue(Authentication, options);
            }
            if (Optional.IsDefined(AdditionalConfiguration))
            {
                writer.WritePropertyName("additionalConfiguration"u8);
                writer.WriteStringValue(AdditionalConfiguration);
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

        AssetEndpointProfileUpdateProperties IJsonModel<AssetEndpointProfileUpdateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssetEndpointProfileUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssetEndpointProfileUpdateProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAssetEndpointProfileUpdateProperties(document.RootElement, options);
        }

        internal static AssetEndpointProfileUpdateProperties DeserializeAssetEndpointProfileUpdateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri targetAddress = default;
            string endpointProfileType = default;
            DeviceRegistryAuthentication authentication = default;
            string additionalConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAddress = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("endpointProfileType"u8))
                {
                    endpointProfileType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authentication = DeviceRegistryAuthentication.DeserializeDeviceRegistryAuthentication(property.Value, options);
                    continue;
                }
                if (property.NameEquals("additionalConfiguration"u8))
                {
                    additionalConfiguration = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AssetEndpointProfileUpdateProperties(targetAddress, endpointProfileType, authentication, additionalConfiguration, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AssetEndpointProfileUpdateProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssetEndpointProfileUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AssetEndpointProfileUpdateProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AssetEndpointProfileUpdateProperties IPersistableModel<AssetEndpointProfileUpdateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssetEndpointProfileUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAssetEndpointProfileUpdateProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AssetEndpointProfileUpdateProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AssetEndpointProfileUpdateProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
