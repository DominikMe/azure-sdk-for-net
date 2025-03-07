// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class DeploymentSettingStorageAdapterIPInfo : IUtf8JsonSerializable, IJsonModel<DeploymentSettingStorageAdapterIPInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeploymentSettingStorageAdapterIPInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DeploymentSettingStorageAdapterIPInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentSettingStorageAdapterIPInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeploymentSettingStorageAdapterIPInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PhysicalNode))
            {
                writer.WritePropertyName("physicalNode"u8);
                writer.WriteStringValue(PhysicalNode);
            }
            if (Optional.IsDefined(IPv4Address))
            {
                writer.WritePropertyName("ipv4Address"u8);
                writer.WriteStringValue(IPv4Address);
            }
            if (Optional.IsDefined(SubnetMask))
            {
                writer.WritePropertyName("subnetMask"u8);
                writer.WriteStringValue(SubnetMask);
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

        DeploymentSettingStorageAdapterIPInfo IJsonModel<DeploymentSettingStorageAdapterIPInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentSettingStorageAdapterIPInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeploymentSettingStorageAdapterIPInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeploymentSettingStorageAdapterIPInfo(document.RootElement, options);
        }

        internal static DeploymentSettingStorageAdapterIPInfo DeserializeDeploymentSettingStorageAdapterIPInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string physicalNode = default;
            string ipv4Address = default;
            string subnetMask = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("physicalNode"u8))
                {
                    physicalNode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipv4Address"u8))
                {
                    ipv4Address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnetMask"u8))
                {
                    subnetMask = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DeploymentSettingStorageAdapterIPInfo(physicalNode, ipv4Address, subnetMask, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PhysicalNode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  physicalNode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PhysicalNode))
                {
                    builder.Append("  physicalNode: ");
                    if (PhysicalNode.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PhysicalNode}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PhysicalNode}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IPv4Address), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  ipv4Address: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IPv4Address))
                {
                    builder.Append("  ipv4Address: ");
                    if (IPv4Address.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{IPv4Address}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{IPv4Address}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SubnetMask), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  subnetMask: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SubnetMask))
                {
                    builder.Append("  subnetMask: ");
                    if (SubnetMask.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SubnetMask}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SubnetMask}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<DeploymentSettingStorageAdapterIPInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentSettingStorageAdapterIPInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DeploymentSettingStorageAdapterIPInfo)} does not support writing '{options.Format}' format.");
            }
        }

        DeploymentSettingStorageAdapterIPInfo IPersistableModel<DeploymentSettingStorageAdapterIPInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentSettingStorageAdapterIPInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDeploymentSettingStorageAdapterIPInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeploymentSettingStorageAdapterIPInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeploymentSettingStorageAdapterIPInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
