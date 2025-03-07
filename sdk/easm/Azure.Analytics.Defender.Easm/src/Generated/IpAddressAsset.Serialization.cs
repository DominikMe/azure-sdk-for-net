// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    public partial class IpAddressAsset : IUtf8JsonSerializable, IJsonModel<IpAddressAsset>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IpAddressAsset>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IpAddressAsset>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IpAddressAsset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IpAddressAsset)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(IpAddress))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IpAddress);
            }
            if (Optional.IsCollectionDefined(Asns))
            {
                writer.WritePropertyName("asns"u8);
                writer.WriteStartArray();
                foreach (var item in Asns)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Reputations))
            {
                writer.WritePropertyName("reputations"u8);
                writer.WriteStartArray();
                foreach (var item in Reputations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(WebComponents))
            {
                writer.WritePropertyName("webComponents"u8);
                writer.WriteStartArray();
                foreach (var item in WebComponents)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NetRanges))
            {
                writer.WritePropertyName("netRanges"u8);
                writer.WriteStartArray();
                foreach (var item in NetRanges)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Headers))
            {
                writer.WritePropertyName("headers"u8);
                writer.WriteStartArray();
                foreach (var item in Headers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Attributes))
            {
                writer.WritePropertyName("attributes"u8);
                writer.WriteStartArray();
                foreach (var item in Attributes)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Cookies))
            {
                writer.WritePropertyName("cookies"u8);
                writer.WriteStartArray();
                foreach (var item in Cookies)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SslCerts))
            {
                writer.WritePropertyName("sslCerts"u8);
                writer.WriteStartArray();
                foreach (var item in SslCerts)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Services))
            {
                writer.WritePropertyName("services"u8);
                writer.WriteStartArray();
                foreach (var item in Services)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IpBlocks))
            {
                writer.WritePropertyName("ipBlocks"u8);
                writer.WriteStartArray();
                foreach (var item in IpBlocks)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Sources))
            {
                writer.WritePropertyName("sources"u8);
                writer.WriteStartArray();
                foreach (var item in Sources)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FirstSeen))
            {
                writer.WritePropertyName("firstSeen"u8);
                writer.WriteStringValue(FirstSeen.Value, "O");
            }
            if (Optional.IsDefined(LastSeen))
            {
                writer.WritePropertyName("lastSeen"u8);
                writer.WriteStringValue(LastSeen.Value, "O");
            }
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (Optional.IsCollectionDefined(Banners))
            {
                writer.WritePropertyName("banners"u8);
                writer.WriteStartArray();
                foreach (var item in Banners)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ScanMetadata))
            {
                writer.WritePropertyName("scanMetadata"u8);
                writer.WriteStartArray();
                foreach (var item in ScanMetadata)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NsRecord))
            {
                writer.WritePropertyName("nsRecord"u8);
                writer.WriteStartArray();
                foreach (var item in NsRecord)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MxRecord))
            {
                writer.WritePropertyName("mxRecord"u8);
                writer.WriteStartArray();
                foreach (var item in MxRecord)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStartArray();
                foreach (var item in Location)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Hosts))
            {
                writer.WritePropertyName("hosts"u8);
                writer.WriteStartArray();
                foreach (var item in Hosts)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Nxdomain))
            {
                writer.WritePropertyName("nxdomain"u8);
                writer.WriteStartArray();
                foreach (var item in Nxdomain)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SslServerConfig))
            {
                writer.WritePropertyName("sslServerConfig"u8);
                writer.WriteStartArray();
                foreach (var item in SslServerConfig)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Ipv4))
            {
                writer.WritePropertyName("ipv4"u8);
                writer.WriteBooleanValue(Ipv4.Value);
            }
            if (Optional.IsDefined(Ipv6))
            {
                writer.WritePropertyName("ipv6"u8);
                writer.WriteBooleanValue(Ipv6.Value);
            }
        }

        IpAddressAsset IJsonModel<IpAddressAsset>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IpAddressAsset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IpAddressAsset)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIpAddressAsset(document.RootElement, options);
        }

        internal static IpAddressAsset DeserializeIpAddressAsset(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ipAddress = default;
            IReadOnlyList<ObservedLong> asns = default;
            IReadOnlyList<ReputationDetails> reputations = default;
            IReadOnlyList<WebComponent> webComponents = default;
            IReadOnlyList<ObservedString> netRanges = default;
            IReadOnlyList<ObservedHeader> headers = default;
            IReadOnlyList<AttributeDetails> attributes = default;
            IReadOnlyList<CookieDetails> cookies = default;
            IReadOnlyList<SslCertAsset> sslCerts = default;
            IReadOnlyList<AssetService> services = default;
            IReadOnlyList<IpBlock> ipBlocks = default;
            IReadOnlyList<SourceDetails> sources = default;
            DateTimeOffset? firstSeen = default;
            DateTimeOffset? lastSeen = default;
            long? count = default;
            IReadOnlyList<BannerDetails> banners = default;
            IReadOnlyList<ScanMetadata> scanMetadata = default;
            IReadOnlyList<ObservedBoolean> nsRecord = default;
            IReadOnlyList<ObservedBoolean> mxRecord = default;
            IReadOnlyList<ObservedLocation> location = default;
            IReadOnlyList<ObservedString> hosts = default;
            IReadOnlyList<ObservedBoolean> nxdomain = default;
            IReadOnlyList<SslServerConfig> sslServerConfig = default;
            bool? ipv4 = default;
            bool? ipv6 = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipAddress"u8))
                {
                    ipAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("asns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedLong> array = new List<ObservedLong>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedLong.DeserializeObservedLong(item, options));
                    }
                    asns = array;
                    continue;
                }
                if (property.NameEquals("reputations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReputationDetails> array = new List<ReputationDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReputationDetails.DeserializeReputationDetails(item, options));
                    }
                    reputations = array;
                    continue;
                }
                if (property.NameEquals("webComponents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WebComponent> array = new List<WebComponent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WebComponent.DeserializeWebComponent(item, options));
                    }
                    webComponents = array;
                    continue;
                }
                if (property.NameEquals("netRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    netRanges = array;
                    continue;
                }
                if (property.NameEquals("headers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedHeader> array = new List<ObservedHeader>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedHeader.DeserializeObservedHeader(item, options));
                    }
                    headers = array;
                    continue;
                }
                if (property.NameEquals("attributes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AttributeDetails> array = new List<AttributeDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AttributeDetails.DeserializeAttributeDetails(item, options));
                    }
                    attributes = array;
                    continue;
                }
                if (property.NameEquals("cookies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CookieDetails> array = new List<CookieDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CookieDetails.DeserializeCookieDetails(item, options));
                    }
                    cookies = array;
                    continue;
                }
                if (property.NameEquals("sslCerts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SslCertAsset> array = new List<SslCertAsset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SslCertAsset.DeserializeSslCertAsset(item, options));
                    }
                    sslCerts = array;
                    continue;
                }
                if (property.NameEquals("services"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AssetService> array = new List<AssetService>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AssetService.DeserializeAssetService(item, options));
                    }
                    services = array;
                    continue;
                }
                if (property.NameEquals("ipBlocks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IpBlock> array = new List<IpBlock>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IpBlock.DeserializeIpBlock(item, options));
                    }
                    ipBlocks = array;
                    continue;
                }
                if (property.NameEquals("sources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SourceDetails> array = new List<SourceDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SourceDetails.DeserializeSourceDetails(item, options));
                    }
                    sources = array;
                    continue;
                }
                if (property.NameEquals("firstSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("banners"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BannerDetails> array = new List<BannerDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BannerDetails.DeserializeBannerDetails(item, options));
                    }
                    banners = array;
                    continue;
                }
                if (property.NameEquals("scanMetadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScanMetadata> array = new List<ScanMetadata>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Easm.ScanMetadata.DeserializeScanMetadata(item, options));
                    }
                    scanMetadata = array;
                    continue;
                }
                if (property.NameEquals("nsRecord"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedBoolean> array = new List<ObservedBoolean>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedBoolean.DeserializeObservedBoolean(item, options));
                    }
                    nsRecord = array;
                    continue;
                }
                if (property.NameEquals("mxRecord"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedBoolean> array = new List<ObservedBoolean>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedBoolean.DeserializeObservedBoolean(item, options));
                    }
                    mxRecord = array;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedLocation> array = new List<ObservedLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedLocation.DeserializeObservedLocation(item, options));
                    }
                    location = array;
                    continue;
                }
                if (property.NameEquals("hosts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    hosts = array;
                    continue;
                }
                if (property.NameEquals("nxdomain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedBoolean> array = new List<ObservedBoolean>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedBoolean.DeserializeObservedBoolean(item, options));
                    }
                    nxdomain = array;
                    continue;
                }
                if (property.NameEquals("sslServerConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SslServerConfig> array = new List<SslServerConfig>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Easm.SslServerConfig.DeserializeSslServerConfig(item, options));
                    }
                    sslServerConfig = array;
                    continue;
                }
                if (property.NameEquals("ipv4"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipv4 = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ipv6"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipv6 = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IpAddressAsset(
                serializedAdditionalRawData,
                ipAddress,
                asns ?? new ChangeTrackingList<ObservedLong>(),
                reputations ?? new ChangeTrackingList<ReputationDetails>(),
                webComponents ?? new ChangeTrackingList<WebComponent>(),
                netRanges ?? new ChangeTrackingList<ObservedString>(),
                headers ?? new ChangeTrackingList<ObservedHeader>(),
                attributes ?? new ChangeTrackingList<AttributeDetails>(),
                cookies ?? new ChangeTrackingList<CookieDetails>(),
                sslCerts ?? new ChangeTrackingList<SslCertAsset>(),
                services ?? new ChangeTrackingList<AssetService>(),
                ipBlocks ?? new ChangeTrackingList<IpBlock>(),
                sources ?? new ChangeTrackingList<SourceDetails>(),
                firstSeen,
                lastSeen,
                count,
                banners ?? new ChangeTrackingList<BannerDetails>(),
                scanMetadata ?? new ChangeTrackingList<ScanMetadata>(),
                nsRecord ?? new ChangeTrackingList<ObservedBoolean>(),
                mxRecord ?? new ChangeTrackingList<ObservedBoolean>(),
                location ?? new ChangeTrackingList<ObservedLocation>(),
                hosts ?? new ChangeTrackingList<ObservedString>(),
                nxdomain ?? new ChangeTrackingList<ObservedBoolean>(),
                sslServerConfig ?? new ChangeTrackingList<SslServerConfig>(),
                ipv4,
                ipv6);
        }

        BinaryData IPersistableModel<IpAddressAsset>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IpAddressAsset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IpAddressAsset)} does not support writing '{options.Format}' format.");
            }
        }

        IpAddressAsset IPersistableModel<IpAddressAsset>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IpAddressAsset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeIpAddressAsset(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IpAddressAsset)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IpAddressAsset>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new IpAddressAsset FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeIpAddressAsset(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
