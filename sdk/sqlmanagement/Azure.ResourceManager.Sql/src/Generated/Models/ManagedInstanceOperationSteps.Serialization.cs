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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstanceOperationSteps : IUtf8JsonSerializable, IJsonModel<ManagedInstanceOperationSteps>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedInstanceOperationSteps>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedInstanceOperationSteps>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceOperationSteps>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedInstanceOperationSteps)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(TotalSteps))
            {
                writer.WritePropertyName("totalSteps"u8);
                writer.WriteStringValue(TotalSteps);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentStep))
            {
                writer.WritePropertyName("currentStep"u8);
                writer.WriteNumberValue(CurrentStep.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(StepsList))
            {
                writer.WritePropertyName("stepsList"u8);
                writer.WriteStartArray();
                foreach (var item in StepsList)
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

        ManagedInstanceOperationSteps IJsonModel<ManagedInstanceOperationSteps>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceOperationSteps>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedInstanceOperationSteps)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedInstanceOperationSteps(document.RootElement, options);
        }

        internal static ManagedInstanceOperationSteps DeserializeManagedInstanceOperationSteps(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string totalSteps = default;
            int? currentStep = default;
            IReadOnlyList<UpsertManagedServerOperationStep> stepsList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalSteps"u8))
                {
                    totalSteps = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currentStep"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentStep = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("stepsList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UpsertManagedServerOperationStep> array = new List<UpsertManagedServerOperationStep>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UpsertManagedServerOperationStep.DeserializeUpsertManagedServerOperationStep(item, options));
                    }
                    stepsList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedInstanceOperationSteps(totalSteps, currentStep, stepsList ?? new ChangeTrackingList<UpsertManagedServerOperationStep>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TotalSteps), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  totalSteps: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TotalSteps))
                {
                    builder.Append("  totalSteps: ");
                    if (TotalSteps.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TotalSteps}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TotalSteps}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CurrentStep), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  currentStep: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CurrentStep))
                {
                    builder.Append("  currentStep: ");
                    builder.AppendLine($"{CurrentStep.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StepsList), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  stepsList: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(StepsList))
                {
                    if (StepsList.Any())
                    {
                        builder.Append("  stepsList: ");
                        builder.AppendLine("[");
                        foreach (var item in StepsList)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  stepsList: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ManagedInstanceOperationSteps>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceOperationSteps>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedInstanceOperationSteps)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedInstanceOperationSteps IPersistableModel<ManagedInstanceOperationSteps>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceOperationSteps>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeManagedInstanceOperationSteps(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedInstanceOperationSteps)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedInstanceOperationSteps>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
