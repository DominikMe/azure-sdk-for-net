// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the NetworkInterface data model.
    /// A network interface in a resource group.
    /// </summary>
    public partial class NetworkInterfaceData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="NetworkInterfaceData"/>. </summary>
        public NetworkInterfaceData()
        {
            IPConfigurations = new ChangeTrackingList<NetworkInterfaceIPConfigurationData>();
            TapConfigurations = new ChangeTrackingList<NetworkInterfaceTapConfigurationData>();
            HostedWorkloads = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkInterfaceData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="extendedLocation"> The extended location of the network interface. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="virtualMachine"> The reference to a virtual machine. </param>
        /// <param name="networkSecurityGroup"> The reference to the NetworkSecurityGroup resource. </param>
        /// <param name="privateEndpoint"> A reference to the private endpoint to which the network interface is linked. </param>
        /// <param name="ipConfigurations"> A list of IPConfigurations of the network interface. </param>
        /// <param name="tapConfigurations"> A list of TapConfigurations of the network interface. </param>
        /// <param name="dnsSettings"> The DNS settings in network interface. </param>
        /// <param name="macAddress"> The MAC address of the network interface. </param>
        /// <param name="primary"> Whether this is a primary network interface on a virtual machine. </param>
        /// <param name="vnetEncryptionSupported"> Whether the virtual machine this nic is attached to supports encryption. </param>
        /// <param name="defaultOutboundConnectivityEnabled"> Whether default outbound connectivity for nic was configured or not. </param>
        /// <param name="enableAcceleratedNetworking"> If the network interface is configured for accelerated networking. Not applicable to VM sizes which require accelerated networking. </param>
        /// <param name="disableTcpStateTracking"> Indicates whether to disable tcp state tracking. </param>
        /// <param name="enableIPForwarding"> Indicates whether IP forwarding is enabled on this network interface. </param>
        /// <param name="hostedWorkloads"> A list of references to linked BareMetal resources. </param>
        /// <param name="dscpConfiguration"> A reference to the dscp configuration to which the network interface is linked. </param>
        /// <param name="resourceGuid"> The resource GUID property of the network interface resource. </param>
        /// <param name="provisioningState"> The provisioning state of the network interface resource. </param>
        /// <param name="workloadType"> WorkloadType of the NetworkInterface for BareMetal resources. </param>
        /// <param name="nicType"> Type of Network Interface resource. </param>
        /// <param name="privateLinkService"> Privatelinkservice of the network interface resource. </param>
        /// <param name="migrationPhase"> Migration phase of Network Interface resource. </param>
        /// <param name="auxiliaryMode"> Auxiliary mode of Network Interface resource. </param>
        /// <param name="auxiliarySku"> Auxiliary sku of Network Interface resource. </param>
        internal NetworkInterfaceData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, ExtendedLocation extendedLocation, ETag? etag, WritableSubResource virtualMachine, NetworkSecurityGroupData networkSecurityGroup, PrivateEndpointData privateEndpoint, IList<NetworkInterfaceIPConfigurationData> ipConfigurations, IReadOnlyList<NetworkInterfaceTapConfigurationData> tapConfigurations, NetworkInterfaceDnsSettings dnsSettings, string macAddress, bool? primary, bool? vnetEncryptionSupported, bool? defaultOutboundConnectivityEnabled, bool? enableAcceleratedNetworking, bool? disableTcpStateTracking, bool? enableIPForwarding, IReadOnlyList<string> hostedWorkloads, WritableSubResource dscpConfiguration, Guid? resourceGuid, NetworkProvisioningState? provisioningState, string workloadType, NetworkInterfaceNicType? nicType, PrivateLinkServiceData privateLinkService, NetworkInterfaceMigrationPhase? migrationPhase, NetworkInterfaceAuxiliaryMode? auxiliaryMode, NetworkInterfaceAuxiliarySku? auxiliarySku) : base(id, name, resourceType, location, tags, serializedAdditionalRawData)
        {
            ExtendedLocation = extendedLocation;
            ETag = etag;
            VirtualMachine = virtualMachine;
            NetworkSecurityGroup = networkSecurityGroup;
            PrivateEndpoint = privateEndpoint;
            IPConfigurations = ipConfigurations;
            TapConfigurations = tapConfigurations;
            DnsSettings = dnsSettings;
            MacAddress = macAddress;
            Primary = primary;
            VnetEncryptionSupported = vnetEncryptionSupported;
            DefaultOutboundConnectivityEnabled = defaultOutboundConnectivityEnabled;
            EnableAcceleratedNetworking = enableAcceleratedNetworking;
            DisableTcpStateTracking = disableTcpStateTracking;
            EnableIPForwarding = enableIPForwarding;
            HostedWorkloads = hostedWorkloads;
            DscpConfiguration = dscpConfiguration;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            WorkloadType = workloadType;
            NicType = nicType;
            PrivateLinkService = privateLinkService;
            MigrationPhase = migrationPhase;
            AuxiliaryMode = auxiliaryMode;
            AuxiliarySku = auxiliarySku;
        }

        /// <summary> The extended location of the network interface. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The reference to a virtual machine. </summary>
        internal WritableSubResource VirtualMachine { get; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier VirtualMachineId
        {
            get => VirtualMachine?.Id;
        }

        /// <summary> The reference to the NetworkSecurityGroup resource. </summary>
        public NetworkSecurityGroupData NetworkSecurityGroup { get; set; }
        /// <summary> A reference to the private endpoint to which the network interface is linked. </summary>
        public PrivateEndpointData PrivateEndpoint { get; }
        /// <summary> A list of IPConfigurations of the network interface. </summary>
        public IList<NetworkInterfaceIPConfigurationData> IPConfigurations { get; }
        /// <summary> A list of TapConfigurations of the network interface. </summary>
        public IReadOnlyList<NetworkInterfaceTapConfigurationData> TapConfigurations { get; }
        /// <summary> The DNS settings in network interface. </summary>
        public NetworkInterfaceDnsSettings DnsSettings { get; set; }
        /// <summary> The MAC address of the network interface. </summary>
        public string MacAddress { get; }
        /// <summary> Whether this is a primary network interface on a virtual machine. </summary>
        public bool? Primary { get; }
        /// <summary> Whether the virtual machine this nic is attached to supports encryption. </summary>
        public bool? VnetEncryptionSupported { get; }
        /// <summary> Whether default outbound connectivity for nic was configured or not. </summary>
        public bool? DefaultOutboundConnectivityEnabled { get; }
        /// <summary> If the network interface is configured for accelerated networking. Not applicable to VM sizes which require accelerated networking. </summary>
        public bool? EnableAcceleratedNetworking { get; set; }
        /// <summary> Indicates whether to disable tcp state tracking. </summary>
        public bool? DisableTcpStateTracking { get; set; }
        /// <summary> Indicates whether IP forwarding is enabled on this network interface. </summary>
        public bool? EnableIPForwarding { get; set; }
        /// <summary> A list of references to linked BareMetal resources. </summary>
        public IReadOnlyList<string> HostedWorkloads { get; }
        /// <summary> A reference to the dscp configuration to which the network interface is linked. </summary>
        internal WritableSubResource DscpConfiguration { get; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier DscpConfigurationId
        {
            get => DscpConfiguration?.Id;
        }

        /// <summary> The resource GUID property of the network interface resource. </summary>
        public Guid? ResourceGuid { get; }
        /// <summary> The provisioning state of the network interface resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> WorkloadType of the NetworkInterface for BareMetal resources. </summary>
        public string WorkloadType { get; set; }
        /// <summary> Type of Network Interface resource. </summary>
        public NetworkInterfaceNicType? NicType { get; set; }
        /// <summary> Privatelinkservice of the network interface resource. </summary>
        public PrivateLinkServiceData PrivateLinkService { get; set; }
        /// <summary> Migration phase of Network Interface resource. </summary>
        public NetworkInterfaceMigrationPhase? MigrationPhase { get; set; }
        /// <summary> Auxiliary mode of Network Interface resource. </summary>
        public NetworkInterfaceAuxiliaryMode? AuxiliaryMode { get; set; }
        /// <summary> Auxiliary sku of Network Interface resource. </summary>
        public NetworkInterfaceAuxiliarySku? AuxiliarySku { get; set; }
    }
}
