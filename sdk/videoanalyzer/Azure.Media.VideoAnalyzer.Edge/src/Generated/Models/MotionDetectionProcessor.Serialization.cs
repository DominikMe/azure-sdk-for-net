// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class MotionDetectionProcessor : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sensitivity))
            {
                writer.WritePropertyName("sensitivity"u8);
                writer.WriteStringValue(Sensitivity.Value.ToString());
            }
            if (Optional.IsDefined(OutputMotionRegion))
            {
                writer.WritePropertyName("outputMotionRegion"u8);
                writer.WriteBooleanValue(OutputMotionRegion.Value);
            }
            if (Optional.IsDefined(EventAggregationWindow))
            {
                writer.WritePropertyName("eventAggregationWindow"u8);
                writer.WriteStringValue(EventAggregationWindow);
            }
            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue(Type);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("inputs"u8);
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static MotionDetectionProcessor DeserializeMotionDetectionProcessor(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MotionDetectionSensitivity? sensitivity = default;
            bool? outputMotionRegion = default;
            string eventAggregationWindow = default;
            string type = default;
            string name = default;
            IList<NodeInput> inputs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sensitivity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sensitivity = new MotionDetectionSensitivity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("outputMotionRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputMotionRegion = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("eventAggregationWindow"u8))
                {
                    eventAggregationWindow = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    List<NodeInput> array = new List<NodeInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NodeInput.DeserializeNodeInput(item));
                    }
                    inputs = array;
                    continue;
                }
            }
            return new MotionDetectionProcessor(
                type,
                name,
                inputs,
                sensitivity,
                outputMotionRegion,
                eventAggregationWindow);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new MotionDetectionProcessor FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeMotionDetectionProcessor(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
