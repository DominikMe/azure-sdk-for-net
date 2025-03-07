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
    public partial class BrokerAuthorizationRule : IUtf8JsonSerializable, IJsonModel<BrokerAuthorizationRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BrokerAuthorizationRule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BrokerAuthorizationRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BrokerAuthorizationRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BrokerAuthorizationRule)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("brokerResources"u8);
            writer.WriteStartArray();
            foreach (var item in BrokerResources)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("principals"u8);
            writer.WriteObjectValue(Principals, options);
            if (Optional.IsCollectionDefined(StateStoreResources))
            {
                writer.WritePropertyName("stateStoreResources"u8);
                writer.WriteStartArray();
                foreach (var item in StateStoreResources)
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

        BrokerAuthorizationRule IJsonModel<BrokerAuthorizationRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BrokerAuthorizationRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BrokerAuthorizationRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBrokerAuthorizationRule(document.RootElement, options);
        }

        internal static BrokerAuthorizationRule DeserializeBrokerAuthorizationRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<BrokerResourceRule> brokerResources = default;
            PrincipalConfig principals = default;
            IList<StateStoreResourceRule> stateStoreResources = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("brokerResources"u8))
                {
                    List<BrokerResourceRule> array = new List<BrokerResourceRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BrokerResourceRule.DeserializeBrokerResourceRule(item, options));
                    }
                    brokerResources = array;
                    continue;
                }
                if (property.NameEquals("principals"u8))
                {
                    principals = PrincipalConfig.DeserializePrincipalConfig(property.Value, options);
                    continue;
                }
                if (property.NameEquals("stateStoreResources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StateStoreResourceRule> array = new List<StateStoreResourceRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StateStoreResourceRule.DeserializeStateStoreResourceRule(item, options));
                    }
                    stateStoreResources = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BrokerAuthorizationRule(brokerResources, principals, stateStoreResources ?? new ChangeTrackingList<StateStoreResourceRule>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BrokerAuthorizationRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BrokerAuthorizationRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BrokerAuthorizationRule)} does not support writing '{options.Format}' format.");
            }
        }

        BrokerAuthorizationRule IPersistableModel<BrokerAuthorizationRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BrokerAuthorizationRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBrokerAuthorizationRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BrokerAuthorizationRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BrokerAuthorizationRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
