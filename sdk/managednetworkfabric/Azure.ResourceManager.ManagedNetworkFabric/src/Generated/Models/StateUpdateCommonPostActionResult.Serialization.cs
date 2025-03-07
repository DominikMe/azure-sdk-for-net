// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class StateUpdateCommonPostActionResult : IUtf8JsonSerializable, IJsonModel<StateUpdateCommonPostActionResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StateUpdateCommonPostActionResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StateUpdateCommonPostActionResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StateUpdateCommonPostActionResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StateUpdateCommonPostActionResult)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(ConfigurationState))
            {
                writer.WritePropertyName("configurationState"u8);
                writer.WriteStringValue(ConfigurationState.Value.ToString());
            }
        }

        StateUpdateCommonPostActionResult IJsonModel<StateUpdateCommonPostActionResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StateUpdateCommonPostActionResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StateUpdateCommonPostActionResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStateUpdateCommonPostActionResult(document.RootElement, options);
        }

        internal static StateUpdateCommonPostActionResult DeserializeStateUpdateCommonPostActionResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NetworkFabricConfigurationState? configurationState = default;
            ResponseError error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("configurationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configurationState = new NetworkFabricConfigurationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StateUpdateCommonPostActionResult(error, serializedAdditionalRawData, configurationState);
        }

        BinaryData IPersistableModel<StateUpdateCommonPostActionResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StateUpdateCommonPostActionResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StateUpdateCommonPostActionResult)} does not support writing '{options.Format}' format.");
            }
        }

        StateUpdateCommonPostActionResult IPersistableModel<StateUpdateCommonPostActionResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StateUpdateCommonPostActionResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStateUpdateCommonPostActionResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StateUpdateCommonPostActionResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StateUpdateCommonPostActionResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
