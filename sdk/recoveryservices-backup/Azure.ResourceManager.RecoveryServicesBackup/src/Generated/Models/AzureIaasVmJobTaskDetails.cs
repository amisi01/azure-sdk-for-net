// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Azure IaaS VM workload-specific job task details. </summary>
    public partial class AzureIaasVmJobTaskDetails
    {
        /// <summary> Initializes a new instance of AzureIaasVmJobTaskDetails. </summary>
        public AzureIaasVmJobTaskDetails()
        {
        }

        /// <summary> Initializes a new instance of AzureIaasVmJobTaskDetails. </summary>
        /// <param name="taskId"> The task display name. </param>
        /// <param name="startOn"> The start time. </param>
        /// <param name="endOn"> The end time. </param>
        /// <param name="instanceId"> The instanceId. </param>
        /// <param name="duration"> Time elapsed for task. </param>
        /// <param name="status"> The status. </param>
        /// <param name="progressPercentage"> Progress of the task. </param>
        /// <param name="taskExecutionDetails">
        /// Details about execution of the task.
        /// eg: number of bytes transferred etc
        /// </param>
        internal AzureIaasVmJobTaskDetails(string taskId, DateTimeOffset? startOn, DateTimeOffset? endOn, string instanceId, TimeSpan? duration, string status, double? progressPercentage, string taskExecutionDetails)
        {
            TaskId = taskId;
            StartOn = startOn;
            EndOn = endOn;
            InstanceId = instanceId;
            Duration = duration;
            Status = status;
            ProgressPercentage = progressPercentage;
            TaskExecutionDetails = taskExecutionDetails;
        }

        /// <summary> The task display name. </summary>
        public string TaskId { get; set; }
        /// <summary> The start time. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> The end time. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> The instanceId. </summary>
        public string InstanceId { get; set; }
        /// <summary> Time elapsed for task. </summary>
        public TimeSpan? Duration { get; set; }
        /// <summary> The status. </summary>
        public string Status { get; set; }
        /// <summary> Progress of the task. </summary>
        public double? ProgressPercentage { get; set; }
        /// <summary>
        /// Details about execution of the task.
        /// eg: number of bytes transferred etc
        /// </summary>
        public string TaskExecutionDetails { get; set; }
    }
}
