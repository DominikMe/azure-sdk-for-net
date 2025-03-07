// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    [PersistableModelProxy(typeof(UnknownLinkedIntegrationRuntimeType))]
    public partial class LinkedIntegrationRuntimeType : IUtf8JsonSerializable, IJsonModel<LinkedIntegrationRuntimeType>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LinkedIntegrationRuntimeType>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LinkedIntegrationRuntimeType>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkedIntegrationRuntimeType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinkedIntegrationRuntimeType)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("authorizationType"u8);
            writer.WriteStringValue(AuthorizationType);
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

        LinkedIntegrationRuntimeType IJsonModel<LinkedIntegrationRuntimeType>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkedIntegrationRuntimeType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinkedIntegrationRuntimeType)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkedIntegrationRuntimeType(document.RootElement, options);
        }

        internal static LinkedIntegrationRuntimeType DeserializeLinkedIntegrationRuntimeType(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("authorizationType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Key": return LinkedIntegrationRuntimeKeyAuthorization.DeserializeLinkedIntegrationRuntimeKeyAuthorization(element, options);
                    case "RBAC": return LinkedIntegrationRuntimeRbacAuthorization.DeserializeLinkedIntegrationRuntimeRbacAuthorization(element, options);
                }
            }
            return UnknownLinkedIntegrationRuntimeType.DeserializeUnknownLinkedIntegrationRuntimeType(element, options);
        }

        BinaryData IPersistableModel<LinkedIntegrationRuntimeType>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkedIntegrationRuntimeType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LinkedIntegrationRuntimeType)} does not support writing '{options.Format}' format.");
            }
        }

        LinkedIntegrationRuntimeType IPersistableModel<LinkedIntegrationRuntimeType>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkedIntegrationRuntimeType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeLinkedIntegrationRuntimeType(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LinkedIntegrationRuntimeType)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LinkedIntegrationRuntimeType>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
