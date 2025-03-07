// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ApplicationMetricDescription : IUtf8JsonSerializable, IJsonModel<ApplicationMetricDescription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationMetricDescription>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApplicationMetricDescription>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationMetricDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationMetricDescription)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(MaximumCapacity))
            {
                writer.WritePropertyName("maximumCapacity"u8);
                writer.WriteNumberValue(MaximumCapacity.Value);
            }
            if (Optional.IsDefined(ReservationCapacity))
            {
                writer.WritePropertyName("reservationCapacity"u8);
                writer.WriteNumberValue(ReservationCapacity.Value);
            }
            if (Optional.IsDefined(TotalApplicationCapacity))
            {
                writer.WritePropertyName("totalApplicationCapacity"u8);
                writer.WriteNumberValue(TotalApplicationCapacity.Value);
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

        ApplicationMetricDescription IJsonModel<ApplicationMetricDescription>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationMetricDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationMetricDescription)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationMetricDescription(document.RootElement, options);
        }

        internal static ApplicationMetricDescription DeserializeApplicationMetricDescription(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            long? maximumCapacity = default;
            long? reservationCapacity = default;
            long? totalApplicationCapacity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maximumCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximumCapacity = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("reservationCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reservationCapacity = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalApplicationCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalApplicationCapacity = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApplicationMetricDescription(name, maximumCapacity, reservationCapacity, totalApplicationCapacity, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationMetricDescription>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationMetricDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationMetricDescription)} does not support writing '{options.Format}' format.");
            }
        }

        ApplicationMetricDescription IPersistableModel<ApplicationMetricDescription>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationMetricDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApplicationMetricDescription(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationMetricDescription)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationMetricDescription>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
