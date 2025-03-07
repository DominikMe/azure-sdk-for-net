// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    public partial class DictionaryExample : IUtf8JsonSerializable, IJsonModel<DictionaryExample>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DictionaryExample>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DictionaryExample>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DictionaryExample>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DictionaryExample)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("sourcePrefix"u8);
            writer.WriteStringValue(SourcePrefix);
            writer.WritePropertyName("sourceTerm"u8);
            writer.WriteStringValue(SourceTerm);
            writer.WritePropertyName("sourceSuffix"u8);
            writer.WriteStringValue(SourceSuffix);
            writer.WritePropertyName("targetPrefix"u8);
            writer.WriteStringValue(TargetPrefix);
            writer.WritePropertyName("targetTerm"u8);
            writer.WriteStringValue(TargetTerm);
            writer.WritePropertyName("targetSuffix"u8);
            writer.WriteStringValue(TargetSuffix);
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

        DictionaryExample IJsonModel<DictionaryExample>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DictionaryExample>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DictionaryExample)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDictionaryExample(document.RootElement, options);
        }

        internal static DictionaryExample DeserializeDictionaryExample(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourcePrefix = default;
            string sourceTerm = default;
            string sourceSuffix = default;
            string targetPrefix = default;
            string targetTerm = default;
            string targetSuffix = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourcePrefix"u8))
                {
                    sourcePrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceTerm"u8))
                {
                    sourceTerm = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceSuffix"u8))
                {
                    sourceSuffix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetPrefix"u8))
                {
                    targetPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetTerm"u8))
                {
                    targetTerm = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetSuffix"u8))
                {
                    targetSuffix = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DictionaryExample(
                sourcePrefix,
                sourceTerm,
                sourceSuffix,
                targetPrefix,
                targetTerm,
                targetSuffix,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DictionaryExample>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DictionaryExample>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DictionaryExample)} does not support writing '{options.Format}' format.");
            }
        }

        DictionaryExample IPersistableModel<DictionaryExample>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DictionaryExample>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDictionaryExample(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DictionaryExample)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DictionaryExample>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DictionaryExample FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeDictionaryExample(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
