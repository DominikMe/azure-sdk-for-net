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
using Azure.ResourceManager.DataMigration.Models;

namespace Azure.ResourceManager.DataMigration
{
    internal partial class DatabaseMigrationsSqlDbRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of DatabaseMigrationsSqlDbRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public DatabaseMigrationsSqlDbRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-03-30-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string sqlDBInstanceName, string targetDBName, Guid? migrationOperationId, string expand)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(sqlDBInstanceName, true);
            uri.AppendPath("/providers/Microsoft.DataMigration/databaseMigrations/", false);
            uri.AppendPath(targetDBName, true);
            if (migrationOperationId != null)
            {
                uri.AppendQuery("migrationOperationId", migrationOperationId.Value, true);
            }
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string sqlDBInstanceName, string targetDBName, Guid? migrationOperationId, string expand)
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
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(sqlDBInstanceName, true);
            uri.AppendPath("/providers/Microsoft.DataMigration/databaseMigrations/", false);
            uri.AppendPath(targetDBName, true);
            if (migrationOperationId != null)
            {
                uri.AppendQuery("migrationOperationId", migrationOperationId.Value, true);
            }
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieve the Database Migration resource. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="sqlDBInstanceName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="migrationOperationId"> Optional migration operation ID. If this is provided, then details of migration operation for that ID are retrieved. If not provided (default), then details related to most recent or current operation are retrieved. </param>
        /// <param name="expand"> Complete migration details be included in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlDBInstanceName"/> or <paramref name="targetDBName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlDBInstanceName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DatabaseMigrationSqlDBData>> GetAsync(string subscriptionId, string resourceGroupName, string sqlDBInstanceName, string targetDBName, Guid? migrationOperationId = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sqlDBInstanceName, nameof(sqlDBInstanceName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, sqlDBInstanceName, targetDBName, migrationOperationId, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseMigrationSqlDBData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = DatabaseMigrationSqlDBData.DeserializeDatabaseMigrationSqlDBData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DatabaseMigrationSqlDBData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve the Database Migration resource. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="sqlDBInstanceName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="migrationOperationId"> Optional migration operation ID. If this is provided, then details of migration operation for that ID are retrieved. If not provided (default), then details related to most recent or current operation are retrieved. </param>
        /// <param name="expand"> Complete migration details be included in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlDBInstanceName"/> or <paramref name="targetDBName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlDBInstanceName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DatabaseMigrationSqlDBData> Get(string subscriptionId, string resourceGroupName, string sqlDBInstanceName, string targetDBName, Guid? migrationOperationId = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sqlDBInstanceName, nameof(sqlDBInstanceName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, sqlDBInstanceName, targetDBName, migrationOperationId, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseMigrationSqlDBData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = DatabaseMigrationSqlDBData.DeserializeDatabaseMigrationSqlDBData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DatabaseMigrationSqlDBData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string subscriptionId, string resourceGroupName, string sqlDBInstanceName, string targetDBName, DatabaseMigrationSqlDBData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(sqlDBInstanceName, true);
            uri.AppendPath("/providers/Microsoft.DataMigration/databaseMigrations/", false);
            uri.AppendPath(targetDBName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string sqlDBInstanceName, string targetDBName, DatabaseMigrationSqlDBData data)
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
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(sqlDBInstanceName, true);
            uri.AppendPath("/providers/Microsoft.DataMigration/databaseMigrations/", false);
            uri.AppendPath(targetDBName, true);
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

        /// <summary> Create or Update Database Migration resource. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="sqlDBInstanceName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="data"> Details of Sql Db migration resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlDBInstanceName"/>, <paramref name="targetDBName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlDBInstanceName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string sqlDBInstanceName, string targetDBName, DatabaseMigrationSqlDBData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sqlDBInstanceName, nameof(sqlDBInstanceName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, sqlDBInstanceName, targetDBName, data);
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

        /// <summary> Create or Update Database Migration resource. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="sqlDBInstanceName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="data"> Details of Sql Db migration resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlDBInstanceName"/>, <paramref name="targetDBName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlDBInstanceName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string sqlDBInstanceName, string targetDBName, DatabaseMigrationSqlDBData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sqlDBInstanceName, nameof(sqlDBInstanceName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, sqlDBInstanceName, targetDBName, data);
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

        internal RequestUriBuilder CreateDeleteRequestUri(string subscriptionId, string resourceGroupName, string sqlDBInstanceName, string targetDBName, bool? force)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(sqlDBInstanceName, true);
            uri.AppendPath("/providers/Microsoft.DataMigration/databaseMigrations/", false);
            uri.AppendPath(targetDBName, true);
            if (force != null)
            {
                uri.AppendQuery("force", force.Value, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string sqlDBInstanceName, string targetDBName, bool? force)
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
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(sqlDBInstanceName, true);
            uri.AppendPath("/providers/Microsoft.DataMigration/databaseMigrations/", false);
            uri.AppendPath(targetDBName, true);
            if (force != null)
            {
                uri.AppendQuery("force", force.Value, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete Database Migration resource. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="sqlDBInstanceName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="force"> Optional force delete boolean. If this is provided as true, migration will be deleted even if active. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlDBInstanceName"/> or <paramref name="targetDBName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlDBInstanceName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string sqlDBInstanceName, string targetDBName, bool? force = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sqlDBInstanceName, nameof(sqlDBInstanceName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, sqlDBInstanceName, targetDBName, force);
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

        /// <summary> Delete Database Migration resource. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="sqlDBInstanceName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="force"> Optional force delete boolean. If this is provided as true, migration will be deleted even if active. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlDBInstanceName"/> or <paramref name="targetDBName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlDBInstanceName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string sqlDBInstanceName, string targetDBName, bool? force = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sqlDBInstanceName, nameof(sqlDBInstanceName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, sqlDBInstanceName, targetDBName, force);
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

        internal RequestUriBuilder CreateCancelRequestUri(string subscriptionId, string resourceGroupName, string sqlDBInstanceName, string targetDBName, MigrationOperationInput input)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(sqlDBInstanceName, true);
            uri.AppendPath("/providers/Microsoft.DataMigration/databaseMigrations/", false);
            uri.AppendPath(targetDBName, true);
            uri.AppendPath("/cancel", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCancelRequest(string subscriptionId, string resourceGroupName, string sqlDBInstanceName, string targetDBName, MigrationOperationInput input)
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
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(sqlDBInstanceName, true);
            uri.AppendPath("/providers/Microsoft.DataMigration/databaseMigrations/", false);
            uri.AppendPath(targetDBName, true);
            uri.AppendPath("/cancel", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(input, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Stop on going migration for the database. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="sqlDBInstanceName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="input"> Required migration operation ID for which cancel will be initiated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlDBInstanceName"/>, <paramref name="targetDBName"/> or <paramref name="input"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlDBInstanceName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CancelAsync(string subscriptionId, string resourceGroupName, string sqlDBInstanceName, string targetDBName, MigrationOperationInput input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sqlDBInstanceName, nameof(sqlDBInstanceName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));
            Argument.AssertNotNull(input, nameof(input));

            using var message = CreateCancelRequest(subscriptionId, resourceGroupName, sqlDBInstanceName, targetDBName, input);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Stop on going migration for the database. </summary>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="sqlDBInstanceName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="input"> Required migration operation ID for which cancel will be initiated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlDBInstanceName"/>, <paramref name="targetDBName"/> or <paramref name="input"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sqlDBInstanceName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Cancel(string subscriptionId, string resourceGroupName, string sqlDBInstanceName, string targetDBName, MigrationOperationInput input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sqlDBInstanceName, nameof(sqlDBInstanceName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));
            Argument.AssertNotNull(input, nameof(input));

            using var message = CreateCancelRequest(subscriptionId, resourceGroupName, sqlDBInstanceName, targetDBName, input);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
