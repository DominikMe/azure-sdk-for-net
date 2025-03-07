// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class AutomationRunbookTaskDetails : IUtf8JsonSerializable, IJsonModel<AutomationRunbookTaskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutomationRunbookTaskDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AutomationRunbookTaskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRunbookTaskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationRunbookTaskDetails)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(CloudServiceName))
            {
                writer.WritePropertyName("cloudServiceName"u8);
                writer.WriteStringValue(CloudServiceName);
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (Optional.IsDefined(AccountName))
            {
                writer.WritePropertyName("accountName"u8);
                writer.WriteStringValue(AccountName);
            }
            if (Optional.IsDefined(RunbookId))
            {
                writer.WritePropertyName("runbookId"u8);
                writer.WriteStringValue(RunbookId);
            }
            if (Optional.IsDefined(RunbookName))
            {
                writer.WritePropertyName("runbookName"u8);
                writer.WriteStringValue(RunbookName);
            }
            if (Optional.IsDefined(JobId))
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId);
            }
            if (Optional.IsDefined(JobOutput))
            {
                writer.WritePropertyName("jobOutput"u8);
                writer.WriteStringValue(JobOutput);
            }
            if (Optional.IsDefined(IsPrimarySideScript))
            {
                writer.WritePropertyName("isPrimarySideScript"u8);
                writer.WriteBooleanValue(IsPrimarySideScript.Value);
            }
        }

        AutomationRunbookTaskDetails IJsonModel<AutomationRunbookTaskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRunbookTaskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationRunbookTaskDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationRunbookTaskDetails(document.RootElement, options);
        }

        internal static AutomationRunbookTaskDetails DeserializeAutomationRunbookTaskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string cloudServiceName = default;
            string subscriptionId = default;
            string accountName = default;
            string runbookId = default;
            string runbookName = default;
            ResourceIdentifier jobId = default;
            string jobOutput = default;
            bool? isPrimarySideScript = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cloudServiceName"u8))
                {
                    cloudServiceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runbookId"u8))
                {
                    runbookId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runbookName"u8))
                {
                    runbookName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobOutput"u8))
                {
                    jobOutput = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPrimarySideScript"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPrimarySideScript = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AutomationRunbookTaskDetails(
                instanceType,
                serializedAdditionalRawData,
                name,
                cloudServiceName,
                subscriptionId,
                accountName,
                runbookId,
                runbookName,
                jobId,
                jobOutput,
                isPrimarySideScript);
        }

        BinaryData IPersistableModel<AutomationRunbookTaskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRunbookTaskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutomationRunbookTaskDetails)} does not support writing '{options.Format}' format.");
            }
        }

        AutomationRunbookTaskDetails IPersistableModel<AutomationRunbookTaskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRunbookTaskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAutomationRunbookTaskDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutomationRunbookTaskDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutomationRunbookTaskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
