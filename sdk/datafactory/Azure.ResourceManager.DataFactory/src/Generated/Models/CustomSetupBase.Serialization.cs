// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    [PersistableModelProxy(typeof(UnknownCustomSetupBase))]
    public partial class CustomSetupBase : IUtf8JsonSerializable, IJsonModel<CustomSetupBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomSetupBase>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CustomSetupBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomSetupBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomSetupBase)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CustomSetupBaseType);
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

        CustomSetupBase IJsonModel<CustomSetupBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomSetupBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomSetupBase)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomSetupBase(document.RootElement, options);
        }

        internal static CustomSetupBase DeserializeCustomSetupBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzPowerShellSetup": return AzPowerShellSetup.DeserializeAzPowerShellSetup(element, options);
                    case "CmdkeySetup": return CmdkeySetup.DeserializeCmdkeySetup(element, options);
                    case "ComponentSetup": return ComponentSetup.DeserializeComponentSetup(element, options);
                    case "EnvironmentVariableSetup": return EnvironmentVariableSetup.DeserializeEnvironmentVariableSetup(element, options);
                }
            }
            return UnknownCustomSetupBase.DeserializeUnknownCustomSetupBase(element, options);
        }

        BinaryData IPersistableModel<CustomSetupBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomSetupBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CustomSetupBase)} does not support writing '{options.Format}' format.");
            }
        }

        CustomSetupBase IPersistableModel<CustomSetupBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomSetupBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCustomSetupBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomSetupBase)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomSetupBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
