// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class ContinuationSettingsReference : IUtf8JsonSerializable, IJsonModel<ContinuationSettingsReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContinuationSettingsReference>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContinuationSettingsReference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinuationSettingsReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContinuationSettingsReference)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ContinuationTtlInMinutes))
            {
                writer.WritePropertyName("continuationTtlInMinutes"u8);
                JsonSerializer.Serialize(writer, ContinuationTtlInMinutes);
            }
            if (Optional.IsDefined(IdleCondition))
            {
                writer.WritePropertyName("idleCondition"u8);
                JsonSerializer.Serialize(writer, IdleCondition);
            }
            if (Optional.IsDefined(CustomizedCheckpointKey))
            {
                writer.WritePropertyName("customizedCheckpointKey"u8);
                JsonSerializer.Serialize(writer, CustomizedCheckpointKey);
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

        ContinuationSettingsReference IJsonModel<ContinuationSettingsReference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinuationSettingsReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContinuationSettingsReference)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContinuationSettingsReference(document.RootElement, options);
        }

        internal static ContinuationSettingsReference DeserializeContinuationSettingsReference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<int> continuationTtlInMinutes = default;
            DataFactoryElement<string> idleCondition = default;
            DataFactoryElement<string> customizedCheckpointKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("continuationTtlInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    continuationTtlInMinutes = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("idleCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    idleCondition = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("customizedCheckpointKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customizedCheckpointKey = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContinuationSettingsReference(continuationTtlInMinutes, idleCondition, customizedCheckpointKey, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContinuationSettingsReference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinuationSettingsReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContinuationSettingsReference)} does not support writing '{options.Format}' format.");
            }
        }

        ContinuationSettingsReference IPersistableModel<ContinuationSettingsReference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinuationSettingsReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContinuationSettingsReference(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContinuationSettingsReference)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContinuationSettingsReference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
