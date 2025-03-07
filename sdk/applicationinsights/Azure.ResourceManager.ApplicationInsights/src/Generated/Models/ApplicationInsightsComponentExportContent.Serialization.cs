// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class ApplicationInsightsComponentExportContent : IUtf8JsonSerializable, IJsonModel<ApplicationInsightsComponentExportContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationInsightsComponentExportContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApplicationInsightsComponentExportContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentExportContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentExportContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(RecordTypes))
            {
                writer.WritePropertyName("RecordTypes"u8);
                writer.WriteStringValue(RecordTypes);
            }
            if (Optional.IsDefined(DestinationType))
            {
                writer.WritePropertyName("DestinationType"u8);
                writer.WriteStringValue(DestinationType);
            }
            if (Optional.IsDefined(DestinationAddress))
            {
                writer.WritePropertyName("DestinationAddress"u8);
                writer.WriteStringValue(DestinationAddress);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("IsEnabled"u8);
                writer.WriteStringValue(IsEnabled);
            }
            if (Optional.IsDefined(IsNotificationQueueEnabled))
            {
                writer.WritePropertyName("NotificationQueueEnabled"u8);
                writer.WriteStringValue(IsNotificationQueueEnabled);
            }
            if (Optional.IsDefined(NotificationQueueUri))
            {
                writer.WritePropertyName("NotificationQueueUri"u8);
                writer.WriteStringValue(NotificationQueueUri.AbsoluteUri);
            }
            if (Optional.IsDefined(DestinationStorageSubscriptionId))
            {
                writer.WritePropertyName("DestinationStorageSubscriptionId"u8);
                writer.WriteStringValue(DestinationStorageSubscriptionId);
            }
            if (Optional.IsDefined(DestinationStorageLocationId))
            {
                writer.WritePropertyName("DestinationStorageLocationId"u8);
                writer.WriteStringValue(DestinationStorageLocationId);
            }
            if (Optional.IsDefined(DestinationAccountId))
            {
                writer.WritePropertyName("DestinationAccountId"u8);
                writer.WriteStringValue(DestinationAccountId);
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

        ApplicationInsightsComponentExportContent IJsonModel<ApplicationInsightsComponentExportContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentExportContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentExportContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationInsightsComponentExportContent(document.RootElement, options);
        }

        internal static ApplicationInsightsComponentExportContent DeserializeApplicationInsightsComponentExportContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string recordTypes = default;
            string destinationType = default;
            string destinationAddress = default;
            string isEnabled = default;
            string notificationQueueEnabled = default;
            Uri notificationQueueUri = default;
            string destinationStorageSubscriptionId = default;
            string destinationStorageLocationId = default;
            ResourceIdentifier destinationAccountId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("RecordTypes"u8))
                {
                    recordTypes = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("DestinationType"u8))
                {
                    destinationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("DestinationAddress"u8))
                {
                    destinationAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("IsEnabled"u8))
                {
                    isEnabled = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("NotificationQueueEnabled"u8))
                {
                    notificationQueueEnabled = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("NotificationQueueUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    notificationQueueUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("DestinationStorageSubscriptionId"u8))
                {
                    destinationStorageSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("DestinationStorageLocationId"u8))
                {
                    destinationStorageLocationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("DestinationAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destinationAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApplicationInsightsComponentExportContent(
                recordTypes,
                destinationType,
                destinationAddress,
                isEnabled,
                notificationQueueEnabled,
                notificationQueueUri,
                destinationStorageSubscriptionId,
                destinationStorageLocationId,
                destinationAccountId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationInsightsComponentExportContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentExportContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationInsightsComponentExportContent)} does not support writing '{options.Format}' format.");
            }
        }

        ApplicationInsightsComponentExportContent IPersistableModel<ApplicationInsightsComponentExportContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentExportContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApplicationInsightsComponentExportContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationInsightsComponentExportContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationInsightsComponentExportContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
