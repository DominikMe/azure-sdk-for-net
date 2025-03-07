// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryDataFlowDebugSessionContent : IUtf8JsonSerializable, IJsonModel<DataFactoryDataFlowDebugSessionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryDataFlowDebugSessionContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataFactoryDataFlowDebugSessionContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataFlowDebugSessionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryDataFlowDebugSessionContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ComputeType))
            {
                writer.WritePropertyName("computeType"u8);
                writer.WriteStringValue(ComputeType);
            }
            if (Optional.IsDefined(CoreCount))
            {
                writer.WritePropertyName("coreCount"u8);
                writer.WriteNumberValue(CoreCount.Value);
            }
            if (Optional.IsDefined(TimeToLiveInMinutes))
            {
                writer.WritePropertyName("timeToLive"u8);
                writer.WriteNumberValue(TimeToLiveInMinutes.Value);
            }
            if (Optional.IsDefined(IntegrationRuntime))
            {
                writer.WritePropertyName("integrationRuntime"u8);
                writer.WriteObjectValue(IntegrationRuntime, options);
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

        DataFactoryDataFlowDebugSessionContent IJsonModel<DataFactoryDataFlowDebugSessionContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataFlowDebugSessionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryDataFlowDebugSessionContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryDataFlowDebugSessionContent(document.RootElement, options);
        }

        internal static DataFactoryDataFlowDebugSessionContent DeserializeDataFactoryDataFlowDebugSessionContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string computeType = default;
            int? coreCount = default;
            int? timeToLive = default;
            DataFactoryIntegrationRuntimeDebugInfo integrationRuntime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computeType"u8))
                {
                    computeType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("coreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    coreCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeToLive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeToLive = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("integrationRuntime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    integrationRuntime = DataFactoryIntegrationRuntimeDebugInfo.DeserializeDataFactoryIntegrationRuntimeDebugInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataFactoryDataFlowDebugSessionContent(computeType, coreCount, timeToLive, integrationRuntime, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataFactoryDataFlowDebugSessionContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataFlowDebugSessionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFactoryDataFlowDebugSessionContent)} does not support writing '{options.Format}' format.");
            }
        }

        DataFactoryDataFlowDebugSessionContent IPersistableModel<DataFactoryDataFlowDebugSessionContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataFlowDebugSessionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataFactoryDataFlowDebugSessionContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFactoryDataFlowDebugSessionContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryDataFlowDebugSessionContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
