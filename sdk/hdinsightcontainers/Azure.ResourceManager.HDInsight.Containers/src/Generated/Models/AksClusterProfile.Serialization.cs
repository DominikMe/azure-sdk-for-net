// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class AksClusterProfile : IUtf8JsonSerializable, IJsonModel<AksClusterProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AksClusterProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AksClusterProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AksClusterProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AksClusterProfile)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AksClusterResourceId))
            {
                writer.WritePropertyName("aksClusterResourceId"u8);
                writer.WriteStringValue(AksClusterResourceId);
            }
            if (Optional.IsDefined(AksClusterAgentPoolIdentityProfile))
            {
                writer.WritePropertyName("aksClusterAgentPoolIdentityProfile"u8);
                writer.WriteObjectValue(AksClusterAgentPoolIdentityProfile, options);
            }
            if (options.Format != "W" && Optional.IsDefined(AksVersion))
            {
                writer.WritePropertyName("aksVersion"u8);
                writer.WriteStringValue(AksVersion);
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

        AksClusterProfile IJsonModel<AksClusterProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AksClusterProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AksClusterProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAksClusterProfile(document.RootElement, options);
        }

        internal static AksClusterProfile DeserializeAksClusterProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier aksClusterResourceId = default;
            HDInsightIdentityProfile aksClusterAgentPoolIdentityProfile = default;
            string aksVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aksClusterResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aksClusterResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("aksClusterAgentPoolIdentityProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aksClusterAgentPoolIdentityProfile = HDInsightIdentityProfile.DeserializeHDInsightIdentityProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("aksVersion"u8))
                {
                    aksVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AksClusterProfile(aksClusterResourceId, aksClusterAgentPoolIdentityProfile, aksVersion, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AksClusterResourceId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  aksClusterResourceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AksClusterResourceId))
                {
                    builder.Append("  aksClusterResourceId: ");
                    builder.AppendLine($"'{AksClusterResourceId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AksClusterAgentPoolIdentityProfile), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  aksClusterAgentPoolIdentityProfile: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AksClusterAgentPoolIdentityProfile))
                {
                    builder.Append("  aksClusterAgentPoolIdentityProfile: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AksClusterAgentPoolIdentityProfile, options, 2, false, "  aksClusterAgentPoolIdentityProfile: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AksVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  aksVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AksVersion))
                {
                    builder.Append("  aksVersion: ");
                    if (AksVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AksVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AksVersion}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AksClusterProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AksClusterProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AksClusterProfile)} does not support writing '{options.Format}' format.");
            }
        }

        AksClusterProfile IPersistableModel<AksClusterProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AksClusterProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAksClusterProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AksClusterProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AksClusterProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
