// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Search.Documents.Models
{
    public partial class QueryRewritesDebugInfo
    {
        internal static QueryRewritesDebugInfo DeserializeQueryRewritesDebugInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            QueryRewritesValuesDebugInfo text = default;
            IReadOnlyList<QueryRewritesValuesDebugInfo> vectors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    text = QueryRewritesValuesDebugInfo.DeserializeQueryRewritesValuesDebugInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("vectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QueryRewritesValuesDebugInfo> array = new List<QueryRewritesValuesDebugInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueryRewritesValuesDebugInfo.DeserializeQueryRewritesValuesDebugInfo(item));
                    }
                    vectors = array;
                    continue;
                }
            }
            return new QueryRewritesDebugInfo(text, vectors ?? new ChangeTrackingList<QueryRewritesValuesDebugInfo>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static QueryRewritesDebugInfo FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeQueryRewritesDebugInfo(document.RootElement);
        }
    }
}
