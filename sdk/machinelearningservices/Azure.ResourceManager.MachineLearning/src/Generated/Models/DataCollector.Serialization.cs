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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class DataCollector : IUtf8JsonSerializable, IJsonModel<DataCollector>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataCollector>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataCollector>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollector>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollector)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("collections"u8);
            writer.WriteStartObject();
            foreach (var item in Collections)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value, options);
            }
            writer.WriteEndObject();
            if (Optional.IsDefined(RollingRate))
            {
                writer.WritePropertyName("rollingRate"u8);
                writer.WriteStringValue(RollingRate.Value.ToString());
            }
            if (Optional.IsDefined(RequestLogging))
            {
                if (RequestLogging != null)
                {
                    writer.WritePropertyName("requestLogging"u8);
                    writer.WriteObjectValue(RequestLogging, options);
                }
                else
                {
                    writer.WriteNull("requestLogging");
                }
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

        DataCollector IJsonModel<DataCollector>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollector>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollector)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCollector(document.RootElement, options);
        }

        internal static DataCollector DeserializeDataCollector(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, DataCollectionConfiguration> collections = default;
            RollingRateType? rollingRate = default;
            RequestLogging requestLogging = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("collections"u8))
                {
                    Dictionary<string, DataCollectionConfiguration> dictionary = new Dictionary<string, DataCollectionConfiguration>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, DataCollectionConfiguration.DeserializeDataCollectionConfiguration(property0.Value, options));
                    }
                    collections = dictionary;
                    continue;
                }
                if (property.NameEquals("rollingRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rollingRate = new RollingRateType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("requestLogging"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        requestLogging = null;
                        continue;
                    }
                    requestLogging = RequestLogging.DeserializeRequestLogging(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataCollector(collections, rollingRate, requestLogging, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Collections), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  collections: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Collections))
                {
                    if (Collections.Any())
                    {
                        builder.Append("  collections: ");
                        builder.AppendLine("{");
                        foreach (var item in Collections)
                        {
                            builder.Append($"    '{item.Key}': ");
                            BicepSerializationHelpers.AppendChildObject(builder, item.Value, options, 4, false, "  collections: ");
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RollingRate), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  rollingRate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RollingRate))
                {
                    builder.Append("  rollingRate: ");
                    builder.AppendLine($"'{RollingRate.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("RequestLoggingCaptureHeaders", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  requestLogging: ");
                builder.AppendLine("{");
                builder.Append("    captureHeaders: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(RequestLogging))
                {
                    builder.Append("  requestLogging: ");
                    BicepSerializationHelpers.AppendChildObject(builder, RequestLogging, options, 2, false, "  requestLogging: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<DataCollector>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollector>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DataCollector)} does not support writing '{options.Format}' format.");
            }
        }

        DataCollector IPersistableModel<DataCollector>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollector>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataCollector(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataCollector)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataCollector>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
