// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class ConfigServerSettingsValidateResult : IUtf8JsonSerializable, IJsonModel<ConfigServerSettingsValidateResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfigServerSettingsValidateResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConfigServerSettingsValidateResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigServerSettingsValidateResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigServerSettingsValidateResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsValid))
            {
                writer.WritePropertyName("isValid"u8);
                writer.WriteBooleanValue(IsValid.Value);
            }
            if (Optional.IsCollectionDefined(Details))
            {
                writer.WritePropertyName("details"u8);
                writer.WriteStartArray();
                foreach (var item in Details)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        ConfigServerSettingsValidateResult IJsonModel<ConfigServerSettingsValidateResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigServerSettingsValidateResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigServerSettingsValidateResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfigServerSettingsValidateResult(document.RootElement, options);
        }

        internal static ConfigServerSettingsValidateResult DeserializeConfigServerSettingsValidateResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? isValid = default;
            IReadOnlyList<ConfigServerSettingsErrorRecord> details = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isValid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isValid = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConfigServerSettingsErrorRecord> array = new List<ConfigServerSettingsErrorRecord>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConfigServerSettingsErrorRecord.DeserializeConfigServerSettingsErrorRecord(item, options));
                    }
                    details = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConfigServerSettingsValidateResult(isValid, details ?? new ChangeTrackingList<ConfigServerSettingsErrorRecord>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConfigServerSettingsValidateResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigServerSettingsValidateResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConfigServerSettingsValidateResult)} does not support writing '{options.Format}' format.");
            }
        }

        ConfigServerSettingsValidateResult IPersistableModel<ConfigServerSettingsValidateResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigServerSettingsValidateResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConfigServerSettingsValidateResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConfigServerSettingsValidateResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfigServerSettingsValidateResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
