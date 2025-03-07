// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    public partial class UpdateSystemServicesResponse : IUtf8JsonSerializable, IJsonModel<UpdateSystemServicesResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpdateSystemServicesResponse>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UpdateSystemServicesResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateSystemServicesResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateSystemServicesResponse)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(UpdateStatus))
            {
                writer.WritePropertyName("updateStatus"u8);
                writer.WriteStringValue(UpdateStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(UpdateStartedOn))
            {
                writer.WritePropertyName("updateStartedOn"u8);
                writer.WriteStringValue(UpdateStartedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(UpdateCompletedOn))
            {
                writer.WritePropertyName("updateCompletedOn"u8);
                writer.WriteStringValue(UpdateCompletedOn.Value, "O");
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

        UpdateSystemServicesResponse IJsonModel<UpdateSystemServicesResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateSystemServicesResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateSystemServicesResponse)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateSystemServicesResponse(document.RootElement, options);
        }

        internal static UpdateSystemServicesResponse DeserializeUpdateSystemServicesResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OperationStatus? updateStatus = default;
            DateTimeOffset? updateStartedOn = default;
            DateTimeOffset? updateCompletedOn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("updateStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updateStatus = new OperationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("updateStartedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updateStartedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("updateCompletedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updateCompletedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UpdateSystemServicesResponse(updateStatus, updateStartedOn, updateCompletedOn, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UpdateSystemServicesResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateSystemServicesResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UpdateSystemServicesResponse)} does not support writing '{options.Format}' format.");
            }
        }

        UpdateSystemServicesResponse IPersistableModel<UpdateSystemServicesResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateSystemServicesResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeUpdateSystemServicesResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpdateSystemServicesResponse)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpdateSystemServicesResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
