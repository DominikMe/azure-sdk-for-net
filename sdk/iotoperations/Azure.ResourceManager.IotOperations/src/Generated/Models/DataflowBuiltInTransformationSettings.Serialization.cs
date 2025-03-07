// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotOperations.Models
{
    public partial class DataflowBuiltInTransformationSettings : IUtf8JsonSerializable, IJsonModel<DataflowBuiltInTransformationSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataflowBuiltInTransformationSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataflowBuiltInTransformationSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowBuiltInTransformationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataflowBuiltInTransformationSettings)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(SerializationFormat))
            {
                writer.WritePropertyName("serializationFormat"u8);
                writer.WriteStringValue(SerializationFormat.Value.ToString());
            }
            if (Optional.IsDefined(SchemaRef))
            {
                writer.WritePropertyName("schemaRef"u8);
                writer.WriteStringValue(SchemaRef);
            }
            if (Optional.IsCollectionDefined(Datasets))
            {
                writer.WritePropertyName("datasets"u8);
                writer.WriteStartArray();
                foreach (var item in Datasets)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteStartArray();
                foreach (var item in Filter)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Map))
            {
                writer.WritePropertyName("map"u8);
                writer.WriteStartArray();
                foreach (var item in Map)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        DataflowBuiltInTransformationSettings IJsonModel<DataflowBuiltInTransformationSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowBuiltInTransformationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataflowBuiltInTransformationSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataflowBuiltInTransformationSettings(document.RootElement, options);
        }

        internal static DataflowBuiltInTransformationSettings DeserializeDataflowBuiltInTransformationSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TransformationSerializationFormat? serializationFormat = default;
            string schemaRef = default;
            IList<DataflowBuiltInTransformationDataset> datasets = default;
            IList<DataflowBuiltInTransformationFilter> filter = default;
            IList<DataflowBuiltInTransformationMap> map = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serializationFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serializationFormat = new TransformationSerializationFormat(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("schemaRef"u8))
                {
                    schemaRef = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datasets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataflowBuiltInTransformationDataset> array = new List<DataflowBuiltInTransformationDataset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataflowBuiltInTransformationDataset.DeserializeDataflowBuiltInTransformationDataset(item, options));
                    }
                    datasets = array;
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataflowBuiltInTransformationFilter> array = new List<DataflowBuiltInTransformationFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataflowBuiltInTransformationFilter.DeserializeDataflowBuiltInTransformationFilter(item, options));
                    }
                    filter = array;
                    continue;
                }
                if (property.NameEquals("map"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataflowBuiltInTransformationMap> array = new List<DataflowBuiltInTransformationMap>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataflowBuiltInTransformationMap.DeserializeDataflowBuiltInTransformationMap(item, options));
                    }
                    map = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataflowBuiltInTransformationSettings(
                serializationFormat,
                schemaRef,
                datasets ?? new ChangeTrackingList<DataflowBuiltInTransformationDataset>(),
                filter ?? new ChangeTrackingList<DataflowBuiltInTransformationFilter>(),
                map ?? new ChangeTrackingList<DataflowBuiltInTransformationMap>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataflowBuiltInTransformationSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowBuiltInTransformationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataflowBuiltInTransformationSettings)} does not support writing '{options.Format}' format.");
            }
        }

        DataflowBuiltInTransformationSettings IPersistableModel<DataflowBuiltInTransformationSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowBuiltInTransformationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataflowBuiltInTransformationSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataflowBuiltInTransformationSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataflowBuiltInTransformationSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
