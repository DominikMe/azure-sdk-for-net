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
    public partial class HyperVReplicaBaseReplicationDetails : IUtf8JsonSerializable, IJsonModel<HyperVReplicaBaseReplicationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HyperVReplicaBaseReplicationDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HyperVReplicaBaseReplicationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaBaseReplicationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVReplicaBaseReplicationDetails)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(LastReplicatedOn))
            {
                writer.WritePropertyName("lastReplicatedTime"u8);
                writer.WriteStringValue(LastReplicatedOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(VmNics))
            {
                writer.WritePropertyName("vmNics"u8);
                writer.WriteStartArray();
                foreach (var item in VmNics)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(VmId))
            {
                writer.WritePropertyName("vmId"u8);
                writer.WriteStringValue(VmId);
            }
            if (Optional.IsDefined(VmProtectionState))
            {
                writer.WritePropertyName("vmProtectionState"u8);
                writer.WriteStringValue(VmProtectionState);
            }
            if (Optional.IsDefined(VmProtectionStateDescription))
            {
                writer.WritePropertyName("vmProtectionStateDescription"u8);
                writer.WriteStringValue(VmProtectionStateDescription);
            }
            if (Optional.IsDefined(InitialReplicationDetails))
            {
                writer.WritePropertyName("initialReplicationDetails"u8);
                writer.WriteObjectValue(InitialReplicationDetails, options);
            }
            if (Optional.IsCollectionDefined(VmDiskDetails))
            {
                writer.WritePropertyName("vMDiskDetails"u8);
                writer.WriteStartArray();
                foreach (var item in VmDiskDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
        }

        HyperVReplicaBaseReplicationDetails IJsonModel<HyperVReplicaBaseReplicationDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaBaseReplicationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVReplicaBaseReplicationDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVReplicaBaseReplicationDetails(document.RootElement, options);
        }

        internal static HyperVReplicaBaseReplicationDetails DeserializeHyperVReplicaBaseReplicationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? lastReplicatedTime = default;
            IReadOnlyList<VmNicDetails> vmNics = default;
            string vmId = default;
            string vmProtectionState = default;
            string vmProtectionStateDescription = default;
            InitialReplicationDetails initialReplicationDetails = default;
            IReadOnlyList<SiteRecoveryDiskDetails> vmDiskDetails = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastReplicatedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastReplicatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("vmNics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VmNicDetails> array = new List<VmNicDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VmNicDetails.DeserializeVmNicDetails(item, options));
                    }
                    vmNics = array;
                    continue;
                }
                if (property.NameEquals("vmId"u8))
                {
                    vmId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmProtectionState"u8))
                {
                    vmProtectionState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmProtectionStateDescription"u8))
                {
                    vmProtectionStateDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialReplicationDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialReplicationDetails = InitialReplicationDetails.DeserializeInitialReplicationDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("vMDiskDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryDiskDetails> array = new List<SiteRecoveryDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryDiskDetails.DeserializeSiteRecoveryDiskDetails(item, options));
                    }
                    vmDiskDetails = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HyperVReplicaBaseReplicationDetails(
                instanceType,
                serializedAdditionalRawData,
                lastReplicatedTime,
                vmNics ?? new ChangeTrackingList<VmNicDetails>(),
                vmId,
                vmProtectionState,
                vmProtectionStateDescription,
                initialReplicationDetails,
                vmDiskDetails ?? new ChangeTrackingList<SiteRecoveryDiskDetails>());
        }

        BinaryData IPersistableModel<HyperVReplicaBaseReplicationDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaBaseReplicationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HyperVReplicaBaseReplicationDetails)} does not support writing '{options.Format}' format.");
            }
        }

        HyperVReplicaBaseReplicationDetails IPersistableModel<HyperVReplicaBaseReplicationDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaBaseReplicationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHyperVReplicaBaseReplicationDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HyperVReplicaBaseReplicationDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HyperVReplicaBaseReplicationDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
