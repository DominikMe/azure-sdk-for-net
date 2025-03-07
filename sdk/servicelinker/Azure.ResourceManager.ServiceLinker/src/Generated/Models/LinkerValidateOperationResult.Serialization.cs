// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    public partial class LinkerValidateOperationResult : IUtf8JsonSerializable, IJsonModel<LinkerValidateOperationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LinkerValidateOperationResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LinkerValidateOperationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkerValidateOperationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinkerValidateOperationResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ResourceId))
            {
                if (ResourceId != null)
                {
                    writer.WritePropertyName("resourceId"u8);
                    writer.WriteStringValue(ResourceId);
                }
                else
                {
                    writer.WriteNull("resourceId");
                }
            }
            if (Optional.IsDefined(Status))
            {
                if (Status != null)
                {
                    writer.WritePropertyName("status"u8);
                    writer.WriteStringValue(Status);
                }
                else
                {
                    writer.WriteNull("status");
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(LinkerName))
            {
                if (LinkerName != null)
                {
                    writer.WritePropertyName("linkerName"u8);
                    writer.WriteStringValue(LinkerName);
                }
                else
                {
                    writer.WriteNull("linkerName");
                }
            }
            if (Optional.IsDefined(IsConnectionAvailable))
            {
                if (IsConnectionAvailable != null)
                {
                    writer.WritePropertyName("isConnectionAvailable"u8);
                    writer.WriteBooleanValue(IsConnectionAvailable.Value);
                }
                else
                {
                    writer.WriteNull("isConnectionAvailable");
                }
            }
            if (Optional.IsDefined(ReportStartOn))
            {
                if (ReportStartOn != null)
                {
                    writer.WritePropertyName("reportStartTimeUtc"u8);
                    writer.WriteStringValue(ReportStartOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("reportStartTimeUtc");
                }
            }
            if (Optional.IsDefined(ReportEndOn))
            {
                if (ReportEndOn != null)
                {
                    writer.WritePropertyName("reportEndTimeUtc"u8);
                    writer.WriteStringValue(ReportEndOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("reportEndTimeUtc");
                }
            }
            if (Optional.IsDefined(SourceId))
            {
                if (SourceId != null)
                {
                    writer.WritePropertyName("sourceId"u8);
                    writer.WriteStringValue(SourceId);
                }
                else
                {
                    writer.WriteNull("sourceId");
                }
            }
            if (Optional.IsDefined(TargetId))
            {
                if (TargetId != null)
                {
                    writer.WritePropertyName("targetId"u8);
                    writer.WriteStringValue(TargetId);
                }
                else
                {
                    writer.WriteNull("targetId");
                }
            }
            if (Optional.IsDefined(AuthType))
            {
                if (AuthType != null)
                {
                    writer.WritePropertyName("authType"u8);
                    writer.WriteStringValue(AuthType.Value.ToString());
                }
                else
                {
                    writer.WriteNull("authType");
                }
            }
            if (Optional.IsCollectionDefined(ValidationDetail))
            {
                if (ValidationDetail != null)
                {
                    writer.WritePropertyName("validationDetail"u8);
                    writer.WriteStartArray();
                    foreach (var item in ValidationDetail)
                    {
                        writer.WriteObjectValue(item, options);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("validationDetail");
                }
            }
            writer.WriteEndObject();
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

        LinkerValidateOperationResult IJsonModel<LinkerValidateOperationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkerValidateOperationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinkerValidateOperationResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkerValidateOperationResult(document.RootElement, options);
        }

        internal static LinkerValidateOperationResult DeserializeLinkerValidateOperationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier resourceId = default;
            string status = default;
            string linkerName = default;
            bool? isConnectionAvailable = default;
            DateTimeOffset? reportStartTimeUtc = default;
            DateTimeOffset? reportEndTimeUtc = default;
            ResourceIdentifier sourceId = default;
            ResourceIdentifier targetId = default;
            LinkerAuthType? authType = default;
            IReadOnlyList<LinkerValidationResultItemInfo> validationDetail = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceId = null;
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        status = null;
                        continue;
                    }
                    status = property.Value.GetString();
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
                        if (property0.NameEquals("linkerName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                linkerName = null;
                                continue;
                            }
                            linkerName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isConnectionAvailable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                isConnectionAvailable = null;
                                continue;
                            }
                            isConnectionAvailable = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("reportStartTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                reportStartTimeUtc = null;
                                continue;
                            }
                            reportStartTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("reportEndTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                reportEndTimeUtc = null;
                                continue;
                            }
                            reportEndTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                sourceId = null;
                                continue;
                            }
                            sourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                targetId = null;
                                continue;
                            }
                            targetId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("authType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                authType = null;
                                continue;
                            }
                            authType = new LinkerAuthType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("validationDetail"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                validationDetail = null;
                                continue;
                            }
                            List<LinkerValidationResultItemInfo> array = new List<LinkerValidationResultItemInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LinkerValidationResultItemInfo.DeserializeLinkerValidationResultItemInfo(item, options));
                            }
                            validationDetail = array;
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
            return new LinkerValidateOperationResult(
                resourceId,
                status,
                linkerName,
                isConnectionAvailable,
                reportStartTimeUtc,
                reportEndTimeUtc,
                sourceId,
                targetId,
                authType,
                validationDetail ?? new ChangeTrackingList<LinkerValidationResultItemInfo>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LinkerValidateOperationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkerValidateOperationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LinkerValidateOperationResult)} does not support writing '{options.Format}' format.");
            }
        }

        LinkerValidateOperationResult IPersistableModel<LinkerValidateOperationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkerValidateOperationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeLinkerValidateOperationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LinkerValidateOperationResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LinkerValidateOperationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
