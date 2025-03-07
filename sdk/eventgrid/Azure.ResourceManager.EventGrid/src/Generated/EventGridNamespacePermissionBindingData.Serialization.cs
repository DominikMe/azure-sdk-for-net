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
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    public partial class EventGridNamespacePermissionBindingData : IUtf8JsonSerializable, IJsonModel<EventGridNamespacePermissionBindingData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventGridNamespacePermissionBindingData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EventGridNamespacePermissionBindingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridNamespacePermissionBindingData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridNamespacePermissionBindingData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(TopicSpaceName))
            {
                writer.WritePropertyName("topicSpaceName"u8);
                writer.WriteStringValue(TopicSpaceName);
            }
            if (Optional.IsDefined(Permission))
            {
                writer.WritePropertyName("permission"u8);
                writer.WriteStringValue(Permission.Value.ToString());
            }
            if (Optional.IsDefined(ClientGroupName))
            {
                writer.WritePropertyName("clientGroupName"u8);
                writer.WriteStringValue(ClientGroupName);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        EventGridNamespacePermissionBindingData IJsonModel<EventGridNamespacePermissionBindingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridNamespacePermissionBindingData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridNamespacePermissionBindingData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventGridNamespacePermissionBindingData(document.RootElement, options);
        }

        internal static EventGridNamespacePermissionBindingData DeserializeEventGridNamespacePermissionBindingData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string description = default;
            string topicSpaceName = default;
            PermissionType? permission = default;
            string clientGroupName = default;
            PermissionBindingProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("topicSpaceName"u8))
                        {
                            topicSpaceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("permission"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            permission = new PermissionType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clientGroupName"u8))
                        {
                            clientGroupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new PermissionBindingProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EventGridNamespacePermissionBindingData(
                id,
                name,
                type,
                systemData,
                description,
                topicSpaceName,
                permission,
                clientGroupName,
                provisioningState,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Description), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    description: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Description))
                {
                    builder.Append("    description: ");
                    if (Description.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Description}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Description}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TopicSpaceName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    topicSpaceName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TopicSpaceName))
                {
                    builder.Append("    topicSpaceName: ");
                    if (TopicSpaceName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TopicSpaceName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TopicSpaceName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Permission), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    permission: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Permission))
                {
                    builder.Append("    permission: ");
                    builder.AppendLine($"'{Permission.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientGroupName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    clientGroupName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientGroupName))
                {
                    builder.Append("    clientGroupName: ");
                    if (ClientGroupName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ClientGroupName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ClientGroupName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("    provisioningState: ");
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<EventGridNamespacePermissionBindingData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridNamespacePermissionBindingData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(EventGridNamespacePermissionBindingData)} does not support writing '{options.Format}' format.");
            }
        }

        EventGridNamespacePermissionBindingData IPersistableModel<EventGridNamespacePermissionBindingData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridNamespacePermissionBindingData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEventGridNamespacePermissionBindingData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventGridNamespacePermissionBindingData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventGridNamespacePermissionBindingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
