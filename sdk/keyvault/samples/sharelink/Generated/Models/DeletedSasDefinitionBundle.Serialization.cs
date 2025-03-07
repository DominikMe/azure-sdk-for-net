// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Security.KeyVault.Storage.Models
{
    public partial class DeletedSasDefinitionBundle
    {
        internal static DeletedSasDefinitionBundle DeserializeDeletedSasDefinitionBundle(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string recoveryId = default;
            DateTimeOffset? scheduledPurgeDate = default;
            DateTimeOffset? deletedDate = default;
            string id = default;
            string sid = default;
            string templateUri = default;
            SasTokenType? sasType = default;
            string validityPeriod = default;
            SasDefinitionAttributes attributes = default;
            IReadOnlyDictionary<string, string> tags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryId"u8))
                {
                    recoveryId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scheduledPurgeDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledPurgeDate = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("deletedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deletedDate = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sid"u8))
                {
                    sid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("templateUri"u8))
                {
                    templateUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sasType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sasType = new SasTokenType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("validityPeriod"u8))
                {
                    validityPeriod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attributes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    attributes = SasDefinitionAttributes.DeserializeSasDefinitionAttributes(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
            }
            return new DeletedSasDefinitionBundle(
                id,
                sid,
                templateUri,
                sasType,
                validityPeriod,
                attributes,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                recoveryId,
                scheduledPurgeDate,
                deletedDate);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new DeletedSasDefinitionBundle FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeDeletedSasDefinitionBundle(document.RootElement);
        }
    }
}
