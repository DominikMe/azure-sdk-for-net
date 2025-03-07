// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.InformaticaDataManagement.Models
{
    public partial class InformaticaServerlessFetchConfigProperties : IUtf8JsonSerializable, IJsonModel<InformaticaServerlessFetchConfigProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InformaticaServerlessFetchConfigProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InformaticaServerlessFetchConfigProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformaticaServerlessFetchConfigProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InformaticaServerlessFetchConfigProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Subnet))
            {
                writer.WritePropertyName("subnet"u8);
                writer.WriteStringValue(Subnet);
            }
            if (Optional.IsDefined(ApplicationType))
            {
                writer.WritePropertyName("applicationType"u8);
                writer.WriteStringValue(ApplicationType);
            }
            if (Optional.IsDefined(ResourceGroupName))
            {
                writer.WritePropertyName("resourceGroupName"u8);
                writer.WriteStringValue(ResourceGroupName);
            }
            if (Optional.IsDefined(AdvancedCustomProperties))
            {
                writer.WritePropertyName("advancedCustomProperties"u8);
                writer.WriteStringValue(AdvancedCustomProperties);
            }
            if (Optional.IsDefined(SupplementaryFileLocation))
            {
                writer.WritePropertyName("supplementaryFileLocation"u8);
                writer.WriteStringValue(SupplementaryFileLocation);
            }
            if (Optional.IsDefined(Platform))
            {
                writer.WritePropertyName("platform"u8);
                writer.WriteStringValue(Platform);
            }
            if (Optional.IsDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStringValue(Tags);
            }
            if (Optional.IsDefined(Vnet))
            {
                writer.WritePropertyName("vnet"u8);
                writer.WriteStringValue(Vnet);
            }
            if (Optional.IsDefined(ExecutionTimeout))
            {
                writer.WritePropertyName("executionTimeout"u8);
                writer.WriteStringValue(ExecutionTimeout);
            }
            if (Optional.IsDefined(ComputeUnits))
            {
                writer.WritePropertyName("computeUnits"u8);
                writer.WriteStringValue(ComputeUnits);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (Optional.IsDefined(Region))
            {
                writer.WritePropertyName("region"u8);
                writer.WriteStringValue(Region);
            }
            if (Optional.IsDefined(ServerlessArmResourceId))
            {
                writer.WritePropertyName("serverlessArmResourceId"u8);
                writer.WriteStringValue(ServerlessArmResourceId);
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

        InformaticaServerlessFetchConfigProperties IJsonModel<InformaticaServerlessFetchConfigProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformaticaServerlessFetchConfigProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InformaticaServerlessFetchConfigProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInformaticaServerlessFetchConfigProperties(document.RootElement, options);
        }

        internal static InformaticaServerlessFetchConfigProperties DeserializeInformaticaServerlessFetchConfigProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string subnet = default;
            string applicationType = default;
            string resourceGroupName = default;
            string advancedCustomProperties = default;
            string supplementaryFileLocation = default;
            string platform = default;
            string tags = default;
            string vnet = default;
            string executionTimeout = default;
            string computeUnits = default;
            Guid? tenantId = default;
            string subscriptionId = default;
            string region = default;
            ResourceIdentifier serverlessArmResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subnet"u8))
                {
                    subnet = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applicationType"u8))
                {
                    applicationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroupName"u8))
                {
                    resourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("advancedCustomProperties"u8))
                {
                    advancedCustomProperties = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supplementaryFileLocation"u8))
                {
                    supplementaryFileLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("platform"u8))
                {
                    platform = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    tags = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vnet"u8))
                {
                    vnet = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("executionTimeout"u8))
                {
                    executionTimeout = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("computeUnits"u8))
                {
                    computeUnits = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("region"u8))
                {
                    region = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverlessArmResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serverlessArmResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InformaticaServerlessFetchConfigProperties(
                subnet,
                applicationType,
                resourceGroupName,
                advancedCustomProperties,
                supplementaryFileLocation,
                platform,
                tags,
                vnet,
                executionTimeout,
                computeUnits,
                tenantId,
                subscriptionId,
                region,
                serverlessArmResourceId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InformaticaServerlessFetchConfigProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformaticaServerlessFetchConfigProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InformaticaServerlessFetchConfigProperties)} does not support writing '{options.Format}' format.");
            }
        }

        InformaticaServerlessFetchConfigProperties IPersistableModel<InformaticaServerlessFetchConfigProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformaticaServerlessFetchConfigProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeInformaticaServerlessFetchConfigProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InformaticaServerlessFetchConfigProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InformaticaServerlessFetchConfigProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
