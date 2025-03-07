// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DelimitedTextWriteSettings : IUtf8JsonSerializable, IJsonModel<DelimitedTextWriteSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DelimitedTextWriteSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DelimitedTextWriteSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DelimitedTextWriteSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DelimitedTextWriteSettings)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(QuoteAllText))
            {
                writer.WritePropertyName("quoteAllText"u8);
                JsonSerializer.Serialize(writer, QuoteAllText);
            }
            writer.WritePropertyName("fileExtension"u8);
            JsonSerializer.Serialize(writer, FileExtension);
            if (Optional.IsDefined(MaxRowsPerFile))
            {
                writer.WritePropertyName("maxRowsPerFile"u8);
                JsonSerializer.Serialize(writer, MaxRowsPerFile);
            }
            if (Optional.IsDefined(FileNamePrefix))
            {
                writer.WritePropertyName("fileNamePrefix"u8);
                JsonSerializer.Serialize(writer, FileNamePrefix);
            }
            foreach (var item in AdditionalProperties)
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

        DelimitedTextWriteSettings IJsonModel<DelimitedTextWriteSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DelimitedTextWriteSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DelimitedTextWriteSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDelimitedTextWriteSettings(document.RootElement, options);
        }

        internal static DelimitedTextWriteSettings DeserializeDelimitedTextWriteSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<bool> quoteAllText = default;
            DataFactoryElement<string> fileExtension = default;
            DataFactoryElement<int> maxRowsPerFile = default;
            DataFactoryElement<string> fileNamePrefix = default;
            string type = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("quoteAllText"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quoteAllText = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("fileExtension"u8))
                {
                    fileExtension = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("maxRowsPerFile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxRowsPerFile = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("fileNamePrefix"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileNamePrefix = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DelimitedTextWriteSettings(
                type,
                additionalProperties,
                quoteAllText,
                fileExtension,
                maxRowsPerFile,
                fileNamePrefix);
        }

        BinaryData IPersistableModel<DelimitedTextWriteSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DelimitedTextWriteSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DelimitedTextWriteSettings)} does not support writing '{options.Format}' format.");
            }
        }

        DelimitedTextWriteSettings IPersistableModel<DelimitedTextWriteSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DelimitedTextWriteSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDelimitedTextWriteSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DelimitedTextWriteSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DelimitedTextWriteSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
