// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ExistingRecoveryVirtualNetwork : IUtf8JsonSerializable, IJsonModel<ExistingRecoveryVirtualNetwork>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExistingRecoveryVirtualNetwork>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExistingRecoveryVirtualNetwork>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExistingRecoveryVirtualNetwork>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExistingRecoveryVirtualNetwork)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("recoveryVirtualNetworkId"u8);
            writer.WriteStringValue(RecoveryVirtualNetworkId);
            if (Optional.IsDefined(RecoverySubnetName))
            {
                writer.WritePropertyName("recoverySubnetName"u8);
                writer.WriteStringValue(RecoverySubnetName);
            }
        }

        ExistingRecoveryVirtualNetwork IJsonModel<ExistingRecoveryVirtualNetwork>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExistingRecoveryVirtualNetwork>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExistingRecoveryVirtualNetwork)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExistingRecoveryVirtualNetwork(document.RootElement, options);
        }

        internal static ExistingRecoveryVirtualNetwork DeserializeExistingRecoveryVirtualNetwork(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier recoveryVirtualNetworkId = default;
            string recoverySubnetName = default;
            string resourceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryVirtualNetworkId"u8))
                {
                    recoveryVirtualNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoverySubnetName"u8))
                {
                    recoverySubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExistingRecoveryVirtualNetwork(resourceType, serializedAdditionalRawData, recoveryVirtualNetworkId, recoverySubnetName);
        }

        BinaryData IPersistableModel<ExistingRecoveryVirtualNetwork>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExistingRecoveryVirtualNetwork>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExistingRecoveryVirtualNetwork)} does not support writing '{options.Format}' format.");
            }
        }

        ExistingRecoveryVirtualNetwork IPersistableModel<ExistingRecoveryVirtualNetwork>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExistingRecoveryVirtualNetwork>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeExistingRecoveryVirtualNetwork(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExistingRecoveryVirtualNetwork)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExistingRecoveryVirtualNetwork>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
