// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.IoT.TimeSeriesInsights
{
    internal partial class SearchInstancesResponse
    {
        internal static SearchInstancesResponse DeserializeSearchInstancesResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<InstanceHit> hits = default;
            int? hitCount = default;
            string continuationToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InstanceHit> array = new List<InstanceHit>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InstanceHit.DeserializeInstanceHit(item));
                    }
                    hits = array;
                    continue;
                }
                if (property.NameEquals("hitCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hitCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("continuationToken"u8))
                {
                    continuationToken = property.Value.GetString();
                    continue;
                }
            }
            return new SearchInstancesResponse(hits ?? new ChangeTrackingList<InstanceHit>(), hitCount, continuationToken);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SearchInstancesResponse FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeSearchInstancesResponse(document.RootElement);
        }
    }
}
