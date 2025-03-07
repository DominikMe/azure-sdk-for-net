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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class InlineEventProperties : IUtf8JsonSerializable, IJsonModel<InlineEventProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InlineEventProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InlineEventProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InlineEventProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InlineEventProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(DocumentationUri))
            {
                writer.WritePropertyName("documentationUrl"u8);
                writer.WriteStringValue(DocumentationUri.AbsoluteUri);
            }
            if (Optional.IsDefined(DataSchemaUri))
            {
                writer.WritePropertyName("dataSchemaUrl"u8);
                writer.WriteStringValue(DataSchemaUri.AbsoluteUri);
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

        InlineEventProperties IJsonModel<InlineEventProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InlineEventProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InlineEventProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInlineEventProperties(document.RootElement, options);
        }

        internal static InlineEventProperties DeserializeInlineEventProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string description = default;
            string displayName = default;
            Uri documentationUri = default;
            Uri dataSchemaUri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("documentationUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    documentationUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataSchemaUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataSchemaUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InlineEventProperties(description, displayName, documentationUri, dataSchemaUri, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Description), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  description: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Description))
                {
                    builder.Append("  description: ");
                    if (Description.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Description}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Description}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  displayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DisplayName))
                {
                    builder.Append("  displayName: ");
                    if (DisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DocumentationUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  documentationUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DocumentationUri))
                {
                    builder.Append("  documentationUrl: ");
                    builder.AppendLine($"'{DocumentationUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DataSchemaUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dataSchemaUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DataSchemaUri))
                {
                    builder.Append("  dataSchemaUrl: ");
                    builder.AppendLine($"'{DataSchemaUri.AbsoluteUri}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<InlineEventProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InlineEventProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(InlineEventProperties)} does not support writing '{options.Format}' format.");
            }
        }

        InlineEventProperties IPersistableModel<InlineEventProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InlineEventProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeInlineEventProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InlineEventProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InlineEventProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
