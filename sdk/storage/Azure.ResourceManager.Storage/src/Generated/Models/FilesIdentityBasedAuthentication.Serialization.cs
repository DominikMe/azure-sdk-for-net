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

namespace Azure.ResourceManager.Storage.Models
{
    public partial class FilesIdentityBasedAuthentication : IUtf8JsonSerializable, IJsonModel<FilesIdentityBasedAuthentication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FilesIdentityBasedAuthentication>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FilesIdentityBasedAuthentication>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FilesIdentityBasedAuthentication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FilesIdentityBasedAuthentication)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("directoryServiceOptions"u8);
            writer.WriteStringValue(DirectoryServiceOptions.ToString());
            if (Optional.IsDefined(ActiveDirectoryProperties))
            {
                writer.WritePropertyName("activeDirectoryProperties"u8);
                writer.WriteObjectValue(ActiveDirectoryProperties, options);
            }
            if (Optional.IsDefined(DefaultSharePermission))
            {
                writer.WritePropertyName("defaultSharePermission"u8);
                writer.WriteStringValue(DefaultSharePermission.Value.ToString());
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

        FilesIdentityBasedAuthentication IJsonModel<FilesIdentityBasedAuthentication>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FilesIdentityBasedAuthentication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FilesIdentityBasedAuthentication)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFilesIdentityBasedAuthentication(document.RootElement, options);
        }

        internal static FilesIdentityBasedAuthentication DeserializeFilesIdentityBasedAuthentication(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DirectoryServiceOption directoryServiceOptions = default;
            StorageActiveDirectoryProperties activeDirectoryProperties = default;
            DefaultSharePermission? defaultSharePermission = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("directoryServiceOptions"u8))
                {
                    directoryServiceOptions = new DirectoryServiceOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("activeDirectoryProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activeDirectoryProperties = StorageActiveDirectoryProperties.DeserializeStorageActiveDirectoryProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("defaultSharePermission"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultSharePermission = new DefaultSharePermission(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FilesIdentityBasedAuthentication(directoryServiceOptions, activeDirectoryProperties, defaultSharePermission, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DirectoryServiceOptions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  directoryServiceOptions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  directoryServiceOptions: ");
                builder.AppendLine($"'{DirectoryServiceOptions.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ActiveDirectoryProperties), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  activeDirectoryProperties: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ActiveDirectoryProperties))
                {
                    builder.Append("  activeDirectoryProperties: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ActiveDirectoryProperties, options, 2, false, "  activeDirectoryProperties: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DefaultSharePermission), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  defaultSharePermission: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DefaultSharePermission))
                {
                    builder.Append("  defaultSharePermission: ");
                    builder.AppendLine($"'{DefaultSharePermission.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<FilesIdentityBasedAuthentication>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FilesIdentityBasedAuthentication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(FilesIdentityBasedAuthentication)} does not support writing '{options.Format}' format.");
            }
        }

        FilesIdentityBasedAuthentication IPersistableModel<FilesIdentityBasedAuthentication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FilesIdentityBasedAuthentication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFilesIdentityBasedAuthentication(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FilesIdentityBasedAuthentication)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FilesIdentityBasedAuthentication>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
