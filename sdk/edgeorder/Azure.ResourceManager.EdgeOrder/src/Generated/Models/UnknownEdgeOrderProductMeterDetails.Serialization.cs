// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    internal partial class UnknownEdgeOrderProductMeterDetails
    {
        internal static UnknownEdgeOrderProductMeterDetails DeserializeUnknownEdgeOrderProductMeterDetails(JsonElement element)
        {
            BillingType billingType = default;
            Optional<double> multiplier = default;
            Optional<EdgeOrderProductChargingType> chargingType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("billingType"))
                {
                    billingType = new BillingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("multiplier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    multiplier = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("chargingType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    chargingType = new EdgeOrderProductChargingType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownEdgeOrderProductMeterDetails(billingType, Optional.ToNullable(multiplier), Optional.ToNullable(chargingType));
        }
    }
}
