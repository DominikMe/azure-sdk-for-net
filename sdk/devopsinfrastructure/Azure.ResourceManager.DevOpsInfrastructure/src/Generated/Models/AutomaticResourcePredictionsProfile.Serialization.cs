// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevOpsInfrastructure.Models
{
    public partial class AutomaticResourcePredictionsProfile : IUtf8JsonSerializable, IJsonModel<AutomaticResourcePredictionsProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutomaticResourcePredictionsProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AutomaticResourcePredictionsProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomaticResourcePredictionsProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomaticResourcePredictionsProfile)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(PredictionPreference))
            {
                writer.WritePropertyName("predictionPreference"u8);
                writer.WriteStringValue(PredictionPreference.Value.ToString());
            }
        }

        AutomaticResourcePredictionsProfile IJsonModel<AutomaticResourcePredictionsProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomaticResourcePredictionsProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomaticResourcePredictionsProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomaticResourcePredictionsProfile(document.RootElement, options);
        }

        internal static AutomaticResourcePredictionsProfile DeserializeAutomaticResourcePredictionsProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PredictionPreference? predictionPreference = default;
            ResourcePredictionsProfileType kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("predictionPreference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    predictionPreference = new PredictionPreference(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new ResourcePredictionsProfileType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AutomaticResourcePredictionsProfile(kind, serializedAdditionalRawData, predictionPreference);
        }

        BinaryData IPersistableModel<AutomaticResourcePredictionsProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomaticResourcePredictionsProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutomaticResourcePredictionsProfile)} does not support writing '{options.Format}' format.");
            }
        }

        AutomaticResourcePredictionsProfile IPersistableModel<AutomaticResourcePredictionsProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomaticResourcePredictionsProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAutomaticResourcePredictionsProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutomaticResourcePredictionsProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutomaticResourcePredictionsProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
