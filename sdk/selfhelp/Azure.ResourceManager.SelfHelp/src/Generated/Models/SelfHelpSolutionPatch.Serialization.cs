// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    public partial class SelfHelpSolutionPatch : IUtf8JsonSerializable, IJsonModel<SelfHelpSolutionPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SelfHelpSolutionPatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SelfHelpSolutionPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpSolutionPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SelfHelpSolutionPatch)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(TriggerCriteria))
            {
                writer.WritePropertyName("triggerCriteria"u8);
                writer.WriteStartArray();
                foreach (var item in TriggerCriteria)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(SolutionId))
            {
                writer.WritePropertyName("solutionId"u8);
                writer.WriteStringValue(SolutionId);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (options.Format != "W" && Optional.IsDefined(Content))
            {
                writer.WritePropertyName("content"u8);
                writer.WriteStringValue(Content);
            }
            if (options.Format != "W" && Optional.IsDefined(ReplacementMaps))
            {
                writer.WritePropertyName("replacementMaps"u8);
                writer.WriteObjectValue(ReplacementMaps, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Sections))
            {
                writer.WritePropertyName("sections"u8);
                writer.WriteStartArray();
                foreach (var item in Sections)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        SelfHelpSolutionPatch IJsonModel<SelfHelpSolutionPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpSolutionPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SelfHelpSolutionPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSelfHelpSolutionPatch(document.RootElement, options);
        }

        internal static SelfHelpSolutionPatch DeserializeSelfHelpSolutionPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<SolutionTriggerCriterion> triggerCriteria = default;
            IDictionary<string, string> parameters = default;
            string solutionId = default;
            SolutionProvisioningState? provisioningState = default;
            string title = default;
            string content = default;
            SolutionReplacementMaps replacementMaps = default;
            IReadOnlyList<SelfHelpSection> sections = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("triggerCriteria"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SolutionTriggerCriterion> array = new List<SolutionTriggerCriterion>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SolutionTriggerCriterion.DeserializeSolutionTriggerCriterion(item, options));
                            }
                            triggerCriteria = array;
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            parameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("solutionId"u8))
                        {
                            solutionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new SolutionProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("title"u8))
                        {
                            title = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("content"u8))
                        {
                            content = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("replacementMaps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replacementMaps = SolutionReplacementMaps.DeserializeSolutionReplacementMaps(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("sections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SelfHelpSection> array = new List<SelfHelpSection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SelfHelpSection.DeserializeSelfHelpSection(item, options));
                            }
                            sections = array;
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
            return new SelfHelpSolutionPatch(
                triggerCriteria ?? new ChangeTrackingList<SolutionTriggerCriterion>(),
                parameters ?? new ChangeTrackingDictionary<string, string>(),
                solutionId,
                provisioningState,
                title,
                content,
                replacementMaps,
                sections ?? new ChangeTrackingList<SelfHelpSection>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SelfHelpSolutionPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpSolutionPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SelfHelpSolutionPatch)} does not support writing '{options.Format}' format.");
            }
        }

        SelfHelpSolutionPatch IPersistableModel<SelfHelpSolutionPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpSolutionPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSelfHelpSolutionPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SelfHelpSolutionPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SelfHelpSolutionPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
