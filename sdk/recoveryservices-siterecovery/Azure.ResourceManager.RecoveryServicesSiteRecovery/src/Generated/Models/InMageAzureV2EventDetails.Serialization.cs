// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageAzureV2EventDetails : IUtf8JsonSerializable, IJsonModel<InMageAzureV2EventDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageAzureV2EventDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InMageAzureV2EventDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageAzureV2EventDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageAzureV2EventDetails)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(EventType))
            {
                writer.WritePropertyName("eventType"u8);
                writer.WriteStringValue(EventType);
            }
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category);
            }
            if (Optional.IsDefined(Component))
            {
                writer.WritePropertyName("component"u8);
                writer.WriteStringValue(Component);
            }
            if (Optional.IsDefined(CorrectiveAction))
            {
                writer.WritePropertyName("correctiveAction"u8);
                writer.WriteStringValue(CorrectiveAction);
            }
            if (Optional.IsDefined(Details))
            {
                writer.WritePropertyName("details"u8);
                writer.WriteStringValue(Details);
            }
            if (Optional.IsDefined(Summary))
            {
                writer.WritePropertyName("summary"u8);
                writer.WriteStringValue(Summary);
            }
            if (Optional.IsDefined(SiteName))
            {
                writer.WritePropertyName("siteName"u8);
                writer.WriteStringValue(SiteName);
            }
        }

        InMageAzureV2EventDetails IJsonModel<InMageAzureV2EventDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageAzureV2EventDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageAzureV2EventDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageAzureV2EventDetails(document.RootElement, options);
        }

        internal static InMageAzureV2EventDetails DeserializeInMageAzureV2EventDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string eventType = default;
            string category = default;
            string component = default;
            string correctiveAction = default;
            string details = default;
            string summary = default;
            string siteName = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventType"u8))
                {
                    eventType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("component"u8))
                {
                    component = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correctiveAction"u8))
                {
                    correctiveAction = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    details = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("summary"u8))
                {
                    summary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("siteName"u8))
                {
                    siteName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InMageAzureV2EventDetails(
                instanceType,
                serializedAdditionalRawData,
                eventType,
                category,
                component,
                correctiveAction,
                details,
                summary,
                siteName);
        }

        BinaryData IPersistableModel<InMageAzureV2EventDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageAzureV2EventDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InMageAzureV2EventDetails)} does not support writing '{options.Format}' format.");
            }
        }

        InMageAzureV2EventDetails IPersistableModel<InMageAzureV2EventDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageAzureV2EventDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeInMageAzureV2EventDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageAzureV2EventDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageAzureV2EventDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
