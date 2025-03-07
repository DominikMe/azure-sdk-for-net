// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.OpenAI.Assistants
{
    public partial class MessageTextFilePathAnnotation : IUtf8JsonSerializable, IJsonModel<MessageTextFilePathAnnotation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MessageTextFilePathAnnotation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MessageTextFilePathAnnotation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageTextFilePathAnnotation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessageTextFilePathAnnotation)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("file_path"u8);
            writer.WriteObjectValue<InternalMessageTextFilePathDetails>(InternalDetails, options);
        }

        MessageTextFilePathAnnotation IJsonModel<MessageTextFilePathAnnotation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageTextFilePathAnnotation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessageTextFilePathAnnotation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMessageTextFilePathAnnotation(document.RootElement, options);
        }

        internal static MessageTextFilePathAnnotation DeserializeMessageTextFilePathAnnotation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalMessageTextFilePathDetails filePath = default;
            string type = default;
            string text = default;
            int startIndex = default;
            int endIndex = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("file_path"u8))
                {
                    filePath = InternalMessageTextFilePathDetails.DeserializeInternalMessageTextFilePathDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("start_index"u8))
                {
                    startIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("end_index"u8))
                {
                    endIndex = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MessageTextFilePathAnnotation(
                type,
                text,
                startIndex,
                endIndex,
                serializedAdditionalRawData,
                filePath);
        }

        BinaryData IPersistableModel<MessageTextFilePathAnnotation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageTextFilePathAnnotation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MessageTextFilePathAnnotation)} does not support writing '{options.Format}' format.");
            }
        }

        MessageTextFilePathAnnotation IPersistableModel<MessageTextFilePathAnnotation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageTextFilePathAnnotation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMessageTextFilePathAnnotation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MessageTextFilePathAnnotation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MessageTextFilePathAnnotation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new MessageTextFilePathAnnotation FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeMessageTextFilePathAnnotation(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
