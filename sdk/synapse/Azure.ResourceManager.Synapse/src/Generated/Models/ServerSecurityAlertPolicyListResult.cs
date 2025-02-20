// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> A list of the workspace managed sql server&apos;s security alert policies. </summary>
    internal partial class ServerSecurityAlertPolicyListResult
    {
        /// <summary> Initializes a new instance of ServerSecurityAlertPolicyListResult. </summary>
        internal ServerSecurityAlertPolicyListResult()
        {
            Value = new ChangeTrackingList<ServerSecurityAlertPolicyData>();
        }

        /// <summary> Initializes a new instance of ServerSecurityAlertPolicyListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ServerSecurityAlertPolicyListResult(IReadOnlyList<ServerSecurityAlertPolicyData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ServerSecurityAlertPolicyData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
