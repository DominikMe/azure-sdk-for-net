// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaJobInputHttp : IUtf8JsonSerializable, IJsonModel<MediaJobInputHttp>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaJobInputHttp>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MediaJobInputHttp>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobInputHttp>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaJobInputHttp)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(BaseUri))
            {
                writer.WritePropertyName("baseUri"u8);
                writer.WriteStringValue(BaseUri.AbsoluteUri);
            }
        }

        MediaJobInputHttp IJsonModel<MediaJobInputHttp>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobInputHttp>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaJobInputHttp)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaJobInputHttp(document.RootElement, options);
        }

        internal static MediaJobInputHttp DeserializeMediaJobInputHttp(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri baseUri = default;
            IList<string> files = default;
            ClipTime start = default;
            ClipTime end = default;
            string label = default;
            IList<MediaJobInputDefinition> inputDefinitions = default;
            string odataType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("baseUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    baseUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("files"u8))
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
                    files = array;
                    continue;
                }
                if (property.NameEquals("start"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    start = ClipTime.DeserializeClipTime(property.Value, options);
                    continue;
                }
                if (property.NameEquals("end"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    end = ClipTime.DeserializeClipTime(property.Value, options);
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputDefinitions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaJobInputDefinition> array = new List<MediaJobInputDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaJobInputDefinition.DeserializeMediaJobInputDefinition(item, options));
                    }
                    inputDefinitions = array;
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MediaJobInputHttp(
                odataType,
                serializedAdditionalRawData,
                files ?? new ChangeTrackingList<string>(),
                start,
                end,
                label,
                inputDefinitions ?? new ChangeTrackingList<MediaJobInputDefinition>(),
                baseUri);
        }

        BinaryData IPersistableModel<MediaJobInputHttp>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobInputHttp>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MediaJobInputHttp)} does not support writing '{options.Format}' format.");
            }
        }

        MediaJobInputHttp IPersistableModel<MediaJobInputHttp>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobInputHttp>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMediaJobInputHttp(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MediaJobInputHttp)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaJobInputHttp>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
