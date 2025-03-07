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
    public partial class WebhookRouterRule : IUtf8JsonSerializable, IJsonModel<WebhookRouterRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebhookRouterRule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WebhookRouterRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebhookRouterRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebhookRouterRule)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(AuthorizationServerUri))
            {
                writer.WritePropertyName("authorizationServerUri"u8);
                writer.WriteStringValue(AuthorizationServerUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ClientCredential))
            {
                writer.WritePropertyName("clientCredential"u8);
                writer.WriteObjectValue(ClientCredential, options);
            }
            if (Optional.IsDefined(WebhookUri))
            {
                writer.WritePropertyName("webhookUri"u8);
                writer.WriteStringValue(WebhookUri.AbsoluteUri);
            }
        }

        WebhookRouterRule IJsonModel<WebhookRouterRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebhookRouterRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebhookRouterRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebhookRouterRule(document.RootElement, options);
        }

        internal static WebhookRouterRule DeserializeWebhookRouterRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri authorizationServerUri = default;
            OAuth2WebhookClientCredential clientCredential = default;
            Uri webhookUri = default;
            RouterRuleKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorizationServerUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authorizationServerUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("clientCredential"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientCredential = OAuth2WebhookClientCredential.DeserializeOAuth2WebhookClientCredential(property.Value, options);
                    continue;
                }
                if (property.NameEquals("webhookUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    webhookUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new RouterRuleKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WebhookRouterRule(kind, serializedAdditionalRawData, authorizationServerUri, clientCredential, webhookUri);
        }

        BinaryData IPersistableModel<WebhookRouterRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebhookRouterRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebhookRouterRule)} does not support writing '{options.Format}' format.");
            }
        }

        WebhookRouterRule IPersistableModel<WebhookRouterRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebhookRouterRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeWebhookRouterRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebhookRouterRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebhookRouterRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new WebhookRouterRule FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeWebhookRouterRule(document.RootElement);
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
