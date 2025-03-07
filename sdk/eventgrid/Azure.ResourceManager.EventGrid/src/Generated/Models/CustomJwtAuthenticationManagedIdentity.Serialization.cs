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
    public partial class CustomJwtAuthenticationManagedIdentity : IUtf8JsonSerializable, IJsonModel<CustomJwtAuthenticationManagedIdentity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomJwtAuthenticationManagedIdentity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CustomJwtAuthenticationManagedIdentity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomJwtAuthenticationManagedIdentity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomJwtAuthenticationManagedIdentity)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(IdentityType.ToString());
            if (Optional.IsDefined(UserAssignedIdentity))
            {
                writer.WritePropertyName("userAssignedIdentity"u8);
                writer.WriteStringValue(UserAssignedIdentity);
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

        CustomJwtAuthenticationManagedIdentity IJsonModel<CustomJwtAuthenticationManagedIdentity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomJwtAuthenticationManagedIdentity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomJwtAuthenticationManagedIdentity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomJwtAuthenticationManagedIdentity(document.RootElement, options);
        }

        internal static CustomJwtAuthenticationManagedIdentity DeserializeCustomJwtAuthenticationManagedIdentity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CustomJwtAuthenticationManagedIdentityType type = default;
            string userAssignedIdentity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new CustomJwtAuthenticationManagedIdentityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("userAssignedIdentity"u8))
                {
                    userAssignedIdentity = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CustomJwtAuthenticationManagedIdentity(type, userAssignedIdentity, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IdentityType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  type: ");
                builder.AppendLine($"'{IdentityType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UserAssignedIdentity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  userAssignedIdentity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UserAssignedIdentity))
                {
                    builder.Append("  userAssignedIdentity: ");
                    if (UserAssignedIdentity.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{UserAssignedIdentity}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{UserAssignedIdentity}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CustomJwtAuthenticationManagedIdentity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomJwtAuthenticationManagedIdentity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CustomJwtAuthenticationManagedIdentity)} does not support writing '{options.Format}' format.");
            }
        }

        CustomJwtAuthenticationManagedIdentity IPersistableModel<CustomJwtAuthenticationManagedIdentity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomJwtAuthenticationManagedIdentity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCustomJwtAuthenticationManagedIdentity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomJwtAuthenticationManagedIdentity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomJwtAuthenticationManagedIdentity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
