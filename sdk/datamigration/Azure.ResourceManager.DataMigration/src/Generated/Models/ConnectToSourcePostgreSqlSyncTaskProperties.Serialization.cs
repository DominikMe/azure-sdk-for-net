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
    public partial class ConnectToSourcePostgreSqlSyncTaskProperties : IUtf8JsonSerializable, IJsonModel<ConnectToSourcePostgreSqlSyncTaskProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectToSourcePostgreSqlSyncTaskProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConnectToSourcePostgreSqlSyncTaskProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourcePostgreSqlSyncTaskProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectToSourcePostgreSqlSyncTaskProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Input))
            {
                writer.WritePropertyName("input"u8);
                writer.WriteObjectValue(Input, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Output))
            {
                writer.WritePropertyName("output"u8);
                writer.WriteStartArray();
                foreach (var item in Output)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
        }

        ConnectToSourcePostgreSqlSyncTaskProperties IJsonModel<ConnectToSourcePostgreSqlSyncTaskProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourcePostgreSqlSyncTaskProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectToSourcePostgreSqlSyncTaskProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectToSourcePostgreSqlSyncTaskProperties(document.RootElement, options);
        }

        internal static ConnectToSourcePostgreSqlSyncTaskProperties DeserializeConnectToSourcePostgreSqlSyncTaskProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ConnectToSourcePostgreSqlSyncTaskInput input = default;
            IReadOnlyList<ConnectToSourcePostgreSqlSyncTaskOutput> output = default;
            TaskType taskType = default;
            IReadOnlyList<ODataError> errors = default;
            TaskState? state = default;
            IReadOnlyList<CommandProperties> commands = default;
            IDictionary<string, string> clientData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("input"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    input = ConnectToSourcePostgreSqlSyncTaskInput.DeserializeConnectToSourcePostgreSqlSyncTaskInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConnectToSourcePostgreSqlSyncTaskOutput> array = new List<ConnectToSourcePostgreSqlSyncTaskOutput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectToSourcePostgreSqlSyncTaskOutput.DeserializeConnectToSourcePostgreSqlSyncTaskOutput(item, options));
                    }
                    output = array;
                    continue;
                }
                if (property.NameEquals("taskType"u8))
                {
                    taskType = new TaskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ODataError> array = new List<ODataError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ODataError.DeserializeODataError(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new TaskState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("commands"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CommandProperties> array = new List<CommandProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CommandProperties.DeserializeCommandProperties(item, options));
                    }
                    commands = array;
                    continue;
                }
                if (property.NameEquals("clientData"u8))
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
                    clientData = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConnectToSourcePostgreSqlSyncTaskProperties(
                taskType,
                errors ?? new ChangeTrackingList<ODataError>(),
                state,
                commands ?? new ChangeTrackingList<CommandProperties>(),
                clientData ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                input,
                output ?? new ChangeTrackingList<ConnectToSourcePostgreSqlSyncTaskOutput>());
        }

        BinaryData IPersistableModel<ConnectToSourcePostgreSqlSyncTaskProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourcePostgreSqlSyncTaskProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectToSourcePostgreSqlSyncTaskProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ConnectToSourcePostgreSqlSyncTaskProperties IPersistableModel<ConnectToSourcePostgreSqlSyncTaskProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourcePostgreSqlSyncTaskProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConnectToSourcePostgreSqlSyncTaskProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectToSourcePostgreSqlSyncTaskProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectToSourcePostgreSqlSyncTaskProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
