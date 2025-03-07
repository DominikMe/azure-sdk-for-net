// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class HealthcareDicomImageCreatedEventData : IUtf8JsonSerializable, IJsonModel<HealthcareDicomImageCreatedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HealthcareDicomImageCreatedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HealthcareDicomImageCreatedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareDicomImageCreatedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthcareDicomImageCreatedEventData)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("partitionName"u8);
            writer.WriteStringValue(PartitionName);
            writer.WritePropertyName("imageStudyInstanceUid"u8);
            writer.WriteStringValue(ImageStudyInstanceUid);
            writer.WritePropertyName("imageSeriesInstanceUid"u8);
            writer.WriteStringValue(ImageSeriesInstanceUid);
            writer.WritePropertyName("imageSopInstanceUid"u8);
            writer.WriteStringValue(ImageSopInstanceUid);
            writer.WritePropertyName("serviceHostName"u8);
            writer.WriteStringValue(ServiceHostName);
            if (Optional.IsDefined(SequenceNumber))
            {
                writer.WritePropertyName("sequenceNumber"u8);
                writer.WriteNumberValue(SequenceNumber.Value);
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

        HealthcareDicomImageCreatedEventData IJsonModel<HealthcareDicomImageCreatedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareDicomImageCreatedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthcareDicomImageCreatedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthcareDicomImageCreatedEventData(document.RootElement, options);
        }

        internal static HealthcareDicomImageCreatedEventData DeserializeHealthcareDicomImageCreatedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string partitionName = default;
            string imageStudyInstanceUid = default;
            string imageSeriesInstanceUid = default;
            string imageSopInstanceUid = default;
            string serviceHostName = default;
            long? sequenceNumber = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionName"u8))
                {
                    partitionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageStudyInstanceUid"u8))
                {
                    imageStudyInstanceUid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageSeriesInstanceUid"u8))
                {
                    imageSeriesInstanceUid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageSopInstanceUid"u8))
                {
                    imageSopInstanceUid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceHostName"u8))
                {
                    serviceHostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sequenceNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sequenceNumber = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HealthcareDicomImageCreatedEventData(
                partitionName,
                imageStudyInstanceUid,
                imageSeriesInstanceUid,
                imageSopInstanceUid,
                serviceHostName,
                sequenceNumber,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HealthcareDicomImageCreatedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareDicomImageCreatedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HealthcareDicomImageCreatedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        HealthcareDicomImageCreatedEventData IPersistableModel<HealthcareDicomImageCreatedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareDicomImageCreatedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHealthcareDicomImageCreatedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HealthcareDicomImageCreatedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HealthcareDicomImageCreatedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static HealthcareDicomImageCreatedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeHealthcareDicomImageCreatedEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
