// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryImportImageContent : IUtf8JsonSerializable, IJsonModel<ContainerRegistryImportImageContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryImportImageContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerRegistryImportImageContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryImportImageContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryImportImageContent)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("source"u8);
            writer.WriteObjectValue(Source, options);
            if (Optional.IsCollectionDefined(TargetTags))
            {
                writer.WritePropertyName("targetTags"u8);
                writer.WriteStartArray();
                foreach (var item in TargetTags)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UntaggedTargetRepositories))
            {
                writer.WritePropertyName("untaggedTargetRepositories"u8);
                writer.WriteStartArray();
                foreach (var item in UntaggedTargetRepositories)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
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

        ContainerRegistryImportImageContent IJsonModel<ContainerRegistryImportImageContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryImportImageContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryImportImageContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryImportImageContent(document.RootElement, options);
        }

        internal static ContainerRegistryImportImageContent DeserializeContainerRegistryImportImageContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerRegistryImportSource source = default;
            IList<string> targetTags = default;
            IList<string> untaggedTargetRepositories = default;
            ContainerRegistryImportMode? mode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"u8))
                {
                    source = ContainerRegistryImportSource.DeserializeContainerRegistryImportSource(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetTags"u8))
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
                    targetTags = array;
                    continue;
                }
                if (property.NameEquals("untaggedTargetRepositories"u8))
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
                    untaggedTargetRepositories = array;
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new ContainerRegistryImportMode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerRegistryImportImageContent(source, targetTags ?? new ChangeTrackingList<string>(), untaggedTargetRepositories ?? new ChangeTrackingList<string>(), mode, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerRegistryImportImageContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryImportImageContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryImportImageContent)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerRegistryImportImageContent IPersistableModel<ContainerRegistryImportImageContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryImportImageContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerRegistryImportImageContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryImportImageContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryImportImageContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
