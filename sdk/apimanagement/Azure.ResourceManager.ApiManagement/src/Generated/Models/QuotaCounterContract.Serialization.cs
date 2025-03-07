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
    public partial class QuotaCounterContract : IUtf8JsonSerializable, IJsonModel<QuotaCounterContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QuotaCounterContract>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<QuotaCounterContract>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaCounterContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QuotaCounterContract)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("counterKey"u8);
            writer.WriteStringValue(CounterKey);
            writer.WritePropertyName("periodKey"u8);
            writer.WriteStringValue(PeriodKey);
            writer.WritePropertyName("periodStartTime"u8);
            writer.WriteStringValue(PeriodStartOn, "O");
            writer.WritePropertyName("periodEndTime"u8);
            writer.WriteStringValue(PeriodEndOn, "O");
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteObjectValue(Value, options);
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

        QuotaCounterContract IJsonModel<QuotaCounterContract>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaCounterContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QuotaCounterContract)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQuotaCounterContract(document.RootElement, options);
        }

        internal static QuotaCounterContract DeserializeQuotaCounterContract(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string counterKey = default;
            string periodKey = default;
            DateTimeOffset periodStartTime = default;
            DateTimeOffset periodEndTime = default;
            QuotaCounterValueContractProperties value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("counterKey"u8))
                {
                    counterKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("periodKey"u8))
                {
                    periodKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("periodStartTime"u8))
                {
                    periodStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("periodEndTime"u8))
                {
                    periodEndTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = QuotaCounterValueContractProperties.DeserializeQuotaCounterValueContractProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new QuotaCounterContract(
                counterKey,
                periodKey,
                periodStartTime,
                periodEndTime,
                value,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CounterKey), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  counterKey: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CounterKey))
                {
                    builder.Append("  counterKey: ");
                    if (CounterKey.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CounterKey}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CounterKey}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PeriodKey), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  periodKey: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PeriodKey))
                {
                    builder.Append("  periodKey: ");
                    if (PeriodKey.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PeriodKey}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PeriodKey}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PeriodStartOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  periodStartTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  periodStartTime: ");
                var formattedDateTimeString = TypeFormatters.ToString(PeriodStartOn, "o");
                builder.AppendLine($"'{formattedDateTimeString}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PeriodEndOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  periodEndTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  periodEndTime: ");
                var formattedDateTimeString = TypeFormatters.ToString(PeriodEndOn, "o");
                builder.AppendLine($"'{formattedDateTimeString}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Value), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  value: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Value))
                {
                    builder.Append("  value: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Value, options, 2, false, "  value: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<QuotaCounterContract>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaCounterContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(QuotaCounterContract)} does not support writing '{options.Format}' format.");
            }
        }

        QuotaCounterContract IPersistableModel<QuotaCounterContract>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaCounterContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeQuotaCounterContract(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QuotaCounterContract)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<QuotaCounterContract>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
