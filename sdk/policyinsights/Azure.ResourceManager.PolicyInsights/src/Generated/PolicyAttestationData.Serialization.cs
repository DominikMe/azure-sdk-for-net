// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PolicyInsights.Models;

namespace Azure.ResourceManager.PolicyInsights
{
    public partial class PolicyAttestationData : IUtf8JsonSerializable, IJsonModel<PolicyAttestationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyAttestationData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PolicyAttestationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyAttestationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyAttestationData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("policyAssignmentId"u8);
            writer.WriteStringValue(PolicyAssignmentId);
            if (Optional.IsDefined(PolicyDefinitionReferenceId))
            {
                writer.WritePropertyName("policyDefinitionReferenceId"u8);
                writer.WriteStringValue(PolicyDefinitionReferenceId);
            }
            if (Optional.IsDefined(ComplianceState))
            {
                writer.WritePropertyName("complianceState"u8);
                writer.WriteStringValue(ComplianceState.Value.ToString());
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expiresOn"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Optional.IsDefined(Owner))
            {
                writer.WritePropertyName("owner"u8);
                writer.WriteStringValue(Owner);
            }
            if (Optional.IsDefined(Comments))
            {
                writer.WritePropertyName("comments"u8);
                writer.WriteStringValue(Comments);
            }
            if (Optional.IsCollectionDefined(Evidence))
            {
                writer.WritePropertyName("evidence"u8);
                writer.WriteStartArray();
                foreach (var item in Evidence)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(LastComplianceStateChangeOn))
            {
                writer.WritePropertyName("lastComplianceStateChangeAt"u8);
                writer.WriteStringValue(LastComplianceStateChangeOn.Value, "O");
            }
            if (Optional.IsDefined(AssessOn))
            {
                writer.WritePropertyName("assessmentDate"u8);
                writer.WriteStringValue(AssessOn.Value, "O");
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                using (JsonDocument document = JsonDocument.Parse(Metadata, ModelSerializationExtensions.JsonDocumentOptions))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
        }

        PolicyAttestationData IJsonModel<PolicyAttestationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyAttestationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyAttestationData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyAttestationData(document.RootElement, options);
        }

        internal static PolicyAttestationData DeserializePolicyAttestationData(JsonElement element, ModelReaderWriterOptions options = null)
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
            ResourceIdentifier policyAssignmentId = default;
            string policyDefinitionReferenceId = default;
            PolicyComplianceState? complianceState = default;
            DateTimeOffset? expiresOn = default;
            string owner = default;
            string comments = default;
            IList<AttestationEvidence> evidence = default;
            string provisioningState = default;
            DateTimeOffset? lastComplianceStateChangeAt = default;
            DateTimeOffset? assessmentDate = default;
            BinaryData metadata = default;
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
                        if (property0.NameEquals("policyAssignmentId"u8))
                        {
                            policyAssignmentId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("policyDefinitionReferenceId"u8))
                        {
                            policyDefinitionReferenceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("complianceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            complianceState = new PolicyComplianceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("expiresOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expiresOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("owner"u8))
                        {
                            owner = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("comments"u8))
                        {
                            comments = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("evidence"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AttestationEvidence> array = new List<AttestationEvidence>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AttestationEvidence.DeserializeAttestationEvidence(item, options));
                            }
                            evidence = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastComplianceStateChangeAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastComplianceStateChangeAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("assessmentDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            assessmentDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("metadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metadata = BinaryData.FromString(property0.Value.GetRawText());
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
            return new PolicyAttestationData(
                id,
                name,
                type,
                systemData,
                policyAssignmentId,
                policyDefinitionReferenceId,
                complianceState,
                expiresOn,
                owner,
                comments,
                evidence ?? new ChangeTrackingList<AttestationEvidence>(),
                provisioningState,
                lastComplianceStateChangeAt,
                assessmentDate,
                metadata,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicyAttestationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyAttestationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicyAttestationData)} does not support writing '{options.Format}' format.");
            }
        }

        PolicyAttestationData IPersistableModel<PolicyAttestationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyAttestationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePolicyAttestationData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicyAttestationData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyAttestationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
