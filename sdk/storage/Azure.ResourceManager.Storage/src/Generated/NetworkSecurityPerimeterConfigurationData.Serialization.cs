// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    public partial class NetworkSecurityPerimeterConfigurationData : IUtf8JsonSerializable, IJsonModel<NetworkSecurityPerimeterConfigurationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkSecurityPerimeterConfigurationData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetworkSecurityPerimeterConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkSecurityPerimeterConfigurationData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ProvisioningIssues))
            {
                writer.WritePropertyName("provisioningIssues"u8);
                writer.WriteStartArray();
                foreach (var item in ProvisioningIssues)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(NetworkSecurityPerimeter))
            {
                writer.WritePropertyName("networkSecurityPerimeter"u8);
                writer.WriteObjectValue(NetworkSecurityPerimeter, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceAssociation))
            {
                writer.WritePropertyName("resourceAssociation"u8);
                writer.WriteObjectValue(ResourceAssociation, options);
            }
            if (options.Format != "W" && Optional.IsDefined(Profile))
            {
                writer.WritePropertyName("profile"u8);
                writer.WriteObjectValue(Profile, options);
            }
            writer.WriteEndObject();
        }

        NetworkSecurityPerimeterConfigurationData IJsonModel<NetworkSecurityPerimeterConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkSecurityPerimeterConfigurationData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkSecurityPerimeterConfigurationData(document.RootElement, options);
        }

        internal static NetworkSecurityPerimeterConfigurationData DeserializeNetworkSecurityPerimeterConfigurationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            NetworkSecurityPerimeterConfigurationProvisioningState? provisioningState = default;
            IReadOnlyList<NetworkSecurityPerimeterProvisioningIssue> provisioningIssues = default;
            NetworkSecurityPerimeter networkSecurityPerimeter = default;
            NetworkSecurityPerimeterConfigurationPropertiesResourceAssociation resourceAssociation = default;
            NetworkSecurityPerimeterConfigurationPropertiesProfile profile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkSecurityPerimeterConfigurationProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningIssues"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkSecurityPerimeterProvisioningIssue> array = new List<NetworkSecurityPerimeterProvisioningIssue>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkSecurityPerimeterProvisioningIssue.DeserializeNetworkSecurityPerimeterProvisioningIssue(item, options));
                            }
                            provisioningIssues = array;
                            continue;
                        }
                        if (property0.NameEquals("networkSecurityPerimeter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkSecurityPerimeter = NetworkSecurityPerimeter.DeserializeNetworkSecurityPerimeter(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("resourceAssociation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceAssociation = NetworkSecurityPerimeterConfigurationPropertiesResourceAssociation.DeserializeNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("profile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            profile = NetworkSecurityPerimeterConfigurationPropertiesProfile.DeserializeNetworkSecurityPerimeterConfigurationPropertiesProfile(property0.Value, options);
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
            return new NetworkSecurityPerimeterConfigurationData(
                id,
                name,
                type,
                systemData,
                provisioningState,
                provisioningIssues ?? new ChangeTrackingList<NetworkSecurityPerimeterProvisioningIssue>(),
                networkSecurityPerimeter,
                resourceAssociation,
                profile,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("    provisioningState: ");
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningIssues), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    provisioningIssues: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ProvisioningIssues))
                {
                    if (ProvisioningIssues.Any())
                    {
                        builder.Append("    provisioningIssues: ");
                        builder.AppendLine("[");
                        foreach (var item in ProvisioningIssues)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    provisioningIssues: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NetworkSecurityPerimeter), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    networkSecurityPerimeter: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NetworkSecurityPerimeter))
                {
                    builder.Append("    networkSecurityPerimeter: ");
                    BicepSerializationHelpers.AppendChildObject(builder, NetworkSecurityPerimeter, options, 4, false, "    networkSecurityPerimeter: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ResourceAssociation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    resourceAssociation: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ResourceAssociation))
                {
                    builder.Append("    resourceAssociation: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ResourceAssociation, options, 4, false, "    resourceAssociation: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Profile), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    profile: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Profile))
                {
                    builder.Append("    profile: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Profile, options, 4, false, "    profile: ");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<NetworkSecurityPerimeterConfigurationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(NetworkSecurityPerimeterConfigurationData)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkSecurityPerimeterConfigurationData IPersistableModel<NetworkSecurityPerimeterConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNetworkSecurityPerimeterConfigurationData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkSecurityPerimeterConfigurationData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkSecurityPerimeterConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
