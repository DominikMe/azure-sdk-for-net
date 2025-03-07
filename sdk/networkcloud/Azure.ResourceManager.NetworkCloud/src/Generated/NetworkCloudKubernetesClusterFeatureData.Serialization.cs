// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    public partial class NetworkCloudKubernetesClusterFeatureData : IUtf8JsonSerializable, IJsonModel<NetworkCloudKubernetesClusterFeatureData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkCloudKubernetesClusterFeatureData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetworkCloudKubernetesClusterFeatureData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudKubernetesClusterFeatureData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudKubernetesClusterFeatureData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(AvailabilityLifecycle))
            {
                writer.WritePropertyName("availabilityLifecycle"u8);
                writer.WriteStringValue(AvailabilityLifecycle.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DetailedStatus))
            {
                writer.WritePropertyName("detailedStatus"u8);
                writer.WriteStringValue(DetailedStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DetailedStatusMessage))
            {
                writer.WritePropertyName("detailedStatusMessage"u8);
                writer.WriteStringValue(DetailedStatusMessage);
            }
            if (Optional.IsCollectionDefined(Options))
            {
                writer.WritePropertyName("options"u8);
                writer.WriteStartArray();
                foreach (var item in Options)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Required))
            {
                writer.WritePropertyName("required"u8);
                writer.WriteStringValue(Required.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            writer.WriteEndObject();
        }

        NetworkCloudKubernetesClusterFeatureData IJsonModel<NetworkCloudKubernetesClusterFeatureData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudKubernetesClusterFeatureData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudKubernetesClusterFeatureData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudKubernetesClusterFeatureData(document.RootElement, options);
        }

        internal static NetworkCloudKubernetesClusterFeatureData DeserializeNetworkCloudKubernetesClusterFeatureData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            KubernetesClusterFeatureAvailabilityLifecycle? availabilityLifecycle = default;
            KubernetesClusterFeatureDetailedStatus? detailedStatus = default;
            string detailedStatusMessage = default;
            IList<StringKeyValuePair> options0 = default;
            KubernetesClusterFeatureProvisioningState? provisioningState = default;
            KubernetesClusterFeatureRequired? required = default;
            string version = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("availabilityLifecycle"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            availabilityLifecycle = new KubernetesClusterFeatureAvailabilityLifecycle(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detailedStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            detailedStatus = new KubernetesClusterFeatureDetailedStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detailedStatusMessage"u8))
                        {
                            detailedStatusMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("options"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StringKeyValuePair> array = new List<StringKeyValuePair>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StringKeyValuePair.DeserializeStringKeyValuePair(item, options));
                            }
                            options0 = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new KubernetesClusterFeatureProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("required"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            required = new KubernetesClusterFeatureRequired(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NetworkCloudKubernetesClusterFeatureData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                availabilityLifecycle,
                detailedStatus,
                detailedStatusMessage,
                options0 ?? new ChangeTrackingList<StringKeyValuePair>(),
                provisioningState,
                required,
                version,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkCloudKubernetesClusterFeatureData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudKubernetesClusterFeatureData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudKubernetesClusterFeatureData)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkCloudKubernetesClusterFeatureData IPersistableModel<NetworkCloudKubernetesClusterFeatureData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudKubernetesClusterFeatureData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNetworkCloudKubernetesClusterFeatureData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudKubernetesClusterFeatureData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkCloudKubernetesClusterFeatureData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
