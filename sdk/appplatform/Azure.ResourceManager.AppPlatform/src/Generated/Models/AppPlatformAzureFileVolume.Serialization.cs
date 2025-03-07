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
    public partial class AppPlatformAzureFileVolume : IUtf8JsonSerializable, IJsonModel<AppPlatformAzureFileVolume>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformAzureFileVolume>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppPlatformAzureFileVolume>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformAzureFileVolume>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformAzureFileVolume)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("shareName"u8);
            writer.WriteStringValue(ShareName);
        }

        AppPlatformAzureFileVolume IJsonModel<AppPlatformAzureFileVolume>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformAzureFileVolume>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformAzureFileVolume)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformAzureFileVolume(document.RootElement, options);
        }

        internal static AppPlatformAzureFileVolume DeserializeAppPlatformAzureFileVolume(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string shareName = default;
            UnderlyingResourceType type = default;
            string mountPath = default;
            bool? readOnly = default;
            IList<string> mountOptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("shareName"u8))
                {
                    shareName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new UnderlyingResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mountPath"u8))
                {
                    mountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("readOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("mountOptions"u8))
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
                    mountOptions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppPlatformAzureFileVolume(
                type,
                mountPath,
                readOnly,
                mountOptions ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData,
                shareName);
        }

        BinaryData IPersistableModel<AppPlatformAzureFileVolume>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformAzureFileVolume>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformAzureFileVolume)} does not support writing '{options.Format}' format.");
            }
        }

        AppPlatformAzureFileVolume IPersistableModel<AppPlatformAzureFileVolume>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformAzureFileVolume>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAppPlatformAzureFileVolume(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformAzureFileVolume)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformAzureFileVolume>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
