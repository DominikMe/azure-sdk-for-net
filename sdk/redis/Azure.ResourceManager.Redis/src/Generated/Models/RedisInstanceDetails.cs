// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> Details of single instance of redis. </summary>
    public partial class RedisInstanceDetails
    {
        /// <summary> Initializes a new instance of RedisInstanceDetails. </summary>
        internal RedisInstanceDetails()
        {
        }

        /// <summary> Initializes a new instance of RedisInstanceDetails. </summary>
        /// <param name="sslPort"> Redis instance SSL port. </param>
        /// <param name="nonSslPort"> If enableNonSslPort is true, provides Redis instance Non-SSL port. </param>
        /// <param name="zone"> If the Cache uses availability zones, specifies availability zone where this instance is located. </param>
        /// <param name="shardId"> If clustering is enabled, the Shard ID of Redis Instance. </param>
        /// <param name="isMaster"> Specifies whether the instance is a primary node. </param>
        /// <param name="isPrimary"> Specifies whether the instance is a primary node. </param>
        internal RedisInstanceDetails(int? sslPort, int? nonSslPort, string zone, int? shardId, bool? isMaster, bool? isPrimary)
        {
            SslPort = sslPort;
            NonSslPort = nonSslPort;
            Zone = zone;
            ShardId = shardId;
            IsMaster = isMaster;
            IsPrimary = isPrimary;
        }

        /// <summary> Redis instance SSL port. </summary>
        public int? SslPort { get; }
        /// <summary> If enableNonSslPort is true, provides Redis instance Non-SSL port. </summary>
        public int? NonSslPort { get; }
        /// <summary> If the Cache uses availability zones, specifies availability zone where this instance is located. </summary>
        public string Zone { get; }
        /// <summary> If clustering is enabled, the Shard ID of Redis Instance. </summary>
        public int? ShardId { get; }
        /// <summary> Specifies whether the instance is a primary node. </summary>
        public bool? IsMaster { get; }
        /// <summary> Specifies whether the instance is a primary node. </summary>
        public bool? IsPrimary { get; }
    }
}
