// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class EdifactValidationOverride : IUtf8JsonSerializable, IJsonModel<EdifactValidationOverride>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdifactValidationOverride>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EdifactValidationOverride>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdifactValidationOverride>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdifactValidationOverride)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("messageId"u8);
            writer.WriteStringValue(MessageId);
            writer.WritePropertyName("enforceCharacterSet"u8);
            writer.WriteBooleanValue(EnforceCharacterSet);
            writer.WritePropertyName("validateEDITypes"u8);
            writer.WriteBooleanValue(ValidateEdiTypes);
            writer.WritePropertyName("validateXSDTypes"u8);
            writer.WriteBooleanValue(ValidateXsdTypes);
            writer.WritePropertyName("allowLeadingAndTrailingSpacesAndZeroes"u8);
            writer.WriteBooleanValue(AllowLeadingAndTrailingSpacesAndZeroes);
            writer.WritePropertyName("trailingSeparatorPolicy"u8);
            writer.WriteStringValue(TrailingSeparatorPolicy.ToString());
            writer.WritePropertyName("trimLeadingAndTrailingSpacesAndZeroes"u8);
            writer.WriteBooleanValue(TrimLeadingAndTrailingSpacesAndZeroes);
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

        EdifactValidationOverride IJsonModel<EdifactValidationOverride>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdifactValidationOverride>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdifactValidationOverride)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdifactValidationOverride(document.RootElement, options);
        }

        internal static EdifactValidationOverride DeserializeEdifactValidationOverride(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string messageId = default;
            bool enforceCharacterSet = default;
            bool validateEdiTypes = default;
            bool validateXsdTypes = default;
            bool allowLeadingAndTrailingSpacesAndZeroes = default;
            TrailingSeparatorPolicy trailingSeparatorPolicy = default;
            bool trimLeadingAndTrailingSpacesAndZeroes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageId"u8))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enforceCharacterSet"u8))
                {
                    enforceCharacterSet = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("validateEDITypes"u8))
                {
                    validateEdiTypes = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("validateXSDTypes"u8))
                {
                    validateXsdTypes = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowLeadingAndTrailingSpacesAndZeroes"u8))
                {
                    allowLeadingAndTrailingSpacesAndZeroes = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("trailingSeparatorPolicy"u8))
                {
                    trailingSeparatorPolicy = new TrailingSeparatorPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("trimLeadingAndTrailingSpacesAndZeroes"u8))
                {
                    trimLeadingAndTrailingSpacesAndZeroes = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EdifactValidationOverride(
                messageId,
                enforceCharacterSet,
                validateEdiTypes,
                validateXsdTypes,
                allowLeadingAndTrailingSpacesAndZeroes,
                trailingSeparatorPolicy,
                trimLeadingAndTrailingSpacesAndZeroes,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdifactValidationOverride>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdifactValidationOverride>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EdifactValidationOverride)} does not support writing '{options.Format}' format.");
            }
        }

        EdifactValidationOverride IPersistableModel<EdifactValidationOverride>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdifactValidationOverride>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEdifactValidationOverride(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdifactValidationOverride)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdifactValidationOverride>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
