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

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterLogAnalyticsApplicationLogs : IUtf8JsonSerializable, IJsonModel<ClusterLogAnalyticsApplicationLogs>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterLogAnalyticsApplicationLogs>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClusterLogAnalyticsApplicationLogs>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterLogAnalyticsApplicationLogs>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterLogAnalyticsApplicationLogs)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsStdOutEnabled))
            {
                writer.WritePropertyName("stdOutEnabled"u8);
                writer.WriteBooleanValue(IsStdOutEnabled.Value);
            }
            if (Optional.IsDefined(IsStdErrorEnabled))
            {
                writer.WritePropertyName("stdErrorEnabled"u8);
                writer.WriteBooleanValue(IsStdErrorEnabled.Value);
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

        ClusterLogAnalyticsApplicationLogs IJsonModel<ClusterLogAnalyticsApplicationLogs>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterLogAnalyticsApplicationLogs>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterLogAnalyticsApplicationLogs)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterLogAnalyticsApplicationLogs(document.RootElement, options);
        }

        internal static ClusterLogAnalyticsApplicationLogs DeserializeClusterLogAnalyticsApplicationLogs(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? stdOutEnabled = default;
            bool? stdErrorEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stdOutEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stdOutEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("stdErrorEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stdErrorEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ClusterLogAnalyticsApplicationLogs(stdOutEnabled, stdErrorEnabled, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsStdOutEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  stdOutEnabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsStdOutEnabled))
                {
                    builder.Append("  stdOutEnabled: ");
                    var boolValue = IsStdOutEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsStdErrorEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  stdErrorEnabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsStdErrorEnabled))
                {
                    builder.Append("  stdErrorEnabled: ");
                    var boolValue = IsStdErrorEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ClusterLogAnalyticsApplicationLogs>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterLogAnalyticsApplicationLogs>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ClusterLogAnalyticsApplicationLogs)} does not support writing '{options.Format}' format.");
            }
        }

        ClusterLogAnalyticsApplicationLogs IPersistableModel<ClusterLogAnalyticsApplicationLogs>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterLogAnalyticsApplicationLogs>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeClusterLogAnalyticsApplicationLogs(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterLogAnalyticsApplicationLogs)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterLogAnalyticsApplicationLogs>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
