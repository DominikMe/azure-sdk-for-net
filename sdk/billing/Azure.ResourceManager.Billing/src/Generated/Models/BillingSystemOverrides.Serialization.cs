// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    public partial class BillingSystemOverrides : IUtf8JsonSerializable, IJsonModel<BillingSystemOverrides>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingSystemOverrides>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BillingSystemOverrides>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingSystemOverrides>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingSystemOverrides)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Cancellation))
            {
                writer.WritePropertyName("cancellation"u8);
                writer.WriteStringValue(Cancellation.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CancellationAllowedEndOn))
            {
                writer.WritePropertyName("cancellationAllowedEndDate"u8);
                writer.WriteStringValue(CancellationAllowedEndOn.Value, "O");
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

        BillingSystemOverrides IJsonModel<BillingSystemOverrides>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingSystemOverrides>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingSystemOverrides)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingSystemOverrides(document.RootElement, options);
        }

        internal static BillingSystemOverrides DeserializeBillingSystemOverrides(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PolicyOverrideCancellation? cancellation = default;
            DateTimeOffset? cancellationAllowedEndDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cancellation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cancellation = new PolicyOverrideCancellation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cancellationAllowedEndDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cancellationAllowedEndDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BillingSystemOverrides(cancellation, cancellationAllowedEndDate, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Cancellation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  cancellation: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Cancellation))
                {
                    builder.Append("  cancellation: ");
                    builder.AppendLine($"'{Cancellation.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CancellationAllowedEndOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  cancellationAllowedEndDate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CancellationAllowedEndOn))
                {
                    builder.Append("  cancellationAllowedEndDate: ");
                    var formattedDateTimeString = TypeFormatters.ToString(CancellationAllowedEndOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<BillingSystemOverrides>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingSystemOverrides>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(BillingSystemOverrides)} does not support writing '{options.Format}' format.");
            }
        }

        BillingSystemOverrides IPersistableModel<BillingSystemOverrides>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingSystemOverrides>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBillingSystemOverrides(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingSystemOverrides)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingSystemOverrides>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
