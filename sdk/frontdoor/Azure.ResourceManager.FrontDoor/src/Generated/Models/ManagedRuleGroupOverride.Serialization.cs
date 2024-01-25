// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class ManagedRuleGroupOverride : IUtf8JsonSerializable, IJsonModel<ManagedRuleGroupOverride>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedRuleGroupOverride>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedRuleGroupOverride>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedRuleGroupOverride>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedRuleGroupOverride)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("ruleGroupName"u8);
            writer.WriteStringValue(RuleGroupName);
            if (Optional.IsCollectionDefined(Exclusions))
            {
                writer.WritePropertyName("exclusions"u8);
                writer.WriteStartArray();
                foreach (var item in Exclusions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Rules))
            {
                writer.WritePropertyName("rules"u8);
                writer.WriteStartArray();
                foreach (var item in Rules)
                {
                    writer.WriteObjectValue(item);
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
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ManagedRuleGroupOverride IJsonModel<ManagedRuleGroupOverride>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedRuleGroupOverride>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedRuleGroupOverride)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedRuleGroupOverride(document.RootElement, options);
        }

        internal static ManagedRuleGroupOverride DeserializeManagedRuleGroupOverride(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ruleGroupName = default;
            Optional<IList<ManagedRuleExclusion>> exclusions = default;
            Optional<IList<ManagedRuleOverride>> rules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleGroupName"u8))
                {
                    ruleGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("exclusions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedRuleExclusion> array = new List<ManagedRuleExclusion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedRuleExclusion.DeserializeManagedRuleExclusion(item));
                    }
                    exclusions = array;
                    continue;
                }
                if (property.NameEquals("rules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedRuleOverride> array = new List<ManagedRuleOverride>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedRuleOverride.DeserializeManagedRuleOverride(item));
                    }
                    rules = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedRuleGroupOverride(ruleGroupName, Optional.ToList(exclusions), Optional.ToList(rules), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedRuleGroupOverride>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedRuleGroupOverride>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedRuleGroupOverride)} does not support '{options.Format}' format.");
            }
        }

        ManagedRuleGroupOverride IPersistableModel<ManagedRuleGroupOverride>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedRuleGroupOverride>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedRuleGroupOverride(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedRuleGroupOverride)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedRuleGroupOverride>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
