// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    [PersistableModelProxy(typeof(UnknownContentKeyPolicyRestrictionTokenKey))]
    public partial class ContentKeyPolicyRestrictionTokenKey : IUtf8JsonSerializable, IJsonModel<ContentKeyPolicyRestrictionTokenKey>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContentKeyPolicyRestrictionTokenKey>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContentKeyPolicyRestrictionTokenKey>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyRestrictionTokenKey>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyRestrictionTokenKey)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        ContentKeyPolicyRestrictionTokenKey IJsonModel<ContentKeyPolicyRestrictionTokenKey>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyRestrictionTokenKey>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyRestrictionTokenKey)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyRestrictionTokenKey(document.RootElement, options);
        }

        internal static ContentKeyPolicyRestrictionTokenKey DeserializeContentKeyPolicyRestrictionTokenKey(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.ContentKeyPolicyRsaTokenKey": return ContentKeyPolicyRsaTokenKey.DeserializeContentKeyPolicyRsaTokenKey(element, options);
                    case "#Microsoft.Media.ContentKeyPolicySymmetricTokenKey": return ContentKeyPolicySymmetricTokenKey.DeserializeContentKeyPolicySymmetricTokenKey(element, options);
                    case "#Microsoft.Media.ContentKeyPolicyX509CertificateTokenKey": return ContentKeyPolicyX509CertificateTokenKey.DeserializeContentKeyPolicyX509CertificateTokenKey(element, options);
                }
            }
            return UnknownContentKeyPolicyRestrictionTokenKey.DeserializeUnknownContentKeyPolicyRestrictionTokenKey(element, options);
        }

        BinaryData IPersistableModel<ContentKeyPolicyRestrictionTokenKey>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyRestrictionTokenKey>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyRestrictionTokenKey)} does not support writing '{options.Format}' format.");
            }
        }

        ContentKeyPolicyRestrictionTokenKey IPersistableModel<ContentKeyPolicyRestrictionTokenKey>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyRestrictionTokenKey>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContentKeyPolicyRestrictionTokenKey(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyRestrictionTokenKey)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContentKeyPolicyRestrictionTokenKey>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
