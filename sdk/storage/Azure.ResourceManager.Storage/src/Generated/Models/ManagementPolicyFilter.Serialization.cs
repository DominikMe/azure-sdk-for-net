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

namespace Azure.ResourceManager.Storage.Models
{
    public partial class ManagementPolicyFilter : IUtf8JsonSerializable, IJsonModel<ManagementPolicyFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagementPolicyFilter>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagementPolicyFilter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementPolicyFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementPolicyFilter)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(PrefixMatch))
            {
                writer.WritePropertyName("prefixMatch"u8);
                writer.WriteStartArray();
                foreach (var item in PrefixMatch)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("blobTypes"u8);
            writer.WriteStartArray();
            foreach (var item in BlobTypes)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(BlobIndexMatch))
            {
                writer.WritePropertyName("blobIndexMatch"u8);
                writer.WriteStartArray();
                foreach (var item in BlobIndexMatch)
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

        ManagementPolicyFilter IJsonModel<ManagementPolicyFilter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementPolicyFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementPolicyFilter)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagementPolicyFilter(document.RootElement, options);
        }

        internal static ManagementPolicyFilter DeserializeManagementPolicyFilter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> prefixMatch = default;
            IList<string> blobTypes = default;
            IList<ManagementPolicyTagFilter> blobIndexMatch = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prefixMatch"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    prefixMatch = array;
                    continue;
                }
                if (property.NameEquals("blobTypes"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    blobTypes = array;
                    continue;
                }
                if (property.NameEquals("blobIndexMatch"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagementPolicyTagFilter> array = new List<ManagementPolicyTagFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagementPolicyTagFilter.DeserializeManagementPolicyTagFilter(item, options));
                    }
                    blobIndexMatch = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagementPolicyFilter(prefixMatch ?? new ChangeTrackingList<string>(), blobTypes, blobIndexMatch ?? new ChangeTrackingList<ManagementPolicyTagFilter>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrefixMatch), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  prefixMatch: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(PrefixMatch))
                {
                    if (PrefixMatch.Any())
                    {
                        builder.Append("  prefixMatch: ");
                        builder.AppendLine("[");
                        foreach (var item in PrefixMatch)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BlobTypes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  blobTypes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(BlobTypes))
                {
                    if (BlobTypes.Any())
                    {
                        builder.Append("  blobTypes: ");
                        builder.AppendLine("[");
                        foreach (var item in BlobTypes)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BlobIndexMatch), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  blobIndexMatch: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(BlobIndexMatch))
                {
                    if (BlobIndexMatch.Any())
                    {
                        builder.Append("  blobIndexMatch: ");
                        builder.AppendLine("[");
                        foreach (var item in BlobIndexMatch)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  blobIndexMatch: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ManagementPolicyFilter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementPolicyFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagementPolicyFilter)} does not support writing '{options.Format}' format.");
            }
        }

        ManagementPolicyFilter IPersistableModel<ManagementPolicyFilter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementPolicyFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeManagementPolicyFilter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagementPolicyFilter)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagementPolicyFilter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
