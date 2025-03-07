// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class BenefitUtilizationSummary : IUtf8JsonSerializable, IJsonModel<BenefitUtilizationSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BenefitUtilizationSummary>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BenefitUtilizationSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BenefitUtilizationSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BenefitUtilizationSummary)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
        }

        BenefitUtilizationSummary IJsonModel<BenefitUtilizationSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BenefitUtilizationSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BenefitUtilizationSummary)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBenefitUtilizationSummary(document.RootElement, options);
        }

        internal static BenefitUtilizationSummary DeserializeBenefitUtilizationSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "IncludedQuantity": return IncludedQuantityUtilizationSummary.DeserializeIncludedQuantityUtilizationSummary(element, options);
                    case "SavingsPlan": return SavingsPlanUtilizationSummary.DeserializeSavingsPlanUtilizationSummary(element, options);
                }
            }
            return UnknownBenefitUtilizationSummary.DeserializeUnknownBenefitUtilizationSummary(element, options);
        }

        BinaryData IPersistableModel<BenefitUtilizationSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BenefitUtilizationSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BenefitUtilizationSummary)} does not support writing '{options.Format}' format.");
            }
        }

        BenefitUtilizationSummary IPersistableModel<BenefitUtilizationSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BenefitUtilizationSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBenefitUtilizationSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BenefitUtilizationSummary)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BenefitUtilizationSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
