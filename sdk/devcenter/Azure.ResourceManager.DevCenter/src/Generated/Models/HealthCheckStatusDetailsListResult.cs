// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevCenter;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> Result of the network health check list operation. </summary>
    internal partial class HealthCheckStatusDetailsListResult
    {
        /// <summary> Initializes a new instance of HealthCheckStatusDetailsListResult. </summary>
        internal HealthCheckStatusDetailsListResult()
        {
            Value = new ChangeTrackingList<HealthCheckStatusDetailData>();
        }

        /// <summary> Initializes a new instance of HealthCheckStatusDetailsListResult. </summary>
        /// <param name="value"> Current page of results. </param>
        /// <param name="nextLink"> URL to get the next set of results if there are any. </param>
        internal HealthCheckStatusDetailsListResult(IReadOnlyList<HealthCheckStatusDetailData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Current page of results. </summary>
        public IReadOnlyList<HealthCheckStatusDetailData> Value { get; }
        /// <summary> URL to get the next set of results if there are any. </summary>
        public string NextLink { get; }
    }
}
