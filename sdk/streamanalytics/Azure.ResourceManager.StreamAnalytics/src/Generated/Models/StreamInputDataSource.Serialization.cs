// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    [PersistableModelProxy(typeof(UnknownStreamInputDataSource))]
    public partial class StreamInputDataSource : IUtf8JsonSerializable, IJsonModel<StreamInputDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamInputDataSource>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StreamInputDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamInputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamInputDataSource)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(StreamInputDataSourceType);
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

        StreamInputDataSource IJsonModel<StreamInputDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamInputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamInputDataSource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamInputDataSource(document.RootElement, options);
        }

        internal static StreamInputDataSource DeserializeStreamInputDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "GatewayMessageBus": return GatewayMessageBusStreamInputDataSource.DeserializeGatewayMessageBusStreamInputDataSource(element, options);
                    case "Microsoft.Devices/IotHubs": return IoTHubStreamInputDataSource.DeserializeIoTHubStreamInputDataSource(element, options);
                    case "Microsoft.EventGrid/EventSubscriptions": return EventGridStreamInputDataSource.DeserializeEventGridStreamInputDataSource(element, options);
                    case "Microsoft.EventHub/EventHub": return EventHubV2StreamInputDataSource.DeserializeEventHubV2StreamInputDataSource(element, options);
                    case "Microsoft.ServiceBus/EventHub": return EventHubStreamInputDataSource.DeserializeEventHubStreamInputDataSource(element, options);
                    case "Microsoft.Storage/Blob": return BlobStreamInputDataSource.DeserializeBlobStreamInputDataSource(element, options);
                    case "Raw": return RawStreamInputDataSource.DeserializeRawStreamInputDataSource(element, options);
                }
            }
            return UnknownStreamInputDataSource.DeserializeUnknownStreamInputDataSource(element, options);
        }

        BinaryData IPersistableModel<StreamInputDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamInputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamInputDataSource)} does not support writing '{options.Format}' format.");
            }
        }

        StreamInputDataSource IPersistableModel<StreamInputDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamInputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStreamInputDataSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamInputDataSource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamInputDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
