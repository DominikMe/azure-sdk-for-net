// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    internal partial class UnknownWorkloadNetworkDhcpEntity : IUtf8JsonSerializable, IJsonModel<WorkloadNetworkDhcpEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkloadNetworkDhcpEntity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WorkloadNetworkDhcpEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadNetworkDhcpEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadNetworkDhcpEntity)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        WorkloadNetworkDhcpEntity IJsonModel<WorkloadNetworkDhcpEntity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadNetworkDhcpEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadNetworkDhcpEntity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkloadNetworkDhcpEntity(document.RootElement, options);
        }

        internal static UnknownWorkloadNetworkDhcpEntity DeserializeUnknownWorkloadNetworkDhcpEntity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DhcpTypeEnum dhcpType = "Unknown";
            string displayName = default;
            IReadOnlyList<string> segments = default;
            WorkloadNetworkDhcpProvisioningState? provisioningState = default;
            long? revision = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dhcpType"u8))
                {
                    dhcpType = new DhcpTypeEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("segments"u8))
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
                    segments = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new WorkloadNetworkDhcpProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("revision"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    revision = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownWorkloadNetworkDhcpEntity(
                dhcpType,
                displayName,
                segments ?? new ChangeTrackingList<string>(),
                provisioningState,
                revision,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WorkloadNetworkDhcpEntity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadNetworkDhcpEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WorkloadNetworkDhcpEntity)} does not support writing '{options.Format}' format.");
            }
        }

        WorkloadNetworkDhcpEntity IPersistableModel<WorkloadNetworkDhcpEntity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadNetworkDhcpEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeWorkloadNetworkDhcpEntity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkloadNetworkDhcpEntity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkloadNetworkDhcpEntity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
