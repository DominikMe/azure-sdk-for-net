// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    [PersistableModelProxy(typeof(UnknownMigrateSqlServerSqlDBSyncTaskOutput))]
    public partial class MigrateSqlServerSqlDBSyncTaskOutput : IUtf8JsonSerializable, IJsonModel<MigrateSqlServerSqlDBSyncTaskOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateSqlServerSqlDBSyncTaskOutput>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MigrateSqlServerSqlDBSyncTaskOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBSyncTaskOutput)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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

        MigrateSqlServerSqlDBSyncTaskOutput IJsonModel<MigrateSqlServerSqlDBSyncTaskOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBSyncTaskOutput)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlServerSqlDBSyncTaskOutput(document.RootElement, options);
        }

        internal static MigrateSqlServerSqlDBSyncTaskOutput DeserializeMigrateSqlServerSqlDBSyncTaskOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("resultType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DatabaseLevelErrorOutput": return MigrateSqlServerSqlDBSyncTaskOutputDatabaseError.DeserializeMigrateSqlServerSqlDBSyncTaskOutputDatabaseError(element, options);
                    case "DatabaseLevelOutput": return MigrateSqlServerSqlDBSyncTaskOutputDatabaseLevel.DeserializeMigrateSqlServerSqlDBSyncTaskOutputDatabaseLevel(element, options);
                    case "ErrorOutput": return MigrateSqlServerSqlDBSyncTaskOutputError.DeserializeMigrateSqlServerSqlDBSyncTaskOutputError(element, options);
                    case "MigrationLevelOutput": return MigrateSqlServerSqlDBSyncTaskOutputMigrationLevel.DeserializeMigrateSqlServerSqlDBSyncTaskOutputMigrationLevel(element, options);
                    case "TableLevelOutput": return MigrateSqlServerSqlDBSyncTaskOutputTableLevel.DeserializeMigrateSqlServerSqlDBSyncTaskOutputTableLevel(element, options);
                }
            }
            return UnknownMigrateSqlServerSqlDBSyncTaskOutput.DeserializeUnknownMigrateSqlServerSqlDBSyncTaskOutput(element, options);
        }

        BinaryData IPersistableModel<MigrateSqlServerSqlDBSyncTaskOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBSyncTaskOutput)} does not support writing '{options.Format}' format.");
            }
        }

        MigrateSqlServerSqlDBSyncTaskOutput IPersistableModel<MigrateSqlServerSqlDBSyncTaskOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMigrateSqlServerSqlDBSyncTaskOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBSyncTaskOutput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateSqlServerSqlDBSyncTaskOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
