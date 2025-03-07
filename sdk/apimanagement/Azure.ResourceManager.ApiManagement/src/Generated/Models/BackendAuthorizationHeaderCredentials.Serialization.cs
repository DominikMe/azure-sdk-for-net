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

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class BackendAuthorizationHeaderCredentials : IUtf8JsonSerializable, IJsonModel<BackendAuthorizationHeaderCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackendAuthorizationHeaderCredentials>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BackendAuthorizationHeaderCredentials>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendAuthorizationHeaderCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackendAuthorizationHeaderCredentials)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("scheme"u8);
            writer.WriteStringValue(Scheme);
            writer.WritePropertyName("parameter"u8);
            writer.WriteStringValue(Parameter);
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

        BackendAuthorizationHeaderCredentials IJsonModel<BackendAuthorizationHeaderCredentials>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendAuthorizationHeaderCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackendAuthorizationHeaderCredentials)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackendAuthorizationHeaderCredentials(document.RootElement, options);
        }

        internal static BackendAuthorizationHeaderCredentials DeserializeBackendAuthorizationHeaderCredentials(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string scheme = default;
            string parameter = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheme"u8))
                {
                    scheme = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameter"u8))
                {
                    parameter = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BackendAuthorizationHeaderCredentials(scheme, parameter, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Scheme), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  scheme: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Scheme))
                {
                    builder.Append("  scheme: ");
                    if (Scheme.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Scheme}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Scheme}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Parameter), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  parameter: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Parameter))
                {
                    builder.Append("  parameter: ");
                    if (Parameter.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Parameter}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Parameter}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<BackendAuthorizationHeaderCredentials>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendAuthorizationHeaderCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(BackendAuthorizationHeaderCredentials)} does not support writing '{options.Format}' format.");
            }
        }

        BackendAuthorizationHeaderCredentials IPersistableModel<BackendAuthorizationHeaderCredentials>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendAuthorizationHeaderCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBackendAuthorizationHeaderCredentials(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackendAuthorizationHeaderCredentials)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackendAuthorizationHeaderCredentials>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
