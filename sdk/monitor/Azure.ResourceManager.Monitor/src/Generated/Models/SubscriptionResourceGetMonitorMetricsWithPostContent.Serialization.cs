// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class SubscriptionResourceGetMonitorMetricsWithPostContent : IUtf8JsonSerializable, IJsonModel<SubscriptionResourceGetMonitorMetricsWithPostContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SubscriptionResourceGetMonitorMetricsWithPostContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SubscriptionResourceGetMonitorMetricsWithPostContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionResourceGetMonitorMetricsWithPostContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubscriptionResourceGetMonitorMetricsWithPostContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Timespan))
            {
                writer.WritePropertyName("timespan"u8);
                writer.WriteStringValue(Timespan.Value, "T");
            }
            if (Optional.IsDefined(Interval))
            {
                writer.WritePropertyName("interval"u8);
                writer.WriteStringValue(Interval.Value, "P");
            }
            if (Optional.IsDefined(MetricNames))
            {
                writer.WritePropertyName("metricNames"u8);
                writer.WriteStringValue(MetricNames);
            }
            if (Optional.IsDefined(Aggregation))
            {
                writer.WritePropertyName("aggregation"u8);
                writer.WriteStringValue(Aggregation);
            }
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteStringValue(Filter);
            }
            if (Optional.IsDefined(Top))
            {
                writer.WritePropertyName("top"u8);
                writer.WriteNumberValue(Top.Value);
            }
            if (Optional.IsDefined(OrderBy))
            {
                writer.WritePropertyName("orderBy"u8);
                writer.WriteStringValue(OrderBy);
            }
            if (Optional.IsDefined(RollUpBy))
            {
                writer.WritePropertyName("rollUpBy"u8);
                writer.WriteStringValue(RollUpBy);
            }
            if (Optional.IsDefined(ResultType))
            {
                writer.WritePropertyName("resultType"u8);
                writer.WriteStringValue(ResultType.Value.ToString());
            }
            if (Optional.IsDefined(MetricNamespace))
            {
                writer.WritePropertyName("metricNamespace"u8);
                writer.WriteStringValue(MetricNamespace);
            }
            if (Optional.IsDefined(AutoAdjustTimegrain))
            {
                writer.WritePropertyName("autoAdjustTimegrain"u8);
                writer.WriteBooleanValue(AutoAdjustTimegrain.Value);
            }
            if (Optional.IsDefined(ValidateDimensions))
            {
                writer.WritePropertyName("validateDimensions"u8);
                writer.WriteBooleanValue(ValidateDimensions.Value);
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

        SubscriptionResourceGetMonitorMetricsWithPostContent IJsonModel<SubscriptionResourceGetMonitorMetricsWithPostContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionResourceGetMonitorMetricsWithPostContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubscriptionResourceGetMonitorMetricsWithPostContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSubscriptionResourceGetMonitorMetricsWithPostContent(document.RootElement, options);
        }

        internal static SubscriptionResourceGetMonitorMetricsWithPostContent DeserializeSubscriptionResourceGetMonitorMetricsWithPostContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSpan? timespan = default;
            TimeSpan? interval = default;
            string metricNames = default;
            string aggregation = default;
            string filter = default;
            int? top = default;
            string orderBy = default;
            string rollUpBy = default;
            MonitorMetricResultType? resultType = default;
            string metricNamespace = default;
            bool? autoAdjustTimegrain = default;
            bool? validateDimensions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timespan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timespan = property.Value.GetTimeSpan("T");
                    continue;
                }
                if (property.NameEquals("interval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    interval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("metricNames"u8))
                {
                    metricNames = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aggregation"u8))
                {
                    aggregation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    filter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("top"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    top = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("orderBy"u8))
                {
                    orderBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rollUpBy"u8))
                {
                    rollUpBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resultType = new MonitorMetricResultType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metricNamespace"u8))
                {
                    metricNamespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoAdjustTimegrain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoAdjustTimegrain = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("validateDimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validateDimensions = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SubscriptionResourceGetMonitorMetricsWithPostContent(
                timespan,
                interval,
                metricNames,
                aggregation,
                filter,
                top,
                orderBy,
                rollUpBy,
                resultType,
                metricNamespace,
                autoAdjustTimegrain,
                validateDimensions,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SubscriptionResourceGetMonitorMetricsWithPostContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionResourceGetMonitorMetricsWithPostContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SubscriptionResourceGetMonitorMetricsWithPostContent)} does not support writing '{options.Format}' format.");
            }
        }

        SubscriptionResourceGetMonitorMetricsWithPostContent IPersistableModel<SubscriptionResourceGetMonitorMetricsWithPostContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionResourceGetMonitorMetricsWithPostContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSubscriptionResourceGetMonitorMetricsWithPostContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SubscriptionResourceGetMonitorMetricsWithPostContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SubscriptionResourceGetMonitorMetricsWithPostContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
