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

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class CommitmentPlanAssociation : IUtf8JsonSerializable, IJsonModel<CommitmentPlanAssociation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CommitmentPlanAssociation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CommitmentPlanAssociation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommitmentPlanAssociation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommitmentPlanAssociation)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(CommitmentPlanId))
            {
                writer.WritePropertyName("commitmentPlanId"u8);
                writer.WriteStringValue(CommitmentPlanId);
            }
            if (Optional.IsDefined(CommitmentPlanLocation))
            {
                writer.WritePropertyName("commitmentPlanLocation"u8);
                writer.WriteStringValue(CommitmentPlanLocation);
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

        CommitmentPlanAssociation IJsonModel<CommitmentPlanAssociation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommitmentPlanAssociation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommitmentPlanAssociation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCommitmentPlanAssociation(document.RootElement, options);
        }

        internal static CommitmentPlanAssociation DeserializeCommitmentPlanAssociation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier commitmentPlanId = default;
            string commitmentPlanLocation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("commitmentPlanId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    commitmentPlanId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("commitmentPlanLocation"u8))
                {
                    commitmentPlanLocation = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CommitmentPlanAssociation(commitmentPlanId, commitmentPlanLocation, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CommitmentPlanId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  commitmentPlanId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CommitmentPlanId))
                {
                    builder.Append("  commitmentPlanId: ");
                    builder.AppendLine($"'{CommitmentPlanId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CommitmentPlanLocation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  commitmentPlanLocation: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CommitmentPlanLocation))
                {
                    builder.Append("  commitmentPlanLocation: ");
                    if (CommitmentPlanLocation.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CommitmentPlanLocation}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CommitmentPlanLocation}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CommitmentPlanAssociation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommitmentPlanAssociation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CommitmentPlanAssociation)} does not support writing '{options.Format}' format.");
            }
        }

        CommitmentPlanAssociation IPersistableModel<CommitmentPlanAssociation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommitmentPlanAssociation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCommitmentPlanAssociation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CommitmentPlanAssociation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CommitmentPlanAssociation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
