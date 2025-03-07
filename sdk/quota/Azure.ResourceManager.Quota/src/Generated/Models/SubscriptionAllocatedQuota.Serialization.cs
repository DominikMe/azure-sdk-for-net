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

namespace Azure.ResourceManager.Quota.Models
{
    public partial class SubscriptionAllocatedQuota : IUtf8JsonSerializable, IJsonModel<SubscriptionAllocatedQuota>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SubscriptionAllocatedQuota>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SubscriptionAllocatedQuota>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionAllocatedQuota>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubscriptionAllocatedQuota)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (Optional.IsDefined(QuotaAllocated))
            {
                writer.WritePropertyName("quotaAllocated"u8);
                writer.WriteNumberValue(QuotaAllocated.Value);
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

        SubscriptionAllocatedQuota IJsonModel<SubscriptionAllocatedQuota>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionAllocatedQuota>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubscriptionAllocatedQuota)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSubscriptionAllocatedQuota(document.RootElement, options);
        }

        internal static SubscriptionAllocatedQuota DeserializeSubscriptionAllocatedQuota(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string subscriptionId = default;
            long? quotaAllocated = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quotaAllocated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quotaAllocated = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SubscriptionAllocatedQuota(subscriptionId, quotaAllocated, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SubscriptionId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  subscriptionId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SubscriptionId))
                {
                    builder.Append("  subscriptionId: ");
                    if (SubscriptionId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SubscriptionId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SubscriptionId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QuotaAllocated), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  quotaAllocated: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(QuotaAllocated))
                {
                    builder.Append("  quotaAllocated: ");
                    builder.AppendLine($"'{QuotaAllocated.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SubscriptionAllocatedQuota>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionAllocatedQuota>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SubscriptionAllocatedQuota)} does not support writing '{options.Format}' format.");
            }
        }

        SubscriptionAllocatedQuota IPersistableModel<SubscriptionAllocatedQuota>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionAllocatedQuota>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSubscriptionAllocatedQuota(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SubscriptionAllocatedQuota)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SubscriptionAllocatedQuota>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
