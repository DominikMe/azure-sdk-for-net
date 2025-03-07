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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class PropertyArrayConditionProperties : IUtf8JsonSerializable, IJsonModel<PropertyArrayConditionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PropertyArrayConditionProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PropertyArrayConditionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PropertyArrayConditionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PropertyArrayConditionProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ConditionProperties))
            {
                writer.WritePropertyName("conditionProperties"u8);
                writer.WriteObjectValue(ConditionProperties, options);
            }
        }

        PropertyArrayConditionProperties IJsonModel<PropertyArrayConditionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PropertyArrayConditionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PropertyArrayConditionProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePropertyArrayConditionProperties(document.RootElement, options);
        }

        internal static PropertyArrayConditionProperties DeserializePropertyArrayConditionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AutomationRulePropertyArrayValuesCondition conditionProperties = default;
            ConditionType conditionType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("conditionProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    conditionProperties = AutomationRulePropertyArrayValuesCondition.DeserializeAutomationRulePropertyArrayValuesCondition(property.Value, options);
                    continue;
                }
                if (property.NameEquals("conditionType"u8))
                {
                    conditionType = new ConditionType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PropertyArrayConditionProperties(conditionType, serializedAdditionalRawData, conditionProperties);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConditionProperties), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  conditionProperties: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConditionProperties))
                {
                    builder.Append("  conditionProperties: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ConditionProperties, options, 2, false, "  conditionProperties: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConditionType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  conditionType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  conditionType: ");
                builder.AppendLine($"'{ConditionType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<PropertyArrayConditionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PropertyArrayConditionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PropertyArrayConditionProperties)} does not support writing '{options.Format}' format.");
            }
        }

        PropertyArrayConditionProperties IPersistableModel<PropertyArrayConditionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PropertyArrayConditionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePropertyArrayConditionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PropertyArrayConditionProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PropertyArrayConditionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
