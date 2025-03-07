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
    public partial class H264Video : IUtf8JsonSerializable, IJsonModel<H264Video>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<H264Video>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<H264Video>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<H264Video>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(H264Video)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Complexity))
            {
                writer.WritePropertyName("complexity"u8);
                writer.WriteStringValue(Complexity.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Layers))
            {
                writer.WritePropertyName("layers"u8);
                writer.WriteStartArray();
                foreach (var item in Layers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RateControlMode))
            {
                writer.WritePropertyName("rateControlMode"u8);
                writer.WriteStringValue(RateControlMode.Value.ToString());
            }
            if (Optional.IsDefined(UseSceneChangeDetection))
            {
                writer.WritePropertyName("sceneChangeDetection"u8);
                writer.WriteBooleanValue(UseSceneChangeDetection.Value);
            }
        }

        H264Video IJsonModel<H264Video>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<H264Video>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(H264Video)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeH264Video(document.RootElement, options);
        }

        internal static H264Video DeserializeH264Video(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            H264Complexity? complexity = default;
            IList<H264Layer> layers = default;
            H264RateControlMode? rateControlMode = default;
            bool? sceneChangeDetection = default;
            TimeSpan? keyFrameInterval = default;
            InputVideoStretchMode? stretchMode = default;
            VideoSyncMode? syncMode = default;
            string odataType = default;
            string label = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("complexity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    complexity = new H264Complexity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("layers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<H264Layer> array = new List<H264Layer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(H264Layer.DeserializeH264Layer(item, options));
                    }
                    layers = array;
                    continue;
                }
                if (property.NameEquals("rateControlMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rateControlMode = new H264RateControlMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sceneChangeDetection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sceneChangeDetection = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("keyFrameInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyFrameInterval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("stretchMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stretchMode = new InputVideoStretchMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("syncMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    syncMode = new VideoSyncMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new H264Video(
                odataType,
                label,
                serializedAdditionalRawData,
                keyFrameInterval,
                stretchMode,
                syncMode,
                complexity,
                layers ?? new ChangeTrackingList<H264Layer>(),
                rateControlMode,
                sceneChangeDetection);
        }

        BinaryData IPersistableModel<H264Video>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<H264Video>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(H264Video)} does not support writing '{options.Format}' format.");
            }
        }

        H264Video IPersistableModel<H264Video>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<H264Video>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeH264Video(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(H264Video)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<H264Video>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
