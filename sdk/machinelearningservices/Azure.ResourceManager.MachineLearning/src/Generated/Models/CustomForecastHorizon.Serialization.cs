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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class CustomForecastHorizon : IUtf8JsonSerializable, IJsonModel<CustomForecastHorizon>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomForecastHorizon>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CustomForecastHorizon>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomForecastHorizon>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomForecastHorizon)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("value"u8);
            writer.WriteNumberValue(Value);
        }

        CustomForecastHorizon IJsonModel<CustomForecastHorizon>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomForecastHorizon>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomForecastHorizon)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomForecastHorizon(document.RootElement, options);
        }

        internal static CustomForecastHorizon DeserializeCustomForecastHorizon(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int value = default;
            ForecastHorizonMode mode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    mode = new ForecastHorizonMode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CustomForecastHorizon(mode, serializedAdditionalRawData, value);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Value), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  value: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  value: ");
                builder.AppendLine($"{Value}");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Mode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  mode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  mode: ");
                builder.AppendLine($"'{Mode.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CustomForecastHorizon>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomForecastHorizon>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CustomForecastHorizon)} does not support writing '{options.Format}' format.");
            }
        }

        CustomForecastHorizon IPersistableModel<CustomForecastHorizon>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomForecastHorizon>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCustomForecastHorizon(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomForecastHorizon)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomForecastHorizon>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
