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
    public partial class FactoryVstsConfiguration : IUtf8JsonSerializable, IJsonModel<FactoryVstsConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FactoryVstsConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FactoryVstsConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FactoryVstsConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FactoryVstsConfiguration)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("projectName"u8);
            writer.WriteStringValue(ProjectName);
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
        }

        FactoryVstsConfiguration IJsonModel<FactoryVstsConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FactoryVstsConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FactoryVstsConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFactoryVstsConfiguration(document.RootElement, options);
        }

        internal static FactoryVstsConfiguration DeserializeFactoryVstsConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string projectName = default;
            Guid? tenantId = default;
            string type = default;
            string accountName = default;
            string repositoryName = default;
            string collaborationBranch = default;
            string rootFolder = default;
            string lastCommitId = default;
            bool? disablePublish = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("projectName"u8))
                {
                    projectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repositoryName"u8))
                {
                    repositoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("collaborationBranch"u8))
                {
                    collaborationBranch = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rootFolder"u8))
                {
                    rootFolder = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastCommitId"u8))
                {
                    lastCommitId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disablePublish"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disablePublish = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FactoryVstsConfiguration(
                type,
                accountName,
                repositoryName,
                collaborationBranch,
                rootFolder,
                lastCommitId,
                disablePublish,
                serializedAdditionalRawData,
                projectName,
                tenantId);
        }

        BinaryData IPersistableModel<FactoryVstsConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FactoryVstsConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FactoryVstsConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        FactoryVstsConfiguration IPersistableModel<FactoryVstsConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FactoryVstsConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFactoryVstsConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FactoryVstsConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FactoryVstsConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
