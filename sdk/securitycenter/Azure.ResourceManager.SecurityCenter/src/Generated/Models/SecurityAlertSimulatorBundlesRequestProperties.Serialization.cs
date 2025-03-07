// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityAlertSimulatorBundlesRequestProperties : IUtf8JsonSerializable, IJsonModel<SecurityAlertSimulatorBundlesRequestProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityAlertSimulatorBundlesRequestProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SecurityAlertSimulatorBundlesRequestProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAlertSimulatorBundlesRequestProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAlertSimulatorBundlesRequestProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsCollectionDefined(Bundles))
            {
                writer.WritePropertyName("bundles"u8);
                writer.WriteStartArray();
                foreach (var item in Bundles)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
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

        SecurityAlertSimulatorBundlesRequestProperties IJsonModel<SecurityAlertSimulatorBundlesRequestProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAlertSimulatorBundlesRequestProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAlertSimulatorBundlesRequestProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityAlertSimulatorBundlesRequestProperties(document.RootElement, options);
        }

        internal static SecurityAlertSimulatorBundlesRequestProperties DeserializeSecurityAlertSimulatorBundlesRequestProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<SecurityAlertSimulatorBundleType> bundles = default;
            SecurityCenterKind kind = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bundles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityAlertSimulatorBundleType> array = new List<SecurityAlertSimulatorBundleType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SecurityAlertSimulatorBundleType(item.GetString()));
                    }
                    bundles = array;
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new SecurityCenterKind(property.Value.GetString());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SecurityAlertSimulatorBundlesRequestProperties(kind, additionalProperties, bundles ?? new ChangeTrackingList<SecurityAlertSimulatorBundleType>());
        }

        BinaryData IPersistableModel<SecurityAlertSimulatorBundlesRequestProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAlertSimulatorBundlesRequestProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityAlertSimulatorBundlesRequestProperties)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityAlertSimulatorBundlesRequestProperties IPersistableModel<SecurityAlertSimulatorBundlesRequestProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAlertSimulatorBundlesRequestProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSecurityAlertSimulatorBundlesRequestProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityAlertSimulatorBundlesRequestProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityAlertSimulatorBundlesRequestProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
