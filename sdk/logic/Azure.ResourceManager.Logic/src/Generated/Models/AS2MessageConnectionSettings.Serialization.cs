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
    public partial class AS2MessageConnectionSettings : IUtf8JsonSerializable, IJsonModel<AS2MessageConnectionSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AS2MessageConnectionSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AS2MessageConnectionSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2MessageConnectionSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AS2MessageConnectionSettings)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("ignoreCertificateNameMismatch"u8);
            writer.WriteBooleanValue(IgnoreCertificateNameMismatch);
            writer.WritePropertyName("supportHttpStatusCodeContinue"u8);
            writer.WriteBooleanValue(SupportHttpStatusCodeContinue);
            writer.WritePropertyName("keepHttpConnectionAlive"u8);
            writer.WriteBooleanValue(KeepHttpConnectionAlive);
            writer.WritePropertyName("unfoldHttpHeaders"u8);
            writer.WriteBooleanValue(UnfoldHttpHeaders);
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

        AS2MessageConnectionSettings IJsonModel<AS2MessageConnectionSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2MessageConnectionSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AS2MessageConnectionSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAS2MessageConnectionSettings(document.RootElement, options);
        }

        internal static AS2MessageConnectionSettings DeserializeAS2MessageConnectionSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool ignoreCertificateNameMismatch = default;
            bool supportHttpStatusCodeContinue = default;
            bool keepHttpConnectionAlive = default;
            bool unfoldHttpHeaders = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ignoreCertificateNameMismatch"u8))
                {
                    ignoreCertificateNameMismatch = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("supportHttpStatusCodeContinue"u8))
                {
                    supportHttpStatusCodeContinue = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("keepHttpConnectionAlive"u8))
                {
                    keepHttpConnectionAlive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("unfoldHttpHeaders"u8))
                {
                    unfoldHttpHeaders = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AS2MessageConnectionSettings(ignoreCertificateNameMismatch, supportHttpStatusCodeContinue, keepHttpConnectionAlive, unfoldHttpHeaders, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AS2MessageConnectionSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2MessageConnectionSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AS2MessageConnectionSettings)} does not support writing '{options.Format}' format.");
            }
        }

        AS2MessageConnectionSettings IPersistableModel<AS2MessageConnectionSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2MessageConnectionSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAS2MessageConnectionSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AS2MessageConnectionSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AS2MessageConnectionSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
