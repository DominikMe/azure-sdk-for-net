// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    public partial class ExperimentExecutionActionTargetDetailsError : IUtf8JsonSerializable, IJsonModel<ExperimentExecutionActionTargetDetailsError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExperimentExecutionActionTargetDetailsError>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExperimentExecutionActionTargetDetailsError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExperimentExecutionActionTargetDetailsError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExperimentExecutionActionTargetDetailsError)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Code))
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code);
            }
            if (options.Format != "W" && Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ExperimentExecutionActionTargetDetailsError IJsonModel<ExperimentExecutionActionTargetDetailsError>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExperimentExecutionActionTargetDetailsError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExperimentExecutionActionTargetDetailsError)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExperimentExecutionActionTargetDetailsError(document.RootElement, options);
        }

        internal static ExperimentExecutionActionTargetDetailsError DeserializeExperimentExecutionActionTargetDetailsError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string code = default;
            string message = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExperimentExecutionActionTargetDetailsError(code, message, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExperimentExecutionActionTargetDetailsError>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExperimentExecutionActionTargetDetailsError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExperimentExecutionActionTargetDetailsError)} does not support writing '{options.Format}' format.");
            }
        }

        ExperimentExecutionActionTargetDetailsError IPersistableModel<ExperimentExecutionActionTargetDetailsError>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExperimentExecutionActionTargetDetailsError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExperimentExecutionActionTargetDetailsError(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExperimentExecutionActionTargetDetailsError)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExperimentExecutionActionTargetDetailsError>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
