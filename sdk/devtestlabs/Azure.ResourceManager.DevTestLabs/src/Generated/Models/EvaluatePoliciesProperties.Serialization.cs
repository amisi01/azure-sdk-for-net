// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class EvaluatePoliciesProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FactName))
            {
                writer.WritePropertyName("factName");
                writer.WriteStringValue(FactName);
            }
            if (Optional.IsDefined(FactData))
            {
                writer.WritePropertyName("factData");
                writer.WriteStringValue(FactData);
            }
            if (Optional.IsDefined(ValueOffset))
            {
                writer.WritePropertyName("valueOffset");
                writer.WriteStringValue(ValueOffset);
            }
            if (Optional.IsDefined(UserObjectId))
            {
                writer.WritePropertyName("userObjectId");
                writer.WriteStringValue(UserObjectId);
            }
            writer.WriteEndObject();
        }
    }
}
