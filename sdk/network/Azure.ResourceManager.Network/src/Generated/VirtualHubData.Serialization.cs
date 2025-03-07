// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class VirtualHubData : IUtf8JsonSerializable, IJsonModel<VirtualHubData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualHubData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VirtualHubData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualHubData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualHubData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualWan))
            {
                writer.WritePropertyName("virtualWan"u8);
                JsonSerializer.Serialize(writer, VirtualWan);
            }
            if (Optional.IsDefined(VpnGateway))
            {
                writer.WritePropertyName("vpnGateway"u8);
                JsonSerializer.Serialize(writer, VpnGateway);
            }
            if (Optional.IsDefined(P2SVpnGateway))
            {
                writer.WritePropertyName("p2SVpnGateway"u8);
                JsonSerializer.Serialize(writer, P2SVpnGateway);
            }
            if (Optional.IsDefined(ExpressRouteGateway))
            {
                writer.WritePropertyName("expressRouteGateway"u8);
                JsonSerializer.Serialize(writer, ExpressRouteGateway);
            }
            if (Optional.IsDefined(AzureFirewall))
            {
                writer.WritePropertyName("azureFirewall"u8);
                JsonSerializer.Serialize(writer, AzureFirewall);
            }
            if (Optional.IsDefined(SecurityPartnerProvider))
            {
                writer.WritePropertyName("securityPartnerProvider"u8);
                JsonSerializer.Serialize(writer, SecurityPartnerProvider);
            }
            if (Optional.IsDefined(AddressPrefix))
            {
                writer.WritePropertyName("addressPrefix"u8);
                writer.WriteStringValue(AddressPrefix);
            }
            if (Optional.IsDefined(RouteTable))
            {
                writer.WritePropertyName("routeTable"u8);
                writer.WriteObjectValue(RouteTable, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(SecurityProviderName))
            {
                writer.WritePropertyName("securityProviderName"u8);
                writer.WriteStringValue(SecurityProviderName);
            }
            if (Optional.IsCollectionDefined(VirtualHubRouteTableV2S))
            {
                writer.WritePropertyName("virtualHubRouteTableV2s"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualHubRouteTableV2S)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteStringValue(Sku);
            }
            if (options.Format != "W" && Optional.IsDefined(RoutingState))
            {
                writer.WritePropertyName("routingState"u8);
                writer.WriteStringValue(RoutingState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(BgpConnections))
            {
                writer.WritePropertyName("bgpConnections"u8);
                writer.WriteStartArray();
                foreach (var item in BgpConnections)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(IPConfigurations))
            {
                writer.WritePropertyName("ipConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in IPConfigurations)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RouteMaps))
            {
                writer.WritePropertyName("routeMaps"u8);
                writer.WriteStartArray();
                foreach (var item in RouteMaps)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(VirtualRouterAsn))
            {
                writer.WritePropertyName("virtualRouterAsn"u8);
                writer.WriteNumberValue(VirtualRouterAsn.Value);
            }
            if (Optional.IsCollectionDefined(VirtualRouterIPs))
            {
                writer.WritePropertyName("virtualRouterIps"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualRouterIPs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AllowBranchToBranchTraffic))
            {
                writer.WritePropertyName("allowBranchToBranchTraffic"u8);
                writer.WriteBooleanValue(AllowBranchToBranchTraffic.Value);
            }
            if (Optional.IsDefined(PreferredRoutingGateway))
            {
                writer.WritePropertyName("preferredRoutingGateway"u8);
                writer.WriteStringValue(PreferredRoutingGateway.Value.ToString());
            }
            if (Optional.IsDefined(HubRoutingPreference))
            {
                writer.WritePropertyName("hubRoutingPreference"u8);
                writer.WriteStringValue(HubRoutingPreference.Value.ToString());
            }
            if (Optional.IsDefined(VirtualRouterAutoScaleConfiguration))
            {
                writer.WritePropertyName("virtualRouterAutoScaleConfiguration"u8);
                writer.WriteObjectValue(VirtualRouterAutoScaleConfiguration, options);
            }
            writer.WriteEndObject();
        }

        VirtualHubData IJsonModel<VirtualHubData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualHubData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualHubData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualHubData(document.RootElement, options);
        }

        internal static VirtualHubData DeserializeVirtualHubData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            AzureLocation? location = default;
            IDictionary<string, string> tags = default;
            WritableSubResource virtualWan = default;
            WritableSubResource vpnGateway = default;
            WritableSubResource p2sVpnGateway = default;
            WritableSubResource expressRouteGateway = default;
            WritableSubResource azureFirewall = default;
            WritableSubResource securityPartnerProvider = default;
            string addressPrefix = default;
            VirtualHubRouteTable routeTable = default;
            NetworkProvisioningState? provisioningState = default;
            string securityProviderName = default;
            IList<VirtualHubRouteTableV2Data> virtualHubRouteTableV2s = default;
            string sku = default;
            RoutingState? routingState = default;
            IReadOnlyList<WritableSubResource> bgpConnections = default;
            IReadOnlyList<WritableSubResource> ipConfigurations = default;
            IReadOnlyList<WritableSubResource> routeMaps = default;
            long? virtualRouterAsn = default;
            IList<string> virtualRouterIPs = default;
            bool? allowBranchToBranchTraffic = default;
            PreferredRoutingGateway? preferredRoutingGateway = default;
            HubRoutingPreference? hubRoutingPreference = default;
            VirtualRouterAutoScaleConfiguration virtualRouterAutoScaleConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("virtualWan"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualWan = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("vpnGateway"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnGateway = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("p2SVpnGateway"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            p2sVpnGateway = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("expressRouteGateway"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expressRouteGateway = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("azureFirewall"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureFirewall = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("securityPartnerProvider"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securityPartnerProvider = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("addressPrefix"u8))
                        {
                            addressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("routeTable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routeTable = VirtualHubRouteTable.DeserializeVirtualHubRouteTable(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("securityProviderName"u8))
                        {
                            securityProviderName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualHubRouteTableV2s"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VirtualHubRouteTableV2Data> array = new List<VirtualHubRouteTableV2Data>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualHubRouteTableV2Data.DeserializeVirtualHubRouteTableV2Data(item, options));
                            }
                            virtualHubRouteTableV2s = array;
                            continue;
                        }
                        if (property0.NameEquals("sku"u8))
                        {
                            sku = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("routingState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routingState = new RoutingState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("bgpConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            bgpConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            ipConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("routeMaps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            routeMaps = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualRouterAsn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualRouterAsn = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("virtualRouterIps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            virtualRouterIPs = array;
                            continue;
                        }
                        if (property0.NameEquals("allowBranchToBranchTraffic"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowBranchToBranchTraffic = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("preferredRoutingGateway"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            preferredRoutingGateway = new PreferredRoutingGateway(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("hubRoutingPreference"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hubRoutingPreference = new HubRoutingPreference(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("virtualRouterAutoScaleConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualRouterAutoScaleConfiguration = VirtualRouterAutoScaleConfiguration.DeserializeVirtualRouterAutoScaleConfiguration(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VirtualHubData(
                id,
                name,
                type,
                location,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                etag,
                kind,
                virtualWan,
                vpnGateway,
                p2sVpnGateway,
                expressRouteGateway,
                azureFirewall,
                securityPartnerProvider,
                addressPrefix,
                routeTable,
                provisioningState,
                securityProviderName,
                virtualHubRouteTableV2s ?? new ChangeTrackingList<VirtualHubRouteTableV2Data>(),
                sku,
                routingState,
                bgpConnections ?? new ChangeTrackingList<WritableSubResource>(),
                ipConfigurations ?? new ChangeTrackingList<WritableSubResource>(),
                routeMaps ?? new ChangeTrackingList<WritableSubResource>(),
                virtualRouterAsn,
                virtualRouterIPs ?? new ChangeTrackingList<string>(),
                allowBranchToBranchTraffic,
                preferredRoutingGateway,
                hubRoutingPreference,
                virtualRouterAutoScaleConfiguration);
        }

        BinaryData IPersistableModel<VirtualHubData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualHubData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualHubData)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualHubData IPersistableModel<VirtualHubData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualHubData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVirtualHubData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualHubData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualHubData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
