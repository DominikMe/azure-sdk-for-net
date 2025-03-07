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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class AnomalySecurityMLAnalyticsSettings : IUtf8JsonSerializable, IJsonModel<AnomalySecurityMLAnalyticsSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AnomalySecurityMLAnalyticsSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AnomalySecurityMLAnalyticsSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnomalySecurityMLAnalyticsSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnomalySecurityMLAnalyticsSettings)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedUtc"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(RequiredDataConnectors))
            {
                writer.WritePropertyName("requiredDataConnectors"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredDataConnectors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Tactics))
            {
                writer.WritePropertyName("tactics"u8);
                writer.WriteStartArray();
                foreach (var item in Tactics)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Techniques))
            {
                writer.WritePropertyName("techniques"u8);
                writer.WriteStartArray();
                foreach (var item in Techniques)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AnomalyVersion))
            {
                writer.WritePropertyName("anomalyVersion"u8);
                writer.WriteStringValue(AnomalyVersion);
            }
            if (Optional.IsDefined(CustomizableObservations))
            {
                writer.WritePropertyName("customizableObservations"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(CustomizableObservations);
#else
                using (JsonDocument document = JsonDocument.Parse(CustomizableObservations, ModelSerializationExtensions.JsonDocumentOptions))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Frequency))
            {
                writer.WritePropertyName("frequency"u8);
                writer.WriteStringValue(Frequency.Value, "P");
            }
            if (Optional.IsDefined(SettingsStatus))
            {
                writer.WritePropertyName("settingsStatus"u8);
                writer.WriteStringValue(SettingsStatus.Value.ToString());
            }
            if (Optional.IsDefined(IsDefaultSettings))
            {
                writer.WritePropertyName("isDefaultSettings"u8);
                writer.WriteBooleanValue(IsDefaultSettings.Value);
            }
            if (Optional.IsDefined(AnomalySettingsVersion))
            {
                writer.WritePropertyName("anomalySettingsVersion"u8);
                writer.WriteNumberValue(AnomalySettingsVersion.Value);
            }
            if (Optional.IsDefined(SettingsDefinitionId))
            {
                writer.WritePropertyName("settingsDefinitionId"u8);
                writer.WriteStringValue(SettingsDefinitionId.Value);
            }
            writer.WriteEndObject();
        }

        AnomalySecurityMLAnalyticsSettings IJsonModel<AnomalySecurityMLAnalyticsSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnomalySecurityMLAnalyticsSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnomalySecurityMLAnalyticsSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnomalySecurityMLAnalyticsSettings(document.RootElement, options);
        }

        internal static AnomalySecurityMLAnalyticsSettings DeserializeAnomalySecurityMLAnalyticsSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SecurityMLAnalyticsSettingsKind kind = default;
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string description = default;
            string displayName = default;
            bool? enabled = default;
            DateTimeOffset? lastModifiedUtc = default;
            IList<SecurityMLAnalyticsSettingsDataSource> requiredDataConnectors = default;
            IList<SecurityInsightsAttackTactic> tactics = default;
            IList<string> techniques = default;
            string anomalyVersion = default;
            BinaryData customizableObservations = default;
            TimeSpan? frequency = default;
            AnomalySecurityMLAnalyticsSettingsStatus? settingsStatus = default;
            bool? isDefaultSettings = default;
            int? anomalySettingsVersion = default;
            Guid? settingsDefinitionId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new SecurityMLAnalyticsSettingsKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("requiredDataConnectors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityMLAnalyticsSettingsDataSource> array = new List<SecurityMLAnalyticsSettingsDataSource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SecurityMLAnalyticsSettingsDataSource.DeserializeSecurityMLAnalyticsSettingsDataSource(item, options));
                            }
                            requiredDataConnectors = array;
                            continue;
                        }
                        if (property0.NameEquals("tactics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityInsightsAttackTactic> array = new List<SecurityInsightsAttackTactic>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new SecurityInsightsAttackTactic(item.GetString()));
                            }
                            tactics = array;
                            continue;
                        }
                        if (property0.NameEquals("techniques"u8))
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
                            techniques = array;
                            continue;
                        }
                        if (property0.NameEquals("anomalyVersion"u8))
                        {
                            anomalyVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customizableObservations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customizableObservations = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("frequency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            frequency = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("settingsStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            settingsStatus = new AnomalySecurityMLAnalyticsSettingsStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isDefaultSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDefaultSettings = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("anomalySettingsVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            anomalySettingsVersion = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("settingsDefinitionId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            settingsDefinitionId = property0.Value.GetGuid();
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
            return new AnomalySecurityMLAnalyticsSettings(
                id,
                name,
                type,
                systemData,
                kind,
                etag,
                serializedAdditionalRawData,
                description,
                displayName,
                enabled,
                lastModifiedUtc,
                requiredDataConnectors ?? new ChangeTrackingList<SecurityMLAnalyticsSettingsDataSource>(),
                tactics ?? new ChangeTrackingList<SecurityInsightsAttackTactic>(),
                techniques ?? new ChangeTrackingList<string>(),
                anomalyVersion,
                customizableObservations,
                frequency,
                settingsStatus,
                isDefaultSettings,
                anomalySettingsVersion,
                settingsDefinitionId);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Kind), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  kind: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  kind: ");
                builder.AppendLine($"'{Kind.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ETag), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  etag: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ETag))
                {
                    builder.Append("  etag: ");
                    builder.AppendLine($"'{ETag.Value.ToString()}'");
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    displayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DisplayName))
                {
                    builder.Append("    displayName: ");
                    if (DisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    enabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsEnabled))
                {
                    builder.Append("    enabled: ");
                    var boolValue = IsEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastModifiedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    lastModifiedUtc: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastModifiedOn))
                {
                    builder.Append("    lastModifiedUtc: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastModifiedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RequiredDataConnectors), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    requiredDataConnectors: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(RequiredDataConnectors))
                {
                    if (RequiredDataConnectors.Any())
                    {
                        builder.Append("    requiredDataConnectors: ");
                        builder.AppendLine("[");
                        foreach (var item in RequiredDataConnectors)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    requiredDataConnectors: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Tactics), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    tactics: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Tactics))
                {
                    if (Tactics.Any())
                    {
                        builder.Append("    tactics: ");
                        builder.AppendLine("[");
                        foreach (var item in Tactics)
                        {
                            builder.AppendLine($"      '{item.ToString()}'");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Techniques), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    techniques: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Techniques))
                {
                    if (Techniques.Any())
                    {
                        builder.Append("    techniques: ");
                        builder.AppendLine("[");
                        foreach (var item in Techniques)
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AnomalyVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    anomalyVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AnomalyVersion))
                {
                    builder.Append("    anomalyVersion: ");
                    if (AnomalyVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AnomalyVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AnomalyVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CustomizableObservations), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    customizableObservations: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CustomizableObservations))
                {
                    builder.Append("    customizableObservations: ");
                    builder.AppendLine($"'{CustomizableObservations.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Frequency), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    frequency: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Frequency))
                {
                    builder.Append("    frequency: ");
                    var formattedTimeSpan = TypeFormatters.ToString(Frequency.Value, "P");
                    builder.AppendLine($"'{formattedTimeSpan}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SettingsStatus), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    settingsStatus: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SettingsStatus))
                {
                    builder.Append("    settingsStatus: ");
                    builder.AppendLine($"'{SettingsStatus.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsDefaultSettings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    isDefaultSettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsDefaultSettings))
                {
                    builder.Append("    isDefaultSettings: ");
                    var boolValue = IsDefaultSettings.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AnomalySettingsVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    anomalySettingsVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AnomalySettingsVersion))
                {
                    builder.Append("    anomalySettingsVersion: ");
                    builder.AppendLine($"{AnomalySettingsVersion.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SettingsDefinitionId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    settingsDefinitionId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SettingsDefinitionId))
                {
                    builder.Append("    settingsDefinitionId: ");
                    builder.AppendLine($"'{SettingsDefinitionId.Value.ToString()}'");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AnomalySecurityMLAnalyticsSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnomalySecurityMLAnalyticsSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AnomalySecurityMLAnalyticsSettings)} does not support writing '{options.Format}' format.");
            }
        }

        AnomalySecurityMLAnalyticsSettings IPersistableModel<AnomalySecurityMLAnalyticsSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnomalySecurityMLAnalyticsSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAnomalySecurityMLAnalyticsSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AnomalySecurityMLAnalyticsSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AnomalySecurityMLAnalyticsSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
