// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class ScheduledSourceSynchronizationSetting : IUtf8JsonSerializable, IJsonModel<ScheduledSourceSynchronizationSetting>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScheduledSourceSynchronizationSetting>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ScheduledSourceSynchronizationSetting>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledSourceSynchronizationSetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduledSourceSynchronizationSetting)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(RecurrenceInterval))
            {
                writer.WritePropertyName("recurrenceInterval"u8);
                writer.WriteStringValue(RecurrenceInterval.Value.ToString());
            }
            if (Optional.IsDefined(SynchronizeOn))
            {
                writer.WritePropertyName("synchronizationTime"u8);
                writer.WriteStringValue(SynchronizeOn.Value, "O");
            }
            writer.WriteEndObject();
        }

        ScheduledSourceSynchronizationSetting IJsonModel<ScheduledSourceSynchronizationSetting>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledSourceSynchronizationSetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduledSourceSynchronizationSetting)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScheduledSourceSynchronizationSetting(document.RootElement, options);
        }

        internal static ScheduledSourceSynchronizationSetting DeserializeScheduledSourceSynchronizationSetting(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SourceShareSynchronizationSettingKind kind = default;
            DataShareSynchronizationRecurrenceInterval? recurrenceInterval = default;
            DateTimeOffset? synchronizationTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new SourceShareSynchronizationSettingKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("recurrenceInterval"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recurrenceInterval = new DataShareSynchronizationRecurrenceInterval(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("synchronizationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            synchronizationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ScheduledSourceSynchronizationSetting(kind, serializedAdditionalRawData, recurrenceInterval, synchronizationTime);
        }

        BinaryData IPersistableModel<ScheduledSourceSynchronizationSetting>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledSourceSynchronizationSetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScheduledSourceSynchronizationSetting)} does not support writing '{options.Format}' format.");
            }
        }

        ScheduledSourceSynchronizationSetting IPersistableModel<ScheduledSourceSynchronizationSetting>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledSourceSynchronizationSetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeScheduledSourceSynchronizationSetting(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScheduledSourceSynchronizationSetting)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScheduledSourceSynchronizationSetting>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
