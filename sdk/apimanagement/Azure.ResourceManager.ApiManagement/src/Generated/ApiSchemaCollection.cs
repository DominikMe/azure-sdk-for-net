// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiSchemaResource"/> and their operations.
    /// Each <see cref="ApiSchemaResource"/> in the collection will belong to the same instance of <see cref="ApiResource"/>.
    /// To get an <see cref="ApiSchemaCollection"/> instance call the GetApiSchemas method from an instance of <see cref="ApiResource"/>.
    /// </summary>
    public partial class ApiSchemaCollection : ArmCollection, IEnumerable<ApiSchemaResource>, IAsyncEnumerable<ApiSchemaResource>
    {
        private readonly ClientDiagnostics _apiSchemaClientDiagnostics;
        private readonly ApiSchemaRestOperations _apiSchemaRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiSchemaCollection"/> class for mocking. </summary>
        protected ApiSchemaCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiSchemaCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiSchemaCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiSchemaClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiSchemaResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiSchemaResource.ResourceType, out string apiSchemaApiVersion);
            _apiSchemaRestClient = new ApiSchemaRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiSchemaApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates schema configuration for the API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/schemas/{schemaId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiSchema_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="schemaId"> Schema id identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> The schema contents to apply. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiSchemaResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string schemaId, ApiSchemaData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaId, nameof(schemaId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiSchemaClientDiagnostics.CreateScope("ApiSchemaCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiSchemaRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiSchemaResource>(new ApiSchemaOperationSource(Client), _apiSchemaClientDiagnostics, Pipeline, _apiSchemaRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaId, data, ifMatch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates schema configuration for the API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/schemas/{schemaId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiSchema_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="schemaId"> Schema id identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> The schema contents to apply. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiSchemaResource> CreateOrUpdate(WaitUntil waitUntil, string schemaId, ApiSchemaData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaId, nameof(schemaId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiSchemaClientDiagnostics.CreateScope("ApiSchemaCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiSchemaRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaId, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiSchemaResource>(new ApiSchemaOperationSource(Client), _apiSchemaClientDiagnostics, Pipeline, _apiSchemaRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaId, data, ifMatch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the schema configuration at the API level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/schemas/{schemaId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiSchema_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaId"> Schema id identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaId"/> is null. </exception>
        public virtual async Task<Response<ApiSchemaResource>> GetAsync(string schemaId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaId, nameof(schemaId));

            using var scope = _apiSchemaClientDiagnostics.CreateScope("ApiSchemaCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiSchemaRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiSchemaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the schema configuration at the API level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/schemas/{schemaId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiSchema_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaId"> Schema id identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaId"/> is null. </exception>
        public virtual Response<ApiSchemaResource> Get(string schemaId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaId, nameof(schemaId));

            using var scope = _apiSchemaClientDiagnostics.CreateScope("ApiSchemaCollection.Get");
            scope.Start();
            try
            {
                var response = _apiSchemaRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiSchemaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the schema configuration at the API level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/schemas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiSchema_ListByApi</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| contentType | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiSchemaResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiSchemaResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiSchemaRestClient.CreateListByApiRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiSchemaRestClient.CreateListByApiNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiSchemaResource(Client, ApiSchemaData.DeserializeApiSchemaData(e)), _apiSchemaClientDiagnostics, Pipeline, "ApiSchemaCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the schema configuration at the API level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/schemas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiSchema_ListByApi</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| contentType | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiSchemaResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiSchemaResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiSchemaRestClient.CreateListByApiRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiSchemaRestClient.CreateListByApiNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiSchemaResource(Client, ApiSchemaData.DeserializeApiSchemaData(e)), _apiSchemaClientDiagnostics, Pipeline, "ApiSchemaCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/schemas/{schemaId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiSchema_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaId"> Schema id identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string schemaId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaId, nameof(schemaId));

            using var scope = _apiSchemaClientDiagnostics.CreateScope("ApiSchemaCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiSchemaRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/schemas/{schemaId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiSchema_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaId"> Schema id identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaId"/> is null. </exception>
        public virtual Response<bool> Exists(string schemaId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaId, nameof(schemaId));

            using var scope = _apiSchemaClientDiagnostics.CreateScope("ApiSchemaCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiSchemaRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/schemas/{schemaId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiSchema_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaId"> Schema id identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaId"/> is null. </exception>
        public virtual async Task<NullableResponse<ApiSchemaResource>> GetIfExistsAsync(string schemaId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaId, nameof(schemaId));

            using var scope = _apiSchemaClientDiagnostics.CreateScope("ApiSchemaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _apiSchemaRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApiSchemaResource>(response.GetRawResponse());
                return Response.FromValue(new ApiSchemaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/schemas/{schemaId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiSchema_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaId"> Schema id identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaId"/> is null. </exception>
        public virtual NullableResponse<ApiSchemaResource> GetIfExists(string schemaId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaId, nameof(schemaId));

            using var scope = _apiSchemaClientDiagnostics.CreateScope("ApiSchemaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _apiSchemaRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApiSchemaResource>(response.GetRawResponse());
                return Response.FromValue(new ApiSchemaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiSchemaResource> IEnumerable<ApiSchemaResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiSchemaResource> IAsyncEnumerable<ApiSchemaResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
