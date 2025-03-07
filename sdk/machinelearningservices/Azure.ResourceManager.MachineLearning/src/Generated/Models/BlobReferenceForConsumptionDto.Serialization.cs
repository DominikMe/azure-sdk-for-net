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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class BlobReferenceForConsumptionDto : IUtf8JsonSerializable, IJsonModel<BlobReferenceForConsumptionDto>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BlobReferenceForConsumptionDto>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BlobReferenceForConsumptionDto>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobReferenceForConsumptionDto>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BlobReferenceForConsumptionDto)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(BlobUri))
            {
                if (BlobUri != null)
                {
                    writer.WritePropertyName("blobUri"u8);
                    writer.WriteStringValue(BlobUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("blobUri");
                }
            }
            if (Optional.IsDefined(StorageAccountArmId))
            {
                if (StorageAccountArmId != null)
                {
                    writer.WritePropertyName("storageAccountArmId"u8);
                    writer.WriteStringValue(StorageAccountArmId);
                }
                else
                {
                    writer.WriteNull("storageAccountArmId");
                }
            }
            if (Optional.IsDefined(Credential))
            {
                if (Credential != null)
                {
                    writer.WritePropertyName("credential"u8);
                    writer.WriteObjectValue(Credential, options);
                }
                else
                {
                    writer.WriteNull("credential");
                }
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

        BlobReferenceForConsumptionDto IJsonModel<BlobReferenceForConsumptionDto>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobReferenceForConsumptionDto>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BlobReferenceForConsumptionDto)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBlobReferenceForConsumptionDto(document.RootElement, options);
        }

        internal static BlobReferenceForConsumptionDto DeserializeBlobReferenceForConsumptionDto(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri blobUri = default;
            ResourceIdentifier storageAccountArmId = default;
            PendingUploadCredentialDto credential = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blobUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        blobUri = null;
                        continue;
                    }
                    blobUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        storageAccountArmId = null;
                        continue;
                    }
                    storageAccountArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("credential"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        credential = null;
                        continue;
                    }
                    credential = PendingUploadCredentialDto.DeserializePendingUploadCredentialDto(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BlobReferenceForConsumptionDto(blobUri, storageAccountArmId, credential, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BlobUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  blobUri: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BlobUri))
                {
                    builder.Append("  blobUri: ");
                    builder.AppendLine($"'{BlobUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StorageAccountArmId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  storageAccountArmId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StorageAccountArmId))
                {
                    builder.Append("  storageAccountArmId: ");
                    builder.AppendLine($"'{StorageAccountArmId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Credential), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  credential: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Credential))
                {
                    builder.Append("  credential: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Credential, options, 2, false, "  credential: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<BlobReferenceForConsumptionDto>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobReferenceForConsumptionDto>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(BlobReferenceForConsumptionDto)} does not support writing '{options.Format}' format.");
            }
        }

        BlobReferenceForConsumptionDto IPersistableModel<BlobReferenceForConsumptionDto>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobReferenceForConsumptionDto>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBlobReferenceForConsumptionDto(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BlobReferenceForConsumptionDto)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BlobReferenceForConsumptionDto>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
