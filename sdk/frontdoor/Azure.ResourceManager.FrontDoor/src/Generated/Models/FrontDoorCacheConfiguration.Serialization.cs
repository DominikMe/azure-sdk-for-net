// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class FrontDoorCacheConfiguration : IUtf8JsonSerializable, IJsonModel<FrontDoorCacheConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FrontDoorCacheConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FrontDoorCacheConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorCacheConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorCacheConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(QueryParameterStripDirective))
            {
                writer.WritePropertyName("queryParameterStripDirective"u8);
                writer.WriteStringValue(QueryParameterStripDirective.Value.ToString());
            }
            if (Optional.IsDefined(QueryParameters))
            {
                writer.WritePropertyName("queryParameters"u8);
                writer.WriteStringValue(QueryParameters);
            }
            if (Optional.IsDefined(DynamicCompression))
            {
                writer.WritePropertyName("dynamicCompression"u8);
                writer.WriteStringValue(DynamicCompression.Value.ToString());
            }
            if (Optional.IsDefined(CacheDuration))
            {
                writer.WritePropertyName("cacheDuration"u8);
                writer.WriteStringValue(CacheDuration.Value, "P");
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

        FrontDoorCacheConfiguration IJsonModel<FrontDoorCacheConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorCacheConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorCacheConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFrontDoorCacheConfiguration(document.RootElement, options);
        }

        internal static FrontDoorCacheConfiguration DeserializeFrontDoorCacheConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FrontDoorQuery? queryParameterStripDirective = default;
            string queryParameters = default;
            DynamicCompressionEnabled? dynamicCompression = default;
            TimeSpan? cacheDuration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryParameterStripDirective"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryParameterStripDirective = new FrontDoorQuery(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queryParameters"u8))
                {
                    queryParameters = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dynamicCompression"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dynamicCompression = new DynamicCompressionEnabled(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cacheDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cacheDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FrontDoorCacheConfiguration(queryParameterStripDirective, queryParameters, dynamicCompression, cacheDuration, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FrontDoorCacheConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorCacheConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FrontDoorCacheConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        FrontDoorCacheConfiguration IPersistableModel<FrontDoorCacheConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorCacheConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFrontDoorCacheConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FrontDoorCacheConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FrontDoorCacheConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
