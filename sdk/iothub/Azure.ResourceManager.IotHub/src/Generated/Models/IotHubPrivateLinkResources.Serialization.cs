// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    internal partial class IotHubPrivateLinkResources : IUtf8JsonSerializable, IJsonModel<IotHubPrivateLinkResources>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotHubPrivateLinkResources>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IotHubPrivateLinkResources>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubPrivateLinkResources>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubPrivateLinkResources)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
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

        IotHubPrivateLinkResources IJsonModel<IotHubPrivateLinkResources>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubPrivateLinkResources>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubPrivateLinkResources)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubPrivateLinkResources(document.RootElement, options);
        }

        internal static IotHubPrivateLinkResources DeserializeIotHubPrivateLinkResources(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<IotHubPrivateEndpointGroupInformationData> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IotHubPrivateEndpointGroupInformationData> array = new List<IotHubPrivateEndpointGroupInformationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotHubPrivateEndpointGroupInformationData.DeserializeIotHubPrivateEndpointGroupInformationData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IotHubPrivateLinkResources(value ?? new ChangeTrackingList<IotHubPrivateEndpointGroupInformationData>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotHubPrivateLinkResources>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubPrivateLinkResources>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IotHubPrivateLinkResources)} does not support writing '{options.Format}' format.");
            }
        }

        IotHubPrivateLinkResources IPersistableModel<IotHubPrivateLinkResources>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubPrivateLinkResources>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeIotHubPrivateLinkResources(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotHubPrivateLinkResources)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotHubPrivateLinkResources>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
