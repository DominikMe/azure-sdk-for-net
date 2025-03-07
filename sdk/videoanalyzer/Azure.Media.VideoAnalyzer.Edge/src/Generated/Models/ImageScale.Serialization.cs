// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class ImageScale : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsDefined(Width))
            {
                writer.WritePropertyName("width"u8);
                writer.WriteStringValue(Width);
            }
            if (Optional.IsDefined(Height))
            {
                writer.WritePropertyName("height"u8);
                writer.WriteStringValue(Height);
            }
            writer.WriteEndObject();
        }

        internal static ImageScale DeserializeImageScale(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ImageScaleMode? mode = default;
            string width = default;
            string height = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new ImageScaleMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("width"u8))
                {
                    width = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("height"u8))
                {
                    height = property.Value.GetString();
                    continue;
                }
            }
            return new ImageScale(mode, width, height);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ImageScale FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeImageScale(document.RootElement);
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
