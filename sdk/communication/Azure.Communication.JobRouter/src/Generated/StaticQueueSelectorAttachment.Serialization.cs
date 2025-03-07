// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class StaticQueueSelectorAttachment : IUtf8JsonSerializable, IJsonModel<StaticQueueSelectorAttachment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StaticQueueSelectorAttachment>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StaticQueueSelectorAttachment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticQueueSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StaticQueueSelectorAttachment)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("queueSelector"u8);
            writer.WriteObjectValue(QueueSelector, options);
        }

        StaticQueueSelectorAttachment IJsonModel<StaticQueueSelectorAttachment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticQueueSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StaticQueueSelectorAttachment)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStaticQueueSelectorAttachment(document.RootElement, options);
        }

        internal static StaticQueueSelectorAttachment DeserializeStaticQueueSelectorAttachment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RouterQueueSelector queueSelector = default;
            QueueSelectorAttachmentKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queueSelector"u8))
                {
                    queueSelector = RouterQueueSelector.DeserializeRouterQueueSelector(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new QueueSelectorAttachmentKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StaticQueueSelectorAttachment(kind, serializedAdditionalRawData, queueSelector);
        }

        BinaryData IPersistableModel<StaticQueueSelectorAttachment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticQueueSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StaticQueueSelectorAttachment)} does not support writing '{options.Format}' format.");
            }
        }

        StaticQueueSelectorAttachment IPersistableModel<StaticQueueSelectorAttachment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticQueueSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStaticQueueSelectorAttachment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StaticQueueSelectorAttachment)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StaticQueueSelectorAttachment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new StaticQueueSelectorAttachment FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeStaticQueueSelectorAttachment(document.RootElement);
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
