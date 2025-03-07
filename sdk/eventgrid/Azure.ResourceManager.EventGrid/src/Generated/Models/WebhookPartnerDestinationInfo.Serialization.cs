// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class WebhookPartnerDestinationInfo : IUtf8JsonSerializable, IJsonModel<WebhookPartnerDestinationInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebhookPartnerDestinationInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WebhookPartnerDestinationInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebhookPartnerDestinationInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebhookPartnerDestinationInfo)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(EndpointUri))
            {
                writer.WritePropertyName("endpointUrl"u8);
                writer.WriteStringValue(EndpointUri.AbsoluteUri);
            }
            if (Optional.IsDefined(EndpointBaseUri))
            {
                writer.WritePropertyName("endpointBaseUrl"u8);
                writer.WriteStringValue(EndpointBaseUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ClientAuthentication))
            {
                writer.WritePropertyName("clientAuthentication"u8);
                writer.WriteObjectValue(ClientAuthentication, options);
            }
            writer.WriteEndObject();
        }

        WebhookPartnerDestinationInfo IJsonModel<WebhookPartnerDestinationInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebhookPartnerDestinationInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebhookPartnerDestinationInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebhookPartnerDestinationInfo(document.RootElement, options);
        }

        internal static WebhookPartnerDestinationInfo DeserializeWebhookPartnerDestinationInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string azureSubscriptionId = default;
            string resourceGroupName = default;
            string name = default;
            PartnerEndpointType endpointType = default;
            string endpointServiceContext = default;
            IList<ResourceMoveChangeHistory> resourceMoveChangeHistory = default;
            Uri endpointUri = default;
            Uri endpointBaseUri = default;
            PartnerClientAuthentication clientAuthentication = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureSubscriptionId"u8))
                {
                    azureSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroupName"u8))
                {
                    resourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new PartnerEndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("endpointServiceContext"u8))
                {
                    endpointServiceContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceMoveChangeHistory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceMoveChangeHistory> array = new List<ResourceMoveChangeHistory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.ResourceMoveChangeHistory.DeserializeResourceMoveChangeHistory(item, options));
                    }
                    resourceMoveChangeHistory = array;
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
                        if (property0.NameEquals("endpointUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpointUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("endpointBaseUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpointBaseUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clientAuthentication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientAuthentication = PartnerClientAuthentication.DeserializePartnerClientAuthentication(property0.Value, options);
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
            return new WebhookPartnerDestinationInfo(
                azureSubscriptionId,
                resourceGroupName,
                name,
                endpointType,
                endpointServiceContext,
                resourceMoveChangeHistory ?? new ChangeTrackingList<ResourceMoveChangeHistory>(),
                serializedAdditionalRawData,
                endpointUri,
                endpointBaseUri,
                clientAuthentication);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AzureSubscriptionId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  azureSubscriptionId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AzureSubscriptionId))
                {
                    builder.Append("  azureSubscriptionId: ");
                    if (AzureSubscriptionId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AzureSubscriptionId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AzureSubscriptionId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ResourceGroupName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  resourceGroupName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ResourceGroupName))
                {
                    builder.Append("  resourceGroupName: ");
                    if (ResourceGroupName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ResourceGroupName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ResourceGroupName}'");
                    }
                }
            }

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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndpointType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  endpointType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  endpointType: ");
                builder.AppendLine($"'{EndpointType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndpointServiceContext), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  endpointServiceContext: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EndpointServiceContext))
                {
                    builder.Append("  endpointServiceContext: ");
                    if (EndpointServiceContext.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{EndpointServiceContext}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{EndpointServiceContext}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ResourceMoveChangeHistory), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  resourceMoveChangeHistory: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ResourceMoveChangeHistory))
                {
                    if (ResourceMoveChangeHistory.Any())
                    {
                        builder.Append("  resourceMoveChangeHistory: ");
                        builder.AppendLine("[");
                        foreach (var item in ResourceMoveChangeHistory)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  resourceMoveChangeHistory: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndpointUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    endpointUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EndpointUri))
                {
                    builder.Append("    endpointUrl: ");
                    builder.AppendLine($"'{EndpointUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndpointBaseUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    endpointBaseUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EndpointBaseUri))
                {
                    builder.Append("    endpointBaseUrl: ");
                    builder.AppendLine($"'{EndpointBaseUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientAuthentication), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    clientAuthentication: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientAuthentication))
                {
                    builder.Append("    clientAuthentication: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ClientAuthentication, options, 4, false, "    clientAuthentication: ");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<WebhookPartnerDestinationInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebhookPartnerDestinationInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(WebhookPartnerDestinationInfo)} does not support writing '{options.Format}' format.");
            }
        }

        WebhookPartnerDestinationInfo IPersistableModel<WebhookPartnerDestinationInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebhookPartnerDestinationInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeWebhookPartnerDestinationInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebhookPartnerDestinationInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebhookPartnerDestinationInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
