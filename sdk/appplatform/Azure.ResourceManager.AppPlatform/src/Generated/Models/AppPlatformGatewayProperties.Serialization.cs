// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformGatewayProperties : IUtf8JsonSerializable, IJsonModel<AppPlatformGatewayProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformGatewayProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppPlatformGatewayProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformGatewayProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformGatewayProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(IsPublic))
            {
                writer.WritePropertyName("public"u8);
                writer.WriteBooleanValue(IsPublic.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (Optional.IsDefined(IsHttpsOnly))
            {
                writer.WritePropertyName("httpsOnly"u8);
                writer.WriteBooleanValue(IsHttpsOnly.Value);
            }
            if (Optional.IsDefined(SsoProperties))
            {
                writer.WritePropertyName("ssoProperties"u8);
                writer.WriteObjectValue(SsoProperties, options);
            }
            if (Optional.IsDefined(ApiMetadataProperties))
            {
                writer.WritePropertyName("apiMetadataProperties"u8);
                writer.WriteObjectValue(ApiMetadataProperties, options);
            }
            if (Optional.IsDefined(CorsProperties))
            {
                writer.WritePropertyName("corsProperties"u8);
                writer.WriteObjectValue(CorsProperties, options);
            }
            if (Optional.IsDefined(ResourceRequests))
            {
                writer.WritePropertyName("resourceRequests"u8);
                writer.WriteObjectValue(ResourceRequests, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Instances))
            {
                writer.WritePropertyName("instances"u8);
                writer.WriteStartArray();
                foreach (var item in Instances)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(OperatorProperties))
            {
                writer.WritePropertyName("operatorProperties"u8);
                writer.WriteObjectValue(OperatorProperties, options);
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

        AppPlatformGatewayProperties IJsonModel<AppPlatformGatewayProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformGatewayProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformGatewayProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformGatewayProperties(document.RootElement, options);
        }

        internal static AppPlatformGatewayProperties DeserializeAppPlatformGatewayProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AppPlatformGatewayProvisioningState? provisioningState = default;
            bool? @public = default;
            Uri uri = default;
            bool? httpsOnly = default;
            AppPlatformSsoProperties ssoProperties = default;
            AppPlatformGatewayApiMetadataProperties apiMetadataProperties = default;
            AppPlatformGatewayCorsProperties corsProperties = default;
            AppPlatformGatewayResourceRequirements resourceRequests = default;
            IReadOnlyList<AppPlatformGatewayInstance> instances = default;
            AppPlatformGatewayOperatorProperties operatorProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AppPlatformGatewayProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("public"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @public = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("httpsOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpsOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ssoProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ssoProperties = AppPlatformSsoProperties.DeserializeAppPlatformSsoProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("apiMetadataProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    apiMetadataProperties = AppPlatformGatewayApiMetadataProperties.DeserializeAppPlatformGatewayApiMetadataProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("corsProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    corsProperties = AppPlatformGatewayCorsProperties.DeserializeAppPlatformGatewayCorsProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resourceRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceRequests = AppPlatformGatewayResourceRequirements.DeserializeAppPlatformGatewayResourceRequirements(property.Value, options);
                    continue;
                }
                if (property.NameEquals("instances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformGatewayInstance> array = new List<AppPlatformGatewayInstance>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformGatewayInstance.DeserializeAppPlatformGatewayInstance(item, options));
                    }
                    instances = array;
                    continue;
                }
                if (property.NameEquals("operatorProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operatorProperties = AppPlatformGatewayOperatorProperties.DeserializeAppPlatformGatewayOperatorProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppPlatformGatewayProperties(
                provisioningState,
                @public,
                uri,
                httpsOnly,
                ssoProperties,
                apiMetadataProperties,
                corsProperties,
                resourceRequests,
                instances ?? new ChangeTrackingList<AppPlatformGatewayInstance>(),
                operatorProperties,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformGatewayProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformGatewayProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformGatewayProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AppPlatformGatewayProperties IPersistableModel<AppPlatformGatewayProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformGatewayProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAppPlatformGatewayProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformGatewayProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformGatewayProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
