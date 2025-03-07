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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class StaticSiteBuildProperties : IUtf8JsonSerializable, IJsonModel<StaticSiteBuildProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StaticSiteBuildProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StaticSiteBuildProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteBuildProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StaticSiteBuildProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AppLocation))
            {
                writer.WritePropertyName("appLocation"u8);
                writer.WriteStringValue(AppLocation);
            }
            if (Optional.IsDefined(ApiLocation))
            {
                writer.WritePropertyName("apiLocation"u8);
                writer.WriteStringValue(ApiLocation);
            }
            if (Optional.IsDefined(AppArtifactLocation))
            {
                writer.WritePropertyName("appArtifactLocation"u8);
                writer.WriteStringValue(AppArtifactLocation);
            }
            if (Optional.IsDefined(OutputLocation))
            {
                writer.WritePropertyName("outputLocation"u8);
                writer.WriteStringValue(OutputLocation);
            }
            if (Optional.IsDefined(AppBuildCommand))
            {
                writer.WritePropertyName("appBuildCommand"u8);
                writer.WriteStringValue(AppBuildCommand);
            }
            if (Optional.IsDefined(ApiBuildCommand))
            {
                writer.WritePropertyName("apiBuildCommand"u8);
                writer.WriteStringValue(ApiBuildCommand);
            }
            if (Optional.IsDefined(SkipGithubActionWorkflowGeneration))
            {
                writer.WritePropertyName("skipGithubActionWorkflowGeneration"u8);
                writer.WriteBooleanValue(SkipGithubActionWorkflowGeneration.Value);
            }
            if (Optional.IsDefined(GithubActionSecretNameOverride))
            {
                writer.WritePropertyName("githubActionSecretNameOverride"u8);
                writer.WriteStringValue(GithubActionSecretNameOverride);
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

        StaticSiteBuildProperties IJsonModel<StaticSiteBuildProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteBuildProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StaticSiteBuildProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStaticSiteBuildProperties(document.RootElement, options);
        }

        internal static StaticSiteBuildProperties DeserializeStaticSiteBuildProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string appLocation = default;
            string apiLocation = default;
            string appArtifactLocation = default;
            string outputLocation = default;
            string appBuildCommand = default;
            string apiBuildCommand = default;
            bool? skipGithubActionWorkflowGeneration = default;
            string githubActionSecretNameOverride = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appLocation"u8))
                {
                    appLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiLocation"u8))
                {
                    apiLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appArtifactLocation"u8))
                {
                    appArtifactLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outputLocation"u8))
                {
                    outputLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appBuildCommand"u8))
                {
                    appBuildCommand = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiBuildCommand"u8))
                {
                    apiBuildCommand = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skipGithubActionWorkflowGeneration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skipGithubActionWorkflowGeneration = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("githubActionSecretNameOverride"u8))
                {
                    githubActionSecretNameOverride = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StaticSiteBuildProperties(
                appLocation,
                apiLocation,
                appArtifactLocation,
                outputLocation,
                appBuildCommand,
                apiBuildCommand,
                skipGithubActionWorkflowGeneration,
                githubActionSecretNameOverride,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AppLocation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  appLocation: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AppLocation))
                {
                    builder.Append("  appLocation: ");
                    if (AppLocation.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AppLocation}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AppLocation}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiLocation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  apiLocation: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiLocation))
                {
                    builder.Append("  apiLocation: ");
                    if (ApiLocation.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ApiLocation}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ApiLocation}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AppArtifactLocation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  appArtifactLocation: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AppArtifactLocation))
                {
                    builder.Append("  appArtifactLocation: ");
                    if (AppArtifactLocation.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AppArtifactLocation}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AppArtifactLocation}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OutputLocation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  outputLocation: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(OutputLocation))
                {
                    builder.Append("  outputLocation: ");
                    if (OutputLocation.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{OutputLocation}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{OutputLocation}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AppBuildCommand), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  appBuildCommand: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AppBuildCommand))
                {
                    builder.Append("  appBuildCommand: ");
                    if (AppBuildCommand.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AppBuildCommand}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AppBuildCommand}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiBuildCommand), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  apiBuildCommand: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiBuildCommand))
                {
                    builder.Append("  apiBuildCommand: ");
                    if (ApiBuildCommand.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ApiBuildCommand}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ApiBuildCommand}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SkipGithubActionWorkflowGeneration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  skipGithubActionWorkflowGeneration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SkipGithubActionWorkflowGeneration))
                {
                    builder.Append("  skipGithubActionWorkflowGeneration: ");
                    var boolValue = SkipGithubActionWorkflowGeneration.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GithubActionSecretNameOverride), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  githubActionSecretNameOverride: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(GithubActionSecretNameOverride))
                {
                    builder.Append("  githubActionSecretNameOverride: ");
                    if (GithubActionSecretNameOverride.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{GithubActionSecretNameOverride}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{GithubActionSecretNameOverride}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<StaticSiteBuildProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteBuildProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(StaticSiteBuildProperties)} does not support writing '{options.Format}' format.");
            }
        }

        StaticSiteBuildProperties IPersistableModel<StaticSiteBuildProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteBuildProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStaticSiteBuildProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StaticSiteBuildProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StaticSiteBuildProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
