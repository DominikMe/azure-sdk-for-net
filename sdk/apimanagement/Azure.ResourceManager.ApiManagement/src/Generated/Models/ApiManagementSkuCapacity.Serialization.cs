// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiManagementSkuCapacity : IUtf8JsonSerializable, IJsonModel<ApiManagementSkuCapacity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiManagementSkuCapacity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApiManagementSkuCapacity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementSkuCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementSkuCapacity)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Minimum))
            {
                writer.WritePropertyName("minimum"u8);
                writer.WriteNumberValue(Minimum.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Maximum))
            {
                writer.WritePropertyName("maximum"u8);
                writer.WriteNumberValue(Maximum.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Default))
            {
                writer.WritePropertyName("default"u8);
                writer.WriteNumberValue(Default.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ScaleType))
            {
                writer.WritePropertyName("scaleType"u8);
                writer.WriteStringValue(ScaleType.Value.ToSerialString());
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

        ApiManagementSkuCapacity IJsonModel<ApiManagementSkuCapacity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementSkuCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementSkuCapacity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiManagementSkuCapacity(document.RootElement, options);
        }

        internal static ApiManagementSkuCapacity DeserializeApiManagementSkuCapacity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? minimum = default;
            int? maximum = default;
            int? @default = default;
            ApiManagementSkuCapacityScaleType? scaleType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minimum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimum = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maximum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximum = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("default"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @default = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scaleType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scaleType = property.Value.GetString().ToApiManagementSkuCapacityScaleType();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApiManagementSkuCapacity(minimum, maximum, @default, scaleType, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Minimum), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  minimum: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Minimum))
                {
                    builder.Append("  minimum: ");
                    builder.AppendLine($"{Minimum.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Maximum), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  maximum: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Maximum))
                {
                    builder.Append("  maximum: ");
                    builder.AppendLine($"{Maximum.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Default), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  default: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Default))
                {
                    builder.Append("  default: ");
                    builder.AppendLine($"{Default.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ScaleType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  scaleType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ScaleType))
                {
                    builder.Append("  scaleType: ");
                    builder.AppendLine($"'{ScaleType.Value.ToSerialString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ApiManagementSkuCapacity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementSkuCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ApiManagementSkuCapacity)} does not support writing '{options.Format}' format.");
            }
        }

        ApiManagementSkuCapacity IPersistableModel<ApiManagementSkuCapacity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementSkuCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApiManagementSkuCapacity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiManagementSkuCapacity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiManagementSkuCapacity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
