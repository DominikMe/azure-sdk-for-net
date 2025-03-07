// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [PersistableModelProxy(typeof(UnknownAddDisksProviderSpecificContent))]
    public partial class SiteRecoveryAddDisksProviderSpecificContent : IUtf8JsonSerializable, IJsonModel<SiteRecoveryAddDisksProviderSpecificContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryAddDisksProviderSpecificContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SiteRecoveryAddDisksProviderSpecificContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryAddDisksProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryAddDisksProviderSpecificContent)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        SiteRecoveryAddDisksProviderSpecificContent IJsonModel<SiteRecoveryAddDisksProviderSpecificContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryAddDisksProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryAddDisksProviderSpecificContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryAddDisksProviderSpecificContent(document.RootElement, options);
        }

        internal static SiteRecoveryAddDisksProviderSpecificContent DeserializeSiteRecoveryAddDisksProviderSpecificContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "A2A": return A2AAddDisksContent.DeserializeA2AAddDisksContent(element, options);
                }
            }
            return UnknownAddDisksProviderSpecificContent.DeserializeUnknownAddDisksProviderSpecificContent(element, options);
        }

        BinaryData IPersistableModel<SiteRecoveryAddDisksProviderSpecificContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryAddDisksProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryAddDisksProviderSpecificContent)} does not support writing '{options.Format}' format.");
            }
        }

        SiteRecoveryAddDisksProviderSpecificContent IPersistableModel<SiteRecoveryAddDisksProviderSpecificContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryAddDisksProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSiteRecoveryAddDisksProviderSpecificContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryAddDisksProviderSpecificContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryAddDisksProviderSpecificContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
