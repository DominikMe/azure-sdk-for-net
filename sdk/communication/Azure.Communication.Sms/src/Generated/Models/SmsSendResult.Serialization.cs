// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Communication.Sms
{
    public partial class SmsSendResult
    {
        internal static SmsSendResult DeserializeSmsSendResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string to = default;
            string messageId = default;
            int httpStatusCode = default;
            SmsSendResponseItemRepeatabilityResult? repeatabilityResult = default;
            bool successful = default;
            string errorMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("to"u8))
                {
                    to = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messageId"u8))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpStatusCode"u8))
                {
                    httpStatusCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("repeatabilityResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    repeatabilityResult = new SmsSendResponseItemRepeatabilityResult(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("successful"u8))
                {
                    successful = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
            }
            return new SmsSendResult(
                to,
                messageId,
                httpStatusCode,
                repeatabilityResult,
                successful,
                errorMessage);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SmsSendResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeSmsSendResult(document.RootElement);
        }
    }
}
