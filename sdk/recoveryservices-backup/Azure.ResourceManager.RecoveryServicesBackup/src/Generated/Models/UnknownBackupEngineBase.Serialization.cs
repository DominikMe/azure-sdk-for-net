// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    internal partial class UnknownBackupEngineBase : IUtf8JsonSerializable, IJsonModel<BackupGenericEngine>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupGenericEngine>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BackupGenericEngine>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericEngine>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupGenericEngine)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        BackupGenericEngine IJsonModel<BackupGenericEngine>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericEngine>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupGenericEngine)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupGenericEngine(document.RootElement, options);
        }

        internal static UnknownBackupEngineBase DeserializeUnknownBackupEngineBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string friendlyName = default;
            BackupManagementType? backupManagementType = default;
            string registrationStatus = default;
            string backupEngineState = default;
            string healthStatus = default;
            BackupEngineType backupEngineType = "Unknown";
            bool? canReRegister = default;
            string backupEngineId = default;
            string dpmVersion = default;
            string azureBackupAgentVersion = default;
            bool? isAzureBackupAgentUpgradeAvailable = default;
            bool? isDpmUpgradeAvailable = default;
            BackupEngineExtendedInfo extendedInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupManagementType = new BackupManagementType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("registrationStatus"u8))
                {
                    registrationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupEngineState"u8))
                {
                    backupEngineState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthStatus"u8))
                {
                    healthStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupEngineType"u8))
                {
                    backupEngineType = new BackupEngineType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("canReRegister"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    canReRegister = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("backupEngineId"u8))
                {
                    backupEngineId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dpmVersion"u8))
                {
                    dpmVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureBackupAgentVersion"u8))
                {
                    azureBackupAgentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAzureBackupAgentUpgradeAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAzureBackupAgentUpgradeAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDpmUpgradeAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDpmUpgradeAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("extendedInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedInfo = BackupEngineExtendedInfo.DeserializeBackupEngineExtendedInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownBackupEngineBase(
                friendlyName,
                backupManagementType,
                registrationStatus,
                backupEngineState,
                healthStatus,
                backupEngineType,
                canReRegister,
                backupEngineId,
                dpmVersion,
                azureBackupAgentVersion,
                isAzureBackupAgentUpgradeAvailable,
                isDpmUpgradeAvailable,
                extendedInfo,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackupGenericEngine>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericEngine>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupGenericEngine)} does not support writing '{options.Format}' format.");
            }
        }

        BackupGenericEngine IPersistableModel<BackupGenericEngine>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericEngine>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBackupGenericEngine(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupGenericEngine)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupGenericEngine>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
