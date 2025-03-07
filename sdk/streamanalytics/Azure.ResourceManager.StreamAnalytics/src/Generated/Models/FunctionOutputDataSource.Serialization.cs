// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class FunctionOutputDataSource : IUtf8JsonSerializable, IJsonModel<FunctionOutputDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FunctionOutputDataSource>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FunctionOutputDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FunctionOutputDataSource)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(FunctionAppName))
            {
                writer.WritePropertyName("functionAppName"u8);
                writer.WriteStringValue(FunctionAppName);
            }
            if (Optional.IsDefined(FunctionName))
            {
                writer.WritePropertyName("functionName"u8);
                writer.WriteStringValue(FunctionName);
            }
            if (Optional.IsDefined(ApiKey))
            {
                writer.WritePropertyName("apiKey"u8);
                writer.WriteStringValue(ApiKey);
            }
            if (Optional.IsDefined(MaxBatchSize))
            {
                writer.WritePropertyName("maxBatchSize"u8);
                writer.WriteNumberValue(MaxBatchSize.Value);
            }
            if (Optional.IsDefined(MaxBatchCount))
            {
                writer.WritePropertyName("maxBatchCount"u8);
                writer.WriteNumberValue(MaxBatchCount.Value);
            }
            writer.WriteEndObject();
        }

        FunctionOutputDataSource IJsonModel<FunctionOutputDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FunctionOutputDataSource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFunctionOutputDataSource(document.RootElement, options);
        }

        internal static FunctionOutputDataSource DeserializeFunctionOutputDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            string functionAppName = default;
            string functionName = default;
            string apiKey = default;
            int? maxBatchSize = default;
            int? maxBatchCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("functionAppName"u8))
                        {
                            functionAppName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("functionName"u8))
                        {
                            functionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("apiKey"u8))
                        {
                            apiKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maxBatchSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxBatchSize = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxBatchCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxBatchCount = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FunctionOutputDataSource(
                type,
                serializedAdditionalRawData,
                functionAppName,
                functionName,
                apiKey,
                maxBatchSize,
                maxBatchCount);
        }

        BinaryData IPersistableModel<FunctionOutputDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FunctionOutputDataSource)} does not support writing '{options.Format}' format.");
            }
        }

        FunctionOutputDataSource IPersistableModel<FunctionOutputDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFunctionOutputDataSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FunctionOutputDataSource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FunctionOutputDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
