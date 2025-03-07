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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppQueueScaleRule : IUtf8JsonSerializable, IJsonModel<ContainerAppQueueScaleRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppQueueScaleRule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerAppQueueScaleRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppQueueScaleRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppQueueScaleRule)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(QueueName))
            {
                writer.WritePropertyName("queueName"u8);
                writer.WriteStringValue(QueueName);
            }
            if (Optional.IsDefined(QueueLength))
            {
                writer.WritePropertyName("queueLength"u8);
                writer.WriteNumberValue(QueueLength.Value);
            }
            if (Optional.IsCollectionDefined(Auth))
            {
                writer.WritePropertyName("auth"u8);
                writer.WriteStartArray();
                foreach (var item in Auth)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        ContainerAppQueueScaleRule IJsonModel<ContainerAppQueueScaleRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppQueueScaleRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppQueueScaleRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppQueueScaleRule(document.RootElement, options);
        }

        internal static ContainerAppQueueScaleRule DeserializeContainerAppQueueScaleRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string queueName = default;
            int? queueLength = default;
            IList<ContainerAppScaleRuleAuth> auth = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queueName"u8))
                {
                    queueName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queueLength"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queueLength = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("auth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppScaleRuleAuth> array = new List<ContainerAppScaleRuleAuth>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppScaleRuleAuth.DeserializeContainerAppScaleRuleAuth(item, options));
                    }
                    auth = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerAppQueueScaleRule(queueName, queueLength, auth ?? new ChangeTrackingList<ContainerAppScaleRuleAuth>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QueueName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  queueName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(QueueName))
                {
                    builder.Append("  queueName: ");
                    if (QueueName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{QueueName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{QueueName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QueueLength), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  queueLength: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(QueueLength))
                {
                    builder.Append("  queueLength: ");
                    builder.AppendLine($"{QueueLength.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Auth), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  auth: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Auth))
                {
                    if (Auth.Any())
                    {
                        builder.Append("  auth: ");
                        builder.AppendLine("[");
                        foreach (var item in Auth)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  auth: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerAppQueueScaleRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppQueueScaleRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppQueueScaleRule)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppQueueScaleRule IPersistableModel<ContainerAppQueueScaleRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppQueueScaleRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerAppQueueScaleRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppQueueScaleRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppQueueScaleRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
