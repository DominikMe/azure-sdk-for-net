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

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class HDInsightClusterProperties : IUtf8JsonSerializable, IJsonModel<HDInsightClusterProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightClusterProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HDInsightClusterProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightClusterProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WritePropertyName("clusterType"u8);
            writer.WriteStringValue(ClusterType);
            if (options.Format != "W" && Optional.IsDefined(DeploymentId))
            {
                writer.WritePropertyName("deploymentId"u8);
                writer.WriteStringValue(DeploymentId);
            }
            writer.WritePropertyName("computeProfile"u8);
            writer.WriteObjectValue(ComputeProfile, options);
            writer.WritePropertyName("clusterProfile"u8);
            writer.WriteObjectValue(ClusterProfile, options);
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
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

        HDInsightClusterProperties IJsonModel<HDInsightClusterProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightClusterProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightClusterProperties(document.RootElement, options);
        }

        internal static HDInsightClusterProperties DeserializeHDInsightClusterProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HDInsightProvisioningStatus? provisioningState = default;
            string clusterType = default;
            string deploymentId = default;
            ClusterComputeProfile computeProfile = default;
            ClusterProfile clusterProfile = default;
            string status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new HDInsightProvisioningStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("clusterType"u8))
                {
                    clusterType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deploymentId"u8))
                {
                    deploymentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("computeProfile"u8))
                {
                    computeProfile = ClusterComputeProfile.DeserializeClusterComputeProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("clusterProfile"u8))
                {
                    clusterProfile = ClusterProfile.DeserializeClusterProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HDInsightClusterProperties(
                provisioningState,
                clusterType,
                deploymentId,
                computeProfile,
                clusterProfile,
                status,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("  provisioningState: ");
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClusterType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clusterType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClusterType))
                {
                    builder.Append("  clusterType: ");
                    if (ClusterType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ClusterType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ClusterType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DeploymentId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  deploymentId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DeploymentId))
                {
                    builder.Append("  deploymentId: ");
                    if (DeploymentId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DeploymentId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DeploymentId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ComputeProfile), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  computeProfile: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ComputeProfile))
                {
                    builder.Append("  computeProfile: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ComputeProfile, options, 2, false, "  computeProfile: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClusterProfile), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clusterProfile: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClusterProfile))
                {
                    builder.Append("  clusterProfile: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ClusterProfile, options, 2, false, "  clusterProfile: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Status), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  status: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Status))
                {
                    builder.Append("  status: ");
                    if (Status.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Status}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Status}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<HDInsightClusterProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightClusterProperties)} does not support writing '{options.Format}' format.");
            }
        }

        HDInsightClusterProperties IPersistableModel<HDInsightClusterProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHDInsightClusterProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightClusterProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightClusterProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
