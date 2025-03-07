// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class AgentConfiguration : IUtf8JsonSerializable, IJsonModel<AgentConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AgentConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AgentConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgentConfiguration)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ProxyUri))
            {
                writer.WritePropertyName("proxyUrl"u8);
                writer.WriteStringValue(ProxyUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(IncomingConnectionsPorts))
            {
                writer.WritePropertyName("incomingConnectionsPorts"u8);
                writer.WriteStartArray();
                foreach (var item in IncomingConnectionsPorts)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ExtensionsAllowList))
            {
                writer.WritePropertyName("extensionsAllowList"u8);
                writer.WriteStartArray();
                foreach (var item in ExtensionsAllowList)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ExtensionsBlockList))
            {
                writer.WritePropertyName("extensionsBlockList"u8);
                writer.WriteStartArray();
                foreach (var item in ExtensionsBlockList)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ProxyBypass))
            {
                writer.WritePropertyName("proxyBypass"u8);
                writer.WriteStartArray();
                foreach (var item in ProxyBypass)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ExtensionsEnabled))
            {
                writer.WritePropertyName("extensionsEnabled"u8);
                writer.WriteStringValue(ExtensionsEnabled);
            }
            if (options.Format != "W" && Optional.IsDefined(GuestConfigurationEnabled))
            {
                writer.WritePropertyName("guestConfigurationEnabled"u8);
                writer.WriteStringValue(GuestConfigurationEnabled);
            }
            if (options.Format != "W" && Optional.IsDefined(ConfigMode))
            {
                writer.WritePropertyName("configMode"u8);
                writer.WriteStringValue(ConfigMode.Value.ToString());
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

        AgentConfiguration IJsonModel<AgentConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgentConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAgentConfiguration(document.RootElement, options);
        }

        internal static AgentConfiguration DeserializeAgentConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri proxyUrl = default;
            IReadOnlyList<string> incomingConnectionsPorts = default;
            IReadOnlyList<HybridComputeConfigurationExtension> extensionsAllowList = default;
            IReadOnlyList<HybridComputeConfigurationExtension> extensionsBlockList = default;
            IReadOnlyList<string> proxyBypass = default;
            string extensionsEnabled = default;
            string guestConfigurationEnabled = default;
            AgentConfigurationMode? configMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("proxyUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    proxyUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("incomingConnectionsPorts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    incomingConnectionsPorts = array;
                    continue;
                }
                if (property.NameEquals("extensionsAllowList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HybridComputeConfigurationExtension> array = new List<HybridComputeConfigurationExtension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HybridComputeConfigurationExtension.DeserializeHybridComputeConfigurationExtension(item, options));
                    }
                    extensionsAllowList = array;
                    continue;
                }
                if (property.NameEquals("extensionsBlockList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HybridComputeConfigurationExtension> array = new List<HybridComputeConfigurationExtension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HybridComputeConfigurationExtension.DeserializeHybridComputeConfigurationExtension(item, options));
                    }
                    extensionsBlockList = array;
                    continue;
                }
                if (property.NameEquals("proxyBypass"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    proxyBypass = array;
                    continue;
                }
                if (property.NameEquals("extensionsEnabled"u8))
                {
                    extensionsEnabled = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("guestConfigurationEnabled"u8))
                {
                    guestConfigurationEnabled = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configMode = new AgentConfigurationMode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AgentConfiguration(
                proxyUrl,
                incomingConnectionsPorts ?? new ChangeTrackingList<string>(),
                extensionsAllowList ?? new ChangeTrackingList<HybridComputeConfigurationExtension>(),
                extensionsBlockList ?? new ChangeTrackingList<HybridComputeConfigurationExtension>(),
                proxyBypass ?? new ChangeTrackingList<string>(),
                extensionsEnabled,
                guestConfigurationEnabled,
                configMode,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProxyUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  proxyUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProxyUri))
                {
                    builder.Append("  proxyUrl: ");
                    builder.AppendLine($"'{ProxyUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IncomingConnectionsPorts), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  incomingConnectionsPorts: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(IncomingConnectionsPorts))
                {
                    if (IncomingConnectionsPorts.Any())
                    {
                        builder.Append("  incomingConnectionsPorts: ");
                        builder.AppendLine("[");
                        foreach (var item in IncomingConnectionsPorts)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExtensionsAllowList), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  extensionsAllowList: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ExtensionsAllowList))
                {
                    if (ExtensionsAllowList.Any())
                    {
                        builder.Append("  extensionsAllowList: ");
                        builder.AppendLine("[");
                        foreach (var item in ExtensionsAllowList)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  extensionsAllowList: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExtensionsBlockList), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  extensionsBlockList: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ExtensionsBlockList))
                {
                    if (ExtensionsBlockList.Any())
                    {
                        builder.Append("  extensionsBlockList: ");
                        builder.AppendLine("[");
                        foreach (var item in ExtensionsBlockList)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  extensionsBlockList: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProxyBypass), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  proxyBypass: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ProxyBypass))
                {
                    if (ProxyBypass.Any())
                    {
                        builder.Append("  proxyBypass: ");
                        builder.AppendLine("[");
                        foreach (var item in ProxyBypass)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExtensionsEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  extensionsEnabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ExtensionsEnabled))
                {
                    builder.Append("  extensionsEnabled: ");
                    if (ExtensionsEnabled.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ExtensionsEnabled}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ExtensionsEnabled}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GuestConfigurationEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  guestConfigurationEnabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(GuestConfigurationEnabled))
                {
                    builder.Append("  guestConfigurationEnabled: ");
                    if (GuestConfigurationEnabled.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{GuestConfigurationEnabled}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{GuestConfigurationEnabled}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConfigMode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  configMode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConfigMode))
                {
                    builder.Append("  configMode: ");
                    builder.AppendLine($"'{ConfigMode.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AgentConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AgentConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        AgentConfiguration IPersistableModel<AgentConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAgentConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AgentConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AgentConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
