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
    public partial class UpdateApplianceForReplicationProtectedItemContent : IUtf8JsonSerializable, IJsonModel<UpdateApplianceForReplicationProtectedItemContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpdateApplianceForReplicationProtectedItemContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UpdateApplianceForReplicationProtectedItemContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateApplianceForReplicationProtectedItemContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateApplianceForReplicationProtectedItemContent)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("properties"u8);
            writer.WriteObjectValue(Properties, options);
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

        UpdateApplianceForReplicationProtectedItemContent IJsonModel<UpdateApplianceForReplicationProtectedItemContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateApplianceForReplicationProtectedItemContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateApplianceForReplicationProtectedItemContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateApplianceForReplicationProtectedItemContent(document.RootElement, options);
        }

        internal static UpdateApplianceForReplicationProtectedItemContent DeserializeUpdateApplianceForReplicationProtectedItemContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UpdateApplianceForReplicationProtectedItemProperties properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    properties = UpdateApplianceForReplicationProtectedItemProperties.DeserializeUpdateApplianceForReplicationProtectedItemProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UpdateApplianceForReplicationProtectedItemContent(properties, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UpdateApplianceForReplicationProtectedItemContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateApplianceForReplicationProtectedItemContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UpdateApplianceForReplicationProtectedItemContent)} does not support writing '{options.Format}' format.");
            }
        }

        UpdateApplianceForReplicationProtectedItemContent IPersistableModel<UpdateApplianceForReplicationProtectedItemContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateApplianceForReplicationProtectedItemContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeUpdateApplianceForReplicationProtectedItemContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpdateApplianceForReplicationProtectedItemContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpdateApplianceForReplicationProtectedItemContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
