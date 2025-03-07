// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations.Authoring
{
    public partial class IntentEvaluationSummary : IUtf8JsonSerializable, IJsonModel<IntentEvaluationSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntentEvaluationSummary>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IntentEvaluationSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntentEvaluationSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntentEvaluationSummary)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("f1"u8);
            writer.WriteNumberValue(F1);
            writer.WritePropertyName("precision"u8);
            writer.WriteNumberValue(Precision);
            writer.WritePropertyName("recall"u8);
            writer.WriteNumberValue(Recall);
            writer.WritePropertyName("truePositiveCount"u8);
            writer.WriteNumberValue(TruePositiveCount);
            writer.WritePropertyName("trueNegativeCount"u8);
            writer.WriteNumberValue(TrueNegativeCount);
            writer.WritePropertyName("falsePositiveCount"u8);
            writer.WriteNumberValue(FalsePositiveCount);
            writer.WritePropertyName("falseNegativeCount"u8);
            writer.WriteNumberValue(FalseNegativeCount);
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

        IntentEvaluationSummary IJsonModel<IntentEvaluationSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntentEvaluationSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntentEvaluationSummary)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntentEvaluationSummary(document.RootElement, options);
        }

        internal static IntentEvaluationSummary DeserializeIntentEvaluationSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double f1 = default;
            double precision = default;
            double recall = default;
            int truePositiveCount = default;
            int trueNegativeCount = default;
            int falsePositiveCount = default;
            int falseNegativeCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("f1"u8))
                {
                    f1 = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("precision"u8))
                {
                    precision = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("recall"u8))
                {
                    recall = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("truePositiveCount"u8))
                {
                    truePositiveCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("trueNegativeCount"u8))
                {
                    trueNegativeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("falsePositiveCount"u8))
                {
                    falsePositiveCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("falseNegativeCount"u8))
                {
                    falseNegativeCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IntentEvaluationSummary(
                f1,
                precision,
                recall,
                truePositiveCount,
                trueNegativeCount,
                falsePositiveCount,
                falseNegativeCount,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IntentEvaluationSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntentEvaluationSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IntentEvaluationSummary)} does not support writing '{options.Format}' format.");
            }
        }

        IntentEvaluationSummary IPersistableModel<IntentEvaluationSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntentEvaluationSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeIntentEvaluationSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IntentEvaluationSummary)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IntentEvaluationSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static IntentEvaluationSummary FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeIntentEvaluationSummary(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
