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
    public partial class ConditionalWorkerSelectorAttachment : IUtf8JsonSerializable, IJsonModel<ConditionalWorkerSelectorAttachment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConditionalWorkerSelectorAttachment>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConditionalWorkerSelectorAttachment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConditionalWorkerSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConditionalWorkerSelectorAttachment)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("condition"u8);
            writer.WriteObjectValue(Condition, options);
            writer.WritePropertyName("workerSelectors"u8);
            writer.WriteStartArray();
            foreach (var item in WorkerSelectors)
            {
                writer.WriteObjectValue<RouterWorkerSelector>(item, options);
            }
            writer.WriteEndArray();
        }

        ConditionalWorkerSelectorAttachment IJsonModel<ConditionalWorkerSelectorAttachment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConditionalWorkerSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConditionalWorkerSelectorAttachment)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConditionalWorkerSelectorAttachment(document.RootElement, options);
        }

        internal static ConditionalWorkerSelectorAttachment DeserializeConditionalWorkerSelectorAttachment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RouterRule condition = default;
            IList<RouterWorkerSelector> workerSelectors = default;
            WorkerSelectorAttachmentKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("condition"u8))
                {
                    condition = RouterRule.DeserializeRouterRule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("workerSelectors"u8))
                {
                    List<RouterWorkerSelector> array = new List<RouterWorkerSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouterWorkerSelector.DeserializeRouterWorkerSelector(item, options));
                    }
                    workerSelectors = array;
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new WorkerSelectorAttachmentKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConditionalWorkerSelectorAttachment(kind, serializedAdditionalRawData, condition, workerSelectors);
        }

        BinaryData IPersistableModel<ConditionalWorkerSelectorAttachment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConditionalWorkerSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConditionalWorkerSelectorAttachment)} does not support writing '{options.Format}' format.");
            }
        }

        ConditionalWorkerSelectorAttachment IPersistableModel<ConditionalWorkerSelectorAttachment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConditionalWorkerSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConditionalWorkerSelectorAttachment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConditionalWorkerSelectorAttachment)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConditionalWorkerSelectorAttachment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new ConditionalWorkerSelectorAttachment FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeConditionalWorkerSelectorAttachment(document.RootElement);
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
