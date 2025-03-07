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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppGitHubActionConfiguration : IUtf8JsonSerializable, IJsonModel<ContainerAppGitHubActionConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppGitHubActionConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerAppGitHubActionConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppGitHubActionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppGitHubActionConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(RegistryInfo))
            {
                writer.WritePropertyName("registryInfo"u8);
                writer.WriteObjectValue(RegistryInfo, options);
            }
            if (Optional.IsDefined(AzureCredentials))
            {
                writer.WritePropertyName("azureCredentials"u8);
                writer.WriteObjectValue(AzureCredentials, options);
            }
            if (Optional.IsDefined(ContextPath))
            {
                writer.WritePropertyName("contextPath"u8);
                writer.WriteStringValue(ContextPath);
            }
            if (Optional.IsDefined(GitHubPersonalAccessToken))
            {
                writer.WritePropertyName("githubPersonalAccessToken"u8);
                writer.WriteStringValue(GitHubPersonalAccessToken);
            }
            if (Optional.IsDefined(Image))
            {
                writer.WritePropertyName("image"u8);
                writer.WriteStringValue(Image);
            }
            if (Optional.IsDefined(PublishType))
            {
                writer.WritePropertyName("publishType"u8);
                writer.WriteStringValue(PublishType);
            }
            if (Optional.IsDefined(OS))
            {
                writer.WritePropertyName("os"u8);
                writer.WriteStringValue(OS);
            }
            if (Optional.IsDefined(RuntimeStack))
            {
                writer.WritePropertyName("runtimeStack"u8);
                writer.WriteStringValue(RuntimeStack);
            }
            if (Optional.IsDefined(RuntimeVersion))
            {
                writer.WritePropertyName("runtimeVersion"u8);
                writer.WriteStringValue(RuntimeVersion);
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

        ContainerAppGitHubActionConfiguration IJsonModel<ContainerAppGitHubActionConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppGitHubActionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppGitHubActionConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppGitHubActionConfiguration(document.RootElement, options);
        }

        internal static ContainerAppGitHubActionConfiguration DeserializeContainerAppGitHubActionConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerAppRegistryInfo registryInfo = default;
            ContainerAppCredentials azureCredentials = default;
            string contextPath = default;
            string gitHubPersonalAccessToken = default;
            string image = default;
            string publishType = default;
            string os = default;
            string runtimeStack = default;
            string runtimeVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("registryInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    registryInfo = ContainerAppRegistryInfo.DeserializeContainerAppRegistryInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("azureCredentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureCredentials = ContainerAppCredentials.DeserializeContainerAppCredentials(property.Value, options);
                    continue;
                }
                if (property.NameEquals("contextPath"u8))
                {
                    contextPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("githubPersonalAccessToken"u8))
                {
                    gitHubPersonalAccessToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("image"u8))
                {
                    image = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publishType"u8))
                {
                    publishType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("os"u8))
                {
                    os = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeStack"u8))
                {
                    runtimeStack = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeVersion"u8))
                {
                    runtimeVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerAppGitHubActionConfiguration(
                registryInfo,
                azureCredentials,
                contextPath,
                gitHubPersonalAccessToken,
                image,
                publishType,
                os,
                runtimeStack,
                runtimeVersion,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RegistryInfo), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  registryInfo: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RegistryInfo))
                {
                    builder.Append("  registryInfo: ");
                    BicepSerializationHelpers.AppendChildObject(builder, RegistryInfo, options, 2, false, "  registryInfo: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AzureCredentials), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  azureCredentials: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AzureCredentials))
                {
                    builder.Append("  azureCredentials: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AzureCredentials, options, 2, false, "  azureCredentials: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ContextPath), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  contextPath: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ContextPath))
                {
                    builder.Append("  contextPath: ");
                    if (ContextPath.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ContextPath}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ContextPath}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GitHubPersonalAccessToken), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  githubPersonalAccessToken: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(GitHubPersonalAccessToken))
                {
                    builder.Append("  githubPersonalAccessToken: ");
                    if (GitHubPersonalAccessToken.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{GitHubPersonalAccessToken}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{GitHubPersonalAccessToken}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Image), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  image: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Image))
                {
                    builder.Append("  image: ");
                    if (Image.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Image}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Image}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PublishType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  publishType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PublishType))
                {
                    builder.Append("  publishType: ");
                    if (PublishType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PublishType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PublishType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OS), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  os: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(OS))
                {
                    builder.Append("  os: ");
                    if (OS.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{OS}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{OS}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RuntimeStack), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  runtimeStack: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RuntimeStack))
                {
                    builder.Append("  runtimeStack: ");
                    if (RuntimeStack.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RuntimeStack}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RuntimeStack}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RuntimeVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  runtimeVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RuntimeVersion))
                {
                    builder.Append("  runtimeVersion: ");
                    if (RuntimeVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RuntimeVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RuntimeVersion}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerAppGitHubActionConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppGitHubActionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppGitHubActionConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppGitHubActionConfiguration IPersistableModel<ContainerAppGitHubActionConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppGitHubActionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerAppGitHubActionConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppGitHubActionConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppGitHubActionConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
