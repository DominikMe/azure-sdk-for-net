// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ConnectToSourceSqlServerTaskInput : IUtf8JsonSerializable, IJsonModel<ConnectToSourceSqlServerTaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectToSourceSqlServerTaskInput>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConnectToSourceSqlServerTaskInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceSqlServerTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectToSourceSqlServerTaskInput)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("sourceConnectionInfo"u8);
            writer.WriteObjectValue(SourceConnectionInfo, options);
            if (Optional.IsDefined(CheckPermissionsGroup))
            {
                writer.WritePropertyName("checkPermissionsGroup"u8);
                writer.WriteStringValue(CheckPermissionsGroup.Value.ToSerialString());
            }
            if (Optional.IsDefined(CollectDatabases))
            {
                writer.WritePropertyName("collectDatabases"u8);
                writer.WriteBooleanValue(CollectDatabases.Value);
            }
            if (Optional.IsDefined(CollectLogins))
            {
                writer.WritePropertyName("collectLogins"u8);
                writer.WriteBooleanValue(CollectLogins.Value);
            }
            if (Optional.IsDefined(CollectAgentJobs))
            {
                writer.WritePropertyName("collectAgentJobs"u8);
                writer.WriteBooleanValue(CollectAgentJobs.Value);
            }
            if (Optional.IsDefined(CollectTdeCertificateInfo))
            {
                writer.WritePropertyName("collectTdeCertificateInfo"u8);
                writer.WriteBooleanValue(CollectTdeCertificateInfo.Value);
            }
            if (Optional.IsDefined(ValidateSsisCatalogOnly))
            {
                writer.WritePropertyName("validateSsisCatalogOnly"u8);
                writer.WriteBooleanValue(ValidateSsisCatalogOnly.Value);
            }
            if (Optional.IsDefined(EncryptedKeyForSecureFields))
            {
                writer.WritePropertyName("encryptedKeyForSecureFields"u8);
                writer.WriteStringValue(EncryptedKeyForSecureFields);
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

        ConnectToSourceSqlServerTaskInput IJsonModel<ConnectToSourceSqlServerTaskInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceSqlServerTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectToSourceSqlServerTaskInput)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectToSourceSqlServerTaskInput(document.RootElement, options);
        }

        internal static ConnectToSourceSqlServerTaskInput DeserializeConnectToSourceSqlServerTaskInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SqlConnectionInfo sourceConnectionInfo = default;
            ServerLevelPermissionsGroup? checkPermissionsGroup = default;
            bool? collectDatabases = default;
            bool? collectLogins = default;
            bool? collectAgentJobs = default;
            bool? collectTdeCertificateInfo = default;
            bool? validateSsisCatalogOnly = default;
            string encryptedKeyForSecureFields = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceConnectionInfo"u8))
                {
                    sourceConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("checkPermissionsGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    checkPermissionsGroup = property.Value.GetString().ToServerLevelPermissionsGroup();
                    continue;
                }
                if (property.NameEquals("collectDatabases"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    collectDatabases = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("collectLogins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    collectLogins = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("collectAgentJobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    collectAgentJobs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("collectTdeCertificateInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    collectTdeCertificateInfo = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("validateSsisCatalogOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validateSsisCatalogOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("encryptedKeyForSecureFields"u8))
                {
                    encryptedKeyForSecureFields = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConnectToSourceSqlServerTaskInput(
                sourceConnectionInfo,
                checkPermissionsGroup,
                collectDatabases,
                collectLogins,
                collectAgentJobs,
                collectTdeCertificateInfo,
                validateSsisCatalogOnly,
                encryptedKeyForSecureFields,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectToSourceSqlServerTaskInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceSqlServerTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectToSourceSqlServerTaskInput)} does not support writing '{options.Format}' format.");
            }
        }

        ConnectToSourceSqlServerTaskInput IPersistableModel<ConnectToSourceSqlServerTaskInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceSqlServerTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConnectToSourceSqlServerTaskInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectToSourceSqlServerTaskInput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectToSourceSqlServerTaskInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
