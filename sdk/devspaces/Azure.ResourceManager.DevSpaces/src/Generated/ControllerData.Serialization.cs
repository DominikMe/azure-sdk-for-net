// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevSpaces.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevSpaces
{
    public partial class ControllerData : IUtf8JsonSerializable, IJsonModel<ControllerData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ControllerData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ControllerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ControllerData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ControllerData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(HostSuffix))
            {
                writer.WritePropertyName("hostSuffix"u8);
                writer.WriteStringValue(HostSuffix);
            }
            if (options.Format != "W" && Optional.IsDefined(DataPlaneFqdn))
            {
                writer.WritePropertyName("dataPlaneFqdn"u8);
                writer.WriteStringValue(DataPlaneFqdn);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetContainerHostApiServerFqdn))
            {
                writer.WritePropertyName("targetContainerHostApiServerFqdn"u8);
                writer.WriteStringValue(TargetContainerHostApiServerFqdn);
            }
            writer.WritePropertyName("targetContainerHostResourceId"u8);
            writer.WriteStringValue(TargetContainerHostResourceId);
            writer.WritePropertyName("targetContainerHostCredentialsBase64"u8);
            writer.WriteStringValue(TargetContainerHostCredentialsBase64);
            writer.WriteEndObject();
        }

        ControllerData IJsonModel<ControllerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ControllerData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ControllerData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeControllerData(document.RootElement, options);
        }

        internal static ControllerData DeserializeControllerData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DevSpacesSku sku = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            ProvisioningState? provisioningState = default;
            string hostSuffix = default;
            string dataPlaneFqdn = default;
            string targetContainerHostApiServerFqdn = default;
            string targetContainerHostResourceId = default;
            string targetContainerHostCredentialsBase64 = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = DevSpacesSku.DeserializeDevSpacesSku(property.Value, options);
                    continue;
                }
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("hostSuffix"u8))
                        {
                            hostSuffix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataPlaneFqdn"u8))
                        {
                            dataPlaneFqdn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetContainerHostApiServerFqdn"u8))
                        {
                            targetContainerHostApiServerFqdn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetContainerHostResourceId"u8))
                        {
                            targetContainerHostResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetContainerHostCredentialsBase64"u8))
                        {
                            targetContainerHostCredentialsBase64 = property0.Value.GetString();
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
            return new ControllerData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                sku,
                provisioningState,
                hostSuffix,
                dataPlaneFqdn,
                targetContainerHostApiServerFqdn,
                targetContainerHostResourceId,
                targetContainerHostCredentialsBase64,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ControllerData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ControllerData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ControllerData)} does not support writing '{options.Format}' format.");
            }
        }

        ControllerData IPersistableModel<ControllerData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ControllerData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeControllerData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ControllerData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ControllerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
