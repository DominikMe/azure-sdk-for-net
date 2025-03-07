// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class ExitCodeRangeMapping : IUtf8JsonSerializable, IJsonModel<ExitCodeRangeMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExitCodeRangeMapping>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExitCodeRangeMapping>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExitCodeRangeMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExitCodeRangeMapping)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("start"u8);
            writer.WriteNumberValue(Start);
            writer.WritePropertyName("end"u8);
            writer.WriteNumberValue(End);
            writer.WritePropertyName("exitOptions"u8);
            writer.WriteObjectValue(ExitOptions, options);
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

        ExitCodeRangeMapping IJsonModel<ExitCodeRangeMapping>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExitCodeRangeMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExitCodeRangeMapping)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExitCodeRangeMapping(document.RootElement, options);
        }

        internal static ExitCodeRangeMapping DeserializeExitCodeRangeMapping(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int start = default;
            int end = default;
            ExitOptions exitOptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("start"u8))
                {
                    start = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("end"u8))
                {
                    end = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("exitOptions"u8))
                {
                    exitOptions = ExitOptions.DeserializeExitOptions(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExitCodeRangeMapping(start, end, exitOptions, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExitCodeRangeMapping>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExitCodeRangeMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExitCodeRangeMapping)} does not support writing '{options.Format}' format.");
            }
        }

        ExitCodeRangeMapping IPersistableModel<ExitCodeRangeMapping>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExitCodeRangeMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeExitCodeRangeMapping(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExitCodeRangeMapping)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExitCodeRangeMapping>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ExitCodeRangeMapping FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeExitCodeRangeMapping(document.RootElement);
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
