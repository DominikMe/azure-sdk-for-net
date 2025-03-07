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
    public partial class FirewallNetworkProfile : IUtf8JsonSerializable, IJsonModel<FirewallNetworkProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallNetworkProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FirewallNetworkProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallNetworkProfile)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(VnetConfiguration))
            {
                writer.WritePropertyName("vnetConfiguration"u8);
                writer.WriteObjectValue(VnetConfiguration, options);
            }
            if (Optional.IsDefined(VwanConfiguration))
            {
                writer.WritePropertyName("vwanConfiguration"u8);
                writer.WriteObjectValue(VwanConfiguration, options);
            }
            writer.WritePropertyName("networkType"u8);
            writer.WriteStringValue(NetworkType.ToString());
            writer.WritePropertyName("publicIps"u8);
            writer.WriteStartArray();
            foreach (var item in PublicIPs)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("enableEgressNat"u8);
            writer.WriteStringValue(EnableEgressNat.ToString());
            if (Optional.IsCollectionDefined(EgressNatIP))
            {
                writer.WritePropertyName("egressNatIp"u8);
                writer.WriteStartArray();
                foreach (var item in EgressNatIP)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TrustedRanges))
            {
                writer.WritePropertyName("trustedRanges"u8);
                writer.WriteStartArray();
                foreach (var item in TrustedRanges)
                {
                    writer.WriteStringValue(item);
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

        FirewallNetworkProfile IJsonModel<FirewallNetworkProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallNetworkProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallNetworkProfile(document.RootElement, options);
        }

        internal static FirewallNetworkProfile DeserializeFirewallNetworkProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FirewallVnetConfiguration vnetConfiguration = default;
            FirewallVwanConfiguration vwanConfiguration = default;
            FirewallNetworkType networkType = default;
            IList<IPAddressInfo> publicIPs = default;
            AllowEgressNatType enableEgressNat = default;
            IList<IPAddressInfo> egressNatIP = default;
            IList<string> trustedRanges = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vnetConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vnetConfiguration = FirewallVnetConfiguration.DeserializeFirewallVnetConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("vwanConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vwanConfiguration = FirewallVwanConfiguration.DeserializeFirewallVwanConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("networkType"u8))
                {
                    networkType = new FirewallNetworkType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicIps"u8))
                {
                    List<IPAddressInfo> array = new List<IPAddressInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPAddressInfo.DeserializeIPAddressInfo(item, options));
                    }
                    publicIPs = array;
                    continue;
                }
                if (property.NameEquals("enableEgressNat"u8))
                {
                    enableEgressNat = new AllowEgressNatType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("egressNatIp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPAddressInfo> array = new List<IPAddressInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPAddressInfo.DeserializeIPAddressInfo(item, options));
                    }
                    egressNatIP = array;
                    continue;
                }
                if (property.NameEquals("trustedRanges"u8))
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
                    trustedRanges = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FirewallNetworkProfile(
                vnetConfiguration,
                vwanConfiguration,
                networkType,
                publicIPs,
                enableEgressNat,
                egressNatIP ?? new ChangeTrackingList<IPAddressInfo>(),
                trustedRanges ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirewallNetworkProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FirewallNetworkProfile)} does not support writing '{options.Format}' format.");
            }
        }

        FirewallNetworkProfile IPersistableModel<FirewallNetworkProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFirewallNetworkProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FirewallNetworkProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirewallNetworkProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
