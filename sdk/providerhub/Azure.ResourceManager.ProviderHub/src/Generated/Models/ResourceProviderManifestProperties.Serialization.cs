// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ResourceProviderManifestProperties : IUtf8JsonSerializable, IJsonModel<ResourceProviderManifestProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceProviderManifestProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ResourceProviderManifestProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceProviderManifestProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceProviderManifestProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ProviderAuthentication))
            {
                writer.WritePropertyName("providerAuthentication"u8);
                writer.WriteObjectValue(ProviderAuthentication, options);
            }
            if (Optional.IsCollectionDefined(ProviderAuthorizations))
            {
                writer.WritePropertyName("providerAuthorizations"u8);
                writer.WriteStartArray();
                foreach (var item in ProviderAuthorizations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Namespace))
            {
                writer.WritePropertyName("namespace"u8);
                writer.WriteStringValue(Namespace);
            }
            if (Optional.IsDefined(ProviderVersion))
            {
                writer.WritePropertyName("providerVersion"u8);
                writer.WriteStringValue(ProviderVersion);
            }
            if (Optional.IsDefined(ProviderType))
            {
                writer.WritePropertyName("providerType"u8);
                writer.WriteStringValue(ProviderType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(RequiredFeatures))
            {
                writer.WritePropertyName("requiredFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredFeatures)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FeaturesRule))
            {
                writer.WritePropertyName("featuresRule"u8);
                writer.WriteObjectValue(FeaturesRule, options);
            }
            if (Optional.IsDefined(RequestHeaderOptions))
            {
                writer.WritePropertyName("requestHeaderOptions"u8);
                writer.WriteObjectValue(RequestHeaderOptions, options);
            }
            if (Optional.IsDefined(Management))
            {
                writer.WritePropertyName("management"u8);
                writer.WriteObjectValue(Management, options);
            }
            if (Optional.IsCollectionDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStartArray();
                foreach (var item in Capabilities)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                using (JsonDocument document = JsonDocument.Parse(Metadata, ModelSerializationExtensions.JsonDocumentOptions))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(TemplateDeploymentOptions))
            {
                writer.WritePropertyName("templateDeploymentOptions"u8);
                writer.WriteObjectValue(TemplateDeploymentOptions, options);
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

        ResourceProviderManifestProperties IJsonModel<ResourceProviderManifestProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceProviderManifestProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceProviderManifestProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceProviderManifestProperties(document.RootElement, options);
        }

        internal static ResourceProviderManifestProperties DeserializeResourceProviderManifestProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceProviderAuthentication providerAuthentication = default;
            IList<ResourceProviderAuthorization> providerAuthorizations = default;
            string @namespace = default;
            string providerVersion = default;
            ResourceProviderType? providerType = default;
            IList<string> requiredFeatures = default;
            FeaturesRule featuresRule = default;
            RequestHeaderOptions requestHeaderOptions = default;
            ResourceProviderManagement management = default;
            IList<ResourceProviderCapabilities> capabilities = default;
            BinaryData metadata = default;
            TemplateDeploymentOptions templateDeploymentOptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("providerAuthentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerAuthentication = ResourceProviderAuthentication.DeserializeResourceProviderAuthentication(property.Value, options);
                    continue;
                }
                if (property.NameEquals("providerAuthorizations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceProviderAuthorization> array = new List<ResourceProviderAuthorization>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceProviderAuthorization.DeserializeResourceProviderAuthorization(item, options));
                    }
                    providerAuthorizations = array;
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerVersion"u8))
                {
                    providerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerType = new ResourceProviderType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("requiredFeatures"u8))
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
                    requiredFeatures = array;
                    continue;
                }
                if (property.NameEquals("featuresRule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    featuresRule = FeaturesRule.DeserializeFeaturesRule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("requestHeaderOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestHeaderOptions = RequestHeaderOptions.DeserializeRequestHeaderOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("management"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    management = ResourceProviderManagement.DeserializeResourceProviderManagement(property.Value, options);
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceProviderCapabilities> array = new List<ResourceProviderCapabilities>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceProviderCapabilities.DeserializeResourceProviderCapabilities(item, options));
                    }
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("templateDeploymentOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    templateDeploymentOptions = TemplateDeploymentOptions.DeserializeTemplateDeploymentOptions(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ResourceProviderManifestProperties(
                providerAuthentication,
                providerAuthorizations ?? new ChangeTrackingList<ResourceProviderAuthorization>(),
                @namespace,
                providerVersion,
                providerType,
                requiredFeatures ?? new ChangeTrackingList<string>(),
                featuresRule,
                requestHeaderOptions,
                management,
                capabilities ?? new ChangeTrackingList<ResourceProviderCapabilities>(),
                metadata,
                templateDeploymentOptions,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceProviderManifestProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceProviderManifestProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceProviderManifestProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ResourceProviderManifestProperties IPersistableModel<ResourceProviderManifestProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceProviderManifestProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeResourceProviderManifestProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceProviderManifestProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceProviderManifestProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
