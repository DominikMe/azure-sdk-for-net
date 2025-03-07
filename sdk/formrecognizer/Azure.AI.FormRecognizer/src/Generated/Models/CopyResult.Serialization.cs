// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class CopyResult
    {
        internal static CopyResult DeserializeCopyResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid modelId = default;
            IReadOnlyList<FormRecognizerError> errors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelId"u8))
                {
                    modelId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FormRecognizerError> array = new List<FormRecognizerError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FormRecognizerError.DeserializeFormRecognizerError(item));
                    }
                    errors = array;
                    continue;
                }
            }
            return new CopyResult(modelId, errors ?? new ChangeTrackingList<FormRecognizerError>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CopyResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeCopyResult(document.RootElement);
        }
    }
}
