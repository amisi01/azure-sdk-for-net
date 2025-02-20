// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Enables or disables a capability on the dedicated host group.&lt;br&gt;&lt;br&gt;Minimum api-version: 2022-03-01. </summary>
    internal partial class DedicatedHostGroupPropertiesAdditionalCapabilities
    {
        /// <summary> Initializes a new instance of DedicatedHostGroupPropertiesAdditionalCapabilities. </summary>
        public DedicatedHostGroupPropertiesAdditionalCapabilities()
        {
        }

        /// <summary> Initializes a new instance of DedicatedHostGroupPropertiesAdditionalCapabilities. </summary>
        /// <param name="ultraSsdEnabled"> The flag that enables or disables a capability to have UltraSSD Enabled Virtual Machines on Dedicated Hosts of the Dedicated Host Group. For the Virtual Machines to be UltraSSD Enabled, UltraSSDEnabled flag for the resource needs to be set true as well. The value is defaulted to &apos;false&apos; when not provided. Please refer to https://docs.microsoft.com/en-us/azure/virtual-machines/disks-enable-ultra-ssd for more details on Ultra SSD feature. &lt;br&gt;&lt;br&gt;NOTE: The ultraSSDEnabled setting can only be enabled for Host Groups that are created as zonal. &lt;br&gt;&lt;br&gt;Minimum api-version: 2022-03-01. </param>
        internal DedicatedHostGroupPropertiesAdditionalCapabilities(bool? ultraSsdEnabled)
        {
            UltraSsdEnabled = ultraSsdEnabled;
        }

        /// <summary> The flag that enables or disables a capability to have UltraSSD Enabled Virtual Machines on Dedicated Hosts of the Dedicated Host Group. For the Virtual Machines to be UltraSSD Enabled, UltraSSDEnabled flag for the resource needs to be set true as well. The value is defaulted to &apos;false&apos; when not provided. Please refer to https://docs.microsoft.com/en-us/azure/virtual-machines/disks-enable-ultra-ssd for more details on Ultra SSD feature. &lt;br&gt;&lt;br&gt;NOTE: The ultraSSDEnabled setting can only be enabled for Host Groups that are created as zonal. &lt;br&gt;&lt;br&gt;Minimum api-version: 2022-03-01. </summary>
        public bool? UltraSsdEnabled { get; set; }
    }
}
