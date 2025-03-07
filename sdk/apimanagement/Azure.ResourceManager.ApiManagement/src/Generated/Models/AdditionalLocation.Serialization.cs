// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class AdditionalLocation : IUtf8JsonSerializable, IJsonModel<AdditionalLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AdditionalLocation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AdditionalLocation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdditionalLocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdditionalLocation)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku, options);
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PublicIPAddresses))
            {
                writer.WritePropertyName("publicIPAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in PublicIPAddresses)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PrivateIPAddresses))
            {
                writer.WritePropertyName("privateIPAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateIPAddresses)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicIPAddressId))
            {
                writer.WritePropertyName("publicIpAddressId"u8);
                writer.WriteStringValue(PublicIPAddressId);
            }
            if (Optional.IsDefined(VirtualNetworkConfiguration))
            {
                writer.WritePropertyName("virtualNetworkConfiguration"u8);
                writer.WriteObjectValue(VirtualNetworkConfiguration, options);
            }
            if (options.Format != "W" && Optional.IsDefined(GatewayRegionalUri))
            {
                writer.WritePropertyName("gatewayRegionalUrl"u8);
                writer.WriteStringValue(GatewayRegionalUri.AbsoluteUri);
            }
            if (Optional.IsDefined(NatGatewayState))
            {
                writer.WritePropertyName("natGatewayState"u8);
                writer.WriteStringValue(NatGatewayState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(OutboundPublicIPAddresses))
            {
                writer.WritePropertyName("outboundPublicIPAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in OutboundPublicIPAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DisableGateway))
            {
                writer.WritePropertyName("disableGateway"u8);
                writer.WriteBooleanValue(DisableGateway.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PlatformVersion))
            {
                writer.WritePropertyName("platformVersion"u8);
                writer.WriteStringValue(PlatformVersion.Value.ToString());
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

        AdditionalLocation IJsonModel<AdditionalLocation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdditionalLocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdditionalLocation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAdditionalLocation(document.RootElement, options);
        }

        internal static AdditionalLocation DeserializeAdditionalLocation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation location = default;
            ApiManagementServiceSkuProperties sku = default;
            IList<string> zones = default;
            IReadOnlyList<IPAddress> publicIPAddresses = default;
            IReadOnlyList<IPAddress> privateIPAddresses = default;
            ResourceIdentifier publicIPAddressId = default;
            VirtualNetworkConfiguration virtualNetworkConfiguration = default;
            Uri gatewayRegionalUri = default;
            ApiManagementNatGatewayState? natGatewayState = default;
            IReadOnlyList<string> outboundPublicIPAddresses = default;
            bool? disableGateway = default;
            PlatformVersion? platformVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    sku = ApiManagementServiceSkuProperties.DeserializeApiManagementServiceSkuProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("zones"u8))
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
                    zones = array;
                    continue;
                }
                if (property.NameEquals("publicIPAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPAddress> array = new List<IPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(IPAddress.Parse(item.GetString()));
                        }
                    }
                    publicIPAddresses = array;
                    continue;
                }
                if (property.NameEquals("privateIPAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPAddress> array = new List<IPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(IPAddress.Parse(item.GetString()));
                        }
                    }
                    privateIPAddresses = array;
                    continue;
                }
                if (property.NameEquals("publicIpAddressId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicIPAddressId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("virtualNetworkConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualNetworkConfiguration = VirtualNetworkConfiguration.DeserializeVirtualNetworkConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("gatewayRegionalUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gatewayRegionalUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("natGatewayState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    natGatewayState = new ApiManagementNatGatewayState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("outboundPublicIPAddresses"u8))
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
                    outboundPublicIPAddresses = array;
                    continue;
                }
                if (property.NameEquals("disableGateway"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableGateway = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("platformVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    platformVersion = new PlatformVersion(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AdditionalLocation(
                location,
                sku,
                zones ?? new ChangeTrackingList<string>(),
                publicIPAddresses ?? new ChangeTrackingList<IPAddress>(),
                privateIPAddresses ?? new ChangeTrackingList<IPAddress>(),
                publicIPAddressId,
                virtualNetworkConfiguration,
                gatewayRegionalUri,
                natGatewayState,
                outboundPublicIPAddresses ?? new ChangeTrackingList<string>(),
                disableGateway,
                platformVersion,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Location), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  location: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  location: ");
                builder.AppendLine($"'{Location.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Sku), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sku: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Sku))
                {
                    builder.Append("  sku: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Sku, options, 2, false, "  sku: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Zones), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  zones: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Zones))
                {
                    if (Zones.Any())
                    {
                        builder.Append("  zones: ");
                        builder.AppendLine("[");
                        foreach (var item in Zones)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PublicIPAddresses), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  publicIPAddresses: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(PublicIPAddresses))
                {
                    if (PublicIPAddresses.Any())
                    {
                        builder.Append("  publicIPAddresses: ");
                        builder.AppendLine("[");
                        foreach (var item in PublicIPAddresses)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            builder.AppendLine($"    '{item.ToString()}'");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrivateIPAddresses), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  privateIPAddresses: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(PrivateIPAddresses))
                {
                    if (PrivateIPAddresses.Any())
                    {
                        builder.Append("  privateIPAddresses: ");
                        builder.AppendLine("[");
                        foreach (var item in PrivateIPAddresses)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            builder.AppendLine($"    '{item.ToString()}'");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PublicIPAddressId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  publicIpAddressId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PublicIPAddressId))
                {
                    builder.Append("  publicIpAddressId: ");
                    builder.AppendLine($"'{PublicIPAddressId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(VirtualNetworkConfiguration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  virtualNetworkConfiguration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(VirtualNetworkConfiguration))
                {
                    builder.Append("  virtualNetworkConfiguration: ");
                    BicepSerializationHelpers.AppendChildObject(builder, VirtualNetworkConfiguration, options, 2, false, "  virtualNetworkConfiguration: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GatewayRegionalUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  gatewayRegionalUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(GatewayRegionalUri))
                {
                    builder.Append("  gatewayRegionalUrl: ");
                    builder.AppendLine($"'{GatewayRegionalUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NatGatewayState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  natGatewayState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NatGatewayState))
                {
                    builder.Append("  natGatewayState: ");
                    builder.AppendLine($"'{NatGatewayState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OutboundPublicIPAddresses), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  outboundPublicIPAddresses: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(OutboundPublicIPAddresses))
                {
                    if (OutboundPublicIPAddresses.Any())
                    {
                        builder.Append("  outboundPublicIPAddresses: ");
                        builder.AppendLine("[");
                        foreach (var item in OutboundPublicIPAddresses)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DisableGateway), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  disableGateway: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DisableGateway))
                {
                    builder.Append("  disableGateway: ");
                    var boolValue = DisableGateway.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PlatformVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  platformVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PlatformVersion))
                {
                    builder.Append("  platformVersion: ");
                    builder.AppendLine($"'{PlatformVersion.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AdditionalLocation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdditionalLocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AdditionalLocation)} does not support writing '{options.Format}' format.");
            }
        }

        AdditionalLocation IPersistableModel<AdditionalLocation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdditionalLocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAdditionalLocation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AdditionalLocation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AdditionalLocation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
