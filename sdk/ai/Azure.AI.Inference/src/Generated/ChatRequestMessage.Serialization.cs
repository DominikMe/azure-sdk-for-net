// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Inference
{
    [PersistableModelProxy(typeof(UnknownChatRequestMessage))]
    public partial class ChatRequestMessage : IUtf8JsonSerializable, IJsonModel<ChatRequestMessage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ChatRequestMessage>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ChatRequestMessage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatRequestMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatRequestMessage)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("role"u8);
            writer.WriteStringValue(Role.ToString());
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

        ChatRequestMessage IJsonModel<ChatRequestMessage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatRequestMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatRequestMessage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatRequestMessage(document.RootElement, options);
        }

        internal static ChatRequestMessage DeserializeChatRequestMessage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("role", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "assistant": return ChatRequestAssistantMessage.DeserializeChatRequestAssistantMessage(element, options);
                    case "developer": return ChatRequestDeveloperMessage.DeserializeChatRequestDeveloperMessage(element, options);
                    case "system": return ChatRequestSystemMessage.DeserializeChatRequestSystemMessage(element, options);
                    case "tool": return ChatRequestToolMessage.DeserializeChatRequestToolMessage(element, options);
                    case "user": return ChatRequestUserMessage.DeserializeChatRequestUserMessage(element, options);
                }
            }
            return UnknownChatRequestMessage.DeserializeUnknownChatRequestMessage(element, options);
        }

        BinaryData IPersistableModel<ChatRequestMessage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatRequestMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChatRequestMessage)} does not support writing '{options.Format}' format.");
            }
        }

        ChatRequestMessage IPersistableModel<ChatRequestMessage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatRequestMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeChatRequestMessage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChatRequestMessage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatRequestMessage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ChatRequestMessage FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeChatRequestMessage(document.RootElement);
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
