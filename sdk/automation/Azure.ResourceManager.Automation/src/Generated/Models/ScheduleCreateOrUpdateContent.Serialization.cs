// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class ScheduleCreateOrUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("startTime");
            writer.WriteStringValue(StartOn, "O");
            if (Optional.IsDefined(ExpiryOn))
            {
                if (ExpiryOn != null)
                {
                    writer.WritePropertyName("expiryTime");
                    writer.WriteStringValue(ExpiryOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("expiryTime");
                }
            }
            if (Optional.IsDefined(Interval))
            {
                writer.WritePropertyName("interval");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Interval);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Interval.ToString()).RootElement);
#endif
            }
            writer.WritePropertyName("frequency");
            writer.WriteStringValue(Frequency.ToString());
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone");
                writer.WriteStringValue(TimeZone);
            }
            if (Optional.IsDefined(AdvancedSchedule))
            {
                writer.WritePropertyName("advancedSchedule");
                writer.WriteObjectValue(AdvancedSchedule);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
