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

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class RangerAdminSpecDatabase : IUtf8JsonSerializable, IJsonModel<RangerAdminSpecDatabase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RangerAdminSpecDatabase>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RangerAdminSpecDatabase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RangerAdminSpecDatabase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RangerAdminSpecDatabase)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("host"u8);
            writer.WriteStringValue(Host);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(PasswordSecretRef))
            {
                writer.WritePropertyName("passwordSecretRef"u8);
                writer.WriteStringValue(PasswordSecretRef);
            }
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username"u8);
                writer.WriteStringValue(Username);
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

        RangerAdminSpecDatabase IJsonModel<RangerAdminSpecDatabase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RangerAdminSpecDatabase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RangerAdminSpecDatabase)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRangerAdminSpecDatabase(document.RootElement, options);
        }

        internal static RangerAdminSpecDatabase DeserializeRangerAdminSpecDatabase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string host = default;
            string name = default;
            string passwordSecretRef = default;
            string username = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("host"u8))
                {
                    host = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("passwordSecretRef"u8))
                {
                    passwordSecretRef = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("username"u8))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RangerAdminSpecDatabase(host, name, passwordSecretRef, username, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Host), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  host: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Host))
                {
                    builder.Append("  host: ");
                    if (Host.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Host}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Host}'");
                    }
                }
            }

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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PasswordSecretRef), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  passwordSecretRef: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PasswordSecretRef))
                {
                    builder.Append("  passwordSecretRef: ");
                    if (PasswordSecretRef.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PasswordSecretRef}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PasswordSecretRef}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Username), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  username: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Username))
                {
                    builder.Append("  username: ");
                    if (Username.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Username}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Username}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<RangerAdminSpecDatabase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RangerAdminSpecDatabase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(RangerAdminSpecDatabase)} does not support writing '{options.Format}' format.");
            }
        }

        RangerAdminSpecDatabase IPersistableModel<RangerAdminSpecDatabase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RangerAdminSpecDatabase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRangerAdminSpecDatabase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RangerAdminSpecDatabase)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RangerAdminSpecDatabase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
