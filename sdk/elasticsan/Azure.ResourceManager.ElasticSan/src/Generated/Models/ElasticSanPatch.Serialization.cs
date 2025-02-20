// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ElasticSan.Models
{
    public partial class ElasticSanPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(BaseSizeTiB))
            {
                writer.WritePropertyName("baseSizeTiB");
                writer.WriteNumberValue(BaseSizeTiB.Value);
            }
            if (Optional.IsDefined(ExtendedCapacitySizeTiB))
            {
                writer.WritePropertyName("extendedCapacitySizeTiB");
                writer.WriteNumberValue(ExtendedCapacitySizeTiB.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
