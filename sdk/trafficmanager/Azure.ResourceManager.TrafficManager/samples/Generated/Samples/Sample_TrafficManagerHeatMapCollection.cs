// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.TrafficManager.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.TrafficManager.Samples
{
    public partial class Sample_TrafficManagerHeatMapCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_HeatMapGET()
        {
            // Generated from example definition: specification/trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/examples/HeatMap-GET.json
            // this example is just showing the usage of "HeatMap_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrafficManagerProfileResource created on azure
            // for more information of creating TrafficManagerProfileResource, please refer to the document of TrafficManagerProfileResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "azuresdkfornetautoresttrafficmanager1323";
            string profileName = "azuresdkfornetautoresttrafficmanager3880";
            ResourceIdentifier trafficManagerProfileResourceId = TrafficManagerProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            TrafficManagerProfileResource trafficManagerProfile = client.GetTrafficManagerProfileResource(trafficManagerProfileResourceId);

            // get the collection of this TrafficManagerHeatMapResource
            TrafficManagerHeatMapCollection collection = trafficManagerProfile.GetTrafficManagerHeatMaps();

            // invoke the operation
            TrafficManagerHeatMapType heatMapType = TrafficManagerHeatMapType.Default;
            TrafficManagerHeatMapResource result = await collection.GetAsync(heatMapType);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TrafficManagerHeatMapData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_HeatMapGETWithNullValues()
        {
            // Generated from example definition: specification/trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/examples/HeatMap-GET-With-Null-Values.json
            // this example is just showing the usage of "HeatMap_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrafficManagerProfileResource created on azure
            // for more information of creating TrafficManagerProfileResource, please refer to the document of TrafficManagerProfileResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "azuresdkfornetautoresttrafficmanager1323";
            string profileName = "azuresdkfornetautoresttrafficmanager3880";
            ResourceIdentifier trafficManagerProfileResourceId = TrafficManagerProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            TrafficManagerProfileResource trafficManagerProfile = client.GetTrafficManagerProfileResource(trafficManagerProfileResourceId);

            // get the collection of this TrafficManagerHeatMapResource
            TrafficManagerHeatMapCollection collection = trafficManagerProfile.GetTrafficManagerHeatMaps();

            // invoke the operation
            TrafficManagerHeatMapType heatMapType = TrafficManagerHeatMapType.Default;
            TrafficManagerHeatMapResource result = await collection.GetAsync(heatMapType);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TrafficManagerHeatMapData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_HeatMapGETWithTopLeftBotRight()
        {
            // Generated from example definition: specification/trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/examples/HeatMap-GET-With-TopLeft-BotRight.json
            // this example is just showing the usage of "HeatMap_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrafficManagerProfileResource created on azure
            // for more information of creating TrafficManagerProfileResource, please refer to the document of TrafficManagerProfileResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "azuresdkfornetautoresttrafficmanager1323";
            string profileName = "azuresdkfornetautoresttrafficmanager3880";
            ResourceIdentifier trafficManagerProfileResourceId = TrafficManagerProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            TrafficManagerProfileResource trafficManagerProfile = client.GetTrafficManagerProfileResource(trafficManagerProfileResourceId);

            // get the collection of this TrafficManagerHeatMapResource
            TrafficManagerHeatMapCollection collection = trafficManagerProfile.GetTrafficManagerHeatMaps();

            // invoke the operation
            TrafficManagerHeatMapType heatMapType = TrafficManagerHeatMapType.Default;
            IEnumerable<double> topLeft = new double[] { 10, 50.001 };
            IEnumerable<double> botRight = new double[] { -50.001, 80 };
            TrafficManagerHeatMapResource result = await collection.GetAsync(heatMapType, topLeft: topLeft, botRight: botRight);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TrafficManagerHeatMapData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_HeatMapGET()
        {
            // Generated from example definition: specification/trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/examples/HeatMap-GET.json
            // this example is just showing the usage of "HeatMap_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrafficManagerProfileResource created on azure
            // for more information of creating TrafficManagerProfileResource, please refer to the document of TrafficManagerProfileResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "azuresdkfornetautoresttrafficmanager1323";
            string profileName = "azuresdkfornetautoresttrafficmanager3880";
            ResourceIdentifier trafficManagerProfileResourceId = TrafficManagerProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            TrafficManagerProfileResource trafficManagerProfile = client.GetTrafficManagerProfileResource(trafficManagerProfileResourceId);

            // get the collection of this TrafficManagerHeatMapResource
            TrafficManagerHeatMapCollection collection = trafficManagerProfile.GetTrafficManagerHeatMaps();

            // invoke the operation
            TrafficManagerHeatMapType heatMapType = TrafficManagerHeatMapType.Default;
            bool result = await collection.ExistsAsync(heatMapType);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_HeatMapGETWithNullValues()
        {
            // Generated from example definition: specification/trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/examples/HeatMap-GET-With-Null-Values.json
            // this example is just showing the usage of "HeatMap_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrafficManagerProfileResource created on azure
            // for more information of creating TrafficManagerProfileResource, please refer to the document of TrafficManagerProfileResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "azuresdkfornetautoresttrafficmanager1323";
            string profileName = "azuresdkfornetautoresttrafficmanager3880";
            ResourceIdentifier trafficManagerProfileResourceId = TrafficManagerProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            TrafficManagerProfileResource trafficManagerProfile = client.GetTrafficManagerProfileResource(trafficManagerProfileResourceId);

            // get the collection of this TrafficManagerHeatMapResource
            TrafficManagerHeatMapCollection collection = trafficManagerProfile.GetTrafficManagerHeatMaps();

            // invoke the operation
            TrafficManagerHeatMapType heatMapType = TrafficManagerHeatMapType.Default;
            bool result = await collection.ExistsAsync(heatMapType);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_HeatMapGETWithTopLeftBotRight()
        {
            // Generated from example definition: specification/trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/examples/HeatMap-GET-With-TopLeft-BotRight.json
            // this example is just showing the usage of "HeatMap_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrafficManagerProfileResource created on azure
            // for more information of creating TrafficManagerProfileResource, please refer to the document of TrafficManagerProfileResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "azuresdkfornetautoresttrafficmanager1323";
            string profileName = "azuresdkfornetautoresttrafficmanager3880";
            ResourceIdentifier trafficManagerProfileResourceId = TrafficManagerProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            TrafficManagerProfileResource trafficManagerProfile = client.GetTrafficManagerProfileResource(trafficManagerProfileResourceId);

            // get the collection of this TrafficManagerHeatMapResource
            TrafficManagerHeatMapCollection collection = trafficManagerProfile.GetTrafficManagerHeatMaps();

            // invoke the operation
            TrafficManagerHeatMapType heatMapType = TrafficManagerHeatMapType.Default;
            IEnumerable<double> topLeft = new double[] { 10, 50.001 };
            IEnumerable<double> botRight = new double[] { -50.001, 80 };
            bool result = await collection.ExistsAsync(heatMapType, topLeft: topLeft, botRight: botRight);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_HeatMapGET()
        {
            // Generated from example definition: specification/trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/examples/HeatMap-GET.json
            // this example is just showing the usage of "HeatMap_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrafficManagerProfileResource created on azure
            // for more information of creating TrafficManagerProfileResource, please refer to the document of TrafficManagerProfileResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "azuresdkfornetautoresttrafficmanager1323";
            string profileName = "azuresdkfornetautoresttrafficmanager3880";
            ResourceIdentifier trafficManagerProfileResourceId = TrafficManagerProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            TrafficManagerProfileResource trafficManagerProfile = client.GetTrafficManagerProfileResource(trafficManagerProfileResourceId);

            // get the collection of this TrafficManagerHeatMapResource
            TrafficManagerHeatMapCollection collection = trafficManagerProfile.GetTrafficManagerHeatMaps();

            // invoke the operation
            TrafficManagerHeatMapType heatMapType = TrafficManagerHeatMapType.Default;
            NullableResponse<TrafficManagerHeatMapResource> response = await collection.GetIfExistsAsync(heatMapType);
            TrafficManagerHeatMapResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                TrafficManagerHeatMapData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_HeatMapGETWithNullValues()
        {
            // Generated from example definition: specification/trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/examples/HeatMap-GET-With-Null-Values.json
            // this example is just showing the usage of "HeatMap_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrafficManagerProfileResource created on azure
            // for more information of creating TrafficManagerProfileResource, please refer to the document of TrafficManagerProfileResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "azuresdkfornetautoresttrafficmanager1323";
            string profileName = "azuresdkfornetautoresttrafficmanager3880";
            ResourceIdentifier trafficManagerProfileResourceId = TrafficManagerProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            TrafficManagerProfileResource trafficManagerProfile = client.GetTrafficManagerProfileResource(trafficManagerProfileResourceId);

            // get the collection of this TrafficManagerHeatMapResource
            TrafficManagerHeatMapCollection collection = trafficManagerProfile.GetTrafficManagerHeatMaps();

            // invoke the operation
            TrafficManagerHeatMapType heatMapType = TrafficManagerHeatMapType.Default;
            NullableResponse<TrafficManagerHeatMapResource> response = await collection.GetIfExistsAsync(heatMapType);
            TrafficManagerHeatMapResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                TrafficManagerHeatMapData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_HeatMapGETWithTopLeftBotRight()
        {
            // Generated from example definition: specification/trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/examples/HeatMap-GET-With-TopLeft-BotRight.json
            // this example is just showing the usage of "HeatMap_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrafficManagerProfileResource created on azure
            // for more information of creating TrafficManagerProfileResource, please refer to the document of TrafficManagerProfileResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "azuresdkfornetautoresttrafficmanager1323";
            string profileName = "azuresdkfornetautoresttrafficmanager3880";
            ResourceIdentifier trafficManagerProfileResourceId = TrafficManagerProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            TrafficManagerProfileResource trafficManagerProfile = client.GetTrafficManagerProfileResource(trafficManagerProfileResourceId);

            // get the collection of this TrafficManagerHeatMapResource
            TrafficManagerHeatMapCollection collection = trafficManagerProfile.GetTrafficManagerHeatMaps();

            // invoke the operation
            TrafficManagerHeatMapType heatMapType = TrafficManagerHeatMapType.Default;
            IEnumerable<double> topLeft = new double[] { 10, 50.001 };
            IEnumerable<double> botRight = new double[] { -50.001, 80 };
            NullableResponse<TrafficManagerHeatMapResource> response = await collection.GetIfExistsAsync(heatMapType, topLeft: topLeft, botRight: botRight);
            TrafficManagerHeatMapResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                TrafficManagerHeatMapData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
