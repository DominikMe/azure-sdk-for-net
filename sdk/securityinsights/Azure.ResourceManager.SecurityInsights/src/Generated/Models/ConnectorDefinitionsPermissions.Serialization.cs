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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class ConnectorDefinitionsPermissions : IUtf8JsonSerializable, IJsonModel<ConnectorDefinitionsPermissions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectorDefinitionsPermissions>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConnectorDefinitionsPermissions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectorDefinitionsPermissions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectorDefinitionsPermissions)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Tenant))
            {
                writer.WritePropertyName("tenant"u8);
                writer.WriteStartArray();
                foreach (var item in Tenant)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Licenses))
            {
                writer.WritePropertyName("licenses"u8);
                writer.WriteStartArray();
                foreach (var item in Licenses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ResourceProvider))
            {
                writer.WritePropertyName("resourceProvider"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceProvider)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Customs))
            {
                writer.WritePropertyName("customs"u8);
                writer.WriteStartArray();
                foreach (var item in Customs)
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

        ConnectorDefinitionsPermissions IJsonModel<ConnectorDefinitionsPermissions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectorDefinitionsPermissions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectorDefinitionsPermissions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectorDefinitionsPermissions(document.RootElement, options);
        }

        internal static ConnectorDefinitionsPermissions DeserializeConnectorDefinitionsPermissions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> tenant = default;
            IList<string> licenses = default;
            IList<ConnectorDefinitionsResourceProvider> resourceProvider = default;
            IList<CustomPermissionDetails> customs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenant"u8))
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
                    tenant = array;
                    continue;
                }
                if (property.NameEquals("licenses"u8))
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
                    licenses = array;
                    continue;
                }
                if (property.NameEquals("resourceProvider"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConnectorDefinitionsResourceProvider> array = new List<ConnectorDefinitionsResourceProvider>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectorDefinitionsResourceProvider.DeserializeConnectorDefinitionsResourceProvider(item, options));
                    }
                    resourceProvider = array;
                    continue;
                }
                if (property.NameEquals("customs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CustomPermissionDetails> array = new List<CustomPermissionDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomPermissionDetails.DeserializeCustomPermissionDetails(item, options));
                    }
                    customs = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConnectorDefinitionsPermissions(tenant ?? new ChangeTrackingList<string>(), licenses ?? new ChangeTrackingList<string>(), resourceProvider ?? new ChangeTrackingList<ConnectorDefinitionsResourceProvider>(), customs ?? new ChangeTrackingList<CustomPermissionDetails>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Tenant), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tenant: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Tenant))
                {
                    if (Tenant.Any())
                    {
                        builder.Append("  tenant: ");
                        builder.AppendLine("[");
                        foreach (var item in Tenant)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Licenses), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  licenses: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Licenses))
                {
                    if (Licenses.Any())
                    {
                        builder.Append("  licenses: ");
                        builder.AppendLine("[");
                        foreach (var item in Licenses)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ResourceProvider), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  resourceProvider: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ResourceProvider))
                {
                    if (ResourceProvider.Any())
                    {
                        builder.Append("  resourceProvider: ");
                        builder.AppendLine("[");
                        foreach (var item in ResourceProvider)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  resourceProvider: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Customs), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  customs: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Customs))
                {
                    if (Customs.Any())
                    {
                        builder.Append("  customs: ");
                        builder.AppendLine("[");
                        foreach (var item in Customs)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  customs: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ConnectorDefinitionsPermissions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectorDefinitionsPermissions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ConnectorDefinitionsPermissions)} does not support writing '{options.Format}' format.");
            }
        }

        ConnectorDefinitionsPermissions IPersistableModel<ConnectorDefinitionsPermissions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectorDefinitionsPermissions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConnectorDefinitionsPermissions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectorDefinitionsPermissions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectorDefinitionsPermissions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
