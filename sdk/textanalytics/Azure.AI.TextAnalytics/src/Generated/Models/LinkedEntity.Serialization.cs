// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics
{
    public partial struct LinkedEntity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("matches"u8);
            writer.WriteStartArray();
            foreach (var item in Matches)
            {
                writer.WriteObjectValue<LinkedEntityMatch>(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("language"u8);
            writer.WriteStringValue(Language);
            if (Optional.IsDefined(DataSourceEntityId))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(DataSourceEntityId);
            }
            writer.WritePropertyName("url"u8);
            writer.WriteStringValue(Url.AbsoluteUri);
            writer.WritePropertyName("dataSource"u8);
            writer.WriteStringValue(DataSource);
            if (Optional.IsDefined(BingEntitySearchApiId))
            {
                writer.WritePropertyName("bingId"u8);
                writer.WriteStringValue(BingEntitySearchApiId);
            }
            writer.WriteEndObject();
        }

        internal static LinkedEntity DeserializeLinkedEntity(JsonElement element)
        {
            string name = default;
            IEnumerable<LinkedEntityMatch> matches = default;
            string language = default;
            string id = default;
            Uri url = default;
            string dataSource = default;
            string bingId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("matches"u8))
                {
                    List<LinkedEntityMatch> array = new List<LinkedEntityMatch>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkedEntityMatch.DeserializeLinkedEntityMatch(item));
                    }
                    matches = array;
                    continue;
                }
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataSource"u8))
                {
                    dataSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bingId"u8))
                {
                    bingId = property.Value.GetString();
                    continue;
                }
            }
            return new LinkedEntity(
                name,
                matches,
                language,
                id,
                url,
                dataSource,
                bingId);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static LinkedEntity FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeLinkedEntity(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
