// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.DigitalTwins.Models;

namespace Azure.ResourceManager.DigitalTwins
{
    internal partial class TimeSeriesDatabaseConnectionsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of TimeSeriesDatabaseConnectionsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public TimeSeriesDatabaseConnectionsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-01-31";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListRequestUri(string subscriptionId, string resourceGroupName, string resourceName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DigitalTwins/digitalTwinsInstances/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/timeSeriesDatabaseConnections", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string resourceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DigitalTwins/digitalTwinsInstances/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/timeSeriesDatabaseConnections", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get all existing time series database connections for this DigitalTwins instance. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<TimeSeriesDatabaseConnectionListResult>> ListAsync(string subscriptionId, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, resourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TimeSeriesDatabaseConnectionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = TimeSeriesDatabaseConnectionListResult.DeserializeTimeSeriesDatabaseConnectionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get all existing time series database connections for this DigitalTwins instance. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<TimeSeriesDatabaseConnectionListResult> List(string subscriptionId, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, resourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TimeSeriesDatabaseConnectionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = TimeSeriesDatabaseConnectionListResult.DeserializeTimeSeriesDatabaseConnectionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string resourceName, string timeSeriesDatabaseConnectionName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DigitalTwins/digitalTwinsInstances/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/timeSeriesDatabaseConnections/", false);
            uri.AppendPath(timeSeriesDatabaseConnectionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string resourceName, string timeSeriesDatabaseConnectionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DigitalTwins/digitalTwinsInstances/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/timeSeriesDatabaseConnections/", false);
            uri.AppendPath(timeSeriesDatabaseConnectionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the description of an existing time series database connection. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="timeSeriesDatabaseConnectionName"> Name of time series database connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="timeSeriesDatabaseConnectionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="timeSeriesDatabaseConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<TimeSeriesDatabaseConnectionData>> GetAsync(string subscriptionId, string resourceGroupName, string resourceName, string timeSeriesDatabaseConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(timeSeriesDatabaseConnectionName, nameof(timeSeriesDatabaseConnectionName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, resourceName, timeSeriesDatabaseConnectionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TimeSeriesDatabaseConnectionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = TimeSeriesDatabaseConnectionData.DeserializeTimeSeriesDatabaseConnectionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((TimeSeriesDatabaseConnectionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the description of an existing time series database connection. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="timeSeriesDatabaseConnectionName"> Name of time series database connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="timeSeriesDatabaseConnectionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="timeSeriesDatabaseConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<TimeSeriesDatabaseConnectionData> Get(string subscriptionId, string resourceGroupName, string resourceName, string timeSeriesDatabaseConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(timeSeriesDatabaseConnectionName, nameof(timeSeriesDatabaseConnectionName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, resourceName, timeSeriesDatabaseConnectionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TimeSeriesDatabaseConnectionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = TimeSeriesDatabaseConnectionData.DeserializeTimeSeriesDatabaseConnectionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((TimeSeriesDatabaseConnectionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string subscriptionId, string resourceGroupName, string resourceName, string timeSeriesDatabaseConnectionName, TimeSeriesDatabaseConnectionData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DigitalTwins/digitalTwinsInstances/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/timeSeriesDatabaseConnections/", false);
            uri.AppendPath(timeSeriesDatabaseConnectionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string resourceName, string timeSeriesDatabaseConnectionName, TimeSeriesDatabaseConnectionData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DigitalTwins/digitalTwinsInstances/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/timeSeriesDatabaseConnections/", false);
            uri.AppendPath(timeSeriesDatabaseConnectionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create or update a time series database connection. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="timeSeriesDatabaseConnectionName"> Name of time series database connection. </param>
        /// <param name="data"> The time series database connection description. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="timeSeriesDatabaseConnectionName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="timeSeriesDatabaseConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string resourceName, string timeSeriesDatabaseConnectionName, TimeSeriesDatabaseConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(timeSeriesDatabaseConnectionName, nameof(timeSeriesDatabaseConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, resourceName, timeSeriesDatabaseConnectionName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create or update a time series database connection. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="timeSeriesDatabaseConnectionName"> Name of time series database connection. </param>
        /// <param name="data"> The time series database connection description. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="timeSeriesDatabaseConnectionName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="timeSeriesDatabaseConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string resourceName, string timeSeriesDatabaseConnectionName, TimeSeriesDatabaseConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(timeSeriesDatabaseConnectionName, nameof(timeSeriesDatabaseConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, resourceName, timeSeriesDatabaseConnectionName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string subscriptionId, string resourceGroupName, string resourceName, string timeSeriesDatabaseConnectionName, CleanupConnectionArtifact? cleanupConnectionArtifacts)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DigitalTwins/digitalTwinsInstances/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/timeSeriesDatabaseConnections/", false);
            uri.AppendPath(timeSeriesDatabaseConnectionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (cleanupConnectionArtifacts != null)
            {
                uri.AppendQuery("cleanupConnectionArtifacts", cleanupConnectionArtifacts.Value.ToString(), true);
            }
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string resourceName, string timeSeriesDatabaseConnectionName, CleanupConnectionArtifact? cleanupConnectionArtifacts)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DigitalTwins/digitalTwinsInstances/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/timeSeriesDatabaseConnections/", false);
            uri.AppendPath(timeSeriesDatabaseConnectionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (cleanupConnectionArtifacts != null)
            {
                uri.AppendQuery("cleanupConnectionArtifacts", cleanupConnectionArtifacts.Value.ToString(), true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete a time series database connection. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="timeSeriesDatabaseConnectionName"> Name of time series database connection. </param>
        /// <param name="cleanupConnectionArtifacts"> Specifies whether or not to attempt to clean up artifacts that were created in order to establish a connection to the time series database. This is a best-effort attempt that will fail if appropriate permissions are not in place. Setting this to 'true' does not delete any recorded data. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="timeSeriesDatabaseConnectionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="timeSeriesDatabaseConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string resourceName, string timeSeriesDatabaseConnectionName, CleanupConnectionArtifact? cleanupConnectionArtifacts = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(timeSeriesDatabaseConnectionName, nameof(timeSeriesDatabaseConnectionName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, resourceName, timeSeriesDatabaseConnectionName, cleanupConnectionArtifacts);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete a time series database connection. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="timeSeriesDatabaseConnectionName"> Name of time series database connection. </param>
        /// <param name="cleanupConnectionArtifacts"> Specifies whether or not to attempt to clean up artifacts that were created in order to establish a connection to the time series database. This is a best-effort attempt that will fail if appropriate permissions are not in place. Setting this to 'true' does not delete any recorded data. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="timeSeriesDatabaseConnectionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="timeSeriesDatabaseConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string resourceName, string timeSeriesDatabaseConnectionName, CleanupConnectionArtifact? cleanupConnectionArtifacts = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(timeSeriesDatabaseConnectionName, nameof(timeSeriesDatabaseConnectionName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, resourceName, timeSeriesDatabaseConnectionName, cleanupConnectionArtifacts);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string resourceName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string resourceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get all existing time series database connections for this DigitalTwins instance. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<TimeSeriesDatabaseConnectionListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, resourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TimeSeriesDatabaseConnectionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = TimeSeriesDatabaseConnectionListResult.DeserializeTimeSeriesDatabaseConnectionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get all existing time series database connections for this DigitalTwins instance. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the DigitalTwinsInstance. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<TimeSeriesDatabaseConnectionListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, resourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TimeSeriesDatabaseConnectionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = TimeSeriesDatabaseConnectionListResult.DeserializeTimeSeriesDatabaseConnectionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
