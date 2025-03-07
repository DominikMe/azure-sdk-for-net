// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotOperations.Models
{
    public partial class DataflowOperationProperties : IUtf8JsonSerializable, IJsonModel<DataflowOperationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataflowOperationProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataflowOperationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowOperationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataflowOperationProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("operationType"u8);
            writer.WriteStringValue(OperationType.ToString());
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(SourceSettings))
            {
                writer.WritePropertyName("sourceSettings"u8);
                writer.WriteObjectValue(SourceSettings, options);
            }
            if (Optional.IsDefined(BuiltInTransformationSettings))
            {
                writer.WritePropertyName("builtInTransformationSettings"u8);
                writer.WriteObjectValue(BuiltInTransformationSettings, options);
            }
            if (Optional.IsDefined(DestinationSettings))
            {
                writer.WritePropertyName("destinationSettings"u8);
                writer.WriteObjectValue(DestinationSettings, options);
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

        DataflowOperationProperties IJsonModel<DataflowOperationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowOperationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataflowOperationProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataflowOperationProperties(document.RootElement, options);
        }

        internal static DataflowOperationProperties DeserializeDataflowOperationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataflowOperationType operationType = default;
            string name = default;
            DataflowSourceOperationSettings sourceSettings = default;
            DataflowBuiltInTransformationSettings builtInTransformationSettings = default;
            DataflowDestinationOperationSettings destinationSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationType"u8))
                {
                    operationType = new DataflowOperationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceSettings = DataflowSourceOperationSettings.DeserializeDataflowSourceOperationSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("builtInTransformationSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    builtInTransformationSettings = DataflowBuiltInTransformationSettings.DeserializeDataflowBuiltInTransformationSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("destinationSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destinationSettings = DataflowDestinationOperationSettings.DeserializeDataflowDestinationOperationSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataflowOperationProperties(
                operationType,
                name,
                sourceSettings,
                builtInTransformationSettings,
                destinationSettings,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataflowOperationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowOperationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataflowOperationProperties)} does not support writing '{options.Format}' format.");
            }
        }

        DataflowOperationProperties IPersistableModel<DataflowOperationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowOperationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataflowOperationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataflowOperationProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataflowOperationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
