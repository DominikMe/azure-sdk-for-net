// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorWebhookReceiver : IUtf8JsonSerializable, IJsonModel<MonitorWebhookReceiver>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorWebhookReceiver>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MonitorWebhookReceiver>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWebhookReceiver>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorWebhookReceiver)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("serviceUri"u8);
            writer.WriteStringValue(ServiceUri.AbsoluteUri);
            if (Optional.IsDefined(UseCommonAlertSchema))
            {
                writer.WritePropertyName("useCommonAlertSchema"u8);
                writer.WriteBooleanValue(UseCommonAlertSchema.Value);
            }
            if (Optional.IsDefined(UseAadAuth))
            {
                writer.WritePropertyName("useAadAuth"u8);
                writer.WriteBooleanValue(UseAadAuth.Value);
            }
            if (Optional.IsDefined(ObjectId))
            {
                writer.WritePropertyName("objectId"u8);
                writer.WriteStringValue(ObjectId);
            }
            if (Optional.IsDefined(IdentifierUri))
            {
                writer.WritePropertyName("identifierUri"u8);
                writer.WriteStringValue(IdentifierUri.AbsoluteUri);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(ManagedIdentity))
            {
                writer.WritePropertyName("managedIdentity"u8);
                writer.WriteStringValue(ManagedIdentity);
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

        MonitorWebhookReceiver IJsonModel<MonitorWebhookReceiver>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWebhookReceiver>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorWebhookReceiver)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorWebhookReceiver(document.RootElement, options);
        }

        internal static MonitorWebhookReceiver DeserializeMonitorWebhookReceiver(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Uri serviceUri = default;
            bool? useCommonAlertSchema = default;
            bool? useAadAuth = default;
            string objectId = default;
            Uri identifierUri = default;
            Guid? tenantId = default;
            string managedIdentity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceUri"u8))
                {
                    serviceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useCommonAlertSchema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useCommonAlertSchema = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("useAadAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useAadAuth = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("objectId"u8))
                {
                    objectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identifierUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identifierUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("managedIdentity"u8))
                {
                    managedIdentity = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MonitorWebhookReceiver(
                name,
                serviceUri,
                useCommonAlertSchema,
                useAadAuth,
                objectId,
                identifierUri,
                tenantId,
                managedIdentity,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitorWebhookReceiver>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWebhookReceiver>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitorWebhookReceiver)} does not support writing '{options.Format}' format.");
            }
        }

        MonitorWebhookReceiver IPersistableModel<MonitorWebhookReceiver>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorWebhookReceiver>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMonitorWebhookReceiver(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitorWebhookReceiver)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorWebhookReceiver>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
