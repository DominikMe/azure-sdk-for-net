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
    public partial class NetworkInterfaceData : IUtf8JsonSerializable, IJsonModel<NetworkInterfaceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkInterfaceData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetworkInterfaceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkInterfaceData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(VirtualMachine))
            {
                writer.WritePropertyName("virtualMachine"u8);
                JsonSerializer.Serialize(writer, VirtualMachine);
            }
            if (Optional.IsDefined(NetworkSecurityGroup))
            {
                writer.WritePropertyName("networkSecurityGroup"u8);
                writer.WriteObjectValue(NetworkSecurityGroup, options);
            }
            if (options.Format != "W" && Optional.IsDefined(PrivateEndpoint))
            {
                writer.WritePropertyName("privateEndpoint"u8);
                writer.WriteObjectValue(PrivateEndpoint, options);
            }
            if (Optional.IsCollectionDefined(IPConfigurations))
            {
                writer.WritePropertyName("ipConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in IPConfigurations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(TapConfigurations))
            {
                writer.WritePropertyName("tapConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in TapConfigurations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DnsSettings))
            {
                writer.WritePropertyName("dnsSettings"u8);
                writer.WriteObjectValue(DnsSettings, options);
            }
            if (options.Format != "W" && Optional.IsDefined(MacAddress))
            {
                writer.WritePropertyName("macAddress"u8);
                writer.WriteStringValue(MacAddress);
            }
            if (options.Format != "W" && Optional.IsDefined(Primary))
            {
                writer.WritePropertyName("primary"u8);
                writer.WriteBooleanValue(Primary.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(VnetEncryptionSupported))
            {
                writer.WritePropertyName("vnetEncryptionSupported"u8);
                writer.WriteBooleanValue(VnetEncryptionSupported.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DefaultOutboundConnectivityEnabled))
            {
                writer.WritePropertyName("defaultOutboundConnectivityEnabled"u8);
                writer.WriteBooleanValue(DefaultOutboundConnectivityEnabled.Value);
            }
            if (Optional.IsDefined(EnableAcceleratedNetworking))
            {
                writer.WritePropertyName("enableAcceleratedNetworking"u8);
                writer.WriteBooleanValue(EnableAcceleratedNetworking.Value);
            }
            if (Optional.IsDefined(DisableTcpStateTracking))
            {
                writer.WritePropertyName("disableTcpStateTracking"u8);
                writer.WriteBooleanValue(DisableTcpStateTracking.Value);
            }
            if (Optional.IsDefined(EnableIPForwarding))
            {
                writer.WritePropertyName("enableIPForwarding"u8);
                writer.WriteBooleanValue(EnableIPForwarding.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(HostedWorkloads))
            {
                writer.WritePropertyName("hostedWorkloads"u8);
                writer.WriteStartArray();
                foreach (var item in HostedWorkloads)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(DscpConfiguration))
            {
                writer.WritePropertyName("dscpConfiguration"u8);
                JsonSerializer.Serialize(writer, DscpConfiguration);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceGuid))
            {
                writer.WritePropertyName("resourceGuid"u8);
                writer.WriteStringValue(ResourceGuid.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(WorkloadType))
            {
                writer.WritePropertyName("workloadType"u8);
                writer.WriteStringValue(WorkloadType);
            }
            if (Optional.IsDefined(NicType))
            {
                writer.WritePropertyName("nicType"u8);
                writer.WriteStringValue(NicType.Value.ToString());
            }
            if (Optional.IsDefined(PrivateLinkService))
            {
                writer.WritePropertyName("privateLinkService"u8);
                writer.WriteObjectValue(PrivateLinkService, options);
            }
            if (Optional.IsDefined(MigrationPhase))
            {
                writer.WritePropertyName("migrationPhase"u8);
                writer.WriteStringValue(MigrationPhase.Value.ToString());
            }
            if (Optional.IsDefined(AuxiliaryMode))
            {
                writer.WritePropertyName("auxiliaryMode"u8);
                writer.WriteStringValue(AuxiliaryMode.Value.ToString());
            }
            if (Optional.IsDefined(AuxiliarySku))
            {
                writer.WritePropertyName("auxiliarySku"u8);
                writer.WriteStringValue(AuxiliarySku.Value.ToString());
            }
            writer.WriteEndObject();
        }

        NetworkInterfaceData IJsonModel<NetworkInterfaceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkInterfaceData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkInterfaceData(document.RootElement, options);
        }

        internal static NetworkInterfaceData DeserializeNetworkInterfaceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExtendedLocation extendedLocation = default;
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            AzureLocation? location = default;
            IDictionary<string, string> tags = default;
            WritableSubResource virtualMachine = default;
            NetworkSecurityGroupData networkSecurityGroup = default;
            PrivateEndpointData privateEndpoint = default;
            IList<NetworkInterfaceIPConfigurationData> ipConfigurations = default;
            IReadOnlyList<NetworkInterfaceTapConfigurationData> tapConfigurations = default;
            NetworkInterfaceDnsSettings dnsSettings = default;
            string macAddress = default;
            bool? primary = default;
            bool? vnetEncryptionSupported = default;
            bool? defaultOutboundConnectivityEnabled = default;
            bool? enableAcceleratedNetworking = default;
            bool? disableTcpStateTracking = default;
            bool? enableIPForwarding = default;
            IReadOnlyList<string> hostedWorkloads = default;
            WritableSubResource dscpConfiguration = default;
            Guid? resourceGuid = default;
            NetworkProvisioningState? provisioningState = default;
            string workloadType = default;
            NetworkInterfaceNicType? nicType = default;
            PrivateLinkServiceData privateLinkService = default;
            NetworkInterfaceMigrationPhase? migrationPhase = default;
            NetworkInterfaceAuxiliaryMode? auxiliaryMode = default;
            NetworkInterfaceAuxiliarySku? auxiliarySku = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = JsonSerializer.Deserialize<ExtendedLocation>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
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
                        if (property0.NameEquals("virtualMachine"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualMachine = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("networkSecurityGroup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkSecurityGroup = NetworkSecurityGroupData.DeserializeNetworkSecurityGroupData(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("privateEndpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateEndpoint = PrivateEndpointData.DeserializePrivateEndpointData(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkInterfaceIPConfigurationData> array = new List<NetworkInterfaceIPConfigurationData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkInterfaceIPConfigurationData.DeserializeNetworkInterfaceIPConfigurationData(item, options));
                            }
                            ipConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("tapConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkInterfaceTapConfigurationData> array = new List<NetworkInterfaceTapConfigurationData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkInterfaceTapConfigurationData.DeserializeNetworkInterfaceTapConfigurationData(item, options));
                            }
                            tapConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("dnsSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dnsSettings = NetworkInterfaceDnsSettings.DeserializeNetworkInterfaceDnsSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("macAddress"u8))
                        {
                            macAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("primary"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            primary = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("vnetEncryptionSupported"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vnetEncryptionSupported = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("defaultOutboundConnectivityEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultOutboundConnectivityEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableAcceleratedNetworking"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableAcceleratedNetworking = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("disableTcpStateTracking"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableTcpStateTracking = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableIPForwarding"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableIPForwarding = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hostedWorkloads"u8))
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
                            hostedWorkloads = array;
                            continue;
                        }
                        if (property0.NameEquals("dscpConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dscpConfiguration = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceGuid = property0.Value.GetGuid();
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
                        if (property0.NameEquals("workloadType"u8))
                        {
                            workloadType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nicType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nicType = new NetworkInterfaceNicType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateLinkService"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateLinkService = PrivateLinkServiceData.DeserializePrivateLinkServiceData(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("migrationPhase"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            migrationPhase = new NetworkInterfaceMigrationPhase(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("auxiliaryMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            auxiliaryMode = new NetworkInterfaceAuxiliaryMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("auxiliarySku"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            auxiliarySku = new NetworkInterfaceAuxiliarySku(property0.Value.GetString());
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
            return new NetworkInterfaceData(
                id,
                name,
                type,
                location,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                extendedLocation,
                etag,
                virtualMachine,
                networkSecurityGroup,
                privateEndpoint,
                ipConfigurations ?? new ChangeTrackingList<NetworkInterfaceIPConfigurationData>(),
                tapConfigurations ?? new ChangeTrackingList<NetworkInterfaceTapConfigurationData>(),
                dnsSettings,
                macAddress,
                primary,
                vnetEncryptionSupported,
                defaultOutboundConnectivityEnabled,
                enableAcceleratedNetworking,
                disableTcpStateTracking,
                enableIPForwarding,
                hostedWorkloads ?? new ChangeTrackingList<string>(),
                dscpConfiguration,
                resourceGuid,
                provisioningState,
                workloadType,
                nicType,
                privateLinkService,
                migrationPhase,
                auxiliaryMode,
                auxiliarySku);
        }

        BinaryData IPersistableModel<NetworkInterfaceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkInterfaceData)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkInterfaceData IPersistableModel<NetworkInterfaceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNetworkInterfaceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkInterfaceData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkInterfaceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
