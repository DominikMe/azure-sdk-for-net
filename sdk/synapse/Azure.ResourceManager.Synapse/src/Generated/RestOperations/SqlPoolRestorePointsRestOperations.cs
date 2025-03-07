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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    internal partial class SqlPoolRestorePointsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of SqlPoolRestorePointsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public SqlPoolRestorePointsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListRequestUri(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Synapse/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/sqlPools/", false);
            uri.AppendPath(sqlPoolName, true);
            uri.AppendPath("/restorePoints", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName)
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
            uri.AppendPath("/providers/Microsoft.Synapse/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/sqlPools/", false);
            uri.AppendPath(sqlPoolName, true);
            uri.AppendPath("/restorePoints", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get SQL pool backup information. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="sqlPoolName"> SQL pool name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="sqlPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="sqlPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SynapseRestorePointListResult>> ListAsync(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(sqlPoolName, nameof(sqlPoolName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SynapseRestorePointListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = SynapseRestorePointListResult.DeserializeSynapseRestorePointListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get SQL pool backup information. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="sqlPoolName"> SQL pool name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="sqlPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="sqlPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SynapseRestorePointListResult> List(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(sqlPoolName, nameof(sqlPoolName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SynapseRestorePointListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = SynapseRestorePointListResult.DeserializeSynapseRestorePointListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateRequestUri(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, SqlPoolCreateRestorePointContent content)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Synapse/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/sqlPools/", false);
            uri.AppendPath(sqlPoolName, true);
            uri.AppendPath("/restorePoints", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, SqlPoolCreateRestorePointContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Synapse/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/sqlPools/", false);
            uri.AppendPath(sqlPoolName, true);
            uri.AppendPath("/restorePoints", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content, ModelSerializationExtensions.WireOptions);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates a restore point for a data warehouse. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="sqlPoolName"> SQL pool name. </param>
        /// <param name="content"> The definition for creating the restore point of this Sql pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="sqlPoolName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="sqlPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateAsync(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, SqlPoolCreateRestorePointContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(sqlPoolName, nameof(sqlPoolName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a restore point for a data warehouse. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="sqlPoolName"> SQL pool name. </param>
        /// <param name="content"> The definition for creating the restore point of this Sql pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="sqlPoolName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="sqlPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Create(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, SqlPoolCreateRestorePointContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(sqlPoolName, nameof(sqlPoolName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, string restorePointName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Synapse/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/sqlPools/", false);
            uri.AppendPath(sqlPoolName, true);
            uri.AppendPath("/restorePoints/", false);
            uri.AppendPath(restorePointName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, string restorePointName)
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
            uri.AppendPath("/providers/Microsoft.Synapse/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/sqlPools/", false);
            uri.AppendPath(sqlPoolName, true);
            uri.AppendPath("/restorePoints/", false);
            uri.AppendPath(restorePointName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a restore point. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="sqlPoolName"> SQL pool name. </param>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="sqlPoolName"/> or <paramref name="restorePointName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="sqlPoolName"/> or <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SynapseRestorePointData>> GetAsync(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, string restorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(sqlPoolName, nameof(sqlPoolName));
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, restorePointName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SynapseRestorePointData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = SynapseRestorePointData.DeserializeSynapseRestorePointData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SynapseRestorePointData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a restore point. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="sqlPoolName"> SQL pool name. </param>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="sqlPoolName"/> or <paramref name="restorePointName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="sqlPoolName"/> or <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SynapseRestorePointData> Get(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, string restorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(sqlPoolName, nameof(sqlPoolName));
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, restorePointName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SynapseRestorePointData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = SynapseRestorePointData.DeserializeSynapseRestorePointData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SynapseRestorePointData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, string restorePointName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Synapse/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/sqlPools/", false);
            uri.AppendPath(sqlPoolName, true);
            uri.AppendPath("/restorePoints/", false);
            uri.AppendPath(restorePointName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, string restorePointName)
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
            uri.AppendPath("/providers/Microsoft.Synapse/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/sqlPools/", false);
            uri.AppendPath(sqlPoolName, true);
            uri.AppendPath("/restorePoints/", false);
            uri.AppendPath(restorePointName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes a restore point. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="sqlPoolName"> SQL pool name. </param>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="sqlPoolName"/> or <paramref name="restorePointName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="sqlPoolName"/> or <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, string restorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(sqlPoolName, nameof(sqlPoolName));
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, restorePointName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes a restore point. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="sqlPoolName"> SQL pool name. </param>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="sqlPoolName"/> or <paramref name="restorePointName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="sqlPoolName"/> or <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, string restorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(sqlPoolName, nameof(sqlPoolName));
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, restorePointName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName)
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

        /// <summary> Get SQL pool backup information. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="sqlPoolName"> SQL pool name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="sqlPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="sqlPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SynapseRestorePointListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(sqlPoolName, nameof(sqlPoolName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SynapseRestorePointListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = SynapseRestorePointListResult.DeserializeSynapseRestorePointListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get SQL pool backup information. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="sqlPoolName"> SQL pool name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="sqlPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="sqlPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SynapseRestorePointListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(sqlPoolName, nameof(sqlPoolName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SynapseRestorePointListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = SynapseRestorePointListResult.DeserializeSynapseRestorePointListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
