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
    public partial class IntegrationServiceEnvironmentSkuDefinition : IUtf8JsonSerializable, IJsonModel<IntegrationServiceEnvironmentSkuDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationServiceEnvironmentSkuDefinition>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IntegrationServiceEnvironmentSkuDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationServiceEnvironmentSkuDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentSkuDefinition)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
            }
            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteObjectValue(Capacity, options);
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

        IntegrationServiceEnvironmentSkuDefinition IJsonModel<IntegrationServiceEnvironmentSkuDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationServiceEnvironmentSkuDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentSkuDefinition)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationServiceEnvironmentSkuDefinition(document.RootElement, options);
        }

        internal static IntegrationServiceEnvironmentSkuDefinition DeserializeIntegrationServiceEnvironmentSkuDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceType? resourceType = default;
            IntegrationServiceEnvironmentSkuDefinitionSku sku = default;
            IntegrationServiceEnvironmentSkuCapacity capacity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceType = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = IntegrationServiceEnvironmentSkuDefinitionSku.DeserializeIntegrationServiceEnvironmentSkuDefinitionSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = IntegrationServiceEnvironmentSkuCapacity.DeserializeIntegrationServiceEnvironmentSkuCapacity(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IntegrationServiceEnvironmentSkuDefinition(resourceType, sku, capacity, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IntegrationServiceEnvironmentSkuDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationServiceEnvironmentSkuDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentSkuDefinition)} does not support writing '{options.Format}' format.");
            }
        }

        IntegrationServiceEnvironmentSkuDefinition IPersistableModel<IntegrationServiceEnvironmentSkuDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationServiceEnvironmentSkuDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeIntegrationServiceEnvironmentSkuDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentSkuDefinition)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IntegrationServiceEnvironmentSkuDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
