// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> This cannot be specified if networkPlugin is anything other than &apos;azure&apos;. </summary>
    public readonly partial struct NetworkMode : IEquatable<NetworkMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TransparentValue = "transparent";
        private const string BridgeValue = "bridge";

        /// <summary> No bridge is created. Intra-VM Pod to Pod communication is through IP routes created by Azure CNI. See [Transparent Mode](https://docs.microsoft.com/azure/aks/faq#transparent-mode) for more information. </summary>
        public static NetworkMode Transparent { get; } = new NetworkMode(TransparentValue);
        /// <summary> This is no longer supported. </summary>
        public static NetworkMode Bridge { get; } = new NetworkMode(BridgeValue);
        /// <summary> Determines if two <see cref="NetworkMode"/> values are the same. </summary>
        public static bool operator ==(NetworkMode left, NetworkMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkMode"/> values are not the same. </summary>
        public static bool operator !=(NetworkMode left, NetworkMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NetworkMode"/>. </summary>
        public static implicit operator NetworkMode(string value) => new NetworkMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
