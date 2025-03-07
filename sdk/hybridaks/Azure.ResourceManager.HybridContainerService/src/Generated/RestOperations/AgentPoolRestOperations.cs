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
using Azure.ResourceManager.HybridContainerService.Models;

namespace Azure.ResourceManager.HybridContainerService
{
    internal partial class AgentPoolRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of AgentPoolRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public AgentPoolRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-01-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string connectedClusterResourceUri, string agentPoolName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(connectedClusterResourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/agentPools/", false);
            uri.AppendPath(agentPoolName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string connectedClusterResourceUri, string agentPoolName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(connectedClusterResourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/agentPools/", false);
            uri.AppendPath(agentPoolName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the specified agent pool in the provisioned cluster. </summary>
        /// <param name="connectedClusterResourceUri"> The fully qualified Azure Resource Manager identifier of the connected cluster resource. </param>
        /// <param name="agentPoolName"> Parameter for the name of the agent pool in the provisioned cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedClusterResourceUri"/> or <paramref name="agentPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<HybridContainerServiceAgentPoolData>> GetAsync(string connectedClusterResourceUri, string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(connectedClusterResourceUri, nameof(connectedClusterResourceUri));
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var message = CreateGetRequest(connectedClusterResourceUri, agentPoolName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridContainerServiceAgentPoolData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = HybridContainerServiceAgentPoolData.DeserializeHybridContainerServiceAgentPoolData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((HybridContainerServiceAgentPoolData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the specified agent pool in the provisioned cluster. </summary>
        /// <param name="connectedClusterResourceUri"> The fully qualified Azure Resource Manager identifier of the connected cluster resource. </param>
        /// <param name="agentPoolName"> Parameter for the name of the agent pool in the provisioned cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedClusterResourceUri"/> or <paramref name="agentPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<HybridContainerServiceAgentPoolData> Get(string connectedClusterResourceUri, string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(connectedClusterResourceUri, nameof(connectedClusterResourceUri));
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var message = CreateGetRequest(connectedClusterResourceUri, agentPoolName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HybridContainerServiceAgentPoolData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = HybridContainerServiceAgentPoolData.DeserializeHybridContainerServiceAgentPoolData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((HybridContainerServiceAgentPoolData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string connectedClusterResourceUri, string agentPoolName, HybridContainerServiceAgentPoolData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(connectedClusterResourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/agentPools/", false);
            uri.AppendPath(agentPoolName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string connectedClusterResourceUri, string agentPoolName, HybridContainerServiceAgentPoolData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(connectedClusterResourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/agentPools/", false);
            uri.AppendPath(agentPoolName, true);
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

        /// <summary> Creates or updates the agent pool in the provisioned cluster. </summary>
        /// <param name="connectedClusterResourceUri"> The fully qualified Azure Resource Manager identifier of the connected cluster resource. </param>
        /// <param name="agentPoolName"> Parameter for the name of the agent pool in the provisioned cluster. </param>
        /// <param name="data"> Agent Pool resource definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedClusterResourceUri"/>, <paramref name="agentPoolName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string connectedClusterResourceUri, string agentPoolName, HybridContainerServiceAgentPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(connectedClusterResourceUri, nameof(connectedClusterResourceUri));
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(connectedClusterResourceUri, agentPoolName, data);
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

        /// <summary> Creates or updates the agent pool in the provisioned cluster. </summary>
        /// <param name="connectedClusterResourceUri"> The fully qualified Azure Resource Manager identifier of the connected cluster resource. </param>
        /// <param name="agentPoolName"> Parameter for the name of the agent pool in the provisioned cluster. </param>
        /// <param name="data"> Agent Pool resource definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedClusterResourceUri"/>, <paramref name="agentPoolName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string connectedClusterResourceUri, string agentPoolName, HybridContainerServiceAgentPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(connectedClusterResourceUri, nameof(connectedClusterResourceUri));
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(connectedClusterResourceUri, agentPoolName, data);
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

        internal RequestUriBuilder CreateDeleteRequestUri(string connectedClusterResourceUri, string agentPoolName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(connectedClusterResourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/agentPools/", false);
            uri.AppendPath(agentPoolName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string connectedClusterResourceUri, string agentPoolName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(connectedClusterResourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/agentPools/", false);
            uri.AppendPath(agentPoolName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes the specified agent pool in the provisioned cluster. </summary>
        /// <param name="connectedClusterResourceUri"> The fully qualified Azure Resource Manager identifier of the connected cluster resource. </param>
        /// <param name="agentPoolName"> Parameter for the name of the agent pool in the provisioned cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedClusterResourceUri"/> or <paramref name="agentPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string connectedClusterResourceUri, string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(connectedClusterResourceUri, nameof(connectedClusterResourceUri));
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var message = CreateDeleteRequest(connectedClusterResourceUri, agentPoolName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes the specified agent pool in the provisioned cluster. </summary>
        /// <param name="connectedClusterResourceUri"> The fully qualified Azure Resource Manager identifier of the connected cluster resource. </param>
        /// <param name="agentPoolName"> Parameter for the name of the agent pool in the provisioned cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedClusterResourceUri"/> or <paramref name="agentPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string connectedClusterResourceUri, string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(connectedClusterResourceUri, nameof(connectedClusterResourceUri));
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var message = CreateDeleteRequest(connectedClusterResourceUri, agentPoolName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByProvisionedClusterRequestUri(string connectedClusterResourceUri)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(connectedClusterResourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/agentPools", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListByProvisionedClusterRequest(string connectedClusterResourceUri)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(connectedClusterResourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/agentPools", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the list of agent pools in the specified provisioned cluster. </summary>
        /// <param name="connectedClusterResourceUri"> The fully qualified Azure Resource Manager identifier of the connected cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedClusterResourceUri"/> is null. </exception>
        public async Task<Response<AgentPoolListResult>> ListByProvisionedClusterAsync(string connectedClusterResourceUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(connectedClusterResourceUri, nameof(connectedClusterResourceUri));

            using var message = CreateListByProvisionedClusterRequest(connectedClusterResourceUri);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AgentPoolListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = AgentPoolListResult.DeserializeAgentPoolListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the list of agent pools in the specified provisioned cluster. </summary>
        /// <param name="connectedClusterResourceUri"> The fully qualified Azure Resource Manager identifier of the connected cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedClusterResourceUri"/> is null. </exception>
        public Response<AgentPoolListResult> ListByProvisionedCluster(string connectedClusterResourceUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(connectedClusterResourceUri, nameof(connectedClusterResourceUri));

            using var message = CreateListByProvisionedClusterRequest(connectedClusterResourceUri);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AgentPoolListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = AgentPoolListResult.DeserializeAgentPoolListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByProvisionedClusterNextPageRequestUri(string nextLink, string connectedClusterResourceUri)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByProvisionedClusterNextPageRequest(string nextLink, string connectedClusterResourceUri)
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

        /// <summary> Gets the list of agent pools in the specified provisioned cluster. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="connectedClusterResourceUri"> The fully qualified Azure Resource Manager identifier of the connected cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="connectedClusterResourceUri"/> is null. </exception>
        public async Task<Response<AgentPoolListResult>> ListByProvisionedClusterNextPageAsync(string nextLink, string connectedClusterResourceUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(connectedClusterResourceUri, nameof(connectedClusterResourceUri));

            using var message = CreateListByProvisionedClusterNextPageRequest(nextLink, connectedClusterResourceUri);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AgentPoolListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = AgentPoolListResult.DeserializeAgentPoolListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the list of agent pools in the specified provisioned cluster. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="connectedClusterResourceUri"> The fully qualified Azure Resource Manager identifier of the connected cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="connectedClusterResourceUri"/> is null. </exception>
        public Response<AgentPoolListResult> ListByProvisionedClusterNextPage(string nextLink, string connectedClusterResourceUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(connectedClusterResourceUri, nameof(connectedClusterResourceUri));

            using var message = CreateListByProvisionedClusterNextPageRequest(nextLink, connectedClusterResourceUri);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AgentPoolListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = AgentPoolListResult.DeserializeAgentPoolListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
