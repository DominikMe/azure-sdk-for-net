// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial struct CurrencyValue
    {
        internal static CurrencyValue DeserializeCurrencyValue(JsonElement element)
        {
            double amount = default;
            string currencySymbol = default;
            string currencyCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("amount"u8))
                {
                    amount = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("currencySymbol"u8))
                {
                    currencySymbol = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currencyCode"u8))
                {
                    currencyCode = property.Value.GetString();
                    continue;
                }
            }
            return new CurrencyValue(amount, currencySymbol, currencyCode);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CurrencyValue FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeCurrencyValue(document.RootElement);
        }
    }
}
