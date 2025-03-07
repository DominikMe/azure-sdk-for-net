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
using Azure.ResourceManager.HardwareSecurityModules.Models;

namespace Azure.ResourceManager.HardwareSecurityModules
{
    internal partial class CloudHsmClusterRestoreStatusRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of CloudHsmClusterRestoreStatusRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public CloudHsmClusterRestoreStatusRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-06-30-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string jobId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/", false);
            uri.AppendPath(cloudHsmClusterName, true);
            uri.AppendPath("/restoreOperationStatus/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string jobId)
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
            uri.AppendPath("/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/", false);
            uri.AppendPath(cloudHsmClusterName, true);
            uri.AppendPath("/restoreOperationStatus/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the restore operation status of the specified Cloud HSM Cluster. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudHsmClusterName"> The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster names must be between 3 and 23 characters in length. </param>
        /// <param name="jobId"> The id returned as part of the backup request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudHsmClusterName"/> or <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudHsmClusterName"/> or <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CloudHsmClusterRestoreResult>> GetAsync(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string jobId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudHsmClusterName, nameof(cloudHsmClusterName));
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, cloudHsmClusterName, jobId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CloudHsmClusterRestoreResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = CloudHsmClusterRestoreResult.DeserializeCloudHsmClusterRestoreResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 202:
                    return Response.FromValue((CloudHsmClusterRestoreResult)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the restore operation status of the specified Cloud HSM Cluster. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudHsmClusterName"> The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster names must be between 3 and 23 characters in length. </param>
        /// <param name="jobId"> The id returned as part of the backup request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudHsmClusterName"/> or <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudHsmClusterName"/> or <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CloudHsmClusterRestoreResult> Get(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string jobId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudHsmClusterName, nameof(cloudHsmClusterName));
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, cloudHsmClusterName, jobId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CloudHsmClusterRestoreResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = CloudHsmClusterRestoreResult.DeserializeCloudHsmClusterRestoreResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 202:
                    return Response.FromValue((CloudHsmClusterRestoreResult)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
