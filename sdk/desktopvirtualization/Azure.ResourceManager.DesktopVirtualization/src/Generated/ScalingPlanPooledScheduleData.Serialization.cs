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
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    public partial class ScalingPlanPooledScheduleData : IUtf8JsonSerializable, IJsonModel<ScalingPlanPooledScheduleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScalingPlanPooledScheduleData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ScalingPlanPooledScheduleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingPlanPooledScheduleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScalingPlanPooledScheduleData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DaysOfWeek))
            {
                writer.WritePropertyName("daysOfWeek"u8);
                writer.WriteStartArray();
                foreach (var item in DaysOfWeek)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RampUpStartTime))
            {
                writer.WritePropertyName("rampUpStartTime"u8);
                writer.WriteObjectValue(RampUpStartTime, options);
            }
            if (Optional.IsDefined(RampUpLoadBalancingAlgorithm))
            {
                writer.WritePropertyName("rampUpLoadBalancingAlgorithm"u8);
                writer.WriteStringValue(RampUpLoadBalancingAlgorithm.Value.ToString());
            }
            if (Optional.IsDefined(RampUpMinimumHostsPct))
            {
                writer.WritePropertyName("rampUpMinimumHostsPct"u8);
                writer.WriteNumberValue(RampUpMinimumHostsPct.Value);
            }
            if (Optional.IsDefined(RampUpCapacityThresholdPct))
            {
                writer.WritePropertyName("rampUpCapacityThresholdPct"u8);
                writer.WriteNumberValue(RampUpCapacityThresholdPct.Value);
            }
            if (Optional.IsDefined(PeakStartTime))
            {
                writer.WritePropertyName("peakStartTime"u8);
                writer.WriteObjectValue(PeakStartTime, options);
            }
            if (Optional.IsDefined(PeakLoadBalancingAlgorithm))
            {
                writer.WritePropertyName("peakLoadBalancingAlgorithm"u8);
                writer.WriteStringValue(PeakLoadBalancingAlgorithm.Value.ToString());
            }
            if (Optional.IsDefined(RampDownStartTime))
            {
                writer.WritePropertyName("rampDownStartTime"u8);
                writer.WriteObjectValue(RampDownStartTime, options);
            }
            if (Optional.IsDefined(RampDownLoadBalancingAlgorithm))
            {
                writer.WritePropertyName("rampDownLoadBalancingAlgorithm"u8);
                writer.WriteStringValue(RampDownLoadBalancingAlgorithm.Value.ToString());
            }
            if (Optional.IsDefined(RampDownMinimumHostsPct))
            {
                writer.WritePropertyName("rampDownMinimumHostsPct"u8);
                writer.WriteNumberValue(RampDownMinimumHostsPct.Value);
            }
            if (Optional.IsDefined(RampDownCapacityThresholdPct))
            {
                writer.WritePropertyName("rampDownCapacityThresholdPct"u8);
                writer.WriteNumberValue(RampDownCapacityThresholdPct.Value);
            }
            if (Optional.IsDefined(RampDownForceLogoffUsers))
            {
                writer.WritePropertyName("rampDownForceLogoffUsers"u8);
                writer.WriteBooleanValue(RampDownForceLogoffUsers.Value);
            }
            if (Optional.IsDefined(RampDownStopHostsWhen))
            {
                writer.WritePropertyName("rampDownStopHostsWhen"u8);
                writer.WriteStringValue(RampDownStopHostsWhen.Value.ToString());
            }
            if (Optional.IsDefined(RampDownWaitTimeMinutes))
            {
                writer.WritePropertyName("rampDownWaitTimeMinutes"u8);
                writer.WriteNumberValue(RampDownWaitTimeMinutes.Value);
            }
            if (Optional.IsDefined(RampDownNotificationMessage))
            {
                writer.WritePropertyName("rampDownNotificationMessage"u8);
                writer.WriteStringValue(RampDownNotificationMessage);
            }
            if (Optional.IsDefined(OffPeakStartTime))
            {
                writer.WritePropertyName("offPeakStartTime"u8);
                writer.WriteObjectValue(OffPeakStartTime, options);
            }
            if (Optional.IsDefined(OffPeakLoadBalancingAlgorithm))
            {
                writer.WritePropertyName("offPeakLoadBalancingAlgorithm"u8);
                writer.WriteStringValue(OffPeakLoadBalancingAlgorithm.Value.ToString());
            }
            writer.WriteEndObject();
        }

        ScalingPlanPooledScheduleData IJsonModel<ScalingPlanPooledScheduleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingPlanPooledScheduleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScalingPlanPooledScheduleData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScalingPlanPooledScheduleData(document.RootElement, options);
        }

        internal static ScalingPlanPooledScheduleData DeserializeScalingPlanPooledScheduleData(JsonElement element, ModelReaderWriterOptions options = null)
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
            IList<DesktopVirtualizationDayOfWeek> daysOfWeek = default;
            ScalingActionTime rampUpStartTime = default;
            SessionHostLoadBalancingAlgorithm? rampUpLoadBalancingAlgorithm = default;
            int? rampUpMinimumHostsPct = default;
            int? rampUpCapacityThresholdPct = default;
            ScalingActionTime peakStartTime = default;
            SessionHostLoadBalancingAlgorithm? peakLoadBalancingAlgorithm = default;
            ScalingActionTime rampDownStartTime = default;
            SessionHostLoadBalancingAlgorithm? rampDownLoadBalancingAlgorithm = default;
            int? rampDownMinimumHostsPct = default;
            int? rampDownCapacityThresholdPct = default;
            bool? rampDownForceLogoffUsers = default;
            DesktopVirtualizationStopHostsWhen? rampDownStopHostsWhen = default;
            int? rampDownWaitTimeMinutes = default;
            string rampDownNotificationMessage = default;
            ScalingActionTime offPeakStartTime = default;
            SessionHostLoadBalancingAlgorithm? offPeakLoadBalancingAlgorithm = default;
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
                        if (property0.NameEquals("daysOfWeek"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DesktopVirtualizationDayOfWeek> array = new List<DesktopVirtualizationDayOfWeek>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString().ToDesktopVirtualizationDayOfWeek());
                            }
                            daysOfWeek = array;
                            continue;
                        }
                        if (property0.NameEquals("rampUpStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampUpStartTime = ScalingActionTime.DeserializeScalingActionTime(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("rampUpLoadBalancingAlgorithm"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampUpLoadBalancingAlgorithm = new SessionHostLoadBalancingAlgorithm(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rampUpMinimumHostsPct"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampUpMinimumHostsPct = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("rampUpCapacityThresholdPct"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampUpCapacityThresholdPct = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("peakStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peakStartTime = ScalingActionTime.DeserializeScalingActionTime(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("peakLoadBalancingAlgorithm"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peakLoadBalancingAlgorithm = new SessionHostLoadBalancingAlgorithm(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rampDownStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampDownStartTime = ScalingActionTime.DeserializeScalingActionTime(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("rampDownLoadBalancingAlgorithm"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampDownLoadBalancingAlgorithm = new SessionHostLoadBalancingAlgorithm(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rampDownMinimumHostsPct"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampDownMinimumHostsPct = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("rampDownCapacityThresholdPct"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampDownCapacityThresholdPct = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("rampDownForceLogoffUsers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampDownForceLogoffUsers = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("rampDownStopHostsWhen"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampDownStopHostsWhen = new DesktopVirtualizationStopHostsWhen(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rampDownWaitTimeMinutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rampDownWaitTimeMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("rampDownNotificationMessage"u8))
                        {
                            rampDownNotificationMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("offPeakStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            offPeakStartTime = ScalingActionTime.DeserializeScalingActionTime(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("offPeakLoadBalancingAlgorithm"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            offPeakLoadBalancingAlgorithm = new SessionHostLoadBalancingAlgorithm(property0.Value.GetString());
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
            return new ScalingPlanPooledScheduleData(
                id,
                name,
                type,
                systemData,
                daysOfWeek ?? new ChangeTrackingList<DesktopVirtualizationDayOfWeek>(),
                rampUpStartTime,
                rampUpLoadBalancingAlgorithm,
                rampUpMinimumHostsPct,
                rampUpCapacityThresholdPct,
                peakStartTime,
                peakLoadBalancingAlgorithm,
                rampDownStartTime,
                rampDownLoadBalancingAlgorithm,
                rampDownMinimumHostsPct,
                rampDownCapacityThresholdPct,
                rampDownForceLogoffUsers,
                rampDownStopHostsWhen,
                rampDownWaitTimeMinutes,
                rampDownNotificationMessage,
                offPeakStartTime,
                offPeakLoadBalancingAlgorithm,
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
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DaysOfWeek), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    daysOfWeek: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(DaysOfWeek))
                {
                    if (DaysOfWeek.Any())
                    {
                        builder.Append("    daysOfWeek: ");
                        builder.AppendLine("[");
                        foreach (var item in DaysOfWeek)
                        {
                            builder.AppendLine($"      '{item.ToSerialString()}'");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RampUpStartTime), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    rampUpStartTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RampUpStartTime))
                {
                    builder.Append("    rampUpStartTime: ");
                    BicepSerializationHelpers.AppendChildObject(builder, RampUpStartTime, options, 4, false, "    rampUpStartTime: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RampUpLoadBalancingAlgorithm), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    rampUpLoadBalancingAlgorithm: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RampUpLoadBalancingAlgorithm))
                {
                    builder.Append("    rampUpLoadBalancingAlgorithm: ");
                    builder.AppendLine($"'{RampUpLoadBalancingAlgorithm.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RampUpMinimumHostsPct), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    rampUpMinimumHostsPct: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RampUpMinimumHostsPct))
                {
                    builder.Append("    rampUpMinimumHostsPct: ");
                    builder.AppendLine($"{RampUpMinimumHostsPct.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RampUpCapacityThresholdPct), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    rampUpCapacityThresholdPct: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RampUpCapacityThresholdPct))
                {
                    builder.Append("    rampUpCapacityThresholdPct: ");
                    builder.AppendLine($"{RampUpCapacityThresholdPct.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PeakStartTime), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    peakStartTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PeakStartTime))
                {
                    builder.Append("    peakStartTime: ");
                    BicepSerializationHelpers.AppendChildObject(builder, PeakStartTime, options, 4, false, "    peakStartTime: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PeakLoadBalancingAlgorithm), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    peakLoadBalancingAlgorithm: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PeakLoadBalancingAlgorithm))
                {
                    builder.Append("    peakLoadBalancingAlgorithm: ");
                    builder.AppendLine($"'{PeakLoadBalancingAlgorithm.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RampDownStartTime), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    rampDownStartTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RampDownStartTime))
                {
                    builder.Append("    rampDownStartTime: ");
                    BicepSerializationHelpers.AppendChildObject(builder, RampDownStartTime, options, 4, false, "    rampDownStartTime: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RampDownLoadBalancingAlgorithm), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    rampDownLoadBalancingAlgorithm: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RampDownLoadBalancingAlgorithm))
                {
                    builder.Append("    rampDownLoadBalancingAlgorithm: ");
                    builder.AppendLine($"'{RampDownLoadBalancingAlgorithm.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RampDownMinimumHostsPct), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    rampDownMinimumHostsPct: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RampDownMinimumHostsPct))
                {
                    builder.Append("    rampDownMinimumHostsPct: ");
                    builder.AppendLine($"{RampDownMinimumHostsPct.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RampDownCapacityThresholdPct), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    rampDownCapacityThresholdPct: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RampDownCapacityThresholdPct))
                {
                    builder.Append("    rampDownCapacityThresholdPct: ");
                    builder.AppendLine($"{RampDownCapacityThresholdPct.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RampDownForceLogoffUsers), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    rampDownForceLogoffUsers: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RampDownForceLogoffUsers))
                {
                    builder.Append("    rampDownForceLogoffUsers: ");
                    var boolValue = RampDownForceLogoffUsers.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RampDownStopHostsWhen), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    rampDownStopHostsWhen: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RampDownStopHostsWhen))
                {
                    builder.Append("    rampDownStopHostsWhen: ");
                    builder.AppendLine($"'{RampDownStopHostsWhen.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RampDownWaitTimeMinutes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    rampDownWaitTimeMinutes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RampDownWaitTimeMinutes))
                {
                    builder.Append("    rampDownWaitTimeMinutes: ");
                    builder.AppendLine($"{RampDownWaitTimeMinutes.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RampDownNotificationMessage), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    rampDownNotificationMessage: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RampDownNotificationMessage))
                {
                    builder.Append("    rampDownNotificationMessage: ");
                    if (RampDownNotificationMessage.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RampDownNotificationMessage}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RampDownNotificationMessage}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OffPeakStartTime), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    offPeakStartTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(OffPeakStartTime))
                {
                    builder.Append("    offPeakStartTime: ");
                    BicepSerializationHelpers.AppendChildObject(builder, OffPeakStartTime, options, 4, false, "    offPeakStartTime: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OffPeakLoadBalancingAlgorithm), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    offPeakLoadBalancingAlgorithm: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(OffPeakLoadBalancingAlgorithm))
                {
                    builder.Append("    offPeakLoadBalancingAlgorithm: ");
                    builder.AppendLine($"'{OffPeakLoadBalancingAlgorithm.Value.ToString()}'");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ScalingPlanPooledScheduleData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingPlanPooledScheduleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ScalingPlanPooledScheduleData)} does not support writing '{options.Format}' format.");
            }
        }

        ScalingPlanPooledScheduleData IPersistableModel<ScalingPlanPooledScheduleData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingPlanPooledScheduleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeScalingPlanPooledScheduleData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScalingPlanPooledScheduleData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScalingPlanPooledScheduleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
