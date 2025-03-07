// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NeonPostgres.Models
{
    public partial class NeonSingleSignOnProperties : IUtf8JsonSerializable, IJsonModel<NeonSingleSignOnProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NeonSingleSignOnProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NeonSingleSignOnProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NeonSingleSignOnProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NeonSingleSignOnProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(SingleSignOnState))
            {
                writer.WritePropertyName("singleSignOnState"u8);
                writer.WriteStringValue(SingleSignOnState.Value.ToString());
            }
            if (Optional.IsDefined(EnterpriseAppId))
            {
                writer.WritePropertyName("enterpriseAppId"u8);
                writer.WriteStringValue(EnterpriseAppId);
            }
            if (Optional.IsDefined(SingleSignOnUri))
            {
                writer.WritePropertyName("singleSignOnUrl"u8);
                writer.WriteStringValue(SingleSignOnUri);
            }
            if (Optional.IsCollectionDefined(AadDomains))
            {
                writer.WritePropertyName("aadDomains"u8);
                writer.WriteStartArray();
                foreach (var item in AadDomains)
                {
                    writer.WriteStringValue(item);
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

        NeonSingleSignOnProperties IJsonModel<NeonSingleSignOnProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NeonSingleSignOnProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NeonSingleSignOnProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNeonSingleSignOnProperties(document.RootElement, options);
        }

        internal static NeonSingleSignOnProperties DeserializeNeonSingleSignOnProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NeonSingleSignOnState? singleSignOnState = default;
            string enterpriseAppId = default;
            string singleSignOnUrl = default;
            IList<string> aadDomains = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("singleSignOnState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    singleSignOnState = new NeonSingleSignOnState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enterpriseAppId"u8))
                {
                    enterpriseAppId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("singleSignOnUrl"u8))
                {
                    singleSignOnUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aadDomains"u8))
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
                    aadDomains = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NeonSingleSignOnProperties(singleSignOnState, enterpriseAppId, singleSignOnUrl, aadDomains ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NeonSingleSignOnProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NeonSingleSignOnProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NeonSingleSignOnProperties)} does not support writing '{options.Format}' format.");
            }
        }

        NeonSingleSignOnProperties IPersistableModel<NeonSingleSignOnProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NeonSingleSignOnProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNeonSingleSignOnProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NeonSingleSignOnProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NeonSingleSignOnProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
