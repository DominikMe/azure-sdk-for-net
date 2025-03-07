// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.LargeInstance.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.LargeInstance
{
    public partial class LargeInstanceData : IUtf8JsonSerializable, IJsonModel<LargeInstanceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LargeInstanceData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LargeInstanceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LargeInstanceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LargeInstanceData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(HardwareProfile))
            {
                writer.WritePropertyName("hardwareProfile"u8);
                writer.WriteObjectValue(HardwareProfile, options);
            }
            if (Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile"u8);
                writer.WriteObjectValue(StorageProfile, options);
            }
            if (Optional.IsDefined(OSProfile))
            {
                writer.WritePropertyName("osProfile"u8);
                writer.WriteObjectValue(OSProfile, options);
            }
            if (Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile"u8);
                writer.WriteObjectValue(NetworkProfile, options);
            }
            if (options.Format != "W" && Optional.IsDefined(AzureLargeInstanceId))
            {
                writer.WritePropertyName("azureLargeInstanceId"u8);
                writer.WriteStringValue(AzureLargeInstanceId);
            }
            if (options.Format != "W" && Optional.IsDefined(PowerState))
            {
                writer.WritePropertyName("powerState"u8);
                writer.WriteStringValue(PowerState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProximityPlacementGroup))
            {
                writer.WritePropertyName("proximityPlacementGroup"u8);
                writer.WriteStringValue(ProximityPlacementGroup);
            }
            if (options.Format != "W" && Optional.IsDefined(HwRevision))
            {
                writer.WritePropertyName("hwRevision"u8);
                writer.WriteStringValue(HwRevision);
            }
            if (Optional.IsDefined(PartnerNodeId))
            {
                writer.WritePropertyName("partnerNodeId"u8);
                writer.WriteStringValue(PartnerNodeId);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        LargeInstanceData IJsonModel<LargeInstanceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LargeInstanceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LargeInstanceData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLargeInstanceData(document.RootElement, options);
        }

        internal static LargeInstanceData DeserializeLargeInstanceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            LargeInstanceHardwareProfile hardwareProfile = default;
            LargeInstanceStorageProfile storageProfile = default;
            LargeInstanceOSProfile osProfile = default;
            LargeInstanceNetworkProfile networkProfile = default;
            string azureLargeInstanceId = default;
            LargeInstancePowerState? powerState = default;
            string proximityPlacementGroup = default;
            string hwRevision = default;
            string partnerNodeId = default;
            LargeInstanceProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("hardwareProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hardwareProfile = LargeInstanceHardwareProfile.DeserializeLargeInstanceHardwareProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("storageProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageProfile = LargeInstanceStorageProfile.DeserializeLargeInstanceStorageProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("osProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osProfile = LargeInstanceOSProfile.DeserializeLargeInstanceOSProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("networkProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkProfile = LargeInstanceNetworkProfile.DeserializeLargeInstanceNetworkProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("azureLargeInstanceId"u8))
                        {
                            azureLargeInstanceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("powerState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            powerState = new LargeInstancePowerState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("proximityPlacementGroup"u8))
                        {
                            proximityPlacementGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hwRevision"u8))
                        {
                            hwRevision = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partnerNodeId"u8))
                        {
                            partnerNodeId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new LargeInstanceProvisioningState(property0.Value.GetString());
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
            return new LargeInstanceData(
                id,
                name,
                type,
                systemData,
                hardwareProfile,
                storageProfile,
                osProfile,
                networkProfile,
                azureLargeInstanceId,
                powerState,
                proximityPlacementGroup,
                hwRevision,
                partnerNodeId,
                provisioningState,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LargeInstanceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LargeInstanceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LargeInstanceData)} does not support writing '{options.Format}' format.");
            }
        }

        LargeInstanceData IPersistableModel<LargeInstanceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LargeInstanceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeLargeInstanceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LargeInstanceData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LargeInstanceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
