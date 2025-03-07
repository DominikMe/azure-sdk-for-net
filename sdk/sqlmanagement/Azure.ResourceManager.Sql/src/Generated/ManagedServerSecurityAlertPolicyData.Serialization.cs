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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class ManagedServerSecurityAlertPolicyData : IUtf8JsonSerializable, IJsonModel<ManagedServerSecurityAlertPolicyData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedServerSecurityAlertPolicyData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedServerSecurityAlertPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServerSecurityAlertPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedServerSecurityAlertPolicyData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(DisabledAlerts))
            {
                writer.WritePropertyName("disabledAlerts"u8);
                writer.WriteStartArray();
                foreach (var item in DisabledAlerts)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EmailAddresses))
            {
                writer.WritePropertyName("emailAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in EmailAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SendToEmailAccountAdmins))
            {
                writer.WritePropertyName("emailAccountAdmins"u8);
                writer.WriteBooleanValue(SendToEmailAccountAdmins.Value);
            }
            if (Optional.IsDefined(StorageEndpoint))
            {
                writer.WritePropertyName("storageEndpoint"u8);
                writer.WriteStringValue(StorageEndpoint);
            }
            if (Optional.IsDefined(StorageAccountAccessKey))
            {
                writer.WritePropertyName("storageAccountAccessKey"u8);
                writer.WriteStringValue(StorageAccountAccessKey);
            }
            if (Optional.IsDefined(RetentionDays))
            {
                writer.WritePropertyName("retentionDays"u8);
                writer.WriteNumberValue(RetentionDays.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            writer.WriteEndObject();
        }

        ManagedServerSecurityAlertPolicyData IJsonModel<ManagedServerSecurityAlertPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServerSecurityAlertPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedServerSecurityAlertPolicyData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedServerSecurityAlertPolicyData(document.RootElement, options);
        }

        internal static ManagedServerSecurityAlertPolicyData DeserializeManagedServerSecurityAlertPolicyData(JsonElement element, ModelReaderWriterOptions options = null)
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
            SecurityAlertsPolicyState? state = default;
            IList<string> disabledAlerts = default;
            IList<string> emailAddresses = default;
            bool? emailAccountAdmins = default;
            string storageEndpoint = default;
            string storageAccountAccessKey = default;
            int? retentionDays = default;
            DateTimeOffset? creationTime = default;
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
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = property0.Value.GetString().ToSecurityAlertsPolicyState();
                            continue;
                        }
                        if (property0.NameEquals("disabledAlerts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            disabledAlerts = array;
                            continue;
                        }
                        if (property0.NameEquals("emailAddresses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            emailAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("emailAccountAdmins"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            emailAccountAdmins = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("storageEndpoint"u8))
                        {
                            storageEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountAccessKey"u8))
                        {
                            storageAccountAccessKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("retentionDays"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            retentionDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
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
            return new ManagedServerSecurityAlertPolicyData(
                id,
                name,
                type,
                systemData,
                state,
                disabledAlerts ?? new ChangeTrackingList<string>(),
                emailAddresses ?? new ChangeTrackingList<string>(),
                emailAccountAdmins,
                storageEndpoint,
                storageAccountAccessKey,
                retentionDays,
                creationTime,
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
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(State), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    state: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(State))
                {
                    builder.Append("    state: ");
                    builder.AppendLine($"'{State.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DisabledAlerts), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    disabledAlerts: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(DisabledAlerts))
                {
                    if (DisabledAlerts.Any())
                    {
                        builder.Append("    disabledAlerts: ");
                        builder.AppendLine("[");
                        foreach (var item in DisabledAlerts)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("      '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"      '{item}'");
                            }
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EmailAddresses), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    emailAddresses: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(EmailAddresses))
                {
                    if (EmailAddresses.Any())
                    {
                        builder.Append("    emailAddresses: ");
                        builder.AppendLine("[");
                        foreach (var item in EmailAddresses)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("      '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"      '{item}'");
                            }
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SendToEmailAccountAdmins), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    emailAccountAdmins: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SendToEmailAccountAdmins))
                {
                    builder.Append("    emailAccountAdmins: ");
                    var boolValue = SendToEmailAccountAdmins.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StorageEndpoint), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    storageEndpoint: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StorageEndpoint))
                {
                    builder.Append("    storageEndpoint: ");
                    if (StorageEndpoint.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{StorageEndpoint}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{StorageEndpoint}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StorageAccountAccessKey), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    storageAccountAccessKey: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StorageAccountAccessKey))
                {
                    builder.Append("    storageAccountAccessKey: ");
                    if (StorageAccountAccessKey.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{StorageAccountAccessKey}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{StorageAccountAccessKey}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RetentionDays), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    retentionDays: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RetentionDays))
                {
                    builder.Append("    retentionDays: ");
                    builder.AppendLine($"{RetentionDays.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CreatedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    creationTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CreatedOn))
                {
                    builder.Append("    creationTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(CreatedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ManagedServerSecurityAlertPolicyData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServerSecurityAlertPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedServerSecurityAlertPolicyData)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedServerSecurityAlertPolicyData IPersistableModel<ManagedServerSecurityAlertPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServerSecurityAlertPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeManagedServerSecurityAlertPolicyData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedServerSecurityAlertPolicyData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedServerSecurityAlertPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
