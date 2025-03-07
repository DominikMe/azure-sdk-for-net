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
    public partial class A2APolicyCreationContent : IUtf8JsonSerializable, IJsonModel<A2APolicyCreationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<A2APolicyCreationContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<A2APolicyCreationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2APolicyCreationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2APolicyCreationContent)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(RecoveryPointHistory))
            {
                writer.WritePropertyName("recoveryPointHistory"u8);
                writer.WriteNumberValue(RecoveryPointHistory.Value);
            }
            if (Optional.IsDefined(CrashConsistentFrequencyInMinutes))
            {
                writer.WritePropertyName("crashConsistentFrequencyInMinutes"u8);
                writer.WriteNumberValue(CrashConsistentFrequencyInMinutes.Value);
            }
            if (Optional.IsDefined(AppConsistentFrequencyInMinutes))
            {
                writer.WritePropertyName("appConsistentFrequencyInMinutes"u8);
                writer.WriteNumberValue(AppConsistentFrequencyInMinutes.Value);
            }
            writer.WritePropertyName("multiVmSyncStatus"u8);
            writer.WriteStringValue(MultiVmSyncStatus.ToString());
        }

        A2APolicyCreationContent IJsonModel<A2APolicyCreationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2APolicyCreationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2APolicyCreationContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeA2APolicyCreationContent(document.RootElement, options);
        }

        internal static A2APolicyCreationContent DeserializeA2APolicyCreationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? recoveryPointHistory = default;
            int? crashConsistentFrequencyInMinutes = default;
            int? appConsistentFrequencyInMinutes = default;
            SetMultiVmSyncStatus multiVmSyncStatus = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointHistory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointHistory = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("crashConsistentFrequencyInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    crashConsistentFrequencyInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("appConsistentFrequencyInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appConsistentFrequencyInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("multiVmSyncStatus"u8))
                {
                    multiVmSyncStatus = new SetMultiVmSyncStatus(property.Value.GetString());
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
            return new A2APolicyCreationContent(
                instanceType,
                serializedAdditionalRawData,
                recoveryPointHistory,
                crashConsistentFrequencyInMinutes,
                appConsistentFrequencyInMinutes,
                multiVmSyncStatus);
        }

        BinaryData IPersistableModel<A2APolicyCreationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2APolicyCreationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(A2APolicyCreationContent)} does not support writing '{options.Format}' format.");
            }
        }

        A2APolicyCreationContent IPersistableModel<A2APolicyCreationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2APolicyCreationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeA2APolicyCreationContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(A2APolicyCreationContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<A2APolicyCreationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
