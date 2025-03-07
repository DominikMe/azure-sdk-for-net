// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SpringAppDiscovery.Models
{
    public partial class SpringBootSiteProperties : IUtf8JsonSerializable, IJsonModel<SpringBootSiteProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SpringBootSiteProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SpringBootSiteProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootSiteProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SpringBootSiteProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(MasterSiteId))
            {
                writer.WritePropertyName("masterSiteId"u8);
                writer.WriteStringValue(MasterSiteId);
            }
            if (Optional.IsDefined(MigrateProjectId))
            {
                writer.WritePropertyName("migrateProjectId"u8);
                writer.WriteStringValue(MigrateProjectId);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        SpringBootSiteProperties IJsonModel<SpringBootSiteProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootSiteProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SpringBootSiteProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSpringBootSiteProperties(document.RootElement, options);
        }

        internal static SpringBootSiteProperties DeserializeSpringBootSiteProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string masterSiteId = default;
            string migrateProjectId = default;
            SpringAppDiscoveryProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("masterSiteId"u8))
                {
                    masterSiteId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrateProjectId"u8))
                {
                    migrateProjectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new SpringAppDiscoveryProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SpringBootSiteProperties(masterSiteId, migrateProjectId, provisioningState, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SpringBootSiteProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootSiteProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SpringBootSiteProperties)} does not support writing '{options.Format}' format.");
            }
        }

        SpringBootSiteProperties IPersistableModel<SpringBootSiteProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootSiteProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSpringBootSiteProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SpringBootSiteProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SpringBootSiteProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
