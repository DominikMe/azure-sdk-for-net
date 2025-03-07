// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text.Authoring
{
    public partial class ExportedCustomAbstractiveSummarizationProjectAsset : IUtf8JsonSerializable, IJsonModel<ExportedCustomAbstractiveSummarizationProjectAsset>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExportedCustomAbstractiveSummarizationProjectAsset>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExportedCustomAbstractiveSummarizationProjectAsset>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportedCustomAbstractiveSummarizationProjectAsset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportedCustomAbstractiveSummarizationProjectAsset)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsCollectionDefined(Documents))
            {
                writer.WritePropertyName("documents"u8);
                writer.WriteStartArray();
                foreach (var item in Documents)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
        }

        ExportedCustomAbstractiveSummarizationProjectAsset IJsonModel<ExportedCustomAbstractiveSummarizationProjectAsset>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportedCustomAbstractiveSummarizationProjectAsset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportedCustomAbstractiveSummarizationProjectAsset)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExportedCustomAbstractiveSummarizationProjectAsset(document.RootElement, options);
        }

        internal static ExportedCustomAbstractiveSummarizationProjectAsset DeserializeExportedCustomAbstractiveSummarizationProjectAsset(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ExportedCustomAbstractiveSummarizationDocument> documents = default;
            TextAuthoringProjectKind projectKind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExportedCustomAbstractiveSummarizationDocument> array = new List<ExportedCustomAbstractiveSummarizationDocument>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExportedCustomAbstractiveSummarizationDocument.DeserializeExportedCustomAbstractiveSummarizationDocument(item, options));
                    }
                    documents = array;
                    continue;
                }
                if (property.NameEquals("projectKind"u8))
                {
                    projectKind = new TextAuthoringProjectKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExportedCustomAbstractiveSummarizationProjectAsset(projectKind, serializedAdditionalRawData, documents ?? new ChangeTrackingList<ExportedCustomAbstractiveSummarizationDocument>());
        }

        BinaryData IPersistableModel<ExportedCustomAbstractiveSummarizationProjectAsset>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportedCustomAbstractiveSummarizationProjectAsset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExportedCustomAbstractiveSummarizationProjectAsset)} does not support writing '{options.Format}' format.");
            }
        }

        ExportedCustomAbstractiveSummarizationProjectAsset IPersistableModel<ExportedCustomAbstractiveSummarizationProjectAsset>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportedCustomAbstractiveSummarizationProjectAsset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeExportedCustomAbstractiveSummarizationProjectAsset(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExportedCustomAbstractiveSummarizationProjectAsset)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExportedCustomAbstractiveSummarizationProjectAsset>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new ExportedCustomAbstractiveSummarizationProjectAsset FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeExportedCustomAbstractiveSummarizationProjectAsset(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
