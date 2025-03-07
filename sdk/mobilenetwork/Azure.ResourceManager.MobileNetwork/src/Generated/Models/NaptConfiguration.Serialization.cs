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

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class NaptConfiguration : IUtf8JsonSerializable, IJsonModel<NaptConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NaptConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NaptConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NaptConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NaptConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteStringValue(Enabled.Value.ToString());
            }
            if (Optional.IsDefined(PortRange))
            {
                writer.WritePropertyName("portRange"u8);
                writer.WriteObjectValue(PortRange, options);
            }
            if (Optional.IsDefined(PortReuseHoldTime))
            {
                writer.WritePropertyName("portReuseHoldTime"u8);
                writer.WriteObjectValue(PortReuseHoldTime, options);
            }
            if (Optional.IsDefined(PinholeLimits))
            {
                writer.WritePropertyName("pinholeLimits"u8);
                writer.WriteNumberValue(PinholeLimits.Value);
            }
            if (Optional.IsDefined(PinholeTimeouts))
            {
                writer.WritePropertyName("pinholeTimeouts"u8);
                writer.WriteObjectValue(PinholeTimeouts, options);
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

        NaptConfiguration IJsonModel<NaptConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NaptConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NaptConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNaptConfiguration(document.RootElement, options);
        }

        internal static NaptConfiguration DeserializeNaptConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NaptState? enabled = default;
            MobileNetworkPortRange portRange = default;
            MobileNetworkPortReuseHoldTimes portReuseHoldTime = default;
            int? pinholeLimits = default;
            PinholeTimeouts pinholeTimeouts = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = new NaptState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("portRange"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    portRange = MobileNetworkPortRange.DeserializeMobileNetworkPortRange(property.Value, options);
                    continue;
                }
                if (property.NameEquals("portReuseHoldTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    portReuseHoldTime = MobileNetworkPortReuseHoldTimes.DeserializeMobileNetworkPortReuseHoldTimes(property.Value, options);
                    continue;
                }
                if (property.NameEquals("pinholeLimits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pinholeLimits = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pinholeTimeouts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pinholeTimeouts = PinholeTimeouts.DeserializePinholeTimeouts(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NaptConfiguration(
                enabled,
                portRange,
                portReuseHoldTime,
                pinholeLimits,
                pinholeTimeouts,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Enabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Enabled))
                {
                    builder.Append("  enabled: ");
                    builder.AppendLine($"'{Enabled.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PortRange), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  portRange: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PortRange))
                {
                    builder.Append("  portRange: ");
                    BicepSerializationHelpers.AppendChildObject(builder, PortRange, options, 2, false, "  portRange: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PortReuseHoldTime), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  portReuseHoldTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PortReuseHoldTime))
                {
                    builder.Append("  portReuseHoldTime: ");
                    BicepSerializationHelpers.AppendChildObject(builder, PortReuseHoldTime, options, 2, false, "  portReuseHoldTime: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PinholeLimits), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  pinholeLimits: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PinholeLimits))
                {
                    builder.Append("  pinholeLimits: ");
                    builder.AppendLine($"{PinholeLimits.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PinholeTimeouts), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  pinholeTimeouts: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PinholeTimeouts))
                {
                    builder.Append("  pinholeTimeouts: ");
                    BicepSerializationHelpers.AppendChildObject(builder, PinholeTimeouts, options, 2, false, "  pinholeTimeouts: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<NaptConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NaptConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(NaptConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        NaptConfiguration IPersistableModel<NaptConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NaptConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNaptConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NaptConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NaptConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
