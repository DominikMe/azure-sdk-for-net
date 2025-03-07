// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    public partial class RemotePrivateLinkServiceConnectionState : IUtf8JsonSerializable, IJsonModel<RemotePrivateLinkServiceConnectionState>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RemotePrivateLinkServiceConnectionState>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RemotePrivateLinkServiceConnectionState>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemotePrivateLinkServiceConnectionState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RemotePrivateLinkServiceConnectionState)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(ActionsRequired))
            {
                writer.WritePropertyName("actionsRequired"u8);
                writer.WriteStringValue(ActionsRequired);
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

        RemotePrivateLinkServiceConnectionState IJsonModel<RemotePrivateLinkServiceConnectionState>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemotePrivateLinkServiceConnectionState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RemotePrivateLinkServiceConnectionState)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRemotePrivateLinkServiceConnectionState(document.RootElement, options);
        }

        internal static RemotePrivateLinkServiceConnectionState DeserializeRemotePrivateLinkServiceConnectionState(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NotificationHubPrivateLinkConnectionStatus? status = default;
            string description = default;
            string actionsRequired = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new NotificationHubPrivateLinkConnectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionsRequired"u8))
                {
                    actionsRequired = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RemotePrivateLinkServiceConnectionState(status, description, actionsRequired, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RemotePrivateLinkServiceConnectionState>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemotePrivateLinkServiceConnectionState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RemotePrivateLinkServiceConnectionState)} does not support writing '{options.Format}' format.");
            }
        }

        RemotePrivateLinkServiceConnectionState IPersistableModel<RemotePrivateLinkServiceConnectionState>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemotePrivateLinkServiceConnectionState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRemotePrivateLinkServiceConnectionState(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RemotePrivateLinkServiceConnectionState)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RemotePrivateLinkServiceConnectionState>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
