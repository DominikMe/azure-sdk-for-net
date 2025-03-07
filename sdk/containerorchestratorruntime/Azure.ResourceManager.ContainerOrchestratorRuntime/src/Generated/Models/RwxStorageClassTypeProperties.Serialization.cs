// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime.Models
{
    public partial class RwxStorageClassTypeProperties : IUtf8JsonSerializable, IJsonModel<RwxStorageClassTypeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RwxStorageClassTypeProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RwxStorageClassTypeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RwxStorageClassTypeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RwxStorageClassTypeProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("backingStorageClassName"u8);
            writer.WriteStringValue(BackingStorageClassName);
        }

        RwxStorageClassTypeProperties IJsonModel<RwxStorageClassTypeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RwxStorageClassTypeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RwxStorageClassTypeProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRwxStorageClassTypeProperties(document.RootElement, options);
        }

        internal static RwxStorageClassTypeProperties DeserializeRwxStorageClassTypeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string backingStorageClassName = default;
            StorageClassType type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backingStorageClassName"u8))
                {
                    backingStorageClassName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new StorageClassType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RwxStorageClassTypeProperties(type, serializedAdditionalRawData, backingStorageClassName);
        }

        BinaryData IPersistableModel<RwxStorageClassTypeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RwxStorageClassTypeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RwxStorageClassTypeProperties)} does not support writing '{options.Format}' format.");
            }
        }

        RwxStorageClassTypeProperties IPersistableModel<RwxStorageClassTypeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RwxStorageClassTypeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRwxStorageClassTypeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RwxStorageClassTypeProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RwxStorageClassTypeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
