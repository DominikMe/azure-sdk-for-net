// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    public partial class NetworkCloudBareMetalMachineData : IUtf8JsonSerializable, IJsonModel<NetworkCloudBareMetalMachineData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkCloudBareMetalMachineData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetworkCloudBareMetalMachineData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudBareMetalMachineData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudBareMetalMachineData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("extendedLocation"u8);
            writer.WriteObjectValue(ExtendedLocation, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(AssociatedResourceIds))
            {
                writer.WritePropertyName("associatedResourceIds"u8);
                writer.WriteStartArray();
                foreach (var item in AssociatedResourceIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("bmcConnectionString"u8);
            writer.WriteStringValue(BmcConnectionString);
            writer.WritePropertyName("bmcCredentials"u8);
            writer.WriteObjectValue(BmcCredentials, options);
            writer.WritePropertyName("bmcMacAddress"u8);
            writer.WriteStringValue(BmcMacAddress);
            writer.WritePropertyName("bootMacAddress"u8);
            writer.WriteStringValue(BootMacAddress);
            if (options.Format != "W" && Optional.IsDefined(ClusterId))
            {
                writer.WritePropertyName("clusterId"u8);
                writer.WriteStringValue(ClusterId);
            }
            if (options.Format != "W" && Optional.IsDefined(CordonStatus))
            {
                writer.WritePropertyName("cordonStatus"u8);
                writer.WriteStringValue(CordonStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DetailedStatus))
            {
                writer.WritePropertyName("detailedStatus"u8);
                writer.WriteStringValue(DetailedStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DetailedStatusMessage))
            {
                writer.WritePropertyName("detailedStatusMessage"u8);
                writer.WriteStringValue(DetailedStatusMessage);
            }
            if (options.Format != "W" && Optional.IsDefined(HardwareInventory))
            {
                writer.WritePropertyName("hardwareInventory"u8);
                writer.WriteObjectValue(HardwareInventory, options);
            }
            if (options.Format != "W" && Optional.IsDefined(HardwareValidationStatus))
            {
                writer.WritePropertyName("hardwareValidationStatus"u8);
                writer.WriteObjectValue(HardwareValidationStatus, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(HybridAksClustersAssociatedIds))
            {
                writer.WritePropertyName("hybridAksClustersAssociatedIds"u8);
                writer.WriteStartArray();
                foreach (var item in HybridAksClustersAssociatedIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(KubernetesNodeName))
            {
                writer.WritePropertyName("kubernetesNodeName"u8);
                writer.WriteStringValue(KubernetesNodeName);
            }
            if (options.Format != "W" && Optional.IsDefined(KubernetesVersion))
            {
                writer.WritePropertyName("kubernetesVersion"u8);
                writer.WriteStringValue(KubernetesVersion);
            }
            if (Optional.IsDefined(MachineClusterVersion))
            {
                writer.WritePropertyName("machineClusterVersion"u8);
                writer.WriteStringValue(MachineClusterVersion);
            }
            writer.WritePropertyName("machineDetails"u8);
            writer.WriteStringValue(MachineDetails);
            writer.WritePropertyName("machineName"u8);
            writer.WriteStringValue(MachineName);
            if (options.Format != "W" && Optional.IsCollectionDefined(MachineRoles))
            {
                writer.WritePropertyName("machineRoles"u8);
                writer.WriteStartArray();
                foreach (var item in MachineRoles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("machineSkuId"u8);
            writer.WriteStringValue(MachineSkuId);
            if (options.Format != "W" && Optional.IsDefined(OamIPv4Address))
            {
                writer.WritePropertyName("oamIpv4Address"u8);
                writer.WriteStringValue(OamIPv4Address.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(OamIPv6Address))
            {
                writer.WritePropertyName("oamIpv6Address"u8);
                writer.WriteStringValue(OamIPv6Address);
            }
            if (options.Format != "W" && Optional.IsDefined(OSImage))
            {
                writer.WritePropertyName("osImage"u8);
                writer.WriteStringValue(OSImage);
            }
            if (options.Format != "W" && Optional.IsDefined(PowerState))
            {
                writer.WritePropertyName("powerState"u8);
                writer.WriteStringValue(PowerState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WritePropertyName("rackId"u8);
            writer.WriteStringValue(RackId);
            writer.WritePropertyName("rackSlot"u8);
            writer.WriteNumberValue(RackSlot);
            if (options.Format != "W" && Optional.IsDefined(ReadyState))
            {
                writer.WritePropertyName("readyState"u8);
                writer.WriteStringValue(ReadyState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(RuntimeProtectionStatus))
            {
                writer.WritePropertyName("runtimeProtectionStatus"u8);
                writer.WriteObjectValue(RuntimeProtectionStatus, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SecretRotationStatus))
            {
                writer.WritePropertyName("secretRotationStatus"u8);
                writer.WriteStartArray();
                foreach (var item in SecretRotationStatus)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("serialNumber"u8);
            writer.WriteStringValue(SerialNumber);
            if (options.Format != "W" && Optional.IsDefined(ServiceTag))
            {
                writer.WritePropertyName("serviceTag"u8);
                writer.WriteStringValue(ServiceTag);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(VirtualMachinesAssociatedIds))
            {
                writer.WritePropertyName("virtualMachinesAssociatedIds"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualMachinesAssociatedIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        NetworkCloudBareMetalMachineData IJsonModel<NetworkCloudBareMetalMachineData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudBareMetalMachineData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudBareMetalMachineData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudBareMetalMachineData(document.RootElement, options);
        }

        internal static NetworkCloudBareMetalMachineData DeserializeNetworkCloudBareMetalMachineData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExtendedLocation extendedLocation = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IReadOnlyList<ResourceIdentifier> associatedResourceIds = default;
            string bmcConnectionString = default;
            AdministrativeCredentials bmcCredentials = default;
            string bmcMacAddress = default;
            string bootMacAddress = default;
            ResourceIdentifier clusterId = default;
            BareMetalMachineCordonStatus? cordonStatus = default;
            BareMetalMachineDetailedStatus? detailedStatus = default;
            string detailedStatusMessage = default;
            HardwareInventory hardwareInventory = default;
            HardwareValidationStatus hardwareValidationStatus = default;
            IReadOnlyList<string> hybridAksClustersAssociatedIds = default;
            string kubernetesNodeName = default;
            string kubernetesVersion = default;
            string machineClusterVersion = default;
            string machineDetails = default;
            string machineName = default;
            IReadOnlyList<string> machineRoles = default;
            string machineSkuId = default;
            IPAddress oamIPv4Address = default;
            string oamIPv6Address = default;
            string osImage = default;
            BareMetalMachinePowerState? powerState = default;
            BareMetalMachineProvisioningState? provisioningState = default;
            ResourceIdentifier rackId = default;
            long rackSlot = default;
            BareMetalMachineReadyState? readyState = default;
            RuntimeProtectionStatus runtimeProtectionStatus = default;
            IReadOnlyList<SecretRotationStatus> secretRotationStatus = default;
            string serialNumber = default;
            string serviceTag = default;
            IReadOnlyList<string> virtualMachinesAssociatedIds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    extendedLocation = ExtendedLocation.DeserializeExtendedLocation(property.Value, options);
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
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("associatedResourceIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            associatedResourceIds = array;
                            continue;
                        }
                        if (property0.NameEquals("bmcConnectionString"u8))
                        {
                            bmcConnectionString = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("bmcCredentials"u8))
                        {
                            bmcCredentials = AdministrativeCredentials.DeserializeAdministrativeCredentials(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("bmcMacAddress"u8))
                        {
                            bmcMacAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("bootMacAddress"u8))
                        {
                            bootMacAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("cordonStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cordonStatus = new BareMetalMachineCordonStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detailedStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            detailedStatus = new BareMetalMachineDetailedStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detailedStatusMessage"u8))
                        {
                            detailedStatusMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hardwareInventory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hardwareInventory = HardwareInventory.DeserializeHardwareInventory(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("hardwareValidationStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hardwareValidationStatus = HardwareValidationStatus.DeserializeHardwareValidationStatus(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("hybridAksClustersAssociatedIds"u8))
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
                            hybridAksClustersAssociatedIds = array;
                            continue;
                        }
                        if (property0.NameEquals("kubernetesNodeName"u8))
                        {
                            kubernetesNodeName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("kubernetesVersion"u8))
                        {
                            kubernetesVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("machineClusterVersion"u8))
                        {
                            machineClusterVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("machineDetails"u8))
                        {
                            machineDetails = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("machineName"u8))
                        {
                            machineName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("machineRoles"u8))
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
                            machineRoles = array;
                            continue;
                        }
                        if (property0.NameEquals("machineSkuId"u8))
                        {
                            machineSkuId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("oamIpv4Address"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            oamIPv4Address = IPAddress.Parse(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("oamIpv6Address"u8))
                        {
                            oamIPv6Address = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("osImage"u8))
                        {
                            osImage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("powerState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            powerState = new BareMetalMachinePowerState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new BareMetalMachineProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rackId"u8))
                        {
                            rackId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rackSlot"u8))
                        {
                            rackSlot = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("readyState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            readyState = new BareMetalMachineReadyState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("runtimeProtectionStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            runtimeProtectionStatus = RuntimeProtectionStatus.DeserializeRuntimeProtectionStatus(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("secretRotationStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecretRotationStatus> array = new List<SecretRotationStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Models.SecretRotationStatus.DeserializeSecretRotationStatus(item, options));
                            }
                            secretRotationStatus = array;
                            continue;
                        }
                        if (property0.NameEquals("serialNumber"u8))
                        {
                            serialNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceTag"u8))
                        {
                            serviceTag = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualMachinesAssociatedIds"u8))
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
                            virtualMachinesAssociatedIds = array;
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
            return new NetworkCloudBareMetalMachineData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                extendedLocation,
                associatedResourceIds ?? new ChangeTrackingList<ResourceIdentifier>(),
                bmcConnectionString,
                bmcCredentials,
                bmcMacAddress,
                bootMacAddress,
                clusterId,
                cordonStatus,
                detailedStatus,
                detailedStatusMessage,
                hardwareInventory,
                hardwareValidationStatus,
                hybridAksClustersAssociatedIds ?? new ChangeTrackingList<string>(),
                kubernetesNodeName,
                kubernetesVersion,
                machineClusterVersion,
                machineDetails,
                machineName,
                machineRoles ?? new ChangeTrackingList<string>(),
                machineSkuId,
                oamIPv4Address,
                oamIPv6Address,
                osImage,
                powerState,
                provisioningState,
                rackId,
                rackSlot,
                readyState,
                runtimeProtectionStatus,
                secretRotationStatus ?? new ChangeTrackingList<SecretRotationStatus>(),
                serialNumber,
                serviceTag,
                virtualMachinesAssociatedIds ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkCloudBareMetalMachineData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudBareMetalMachineData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudBareMetalMachineData)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkCloudBareMetalMachineData IPersistableModel<NetworkCloudBareMetalMachineData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudBareMetalMachineData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNetworkCloudBareMetalMachineData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudBareMetalMachineData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkCloudBareMetalMachineData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
