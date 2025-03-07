// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class FirewallVnetConfiguration : IUtf8JsonSerializable, IJsonModel<FirewallVnetConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallVnetConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FirewallVnetConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallVnetConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallVnetConfiguration)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("vnet"u8);
            writer.WriteObjectValue(Vnet, options);
            writer.WritePropertyName("trustSubnet"u8);
            writer.WriteObjectValue(TrustSubnet, options);
            writer.WritePropertyName("unTrustSubnet"u8);
            writer.WriteObjectValue(UnTrustSubnet, options);
            if (Optional.IsDefined(IPOfTrustSubnetForUdr))
            {
                writer.WritePropertyName("ipOfTrustSubnetForUdr"u8);
                writer.WriteObjectValue(IPOfTrustSubnetForUdr, options);
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

        FirewallVnetConfiguration IJsonModel<FirewallVnetConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallVnetConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallVnetConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallVnetConfiguration(document.RootElement, options);
        }

        internal static FirewallVnetConfiguration DeserializeFirewallVnetConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IPAddressSpaceInfo vnet = default;
            IPAddressSpaceInfo trustSubnet = default;
            IPAddressSpaceInfo unTrustSubnet = default;
            IPAddressInfo ipOfTrustSubnetForUdr = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vnet"u8))
                {
                    vnet = IPAddressSpaceInfo.DeserializeIPAddressSpaceInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("trustSubnet"u8))
                {
                    trustSubnet = IPAddressSpaceInfo.DeserializeIPAddressSpaceInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("unTrustSubnet"u8))
                {
                    unTrustSubnet = IPAddressSpaceInfo.DeserializeIPAddressSpaceInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("ipOfTrustSubnetForUdr"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipOfTrustSubnetForUdr = IPAddressInfo.DeserializeIPAddressInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FirewallVnetConfiguration(vnet, trustSubnet, unTrustSubnet, ipOfTrustSubnetForUdr, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirewallVnetConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallVnetConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FirewallVnetConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        FirewallVnetConfiguration IPersistableModel<FirewallVnetConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallVnetConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFirewallVnetConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FirewallVnetConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirewallVnetConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
