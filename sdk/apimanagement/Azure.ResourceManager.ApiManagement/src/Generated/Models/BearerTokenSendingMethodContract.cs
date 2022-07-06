// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Form of an authorization grant, which the client uses to request the access token. </summary>
    public readonly partial struct BearerTokenSendingMethodContract : IEquatable<BearerTokenSendingMethodContract>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BearerTokenSendingMethodContract"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BearerTokenSendingMethodContract(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AuthorizationHeaderValue = "authorizationHeader";
        private const string QueryValue = "query";

        /// <summary> Access token will be transmitted in the Authorization header using Bearer schema. </summary>
        public static BearerTokenSendingMethodContract AuthorizationHeader { get; } = new BearerTokenSendingMethodContract(AuthorizationHeaderValue);
        /// <summary> Access token will be transmitted as query parameters. </summary>
        public static BearerTokenSendingMethodContract Query { get; } = new BearerTokenSendingMethodContract(QueryValue);
        /// <summary> Determines if two <see cref="BearerTokenSendingMethodContract"/> values are the same. </summary>
        public static bool operator ==(BearerTokenSendingMethodContract left, BearerTokenSendingMethodContract right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BearerTokenSendingMethodContract"/> values are not the same. </summary>
        public static bool operator !=(BearerTokenSendingMethodContract left, BearerTokenSendingMethodContract right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BearerTokenSendingMethodContract"/>. </summary>
        public static implicit operator BearerTokenSendingMethodContract(string value) => new BearerTokenSendingMethodContract(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BearerTokenSendingMethodContract other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BearerTokenSendingMethodContract other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
