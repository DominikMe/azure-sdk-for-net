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
    public partial class AbusePenalty : IUtf8JsonSerializable, IJsonModel<AbusePenalty>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AbusePenalty>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AbusePenalty>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AbusePenalty>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AbusePenalty)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action.Value.ToString());
            }
            if (Optional.IsDefined(RateLimitPercentage))
            {
                writer.WritePropertyName("rateLimitPercentage"u8);
                writer.WriteNumberValue(RateLimitPercentage.Value);
            }
            if (Optional.IsDefined(Expiration))
            {
                writer.WritePropertyName("expiration"u8);
                writer.WriteStringValue(Expiration.Value, "O");
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

        AbusePenalty IJsonModel<AbusePenalty>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AbusePenalty>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AbusePenalty)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAbusePenalty(document.RootElement, options);
        }

        internal static AbusePenalty DeserializeAbusePenalty(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AbusePenaltyAction? action = default;
            float? rateLimitPercentage = default;
            DateTimeOffset? expiration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("action"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    action = new AbusePenaltyAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rateLimitPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rateLimitPercentage = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("expiration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiration = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AbusePenalty(action, rateLimitPercentage, expiration, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Action), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  action: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Action))
                {
                    builder.Append("  action: ");
                    builder.AppendLine($"'{Action.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RateLimitPercentage), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  rateLimitPercentage: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RateLimitPercentage))
                {
                    builder.Append("  rateLimitPercentage: ");
                    builder.AppendLine($"'{RateLimitPercentage.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Expiration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  expiration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Expiration))
                {
                    builder.Append("  expiration: ");
                    var formattedDateTimeString = TypeFormatters.ToString(Expiration.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AbusePenalty>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AbusePenalty>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AbusePenalty)} does not support writing '{options.Format}' format.");
            }
        }

        AbusePenalty IPersistableModel<AbusePenalty>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AbusePenalty>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAbusePenalty(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AbusePenalty)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AbusePenalty>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
