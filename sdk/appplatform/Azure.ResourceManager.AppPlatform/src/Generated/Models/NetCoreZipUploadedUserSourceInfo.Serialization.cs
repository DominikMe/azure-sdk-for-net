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
    public partial class NetCoreZipUploadedUserSourceInfo : IUtf8JsonSerializable, IJsonModel<NetCoreZipUploadedUserSourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetCoreZipUploadedUserSourceInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetCoreZipUploadedUserSourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetCoreZipUploadedUserSourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetCoreZipUploadedUserSourceInfo)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(NetCoreMainEntryPath))
            {
                writer.WritePropertyName("netCoreMainEntryPath"u8);
                writer.WriteStringValue(NetCoreMainEntryPath);
            }
            if (Optional.IsDefined(RuntimeVersion))
            {
                writer.WritePropertyName("runtimeVersion"u8);
                writer.WriteStringValue(RuntimeVersion);
            }
        }

        NetCoreZipUploadedUserSourceInfo IJsonModel<NetCoreZipUploadedUserSourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetCoreZipUploadedUserSourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetCoreZipUploadedUserSourceInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetCoreZipUploadedUserSourceInfo(document.RootElement, options);
        }

        internal static NetCoreZipUploadedUserSourceInfo DeserializeNetCoreZipUploadedUserSourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string netCoreMainEntryPath = default;
            string runtimeVersion = default;
            string relativePath = default;
            string type = default;
            string version = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("netCoreMainEntryPath"u8))
                {
                    netCoreMainEntryPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeVersion"u8))
                {
                    runtimeVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relativePath"u8))
                {
                    relativePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NetCoreZipUploadedUserSourceInfo(
                type,
                version,
                serializedAdditionalRawData,
                relativePath,
                netCoreMainEntryPath,
                runtimeVersion);
        }

        BinaryData IPersistableModel<NetCoreZipUploadedUserSourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetCoreZipUploadedUserSourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetCoreZipUploadedUserSourceInfo)} does not support writing '{options.Format}' format.");
            }
        }

        NetCoreZipUploadedUserSourceInfo IPersistableModel<NetCoreZipUploadedUserSourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetCoreZipUploadedUserSourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNetCoreZipUploadedUserSourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetCoreZipUploadedUserSourceInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetCoreZipUploadedUserSourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
