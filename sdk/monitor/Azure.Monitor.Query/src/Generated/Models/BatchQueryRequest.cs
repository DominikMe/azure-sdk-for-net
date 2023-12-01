// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> An single request in a batch. </summary>
    internal partial class BatchQueryRequest
    {
        /// <summary> Initializes a new instance of <see cref="BatchQueryRequest"/>. </summary>
        /// <param name="id"> Unique ID corresponding to each request in the batch. </param>
        /// <param name="body"> The Analytics query. Learn more about the [Analytics query syntax](https://azure.microsoft.com/documentation/articles/app-insights-analytics-reference/). </param>
        /// <param name="workspace"> Primary Workspace ID of the query. This is the Workspace ID from the Properties blade in the Azure portal. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="body"/> or <paramref name="workspace"/> is null. </exception>
        public BatchQueryRequest(string id, QueryBody body, string workspace)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(body, nameof(body));
            Argument.AssertNotNull(workspace, nameof(workspace));

            Id = id;
            Headers = new ChangeTrackingDictionary<string, string>();
            Body = body;
            Path = "/query";
            Method = "POST";
            Workspace = workspace;
        }

        /// <summary> Initializes a new instance of <see cref="BatchQueryRequest"/>. </summary>
        /// <param name="id"> Unique ID corresponding to each request in the batch. </param>
        /// <param name="headers"> Headers of the request. Can use prefer header to set server timeout and to query statistics and visualization information. </param>
        /// <param name="body"> The Analytics query. Learn more about the [Analytics query syntax](https://azure.microsoft.com/documentation/articles/app-insights-analytics-reference/). </param>
        /// <param name="path"> The query path of a single request in a batch, defaults to /query. </param>
        /// <param name="method"> The method of a single request in a batch, defaults to POST. </param>
        /// <param name="workspace"> Primary Workspace ID of the query. This is the Workspace ID from the Properties blade in the Azure portal. </param>
        internal BatchQueryRequest(string id, IDictionary<string, string> headers, QueryBody body, string path, string method, string workspace)
        {
            Id = id;
            Headers = headers;
            Body = body;
            Path = path;
            Method = method;
            Workspace = workspace;
        }

        /// <summary> Unique ID corresponding to each request in the batch. </summary>
        public string Id { get; }
        /// <summary> Headers of the request. Can use prefer header to set server timeout and to query statistics and visualization information. </summary>
        public IDictionary<string, string> Headers { get; }
        /// <summary> The Analytics query. Learn more about the [Analytics query syntax](https://azure.microsoft.com/documentation/articles/app-insights-analytics-reference/). </summary>
        public QueryBody Body { get; }
        /// <summary> The query path of a single request in a batch, defaults to /query. </summary>
        public string Path { get; }
        /// <summary> The method of a single request in a batch, defaults to POST. </summary>
        public string Method { get; }
        /// <summary> Primary Workspace ID of the query. This is the Workspace ID from the Properties blade in the Azure portal. </summary>
        public string Workspace { get; }
    }
}
