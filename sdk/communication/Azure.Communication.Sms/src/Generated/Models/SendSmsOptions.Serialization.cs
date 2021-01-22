// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Sms
{
    public partial class SendSmsOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EnableDeliveryReport))
            {
                writer.WritePropertyName("enableDeliveryReport");
                writer.WriteBooleanValue(EnableDeliveryReport.Value);
            }
            if (Optional.IsDefined(Tag))
            {
                writer.WritePropertyName("tag");
                writer.WriteStringValue(Tag);
            }
            writer.WriteEndObject();
        }
    }
}
