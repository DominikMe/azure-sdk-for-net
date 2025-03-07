// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dns.Models
{
    public partial class DnsSoaRecordInfo : IUtf8JsonSerializable, IJsonModel<DnsSoaRecordInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DnsSoaRecordInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DnsSoaRecordInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DnsSoaRecordInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DnsSoaRecordInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Host))
            {
                writer.WritePropertyName("host"u8);
                writer.WriteStringValue(Host);
            }
            if (Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email"u8);
                writer.WriteStringValue(Email);
            }
            if (Optional.IsDefined(SerialNumber))
            {
                writer.WritePropertyName("serialNumber"u8);
                writer.WriteNumberValue(SerialNumber.Value);
            }
            if (Optional.IsDefined(RefreshTimeInSeconds))
            {
                writer.WritePropertyName("refreshTime"u8);
                writer.WriteNumberValue(RefreshTimeInSeconds.Value);
            }
            if (Optional.IsDefined(RetryTimeInSeconds))
            {
                writer.WritePropertyName("retryTime"u8);
                writer.WriteNumberValue(RetryTimeInSeconds.Value);
            }
            if (Optional.IsDefined(ExpireTimeInSeconds))
            {
                writer.WritePropertyName("expireTime"u8);
                writer.WriteNumberValue(ExpireTimeInSeconds.Value);
            }
            if (Optional.IsDefined(MinimumTtlInSeconds))
            {
                writer.WritePropertyName("minimumTTL"u8);
                writer.WriteNumberValue(MinimumTtlInSeconds.Value);
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

        DnsSoaRecordInfo IJsonModel<DnsSoaRecordInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DnsSoaRecordInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DnsSoaRecordInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDnsSoaRecordInfo(document.RootElement, options);
        }

        internal static DnsSoaRecordInfo DeserializeDnsSoaRecordInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string host = default;
            string email = default;
            long? serialNumber = default;
            long? refreshTime = default;
            long? retryTime = default;
            long? expireTime = default;
            long? minimumTTL = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("host"u8))
                {
                    host = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("email"u8))
                {
                    email = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serialNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serialNumber = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("refreshTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    refreshTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("retryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retryTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("expireTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expireTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("minimumTTL"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimumTTL = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DnsSoaRecordInfo(
                host,
                email,
                serialNumber,
                refreshTime,
                retryTime,
                expireTime,
                minimumTTL,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DnsSoaRecordInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DnsSoaRecordInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DnsSoaRecordInfo)} does not support writing '{options.Format}' format.");
            }
        }

        DnsSoaRecordInfo IPersistableModel<DnsSoaRecordInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DnsSoaRecordInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDnsSoaRecordInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DnsSoaRecordInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DnsSoaRecordInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
