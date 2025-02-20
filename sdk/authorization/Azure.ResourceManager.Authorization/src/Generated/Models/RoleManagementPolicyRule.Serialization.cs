// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class RoleManagementPolicyRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("ruleType");
            writer.WriteStringValue(RuleType.ToString());
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target");
                writer.WriteObjectValue(Target);
            }
            writer.WriteEndObject();
        }

        internal static RoleManagementPolicyRule DeserializeRoleManagementPolicyRule(JsonElement element)
        {
            if (element.TryGetProperty("ruleType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "RoleManagementPolicyApprovalRule": return RoleManagementPolicyApprovalRule.DeserializeRoleManagementPolicyApprovalRule(element);
                    case "RoleManagementPolicyAuthenticationContextRule": return RoleManagementPolicyAuthenticationContextRule.DeserializeRoleManagementPolicyAuthenticationContextRule(element);
                    case "RoleManagementPolicyEnablementRule": return RoleManagementPolicyEnablementRule.DeserializeRoleManagementPolicyEnablementRule(element);
                    case "RoleManagementPolicyExpirationRule": return RoleManagementPolicyExpirationRule.DeserializeRoleManagementPolicyExpirationRule(element);
                    case "RoleManagementPolicyNotificationRule": return RoleManagementPolicyNotificationRule.DeserializeRoleManagementPolicyNotificationRule(element);
                }
            }
            Optional<string> id = default;
            RoleManagementPolicyRuleType ruleType = default;
            Optional<RoleManagementPolicyRuleTarget> target = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleType"))
                {
                    ruleType = new RoleManagementPolicyRuleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    target = RoleManagementPolicyRuleTarget.DeserializeRoleManagementPolicyRuleTarget(property.Value);
                    continue;
                }
            }
            return new UnknownRoleManagementPolicyRule(id.Value, ruleType, target.Value);
        }
    }
}
