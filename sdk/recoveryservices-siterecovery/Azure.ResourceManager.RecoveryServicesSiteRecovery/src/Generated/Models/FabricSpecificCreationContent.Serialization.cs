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
    [PersistableModelProxy(typeof(UnknownFabricSpecificCreationContent))]
    public partial class FabricSpecificCreationContent : IUtf8JsonSerializable, IJsonModel<FabricSpecificCreationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FabricSpecificCreationContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FabricSpecificCreationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FabricSpecificCreationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FabricSpecificCreationContent)} does not support writing '{format}' format.");
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

        FabricSpecificCreationContent IJsonModel<FabricSpecificCreationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FabricSpecificCreationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FabricSpecificCreationContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFabricSpecificCreationContent(document.RootElement, options);
        }

        internal static FabricSpecificCreationContent DeserializeFabricSpecificCreationContent(JsonElement element, ModelReaderWriterOptions options = null)
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
                    case "Azure": return SiteRecoveryFabricProviderCreationContent.DeserializeSiteRecoveryFabricProviderCreationContent(element, options);
                    case "InMageRcm": return InMageRcmFabricCreationContent.DeserializeInMageRcmFabricCreationContent(element, options);
                    case "VMwareV2": return VMwareV2FabricCreationContent.DeserializeVMwareV2FabricCreationContent(element, options);
                }
            }
            return UnknownFabricSpecificCreationContent.DeserializeUnknownFabricSpecificCreationContent(element, options);
        }

        BinaryData IPersistableModel<FabricSpecificCreationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FabricSpecificCreationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FabricSpecificCreationContent)} does not support writing '{options.Format}' format.");
            }
        }

        FabricSpecificCreationContent IPersistableModel<FabricSpecificCreationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FabricSpecificCreationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFabricSpecificCreationContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FabricSpecificCreationContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FabricSpecificCreationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
