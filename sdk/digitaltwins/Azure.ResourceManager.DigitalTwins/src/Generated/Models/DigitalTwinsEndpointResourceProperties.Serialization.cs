// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    [PersistableModelProxy(typeof(UnknownDigitalTwinsEndpointResourceProperties))]
    public partial class DigitalTwinsEndpointResourceProperties : IUtf8JsonSerializable, IJsonModel<DigitalTwinsEndpointResourceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DigitalTwinsEndpointResourceProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DigitalTwinsEndpointResourceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsEndpointResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DigitalTwinsEndpointResourceProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                if (ProvisioningState != null)
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
                else
                {
                    writer.WriteNull("provisioningState");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                if (CreatedOn != null)
                {
                    writer.WritePropertyName("createdTime"u8);
                    writer.WriteStringValue(CreatedOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("createdTime");
                }
            }
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (Optional.IsDefined(DeadLetterSecret))
            {
                if (DeadLetterSecret != null)
                {
                    writer.WritePropertyName("deadLetterSecret"u8);
                    writer.WriteStringValue(DeadLetterSecret);
                }
                else
                {
                    writer.WriteNull("deadLetterSecret");
                }
            }
            if (Optional.IsDefined(DeadLetterUri))
            {
                if (DeadLetterUri != null)
                {
                    writer.WritePropertyName("deadLetterUri"u8);
                    writer.WriteStringValue(DeadLetterUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("deadLetterUri");
                }
            }
            if (Optional.IsDefined(Identity))
            {
                if (Identity != null)
                {
                    writer.WritePropertyName("identity"u8);
                    writer.WriteObjectValue(Identity, options);
                }
                else
                {
                    writer.WriteNull("identity");
                }
            }
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

        DigitalTwinsEndpointResourceProperties IJsonModel<DigitalTwinsEndpointResourceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsEndpointResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DigitalTwinsEndpointResourceProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDigitalTwinsEndpointResourceProperties(document.RootElement, options);
        }

        internal static DigitalTwinsEndpointResourceProperties DeserializeDigitalTwinsEndpointResourceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("endpointType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "EventGrid": return DigitalTwinsEventGridProperties.DeserializeDigitalTwinsEventGridProperties(element, options);
                    case "EventHub": return DigitalTwinsEventHubProperties.DeserializeDigitalTwinsEventHubProperties(element, options);
                    case "ServiceBus": return DigitalTwinsServiceBusProperties.DeserializeDigitalTwinsServiceBusProperties(element, options);
                }
            }
            return UnknownDigitalTwinsEndpointResourceProperties.DeserializeUnknownDigitalTwinsEndpointResourceProperties(element, options);
        }

        BinaryData IPersistableModel<DigitalTwinsEndpointResourceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsEndpointResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DigitalTwinsEndpointResourceProperties)} does not support writing '{options.Format}' format.");
            }
        }

        DigitalTwinsEndpointResourceProperties IPersistableModel<DigitalTwinsEndpointResourceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsEndpointResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDigitalTwinsEndpointResourceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DigitalTwinsEndpointResourceProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DigitalTwinsEndpointResourceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
