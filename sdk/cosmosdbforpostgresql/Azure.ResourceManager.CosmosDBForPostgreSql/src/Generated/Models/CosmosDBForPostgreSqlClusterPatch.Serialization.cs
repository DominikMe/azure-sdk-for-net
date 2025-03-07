// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Models
{
    public partial class CosmosDBForPostgreSqlClusterPatch : IUtf8JsonSerializable, IJsonModel<CosmosDBForPostgreSqlClusterPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBForPostgreSqlClusterPatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CosmosDBForPostgreSqlClusterPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBForPostgreSqlClusterPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBForPostgreSqlClusterPatch)} does not support writing '{format}' format.");
            }

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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AdministratorLoginPassword))
            {
                writer.WritePropertyName("administratorLoginPassword"u8);
                writer.WriteStringValue(AdministratorLoginPassword);
            }
            if (Optional.IsDefined(PostgresqlVersion))
            {
                writer.WritePropertyName("postgresqlVersion"u8);
                writer.WriteStringValue(PostgresqlVersion);
            }
            if (Optional.IsDefined(CitusVersion))
            {
                writer.WritePropertyName("citusVersion"u8);
                writer.WriteStringValue(CitusVersion);
            }
            if (Optional.IsDefined(IsShardsOnCoordinatorEnabled))
            {
                writer.WritePropertyName("enableShardsOnCoordinator"u8);
                writer.WriteBooleanValue(IsShardsOnCoordinatorEnabled.Value);
            }
            if (Optional.IsDefined(IsHAEnabled))
            {
                writer.WritePropertyName("enableHa"u8);
                writer.WriteBooleanValue(IsHAEnabled.Value);
            }
            if (Optional.IsDefined(PreferredPrimaryZone))
            {
                writer.WritePropertyName("preferredPrimaryZone"u8);
                writer.WriteStringValue(PreferredPrimaryZone);
            }
            if (Optional.IsDefined(CoordinatorServerEdition))
            {
                writer.WritePropertyName("coordinatorServerEdition"u8);
                writer.WriteStringValue(CoordinatorServerEdition);
            }
            if (Optional.IsDefined(CoordinatorStorageQuotaInMb))
            {
                writer.WritePropertyName("coordinatorStorageQuotaInMb"u8);
                writer.WriteNumberValue(CoordinatorStorageQuotaInMb.Value);
            }
            if (Optional.IsDefined(CoordinatorVCores))
            {
                writer.WritePropertyName("coordinatorVCores"u8);
                writer.WriteNumberValue(CoordinatorVCores.Value);
            }
            if (Optional.IsDefined(IsCoordinatorPublicIPAccessEnabled))
            {
                writer.WritePropertyName("coordinatorEnablePublicIpAccess"u8);
                writer.WriteBooleanValue(IsCoordinatorPublicIPAccessEnabled.Value);
            }
            if (Optional.IsDefined(NodeServerEdition))
            {
                writer.WritePropertyName("nodeServerEdition"u8);
                writer.WriteStringValue(NodeServerEdition);
            }
            if (Optional.IsDefined(NodeCount))
            {
                writer.WritePropertyName("nodeCount"u8);
                writer.WriteNumberValue(NodeCount.Value);
            }
            if (Optional.IsDefined(NodeStorageQuotaInMb))
            {
                writer.WritePropertyName("nodeStorageQuotaInMb"u8);
                writer.WriteNumberValue(NodeStorageQuotaInMb.Value);
            }
            if (Optional.IsDefined(NodeVCores))
            {
                writer.WritePropertyName("nodeVCores"u8);
                writer.WriteNumberValue(NodeVCores.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsNodePublicIPAccessEnabled))
            {
                writer.WritePropertyName("nodeEnablePublicIpAccess"u8);
                writer.WriteBooleanValue(IsNodePublicIPAccessEnabled.Value);
            }
            if (Optional.IsDefined(MaintenanceWindow))
            {
                writer.WritePropertyName("maintenanceWindow"u8);
                writer.WriteObjectValue(MaintenanceWindow, options);
            }
            writer.WriteEndObject();
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

        CosmosDBForPostgreSqlClusterPatch IJsonModel<CosmosDBForPostgreSqlClusterPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBForPostgreSqlClusterPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBForPostgreSqlClusterPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBForPostgreSqlClusterPatch(document.RootElement, options);
        }

        internal static CosmosDBForPostgreSqlClusterPatch DeserializeCosmosDBForPostgreSqlClusterPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            string administratorLoginPassword = default;
            string postgresqlVersion = default;
            string citusVersion = default;
            bool? enableShardsOnCoordinator = default;
            bool? enableHa = default;
            string preferredPrimaryZone = default;
            string coordinatorServerEdition = default;
            int? coordinatorStorageQuotaInMb = default;
            int? coordinatorVCores = default;
            bool? coordinatorEnablePublicIPAccess = default;
            string nodeServerEdition = default;
            int? nodeCount = default;
            int? nodeStorageQuotaInMb = default;
            int? nodeVCores = default;
            bool? nodeEnablePublicIPAccess = default;
            CosmosDBForPostgreSqlMaintenanceWindow maintenanceWindow = default;
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("administratorLoginPassword"u8))
                        {
                            administratorLoginPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("postgresqlVersion"u8))
                        {
                            postgresqlVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("citusVersion"u8))
                        {
                            citusVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enableShardsOnCoordinator"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableShardsOnCoordinator = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableHa"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableHa = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("preferredPrimaryZone"u8))
                        {
                            preferredPrimaryZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("coordinatorServerEdition"u8))
                        {
                            coordinatorServerEdition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("coordinatorStorageQuotaInMb"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coordinatorStorageQuotaInMb = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("coordinatorVCores"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coordinatorVCores = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("coordinatorEnablePublicIpAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coordinatorEnablePublicIPAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("nodeServerEdition"u8))
                        {
                            nodeServerEdition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("nodeStorageQuotaInMb"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeStorageQuotaInMb = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("nodeVCores"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeVCores = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("nodeEnablePublicIpAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeEnablePublicIPAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("maintenanceWindow"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maintenanceWindow = CosmosDBForPostgreSqlMaintenanceWindow.DeserializeCosmosDBForPostgreSqlMaintenanceWindow(property0.Value, options);
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
            return new CosmosDBForPostgreSqlClusterPatch(
                tags ?? new ChangeTrackingDictionary<string, string>(),
                administratorLoginPassword,
                postgresqlVersion,
                citusVersion,
                enableShardsOnCoordinator,
                enableHa,
                preferredPrimaryZone,
                coordinatorServerEdition,
                coordinatorStorageQuotaInMb,
                coordinatorVCores,
                coordinatorEnablePublicIPAccess,
                nodeServerEdition,
                nodeCount,
                nodeStorageQuotaInMb,
                nodeVCores,
                nodeEnablePublicIPAccess,
                maintenanceWindow,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CosmosDBForPostgreSqlClusterPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBForPostgreSqlClusterPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBForPostgreSqlClusterPatch)} does not support writing '{options.Format}' format.");
            }
        }

        CosmosDBForPostgreSqlClusterPatch IPersistableModel<CosmosDBForPostgreSqlClusterPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBForPostgreSqlClusterPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCosmosDBForPostgreSqlClusterPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBForPostgreSqlClusterPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBForPostgreSqlClusterPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
