// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseIntegrationRuntimeConnectionInfo : IUtf8JsonSerializable, IJsonModel<SynapseIntegrationRuntimeConnectionInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseIntegrationRuntimeConnectionInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SynapseIntegrationRuntimeConnectionInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeConnectionInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeConnectionInfo)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ServiceToken))
            {
                writer.WritePropertyName("serviceToken"u8);
                writer.WriteStringValue(ServiceToken);
            }
            if (options.Format != "W" && Optional.IsDefined(IdentityCertThumbprint))
            {
                writer.WritePropertyName("identityCertThumbprint"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(IdentityCertThumbprint);
#else
                using (JsonDocument document = JsonDocument.Parse(IdentityCertThumbprint, ModelSerializationExtensions.JsonDocumentOptions))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && Optional.IsDefined(HostServiceUri))
            {
                writer.WritePropertyName("hostServiceUri"u8);
                writer.WriteStringValue(HostServiceUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (options.Format != "W" && Optional.IsDefined(PublicKey))
            {
                writer.WritePropertyName("publicKey"u8);
                writer.WriteStringValue(PublicKey);
            }
            if (options.Format != "W" && Optional.IsDefined(IsIdentityCertExprired))
            {
                writer.WritePropertyName("isIdentityCertExprired"u8);
                writer.WriteBooleanValue(IsIdentityCertExprired.Value);
            }
            foreach (var item in AdditionalProperties)
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

        SynapseIntegrationRuntimeConnectionInfo IJsonModel<SynapseIntegrationRuntimeConnectionInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeConnectionInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeConnectionInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseIntegrationRuntimeConnectionInfo(document.RootElement, options);
        }

        internal static SynapseIntegrationRuntimeConnectionInfo DeserializeSynapseIntegrationRuntimeConnectionInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string serviceToken = default;
            BinaryData identityCertThumbprint = default;
            Uri hostServiceUri = default;
            string version = default;
            string publicKey = default;
            bool? isIdentityCertExprired = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceToken"u8))
                {
                    serviceToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identityCertThumbprint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityCertThumbprint = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("hostServiceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostServiceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicKey"u8))
                {
                    publicKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isIdentityCertExprired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isIdentityCertExprired = property.Value.GetBoolean();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseIntegrationRuntimeConnectionInfo(
                serviceToken,
                identityCertThumbprint,
                hostServiceUri,
                version,
                publicKey,
                isIdentityCertExprired,
                additionalProperties);
        }

        BinaryData IPersistableModel<SynapseIntegrationRuntimeConnectionInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeConnectionInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeConnectionInfo)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseIntegrationRuntimeConnectionInfo IPersistableModel<SynapseIntegrationRuntimeConnectionInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeConnectionInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSynapseIntegrationRuntimeConnectionInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeConnectionInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseIntegrationRuntimeConnectionInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
