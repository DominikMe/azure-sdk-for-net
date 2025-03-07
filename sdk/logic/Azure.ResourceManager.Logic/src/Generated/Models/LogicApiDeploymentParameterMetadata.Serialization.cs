// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicApiDeploymentParameterMetadata : IUtf8JsonSerializable, IJsonModel<LogicApiDeploymentParameterMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicApiDeploymentParameterMetadata>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LogicApiDeploymentParameterMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiDeploymentParameterMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicApiDeploymentParameterMetadata)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ApiDeploymentParameterMetadataType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ApiDeploymentParameterMetadataType);
            }
            if (Optional.IsDefined(IsRequired))
            {
                writer.WritePropertyName("isRequired"u8);
                writer.WriteBooleanValue(IsRequired.Value);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Visibility))
            {
                writer.WritePropertyName("visibility"u8);
                writer.WriteStringValue(Visibility.Value.ToString());
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

        LogicApiDeploymentParameterMetadata IJsonModel<LogicApiDeploymentParameterMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiDeploymentParameterMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicApiDeploymentParameterMetadata)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicApiDeploymentParameterMetadata(document.RootElement, options);
        }

        internal static LogicApiDeploymentParameterMetadata DeserializeLogicApiDeploymentParameterMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            bool? isRequired = default;
            string displayName = default;
            string description = default;
            LogicApiDeploymentParameterVisibility? visibility = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("visibility"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    visibility = new LogicApiDeploymentParameterVisibility(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LogicApiDeploymentParameterMetadata(
                type,
                isRequired,
                displayName,
                description,
                visibility,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LogicApiDeploymentParameterMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiDeploymentParameterMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogicApiDeploymentParameterMetadata)} does not support writing '{options.Format}' format.");
            }
        }

        LogicApiDeploymentParameterMetadata IPersistableModel<LogicApiDeploymentParameterMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiDeploymentParameterMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeLogicApiDeploymentParameterMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogicApiDeploymentParameterMetadata)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogicApiDeploymentParameterMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
