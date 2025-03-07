// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class SingletonPartitionSchemeDescription : IUtf8JsonSerializable, IJsonModel<SingletonPartitionSchemeDescription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SingletonPartitionSchemeDescription>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SingletonPartitionSchemeDescription>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingletonPartitionSchemeDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SingletonPartitionSchemeDescription)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        SingletonPartitionSchemeDescription IJsonModel<SingletonPartitionSchemeDescription>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingletonPartitionSchemeDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SingletonPartitionSchemeDescription)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSingletonPartitionSchemeDescription(document.RootElement, options);
        }

        internal static SingletonPartitionSchemeDescription DeserializeSingletonPartitionSchemeDescription(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ApplicationPartitionScheme partitionScheme = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionScheme"u8))
                {
                    partitionScheme = new ApplicationPartitionScheme(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SingletonPartitionSchemeDescription(partitionScheme, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SingletonPartitionSchemeDescription>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingletonPartitionSchemeDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SingletonPartitionSchemeDescription)} does not support writing '{options.Format}' format.");
            }
        }

        SingletonPartitionSchemeDescription IPersistableModel<SingletonPartitionSchemeDescription>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingletonPartitionSchemeDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSingletonPartitionSchemeDescription(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SingletonPartitionSchemeDescription)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SingletonPartitionSchemeDescription>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
