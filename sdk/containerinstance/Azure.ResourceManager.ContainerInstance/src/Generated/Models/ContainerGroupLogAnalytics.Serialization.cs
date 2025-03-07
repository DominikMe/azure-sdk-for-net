// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerGroupLogAnalytics : IUtf8JsonSerializable, IJsonModel<ContainerGroupLogAnalytics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerGroupLogAnalytics>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerGroupLogAnalytics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupLogAnalytics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerGroupLogAnalytics)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("workspaceId"u8);
            writer.WriteStringValue(WorkspaceId);
            writer.WritePropertyName("workspaceKey"u8);
            writer.WriteStringValue(WorkspaceKey);
            if (Optional.IsDefined(LogType))
            {
                writer.WritePropertyName("logType"u8);
                writer.WriteStringValue(LogType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(WorkspaceResourceId))
            {
                writer.WritePropertyName("workspaceResourceId"u8);
                writer.WriteStringValue(WorkspaceResourceId);
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

        ContainerGroupLogAnalytics IJsonModel<ContainerGroupLogAnalytics>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupLogAnalytics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerGroupLogAnalytics)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerGroupLogAnalytics(document.RootElement, options);
        }

        internal static ContainerGroupLogAnalytics DeserializeContainerGroupLogAnalytics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string workspaceId = default;
            string workspaceKey = default;
            ContainerGroupLogAnalyticsLogType? logType = default;
            IDictionary<string, string> metadata = default;
            ResourceIdentifier workspaceResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workspaceId"u8))
                {
                    workspaceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceKey"u8))
                {
                    workspaceKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logType = new ContainerGroupLogAnalyticsLogType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    metadata = dictionary;
                    continue;
                }
                if (property.NameEquals("workspaceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspaceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerGroupLogAnalytics(
                workspaceId,
                workspaceKey,
                logType,
                metadata ?? new ChangeTrackingDictionary<string, string>(),
                workspaceResourceId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerGroupLogAnalytics>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupLogAnalytics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerGroupLogAnalytics)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerGroupLogAnalytics IPersistableModel<ContainerGroupLogAnalytics>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupLogAnalytics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerGroupLogAnalytics(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerGroupLogAnalytics)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerGroupLogAnalytics>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
