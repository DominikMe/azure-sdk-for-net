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
    public partial class UserManagedHttpsContent : IUtf8JsonSerializable, IJsonModel<UserManagedHttpsContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UserManagedHttpsContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UserManagedHttpsContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserManagedHttpsContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserManagedHttpsContent)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("certificateSourceParameters"u8);
            writer.WriteObjectValue(CertificateSourceParameters, options);
        }

        UserManagedHttpsContent IJsonModel<UserManagedHttpsContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserManagedHttpsContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserManagedHttpsContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUserManagedHttpsContent(document.RootElement, options);
        }

        internal static UserManagedHttpsContent DeserializeUserManagedHttpsContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            KeyVaultCertificateSource certificateSourceParameters = default;
            CertificateSource certificateSource = default;
            SecureDeliveryProtocolType protocolType = default;
            CdnMinimumTlsVersion? minimumTlsVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateSourceParameters"u8))
                {
                    certificateSourceParameters = KeyVaultCertificateSource.DeserializeKeyVaultCertificateSource(property.Value, options);
                    continue;
                }
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
            return new UserManagedHttpsContent(certificateSource, protocolType, minimumTlsVersion, serializedAdditionalRawData, certificateSourceParameters);
        }

        BinaryData IPersistableModel<UserManagedHttpsContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserManagedHttpsContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UserManagedHttpsContent)} does not support writing '{options.Format}' format.");
            }
        }

        UserManagedHttpsContent IPersistableModel<UserManagedHttpsContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserManagedHttpsContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeUserManagedHttpsContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UserManagedHttpsContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UserManagedHttpsContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
