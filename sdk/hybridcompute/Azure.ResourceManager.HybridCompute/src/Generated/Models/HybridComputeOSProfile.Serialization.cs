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

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class HybridComputeOSProfile : IUtf8JsonSerializable, IJsonModel<HybridComputeOSProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HybridComputeOSProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HybridComputeOSProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeOSProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridComputeOSProfile)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ComputerName))
            {
                writer.WritePropertyName("computerName"u8);
                writer.WriteStringValue(ComputerName);
            }
            if (Optional.IsDefined(WindowsConfiguration))
            {
                writer.WritePropertyName("windowsConfiguration"u8);
                writer.WriteObjectValue(WindowsConfiguration, options);
            }
            if (Optional.IsDefined(LinuxConfiguration))
            {
                writer.WritePropertyName("linuxConfiguration"u8);
                writer.WriteObjectValue(LinuxConfiguration, options);
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

        HybridComputeOSProfile IJsonModel<HybridComputeOSProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeOSProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridComputeOSProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHybridComputeOSProfile(document.RootElement, options);
        }

        internal static HybridComputeOSProfile DeserializeHybridComputeOSProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string computerName = default;
            HybridComputeWindowsConfiguration windowsConfiguration = default;
            HybridComputeLinuxConfiguration linuxConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computerName"u8))
                {
                    computerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("windowsConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windowsConfiguration = HybridComputeWindowsConfiguration.DeserializeHybridComputeWindowsConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("linuxConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linuxConfiguration = HybridComputeLinuxConfiguration.DeserializeHybridComputeLinuxConfiguration(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HybridComputeOSProfile(computerName, windowsConfiguration, linuxConfiguration, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ComputerName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  computerName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ComputerName))
                {
                    builder.Append("  computerName: ");
                    if (ComputerName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ComputerName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ComputerName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WindowsConfiguration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  windowsConfiguration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(WindowsConfiguration))
                {
                    builder.Append("  windowsConfiguration: ");
                    BicepSerializationHelpers.AppendChildObject(builder, WindowsConfiguration, options, 2, false, "  windowsConfiguration: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LinuxConfiguration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  linuxConfiguration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LinuxConfiguration))
                {
                    builder.Append("  linuxConfiguration: ");
                    BicepSerializationHelpers.AppendChildObject(builder, LinuxConfiguration, options, 2, false, "  linuxConfiguration: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<HybridComputeOSProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeOSProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(HybridComputeOSProfile)} does not support writing '{options.Format}' format.");
            }
        }

        HybridComputeOSProfile IPersistableModel<HybridComputeOSProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeOSProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHybridComputeOSProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HybridComputeOSProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HybridComputeOSProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
