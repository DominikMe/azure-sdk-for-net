// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Monitor.OpenTelemetry.LiveMetrics.Models;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics
{
    internal partial class LiveMetricsRestAPIsForClientSDKsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of LiveMetricsRestAPIsForClientSDKsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public LiveMetricsRestAPIsForClientSDKsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string apiVersion = "2024-04-01-preview")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateIsSubscribedRequest(string endpoint, string ikey, long? transmissionTime, string machineName, string instanceName, string streamId, string roleName, string invariantVersion, string configurationEtag, MonitoringDataPoint monitoringDataPoint)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, true);
            uri.AppendPath("/QuickPulseService.svc/ping", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            uri.AppendQuery("ikey", ikey, true);
            request.Uri = uri;
            if (transmissionTime != null)
            {
                request.Headers.Add("x-ms-qps-transmission-time", transmissionTime.Value);
            }
            if (machineName != null)
            {
                request.Headers.Add("x-ms-qps-machine-name", machineName);
            }
            if (instanceName != null)
            {
                request.Headers.Add("x-ms-qps-instance-name", instanceName);
            }
            if (streamId != null)
            {
                request.Headers.Add("x-ms-qps-stream-id", streamId);
            }
            if (roleName != null)
            {
                request.Headers.Add("x-ms-qps-role-name", roleName);
            }
            if (invariantVersion != null)
            {
                request.Headers.Add("x-ms-qps-invariant-version", invariantVersion);
            }
            if (configurationEtag != null)
            {
                request.Headers.Add("x-ms-qps-configuration-etag", configurationEtag);
            }
            request.Headers.Add("Accept", "application/json");
            if (monitoringDataPoint != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(monitoringDataPoint);
                request.Content = content;
            }
            return message;
        }

        /// <summary> Determine whether there is any subscription to the metrics and documents. </summary>
        /// <param name="endpoint"> The endpoint of the Live Metrics service. The default value is "https://global.livediagnostics.monitor.azure.com". </param>
        /// <param name="ikey"> The instrumentation key of the target Application Insights component for which the client checks whether there's any subscription to it. </param>
        /// <param name="transmissionTime"> Timestamp when the client transmits the metrics and documents to Live Metrics. A 8-byte long type of ticks. </param>
        /// <param name="machineName"> Computer name where Application Insights SDK lives. Live Metrics uses machine name with instance name as a backup. </param>
        /// <param name="instanceName"> Service instance name where Application Insights SDK lives. Live Metrics uses machine name with instance name as a backup. </param>
        /// <param name="streamId"> Identifies an Application Insights SDK as trusted agent to report metrics and documents. </param>
        /// <param name="roleName"> Cloud role name of the service. </param>
        /// <param name="invariantVersion"> Version/generation of the data contract (MonitoringDataPoint) between the client and Live Metrics. </param>
        /// <param name="configurationEtag"> An encoded string that indicates whether the collection configuration is changed. </param>
        /// <param name="monitoringDataPoint"> Data contract between Application Insights client SDK and Live Metrics. /QuickPulseService.svc/ping uses this as a backup source of machine name, instance name and invariant version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="ikey"/> is null. </exception>
        public async Task<ResponseWithHeaders<CollectionConfigurationInfo, LiveMetricsRestAPIsForClientSDKsIsSubscribedHeaders>> IsSubscribedAsync(string endpoint, string ikey, long? transmissionTime = null, string machineName = null, string instanceName = null, string streamId = null, string roleName = null, string invariantVersion = null, string configurationEtag = null, MonitoringDataPoint monitoringDataPoint = null, CancellationToken cancellationToken = default)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (ikey == null)
            {
                throw new ArgumentNullException(nameof(ikey));
            }

            using var message = CreateIsSubscribedRequest(endpoint, ikey, transmissionTime, machineName, instanceName, streamId, roleName, invariantVersion, configurationEtag, monitoringDataPoint);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new LiveMetricsRestAPIsForClientSDKsIsSubscribedHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CollectionConfigurationInfo value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = CollectionConfigurationInfo.DeserializeCollectionConfigurationInfo(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Determine whether there is any subscription to the metrics and documents. </summary>
        /// <param name="endpoint"> The endpoint of the Live Metrics service. The default value is "https://global.livediagnostics.monitor.azure.com". </param>
        /// <param name="ikey"> The instrumentation key of the target Application Insights component for which the client checks whether there's any subscription to it. </param>
        /// <param name="transmissionTime"> Timestamp when the client transmits the metrics and documents to Live Metrics. A 8-byte long type of ticks. </param>
        /// <param name="machineName"> Computer name where Application Insights SDK lives. Live Metrics uses machine name with instance name as a backup. </param>
        /// <param name="instanceName"> Service instance name where Application Insights SDK lives. Live Metrics uses machine name with instance name as a backup. </param>
        /// <param name="streamId"> Identifies an Application Insights SDK as trusted agent to report metrics and documents. </param>
        /// <param name="roleName"> Cloud role name of the service. </param>
        /// <param name="invariantVersion"> Version/generation of the data contract (MonitoringDataPoint) between the client and Live Metrics. </param>
        /// <param name="configurationEtag"> An encoded string that indicates whether the collection configuration is changed. </param>
        /// <param name="monitoringDataPoint"> Data contract between Application Insights client SDK and Live Metrics. /QuickPulseService.svc/ping uses this as a backup source of machine name, instance name and invariant version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="ikey"/> is null. </exception>
        public ResponseWithHeaders<CollectionConfigurationInfo, LiveMetricsRestAPIsForClientSDKsIsSubscribedHeaders> IsSubscribed(string endpoint, string ikey, long? transmissionTime = null, string machineName = null, string instanceName = null, string streamId = null, string roleName = null, string invariantVersion = null, string configurationEtag = null, MonitoringDataPoint monitoringDataPoint = null, CancellationToken cancellationToken = default)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (ikey == null)
            {
                throw new ArgumentNullException(nameof(ikey));
            }

            using var message = CreateIsSubscribedRequest(endpoint, ikey, transmissionTime, machineName, instanceName, streamId, roleName, invariantVersion, configurationEtag, monitoringDataPoint);
            _pipeline.Send(message, cancellationToken);
            var headers = new LiveMetricsRestAPIsForClientSDKsIsSubscribedHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CollectionConfigurationInfo value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = CollectionConfigurationInfo.DeserializeCollectionConfigurationInfo(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePublishRequest(string endpoint, string ikey, string configurationEtag, long? transmissionTime, IEnumerable<MonitoringDataPoint> monitoringDataPoints)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, true);
            uri.AppendPath("/QuickPulseService.svc/post", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            uri.AppendQuery("ikey", ikey, true);
            request.Uri = uri;
            if (configurationEtag != null)
            {
                request.Headers.Add("x-ms-qps-configuration-etag", configurationEtag);
            }
            if (transmissionTime != null)
            {
                request.Headers.Add("x-ms-qps-transmission-time", transmissionTime.Value);
            }
            request.Headers.Add("Accept", "application/json");
            if (monitoringDataPoints != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteStartArray();
                foreach (var item in monitoringDataPoints)
                {
                    content.JsonWriter.WriteObjectValue(item);
                }
                content.JsonWriter.WriteEndArray();
                request.Content = content;
            }
            return message;
        }

        /// <summary> Publish live metrics to the Live Metrics service when there is an active subscription to the metrics. </summary>
        /// <param name="endpoint"> The endpoint of the Live Metrics service. The default value is "https://global.livediagnostics.monitor.azure.com". </param>
        /// <param name="ikey"> The instrumentation key of the target Application Insights component for which the client checks whether there's any subscription to it. </param>
        /// <param name="configurationEtag"> An encoded string that indicates whether the collection configuration is changed. </param>
        /// <param name="transmissionTime"> Timestamp when the client transmits the metrics and documents to Live Metrics. A 8-byte long type of ticks. </param>
        /// <param name="monitoringDataPoints"> Data contract between the client and Live Metrics. /QuickPulseService.svc/ping uses this as a backup source of machine name, instance name and invariant version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="ikey"/> is null. </exception>
        public async Task<ResponseWithHeaders<CollectionConfigurationInfo, LiveMetricsRestAPIsForClientSDKsPublishHeaders>> PublishAsync(string endpoint, string ikey, string configurationEtag = null, long? transmissionTime = null, IEnumerable<MonitoringDataPoint> monitoringDataPoints = null, CancellationToken cancellationToken = default)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (ikey == null)
            {
                throw new ArgumentNullException(nameof(ikey));
            }

            using var message = CreatePublishRequest(endpoint, ikey, configurationEtag, transmissionTime, monitoringDataPoints);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new LiveMetricsRestAPIsForClientSDKsPublishHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CollectionConfigurationInfo value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = CollectionConfigurationInfo.DeserializeCollectionConfigurationInfo(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Publish live metrics to the Live Metrics service when there is an active subscription to the metrics. </summary>
        /// <param name="endpoint"> The endpoint of the Live Metrics service. The default value is "https://global.livediagnostics.monitor.azure.com". </param>
        /// <param name="ikey"> The instrumentation key of the target Application Insights component for which the client checks whether there's any subscription to it. </param>
        /// <param name="configurationEtag"> An encoded string that indicates whether the collection configuration is changed. </param>
        /// <param name="transmissionTime"> Timestamp when the client transmits the metrics and documents to Live Metrics. A 8-byte long type of ticks. </param>
        /// <param name="monitoringDataPoints"> Data contract between the client and Live Metrics. /QuickPulseService.svc/ping uses this as a backup source of machine name, instance name and invariant version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="ikey"/> is null. </exception>
        public ResponseWithHeaders<CollectionConfigurationInfo, LiveMetricsRestAPIsForClientSDKsPublishHeaders> Publish(string endpoint, string ikey, string configurationEtag = null, long? transmissionTime = null, IEnumerable<MonitoringDataPoint> monitoringDataPoints = null, CancellationToken cancellationToken = default)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (ikey == null)
            {
                throw new ArgumentNullException(nameof(ikey));
            }

            using var message = CreatePublishRequest(endpoint, ikey, configurationEtag, transmissionTime, monitoringDataPoints);
            _pipeline.Send(message, cancellationToken);
            var headers = new LiveMetricsRestAPIsForClientSDKsPublishHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CollectionConfigurationInfo value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = CollectionConfigurationInfo.DeserializeCollectionConfigurationInfo(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
