// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class LeaseShareContent : IUtf8JsonSerializable, IJsonModel<LeaseShareContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LeaseShareContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LeaseShareContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LeaseShareContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LeaseShareContent)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("action"u8);
            writer.WriteStringValue(Action.ToString());
            if (Optional.IsDefined(LeaseId))
            {
                writer.WritePropertyName("leaseId"u8);
                writer.WriteStringValue(LeaseId);
            }
            if (Optional.IsDefined(BreakPeriod))
            {
                writer.WritePropertyName("breakPeriod"u8);
                writer.WriteNumberValue(BreakPeriod.Value);
            }
            if (Optional.IsDefined(LeaseDuration))
            {
                writer.WritePropertyName("leaseDuration"u8);
                writer.WriteNumberValue(LeaseDuration.Value);
            }
            if (Optional.IsDefined(ProposedLeaseId))
            {
                writer.WritePropertyName("proposedLeaseId"u8);
                writer.WriteStringValue(ProposedLeaseId);
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

        LeaseShareContent IJsonModel<LeaseShareContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LeaseShareContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LeaseShareContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLeaseShareContent(document.RootElement, options);
        }

        internal static LeaseShareContent DeserializeLeaseShareContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LeaseShareAction action = default;
            string leaseId = default;
            int? breakPeriod = default;
            int? leaseDuration = default;
            string proposedLeaseId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("action"u8))
                {
                    action = new LeaseShareAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("leaseId"u8))
                {
                    leaseId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("breakPeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    breakPeriod = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("leaseDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    leaseDuration = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("proposedLeaseId"u8))
                {
                    proposedLeaseId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LeaseShareContent(
                action,
                leaseId,
                breakPeriod,
                leaseDuration,
                proposedLeaseId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LeaseShareContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LeaseShareContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LeaseShareContent)} does not support writing '{options.Format}' format.");
            }
        }

        LeaseShareContent IPersistableModel<LeaseShareContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LeaseShareContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeLeaseShareContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LeaseShareContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LeaseShareContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
