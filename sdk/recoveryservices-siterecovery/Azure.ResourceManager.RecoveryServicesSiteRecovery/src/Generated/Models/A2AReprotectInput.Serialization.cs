// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AReprotectInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryContainerId))
            {
                writer.WritePropertyName("recoveryContainerId");
                writer.WriteStringValue(RecoveryContainerId);
            }
            if (Optional.IsCollectionDefined(VmDisks))
            {
                writer.WritePropertyName("vmDisks");
                writer.WriteStartArray();
                foreach (var item in VmDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RecoveryResourceGroupId))
            {
                writer.WritePropertyName("recoveryResourceGroupId");
                writer.WriteStringValue(RecoveryResourceGroupId);
            }
            if (Optional.IsDefined(RecoveryCloudServiceId))
            {
                writer.WritePropertyName("recoveryCloudServiceId");
                writer.WriteStringValue(RecoveryCloudServiceId);
            }
            if (Optional.IsDefined(RecoveryAvailabilitySetId))
            {
                writer.WritePropertyName("recoveryAvailabilitySetId");
                writer.WriteStringValue(RecoveryAvailabilitySetId);
            }
            if (Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId");
                writer.WriteStringValue(PolicyId);
            }
            writer.WritePropertyName("instanceType");
            writer.WriteStringValue(InstanceType);
            writer.WriteEndObject();
        }
    }
}
