// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndexerCache : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageConnectionString))
            {
                writer.WritePropertyName("storageConnectionString"u8);
                writer.WriteStringValue(StorageConnectionString);
            }
            if (Optional.IsDefined(EnableReprocessing))
            {
                if (EnableReprocessing != null)
                {
                    writer.WritePropertyName("enableReprocessing"u8);
                    writer.WriteBooleanValue(EnableReprocessing.Value);
                }
                else
                {
                    writer.WriteNull("enableReprocessing");
                }
            }
            if (Optional.IsDefined(Identity))
            {
                if (Identity != null)
                {
                    writer.WritePropertyName("identity"u8);
                    writer.WriteObjectValue(Identity);
                }
                else
                {
                    writer.WriteNull("identity");
                }
            }
            writer.WriteEndObject();
        }

        internal static SearchIndexerCache DeserializeSearchIndexerCache(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string storageConnectionString = default;
            bool? enableReprocessing = default;
            SearchIndexerDataIdentity identity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageConnectionString"u8))
                {
                    storageConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableReprocessing"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enableReprocessing = null;
                        continue;
                    }
                    enableReprocessing = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        identity = null;
                        continue;
                    }
                    identity = SearchIndexerDataIdentity.DeserializeSearchIndexerDataIdentity(property.Value);
                    continue;
                }
            }
            return new SearchIndexerCache(storageConnectionString, enableReprocessing, identity);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SearchIndexerCache FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeSearchIndexerCache(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
