// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary>
    /// A class representing a collection of <see cref="TaskResource" /> and their operations.
    /// Each <see cref="TaskResource" /> in the collection will belong to the same instance of <see cref="RegistryResource" />.
    /// To get a <see cref="TaskCollection" /> instance call the GetTasks method from an instance of <see cref="RegistryResource" />.
    /// </summary>
    public partial class TaskCollection : ArmCollection, IEnumerable<TaskResource>, IAsyncEnumerable<TaskResource>
    {
        private readonly ClientDiagnostics _taskClientDiagnostics;
        private readonly TasksRestOperations _taskRestClient;

        /// <summary> Initializes a new instance of the <see cref="TaskCollection"/> class for mocking. </summary>
        protected TaskCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TaskCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TaskCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _taskClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerRegistry", TaskResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TaskResource.ResourceType, out string taskApiVersion);
            _taskRestClient = new TasksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, taskApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != RegistryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, RegistryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a task for a container registry with the specified parameters.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tasks/{taskName}
        /// Operation Id: Tasks_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="taskName"> The name of the container registry task. </param>
        /// <param name="data"> The parameters for creating a task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<TaskResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string taskName, TaskData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskName, nameof(taskName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _taskClientDiagnostics.CreateScope("TaskCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _taskRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerRegistryArmOperation<TaskResource>(new TaskOperationSource(Client), _taskClientDiagnostics, Pipeline, _taskRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a task for a container registry with the specified parameters.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tasks/{taskName}
        /// Operation Id: Tasks_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="taskName"> The name of the container registry task. </param>
        /// <param name="data"> The parameters for creating a task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<TaskResource> CreateOrUpdate(WaitUntil waitUntil, string taskName, TaskData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskName, nameof(taskName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _taskClientDiagnostics.CreateScope("TaskCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _taskRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, data, cancellationToken);
                var operation = new ContainerRegistryArmOperation<TaskResource>(new TaskOperationSource(Client), _taskClientDiagnostics, Pipeline, _taskRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get the properties of a specified task.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tasks/{taskName}
        /// Operation Id: Tasks_Get
        /// </summary>
        /// <param name="taskName"> The name of the container registry task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> is null. </exception>
        public virtual async Task<Response<TaskResource>> GetAsync(string taskName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskName, nameof(taskName));

            using var scope = _taskClientDiagnostics.CreateScope("TaskCollection.Get");
            scope.Start();
            try
            {
                var response = await _taskRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TaskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the properties of a specified task.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tasks/{taskName}
        /// Operation Id: Tasks_Get
        /// </summary>
        /// <param name="taskName"> The name of the container registry task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> is null. </exception>
        public virtual Response<TaskResource> Get(string taskName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskName, nameof(taskName));

            using var scope = _taskClientDiagnostics.CreateScope("TaskCollection.Get");
            scope.Start();
            try
            {
                var response = _taskRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TaskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the tasks for a specified container registry.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tasks
        /// Operation Id: Tasks_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TaskResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TaskResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<TaskResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _taskClientDiagnostics.CreateScope("TaskCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _taskRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TaskResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<TaskResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _taskClientDiagnostics.CreateScope("TaskCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _taskRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TaskResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all the tasks for a specified container registry.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tasks
        /// Operation Id: Tasks_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TaskResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TaskResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<TaskResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _taskClientDiagnostics.CreateScope("TaskCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _taskRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TaskResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<TaskResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _taskClientDiagnostics.CreateScope("TaskCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _taskRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TaskResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tasks/{taskName}
        /// Operation Id: Tasks_Get
        /// </summary>
        /// <param name="taskName"> The name of the container registry task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string taskName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskName, nameof(taskName));

            using var scope = _taskClientDiagnostics.CreateScope("TaskCollection.Exists");
            scope.Start();
            try
            {
                var response = await _taskRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tasks/{taskName}
        /// Operation Id: Tasks_Get
        /// </summary>
        /// <param name="taskName"> The name of the container registry task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> is null. </exception>
        public virtual Response<bool> Exists(string taskName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskName, nameof(taskName));

            using var scope = _taskClientDiagnostics.CreateScope("TaskCollection.Exists");
            scope.Start();
            try
            {
                var response = _taskRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TaskResource> IEnumerable<TaskResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TaskResource> IAsyncEnumerable<TaskResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
