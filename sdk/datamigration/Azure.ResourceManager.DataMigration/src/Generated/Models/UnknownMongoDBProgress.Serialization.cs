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
    internal partial class UnknownMongoDBProgress : IUtf8JsonSerializable, IJsonModel<MongoDBProgress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MongoDBProgress>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MongoDBProgress>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBProgress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBProgress)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        MongoDBProgress IJsonModel<MongoDBProgress>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBProgress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBProgress)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMongoDBProgress(document.RootElement, options);
        }

        internal static UnknownMongoDBProgress DeserializeUnknownMongoDBProgress(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long bytesCopied = default;
            long documentsCopied = default;
            string elapsedTime = default;
            IReadOnlyDictionary<string, MongoDBError> errors = default;
            long eventsPending = default;
            long eventsReplayed = default;
            DateTimeOffset? lastEventTime = default;
            DateTimeOffset? lastReplayTime = default;
            string name = default;
            string qualifiedName = default;
            MongoDBProgressResultType resultType = "Unknown";
            MongoDBMigrationState state = default;
            long totalBytes = default;
            long totalDocuments = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bytesCopied"u8))
                {
                    bytesCopied = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("documentsCopied"u8))
                {
                    documentsCopied = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("elapsedTime"u8))
                {
                    elapsedTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    Dictionary<string, MongoDBError> dictionary = new Dictionary<string, MongoDBError>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MongoDBError.DeserializeMongoDBError(property0.Value, options));
                    }
                    errors = dictionary;
                    continue;
                }
                if (property.NameEquals("eventsPending"u8))
                {
                    eventsPending = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("eventsReplayed"u8))
                {
                    eventsReplayed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastEventTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastEventTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastReplayTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastReplayTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("qualifiedName"u8))
                {
                    qualifiedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = new MongoDBProgressResultType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = new MongoDBMigrationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("totalBytes"u8))
                {
                    totalBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalDocuments"u8))
                {
                    totalDocuments = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownMongoDBProgress(
                bytesCopied,
                documentsCopied,
                elapsedTime,
                errors,
                eventsPending,
                eventsReplayed,
                lastEventTime,
                lastReplayTime,
                name,
                qualifiedName,
                resultType,
                state,
                totalBytes,
                totalDocuments,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MongoDBProgress>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBProgress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MongoDBProgress)} does not support writing '{options.Format}' format.");
            }
        }

        MongoDBProgress IPersistableModel<MongoDBProgress>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBProgress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMongoDBProgress(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MongoDBProgress)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MongoDBProgress>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
