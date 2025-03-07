// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Rendering
{
    public partial class RegionalCopyrightCountry
    {
        internal static RegionalCopyrightCountry DeserializeRegionalCopyrightCountry(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string isO3 = default;
            string label = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ISO3"u8))
                {
                    isO3 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
            }
            return new RegionalCopyrightCountry(isO3, label);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RegionalCopyrightCountry FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeRegionalCopyrightCountry(document.RootElement);
        }
    }
}
