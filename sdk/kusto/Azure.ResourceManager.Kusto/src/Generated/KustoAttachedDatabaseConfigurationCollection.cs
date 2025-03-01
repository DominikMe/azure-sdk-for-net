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

namespace Azure.ResourceManager.Kusto
{
    /// <summary>
    /// A class representing a collection of <see cref="KustoAttachedDatabaseConfigurationResource"/> and their operations.
    /// Each <see cref="KustoAttachedDatabaseConfigurationResource"/> in the collection will belong to the same instance of <see cref="KustoClusterResource"/>.
    /// To get a <see cref="KustoAttachedDatabaseConfigurationCollection"/> instance call the GetKustoAttachedDatabaseConfigurations method from an instance of <see cref="KustoClusterResource"/>.
    /// </summary>
    public partial class KustoAttachedDatabaseConfigurationCollection : ArmCollection, IEnumerable<KustoAttachedDatabaseConfigurationResource>, IAsyncEnumerable<KustoAttachedDatabaseConfigurationResource>
    {
        private readonly ClientDiagnostics _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsClientDiagnostics;
        private readonly AttachedDatabaseConfigurationsRestOperations _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="KustoAttachedDatabaseConfigurationCollection"/> class for mocking. </summary>
        protected KustoAttachedDatabaseConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="KustoAttachedDatabaseConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal KustoAttachedDatabaseConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Kusto", KustoAttachedDatabaseConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(KustoAttachedDatabaseConfigurationResource.ResourceType, out string kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsApiVersion);
            _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsRestClient = new AttachedDatabaseConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != KustoClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, KustoClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an attached database configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/attachedDatabaseConfigurations/{attachedDatabaseConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedDatabaseConfigurations_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-13</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoAttachedDatabaseConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="attachedDatabaseConfigurationName"> The name of the attached database configuration. </param>
        /// <param name="data"> The database parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedDatabaseConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedDatabaseConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<KustoAttachedDatabaseConfigurationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string attachedDatabaseConfigurationName, KustoAttachedDatabaseConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedDatabaseConfigurationName, nameof(attachedDatabaseConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsClientDiagnostics.CreateScope("KustoAttachedDatabaseConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, attachedDatabaseConfigurationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new KustoArmOperation<KustoAttachedDatabaseConfigurationResource>(new KustoAttachedDatabaseConfigurationOperationSource(Client), _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsClientDiagnostics, Pipeline, _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, attachedDatabaseConfigurationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an attached database configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/attachedDatabaseConfigurations/{attachedDatabaseConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedDatabaseConfigurations_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-13</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoAttachedDatabaseConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="attachedDatabaseConfigurationName"> The name of the attached database configuration. </param>
        /// <param name="data"> The database parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedDatabaseConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedDatabaseConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<KustoAttachedDatabaseConfigurationResource> CreateOrUpdate(WaitUntil waitUntil, string attachedDatabaseConfigurationName, KustoAttachedDatabaseConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedDatabaseConfigurationName, nameof(attachedDatabaseConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsClientDiagnostics.CreateScope("KustoAttachedDatabaseConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, attachedDatabaseConfigurationName, data, cancellationToken);
                var operation = new KustoArmOperation<KustoAttachedDatabaseConfigurationResource>(new KustoAttachedDatabaseConfigurationOperationSource(Client), _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsClientDiagnostics, Pipeline, _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, attachedDatabaseConfigurationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Returns an attached database configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/attachedDatabaseConfigurations/{attachedDatabaseConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedDatabaseConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-13</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoAttachedDatabaseConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachedDatabaseConfigurationName"> The name of the attached database configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedDatabaseConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedDatabaseConfigurationName"/> is null. </exception>
        public virtual async Task<Response<KustoAttachedDatabaseConfigurationResource>> GetAsync(string attachedDatabaseConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedDatabaseConfigurationName, nameof(attachedDatabaseConfigurationName));

            using var scope = _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsClientDiagnostics.CreateScope("KustoAttachedDatabaseConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, attachedDatabaseConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KustoAttachedDatabaseConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns an attached database configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/attachedDatabaseConfigurations/{attachedDatabaseConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedDatabaseConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-13</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoAttachedDatabaseConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachedDatabaseConfigurationName"> The name of the attached database configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedDatabaseConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedDatabaseConfigurationName"/> is null. </exception>
        public virtual Response<KustoAttachedDatabaseConfigurationResource> Get(string attachedDatabaseConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedDatabaseConfigurationName, nameof(attachedDatabaseConfigurationName));

            using var scope = _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsClientDiagnostics.CreateScope("KustoAttachedDatabaseConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, attachedDatabaseConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KustoAttachedDatabaseConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the list of attached database configurations of the given Kusto cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/attachedDatabaseConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedDatabaseConfigurations_ListByCluster</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-13</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoAttachedDatabaseConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="KustoAttachedDatabaseConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<KustoAttachedDatabaseConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new KustoAttachedDatabaseConfigurationResource(Client, KustoAttachedDatabaseConfigurationData.DeserializeKustoAttachedDatabaseConfigurationData(e)), _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsClientDiagnostics, Pipeline, "KustoAttachedDatabaseConfigurationCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Returns the list of attached database configurations of the given Kusto cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/attachedDatabaseConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedDatabaseConfigurations_ListByCluster</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-13</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoAttachedDatabaseConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="KustoAttachedDatabaseConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<KustoAttachedDatabaseConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new KustoAttachedDatabaseConfigurationResource(Client, KustoAttachedDatabaseConfigurationData.DeserializeKustoAttachedDatabaseConfigurationData(e)), _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsClientDiagnostics, Pipeline, "KustoAttachedDatabaseConfigurationCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/attachedDatabaseConfigurations/{attachedDatabaseConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedDatabaseConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-13</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoAttachedDatabaseConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachedDatabaseConfigurationName"> The name of the attached database configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedDatabaseConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedDatabaseConfigurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string attachedDatabaseConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedDatabaseConfigurationName, nameof(attachedDatabaseConfigurationName));

            using var scope = _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsClientDiagnostics.CreateScope("KustoAttachedDatabaseConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, attachedDatabaseConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/attachedDatabaseConfigurations/{attachedDatabaseConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedDatabaseConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-13</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoAttachedDatabaseConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachedDatabaseConfigurationName"> The name of the attached database configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedDatabaseConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedDatabaseConfigurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string attachedDatabaseConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedDatabaseConfigurationName, nameof(attachedDatabaseConfigurationName));

            using var scope = _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsClientDiagnostics.CreateScope("KustoAttachedDatabaseConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, attachedDatabaseConfigurationName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/attachedDatabaseConfigurations/{attachedDatabaseConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedDatabaseConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-13</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoAttachedDatabaseConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachedDatabaseConfigurationName"> The name of the attached database configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedDatabaseConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedDatabaseConfigurationName"/> is null. </exception>
        public virtual async Task<NullableResponse<KustoAttachedDatabaseConfigurationResource>> GetIfExistsAsync(string attachedDatabaseConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedDatabaseConfigurationName, nameof(attachedDatabaseConfigurationName));

            using var scope = _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsClientDiagnostics.CreateScope("KustoAttachedDatabaseConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, attachedDatabaseConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<KustoAttachedDatabaseConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new KustoAttachedDatabaseConfigurationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/attachedDatabaseConfigurations/{attachedDatabaseConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedDatabaseConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-13</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KustoAttachedDatabaseConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachedDatabaseConfigurationName"> The name of the attached database configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedDatabaseConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedDatabaseConfigurationName"/> is null. </exception>
        public virtual NullableResponse<KustoAttachedDatabaseConfigurationResource> GetIfExists(string attachedDatabaseConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedDatabaseConfigurationName, nameof(attachedDatabaseConfigurationName));

            using var scope = _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsClientDiagnostics.CreateScope("KustoAttachedDatabaseConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _kustoAttachedDatabaseConfigurationAttachedDatabaseConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, attachedDatabaseConfigurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<KustoAttachedDatabaseConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new KustoAttachedDatabaseConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<KustoAttachedDatabaseConfigurationResource> IEnumerable<KustoAttachedDatabaseConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<KustoAttachedDatabaseConfigurationResource> IAsyncEnumerable<KustoAttachedDatabaseConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
