// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class SpatialAnalysisTypedOperationBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Debug))
            {
                writer.WritePropertyName("debug"u8);
                writer.WriteStringValue(Debug);
            }
            if (Optional.IsDefined(CalibrationConfiguration))
            {
                writer.WritePropertyName("calibrationConfiguration"u8);
                writer.WriteStringValue(CalibrationConfiguration);
            }
            if (Optional.IsDefined(CameraConfiguration))
            {
                writer.WritePropertyName("cameraConfiguration"u8);
                writer.WriteStringValue(CameraConfiguration);
            }
            if (Optional.IsDefined(CameraCalibratorNodeConfiguration))
            {
                writer.WritePropertyName("cameraCalibratorNodeConfiguration"u8);
                writer.WriteStringValue(CameraCalibratorNodeConfiguration);
            }
            if (Optional.IsDefined(DetectorNodeConfiguration))
            {
                writer.WritePropertyName("detectorNodeConfiguration"u8);
                writer.WriteStringValue(DetectorNodeConfiguration);
            }
            if (Optional.IsDefined(TrackerNodeConfiguration))
            {
                writer.WritePropertyName("trackerNodeConfiguration"u8);
                writer.WriteStringValue(TrackerNodeConfiguration);
            }
            if (Optional.IsDefined(EnableFaceMaskClassifier))
            {
                writer.WritePropertyName("enableFaceMaskClassifier"u8);
                writer.WriteStringValue(EnableFaceMaskClassifier);
            }
            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static SpatialAnalysisTypedOperationBase DeserializeSpatialAnalysisTypedOperationBase(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.VideoAnalyzer.SpatialAnalysisPersonCountOperation": return SpatialAnalysisPersonCountOperation.DeserializeSpatialAnalysisPersonCountOperation(element);
                    case "#Microsoft.VideoAnalyzer.SpatialAnalysisPersonDistanceOperation": return SpatialAnalysisPersonDistanceOperation.DeserializeSpatialAnalysisPersonDistanceOperation(element);
                    case "#Microsoft.VideoAnalyzer.SpatialAnalysisPersonLineCrossingOperation": return SpatialAnalysisPersonLineCrossingOperation.DeserializeSpatialAnalysisPersonLineCrossingOperation(element);
                    case "#Microsoft.VideoAnalyzer.SpatialAnalysisPersonZoneCrossingOperation": return SpatialAnalysisPersonZoneCrossingOperation.DeserializeSpatialAnalysisPersonZoneCrossingOperation(element);
                }
            }
            string debug = default;
            string calibrationConfiguration = default;
            string cameraConfiguration = default;
            string cameraCalibratorNodeConfiguration = default;
            string detectorNodeConfiguration = default;
            string trackerNodeConfiguration = default;
            string enableFaceMaskClassifier = default;
            string type = "SpatialAnalysisTypedOperationBase";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("debug"u8))
                {
                    debug = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("calibrationConfiguration"u8))
                {
                    calibrationConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cameraConfiguration"u8))
                {
                    cameraConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cameraCalibratorNodeConfiguration"u8))
                {
                    cameraCalibratorNodeConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("detectorNodeConfiguration"u8))
                {
                    detectorNodeConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackerNodeConfiguration"u8))
                {
                    trackerNodeConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableFaceMaskClassifier"u8))
                {
                    enableFaceMaskClassifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new SpatialAnalysisTypedOperationBase(
                type,
                debug,
                calibrationConfiguration,
                cameraConfiguration,
                cameraCalibratorNodeConfiguration,
                detectorNodeConfiguration,
                trackerNodeConfiguration,
                enableFaceMaskClassifier);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new SpatialAnalysisTypedOperationBase FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeSpatialAnalysisTypedOperationBase(document.RootElement);
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
