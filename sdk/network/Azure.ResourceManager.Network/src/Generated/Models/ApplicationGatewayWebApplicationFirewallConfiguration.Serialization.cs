// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayWebApplicationFirewallConfiguration : IUtf8JsonSerializable, IJsonModel<ApplicationGatewayWebApplicationFirewallConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationGatewayWebApplicationFirewallConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApplicationGatewayWebApplicationFirewallConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayWebApplicationFirewallConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayWebApplicationFirewallConfiguration)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("enabled"u8);
            writer.WriteBooleanValue(Enabled);
            writer.WritePropertyName("firewallMode"u8);
            writer.WriteStringValue(FirewallMode.ToString());
            writer.WritePropertyName("ruleSetType"u8);
            writer.WriteStringValue(RuleSetType);
            writer.WritePropertyName("ruleSetVersion"u8);
            writer.WriteStringValue(RuleSetVersion);
            if (Optional.IsCollectionDefined(DisabledRuleGroups))
            {
                writer.WritePropertyName("disabledRuleGroups"u8);
                writer.WriteStartArray();
                foreach (var item in DisabledRuleGroups)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RequestBodyCheck))
            {
                writer.WritePropertyName("requestBodyCheck"u8);
                writer.WriteBooleanValue(RequestBodyCheck.Value);
            }
            if (Optional.IsDefined(MaxRequestBodySize))
            {
                writer.WritePropertyName("maxRequestBodySize"u8);
                writer.WriteNumberValue(MaxRequestBodySize.Value);
            }
            if (Optional.IsDefined(MaxRequestBodySizeInKb))
            {
                writer.WritePropertyName("maxRequestBodySizeInKb"u8);
                writer.WriteNumberValue(MaxRequestBodySizeInKb.Value);
            }
            if (Optional.IsDefined(FileUploadLimitInMb))
            {
                writer.WritePropertyName("fileUploadLimitInMb"u8);
                writer.WriteNumberValue(FileUploadLimitInMb.Value);
            }
            if (Optional.IsCollectionDefined(Exclusions))
            {
                writer.WritePropertyName("exclusions"u8);
                writer.WriteStartArray();
                foreach (var item in Exclusions)
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

        ApplicationGatewayWebApplicationFirewallConfiguration IJsonModel<ApplicationGatewayWebApplicationFirewallConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayWebApplicationFirewallConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayWebApplicationFirewallConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayWebApplicationFirewallConfiguration(document.RootElement, options);
        }

        internal static ApplicationGatewayWebApplicationFirewallConfiguration DeserializeApplicationGatewayWebApplicationFirewallConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool enabled = default;
            ApplicationGatewayFirewallMode firewallMode = default;
            string ruleSetType = default;
            string ruleSetVersion = default;
            IList<ApplicationGatewayFirewallDisabledRuleGroup> disabledRuleGroups = default;
            bool? requestBodyCheck = default;
            int? maxRequestBodySize = default;
            int? maxRequestBodySizeInKb = default;
            int? fileUploadLimitInMb = default;
            IList<ApplicationGatewayFirewallExclusion> exclusions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("firewallMode"u8))
                {
                    firewallMode = new ApplicationGatewayFirewallMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ruleSetType"u8))
                {
                    ruleSetType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleSetVersion"u8))
                {
                    ruleSetVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disabledRuleGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationGatewayFirewallDisabledRuleGroup> array = new List<ApplicationGatewayFirewallDisabledRuleGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationGatewayFirewallDisabledRuleGroup.DeserializeApplicationGatewayFirewallDisabledRuleGroup(item, options));
                    }
                    disabledRuleGroups = array;
                    continue;
                }
                if (property.NameEquals("requestBodyCheck"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestBodyCheck = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxRequestBodySize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxRequestBodySize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxRequestBodySizeInKb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxRequestBodySizeInKb = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("fileUploadLimitInMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileUploadLimitInMb = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("exclusions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationGatewayFirewallExclusion> array = new List<ApplicationGatewayFirewallExclusion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationGatewayFirewallExclusion.DeserializeApplicationGatewayFirewallExclusion(item, options));
                    }
                    exclusions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApplicationGatewayWebApplicationFirewallConfiguration(
                enabled,
                firewallMode,
                ruleSetType,
                ruleSetVersion,
                disabledRuleGroups ?? new ChangeTrackingList<ApplicationGatewayFirewallDisabledRuleGroup>(),
                requestBodyCheck,
                maxRequestBodySize,
                maxRequestBodySizeInKb,
                fileUploadLimitInMb,
                exclusions ?? new ChangeTrackingList<ApplicationGatewayFirewallExclusion>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationGatewayWebApplicationFirewallConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayWebApplicationFirewallConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayWebApplicationFirewallConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        ApplicationGatewayWebApplicationFirewallConfiguration IPersistableModel<ApplicationGatewayWebApplicationFirewallConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayWebApplicationFirewallConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApplicationGatewayWebApplicationFirewallConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayWebApplicationFirewallConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationGatewayWebApplicationFirewallConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
