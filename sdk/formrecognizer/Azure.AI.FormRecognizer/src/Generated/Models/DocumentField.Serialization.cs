// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class DocumentField
    {
        internal static DocumentField DeserializeDocumentField(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DocumentFieldType type = default;
            string valueString = default;
            DateTimeOffset? valueDate = default;
            TimeSpan? valueTime = default;
            string valuePhoneNumber = default;
            double? valueNumber = default;
            long? valueInteger = default;
            V3SelectionMarkState? valueSelectionMark = default;
            DocumentSignatureType? valueSignature = default;
            string valueCountryRegion = default;
            IReadOnlyList<DocumentField> valueArray = default;
            IReadOnlyDictionary<string, DocumentField> valueObject = default;
            CurrencyValue? valueCurrency = default;
            AddressValue valueAddress = default;
            bool? valueBoolean = default;
            string content = default;
            IReadOnlyList<BoundingRegion> boundingRegions = default;
            IReadOnlyList<DocumentSpan> spans = default;
            float? confidence = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString().ToDocumentFieldType();
                    continue;
                }
                if (property.NameEquals("valueString"u8))
                {
                    valueString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("valueTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueTime = property.Value.GetTimeSpan("T");
                    continue;
                }
                if (property.NameEquals("valuePhoneNumber"u8))
                {
                    valuePhoneNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueNumber = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("valueInteger"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueInteger = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("valueSelectionMark"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueSelectionMark = new V3SelectionMarkState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("valueSignature"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueSignature = new DocumentSignatureType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("valueCountryRegion"u8))
                {
                    valueCountryRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueArray"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentField> array = new List<DocumentField>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeDocumentField(item));
                    }
                    valueArray = array;
                    continue;
                }
                if (property.NameEquals("valueObject"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, DocumentField> dictionary = new Dictionary<string, DocumentField>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, DeserializeDocumentField(property0.Value));
                    }
                    valueObject = dictionary;
                    continue;
                }
                if (property.NameEquals("valueCurrency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueCurrency = CurrencyValue.DeserializeCurrencyValue(property.Value);
                    continue;
                }
                if (property.NameEquals("valueAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueAddress = AddressValue.DeserializeAddressValue(property.Value);
                    continue;
                }
                if (property.NameEquals("valueBoolean"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueBoolean = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("content"u8))
                {
                    content = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("boundingRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BoundingRegion> array = new List<BoundingRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BoundingRegion.DeserializeBoundingRegion(item));
                    }
                    boundingRegions = array;
                    continue;
                }
                if (property.NameEquals("spans"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentSpan> array = new List<DocumentSpan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentSpan.DeserializeDocumentSpan(item));
                    }
                    spans = array;
                    continue;
                }
                if (property.NameEquals("confidence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    confidence = property.Value.GetSingle();
                    continue;
                }
            }
            return new DocumentField(
                type,
                valueString,
                valueDate,
                valueTime,
                valuePhoneNumber,
                valueNumber,
                valueInteger,
                valueSelectionMark,
                valueSignature,
                valueCountryRegion,
                valueArray ?? new ChangeTrackingList<DocumentField>(),
                valueObject ?? new ChangeTrackingDictionary<string, DocumentField>(),
                valueCurrency,
                valueAddress,
                valueBoolean,
                content,
                boundingRegions ?? new ChangeTrackingList<BoundingRegion>(),
                spans ?? new ChangeTrackingList<DocumentSpan>(),
                confidence);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DocumentField FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeDocumentField(document.RootElement);
        }
    }
}
