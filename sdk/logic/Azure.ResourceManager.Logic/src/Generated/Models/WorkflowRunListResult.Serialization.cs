// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    internal partial class WorkflowRunListResult
    {
        internal static WorkflowRunListResult DeserializeWorkflowRunListResult(JsonElement element)
        {
            Optional<IReadOnlyList<WorkflowRunData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<WorkflowRunData> array = new List<WorkflowRunData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkflowRunData.DeserializeWorkflowRunData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new WorkflowRunListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
