// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    internal partial class UnknownCustomDomainHttpsParameters : IUtf8JsonSerializable, IJsonModel<CustomDomainHttpsContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomDomainHttpsContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CustomDomainHttpsContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomDomainHttpsContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomDomainHttpsContent)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        CustomDomainHttpsContent IJsonModel<CustomDomainHttpsContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomDomainHttpsContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomDomainHttpsContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomDomainHttpsContent(document.RootElement, options);
        }

        internal static UnknownCustomDomainHttpsParameters DeserializeUnknownCustomDomainHttpsParameters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CertificateSource certificateSource = "Unknown";
            SecureDeliveryProtocolType protocolType = default;
            CdnMinimumTlsVersion? minimumTlsVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateSource"u8))
                {
                    certificateSource = new CertificateSource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protocolType"u8))
                {
                    protocolType = new SecureDeliveryProtocolType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("minimumTlsVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimumTlsVersion = property.Value.GetString().ToCdnMinimumTlsVersion();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownCustomDomainHttpsParameters(certificateSource, protocolType, minimumTlsVersion, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CustomDomainHttpsContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomDomainHttpsContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CustomDomainHttpsContent)} does not support writing '{options.Format}' format.");
            }
        }

        CustomDomainHttpsContent IPersistableModel<CustomDomainHttpsContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomDomainHttpsContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCustomDomainHttpsContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomDomainHttpsContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomDomainHttpsContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
