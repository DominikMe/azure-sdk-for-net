// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.DataMap
{
    public partial class AtlasTypeDef : IUtf8JsonSerializable, IJsonModel<AtlasTypeDef>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AtlasTypeDef>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AtlasTypeDef>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasTypeDef>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtlasTypeDef)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (Optional.IsDefined(CreateTime))
            {
                writer.WritePropertyName("createTime"u8);
                writer.WriteNumberValue(CreateTime.Value);
            }
            if (Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy"u8);
                writer.WriteStringValue(CreatedBy);
            }
            if (Optional.IsDefined(DateFormatter))
            {
                writer.WritePropertyName("dateFormatter"u8);
                writer.WriteObjectValue(DateFormatter, options);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Guid))
            {
                writer.WritePropertyName("guid"u8);
                writer.WriteStringValue(Guid);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(Options))
            {
                writer.WritePropertyName("options"u8);
                writer.WriteStartObject();
                foreach (var item in Options)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ServiceType))
            {
                writer.WritePropertyName("serviceType"u8);
                writer.WriteStringValue(ServiceType);
            }
            if (Optional.IsDefined(TypeVersion))
            {
                writer.WritePropertyName("typeVersion"u8);
                writer.WriteStringValue(TypeVersion);
            }
            if (Optional.IsDefined(UpdateTime))
            {
                writer.WritePropertyName("updateTime"u8);
                writer.WriteNumberValue(UpdateTime.Value);
            }
            if (Optional.IsDefined(UpdatedBy))
            {
                writer.WritePropertyName("updatedBy"u8);
                writer.WriteStringValue(UpdatedBy);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteNumberValue(Version.Value);
            }
            if (Optional.IsDefined(LastModifiedTS))
            {
                writer.WritePropertyName("lastModifiedTS"u8);
                writer.WriteStringValue(LastModifiedTS);
            }
            if (Optional.IsCollectionDefined(EntityTypes))
            {
                writer.WritePropertyName("entityTypes"u8);
                writer.WriteStartArray();
                foreach (var item in EntityTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SubTypes))
            {
                writer.WritePropertyName("subTypes"u8);
                writer.WriteStartArray();
                foreach (var item in SubTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SuperTypes))
            {
                writer.WritePropertyName("superTypes"u8);
                writer.WriteStartArray();
                foreach (var item in SuperTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RelationshipAttributeDefs))
            {
                writer.WritePropertyName("relationshipAttributeDefs"u8);
                writer.WriteStartArray();
                foreach (var item in RelationshipAttributeDefs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue"u8);
                writer.WriteStringValue(DefaultValue);
            }
            if (Optional.IsCollectionDefined(ElementDefs))
            {
                writer.WritePropertyName("elementDefs"u8);
                writer.WriteStartArray();
                foreach (var item in ElementDefs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EndDef1))
            {
                writer.WritePropertyName("endDef1"u8);
                writer.WriteObjectValue(EndDef1, options);
            }
            if (Optional.IsDefined(EndDef2))
            {
                writer.WritePropertyName("endDef2"u8);
                writer.WriteObjectValue(EndDef2, options);
            }
            if (Optional.IsDefined(RelationshipCategory))
            {
                writer.WritePropertyName("relationshipCategory"u8);
                writer.WriteStringValue(RelationshipCategory.Value.ToString());
            }
            if (Optional.IsDefined(RelationshipLabel))
            {
                writer.WritePropertyName("relationshipLabel"u8);
                writer.WriteStringValue(RelationshipLabel);
            }
            if (Optional.IsCollectionDefined(AttributeDefs))
            {
                writer.WritePropertyName("attributeDefs"u8);
                writer.WriteStartArray();
                foreach (var item in AttributeDefs)
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

        AtlasTypeDef IJsonModel<AtlasTypeDef>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasTypeDef>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtlasTypeDef)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAtlasTypeDef(document.RootElement, options);
        }

        internal static AtlasTypeDef DeserializeAtlasTypeDef(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TypeCategory? category = default;
            long? createTime = default;
            string createdBy = default;
            AtlasDateFormat dateFormatter = default;
            string description = default;
            string guid = default;
            string name = default;
            IReadOnlyDictionary<string, string> options0 = default;
            string serviceType = default;
            string typeVersion = default;
            long? updateTime = default;
            string updatedBy = default;
            long? version = default;
            string lastModifiedTS = default;
            IReadOnlyList<string> entityTypes = default;
            IReadOnlyList<string> subTypes = default;
            IReadOnlyList<string> superTypes = default;
            IReadOnlyList<AtlasRelationshipAttributeDef> relationshipAttributeDefs = default;
            string defaultValue = default;
            IReadOnlyList<AtlasEnumElementDef> elementDefs = default;
            AtlasRelationshipEndDef endDef1 = default;
            AtlasRelationshipEndDef endDef2 = default;
            RelationshipCategory? relationshipCategory = default;
            string relationshipLabel = default;
            IReadOnlyList<AtlasAttributeDef> attributeDefs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("category"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    category = new TypeCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("createdBy"u8))
                {
                    createdBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dateFormatter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateFormatter = AtlasDateFormat.DeserializeAtlasDateFormat(property.Value, options);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("guid"u8))
                {
                    guid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("options"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    options0 = dictionary;
                    continue;
                }
                if (property.NameEquals("serviceType"u8))
                {
                    serviceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeVersion"u8))
                {
                    typeVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("updateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updateTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("updatedBy"u8))
                {
                    updatedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastModifiedTS"u8))
                {
                    lastModifiedTS = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entityTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    entityTypes = array;
                    continue;
                }
                if (property.NameEquals("subTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    subTypes = array;
                    continue;
                }
                if (property.NameEquals("superTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    superTypes = array;
                    continue;
                }
                if (property.NameEquals("relationshipAttributeDefs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AtlasRelationshipAttributeDef> array = new List<AtlasRelationshipAttributeDef>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AtlasRelationshipAttributeDef.DeserializeAtlasRelationshipAttributeDef(item, options));
                    }
                    relationshipAttributeDefs = array;
                    continue;
                }
                if (property.NameEquals("defaultValue"u8))
                {
                    defaultValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("elementDefs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AtlasEnumElementDef> array = new List<AtlasEnumElementDef>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AtlasEnumElementDef.DeserializeAtlasEnumElementDef(item, options));
                    }
                    elementDefs = array;
                    continue;
                }
                if (property.NameEquals("endDef1"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endDef1 = AtlasRelationshipEndDef.DeserializeAtlasRelationshipEndDef(property.Value, options);
                    continue;
                }
                if (property.NameEquals("endDef2"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endDef2 = AtlasRelationshipEndDef.DeserializeAtlasRelationshipEndDef(property.Value, options);
                    continue;
                }
                if (property.NameEquals("relationshipCategory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    relationshipCategory = new RelationshipCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("relationshipLabel"u8))
                {
                    relationshipLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attributeDefs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AtlasAttributeDef> array = new List<AtlasAttributeDef>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AtlasAttributeDef.DeserializeAtlasAttributeDef(item, options));
                    }
                    attributeDefs = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AtlasTypeDef(
                category,
                createTime,
                createdBy,
                dateFormatter,
                description,
                guid,
                name,
                options0 ?? new ChangeTrackingDictionary<string, string>(),
                serviceType,
                typeVersion,
                updateTime,
                updatedBy,
                version,
                lastModifiedTS,
                entityTypes ?? new ChangeTrackingList<string>(),
                subTypes ?? new ChangeTrackingList<string>(),
                superTypes ?? new ChangeTrackingList<string>(),
                relationshipAttributeDefs ?? new ChangeTrackingList<AtlasRelationshipAttributeDef>(),
                defaultValue,
                elementDefs ?? new ChangeTrackingList<AtlasEnumElementDef>(),
                endDef1,
                endDef2,
                relationshipCategory,
                relationshipLabel,
                attributeDefs ?? new ChangeTrackingList<AtlasAttributeDef>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AtlasTypeDef>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasTypeDef>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AtlasTypeDef)} does not support writing '{options.Format}' format.");
            }
        }

        AtlasTypeDef IPersistableModel<AtlasTypeDef>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasTypeDef>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAtlasTypeDef(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AtlasTypeDef)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AtlasTypeDef>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AtlasTypeDef FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAtlasTypeDef(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
