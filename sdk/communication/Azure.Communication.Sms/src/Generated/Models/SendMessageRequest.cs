// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.Sms
{
    /// <summary> Represents the properties of a send message request. </summary>
    internal partial class SendMessageRequest
    {
        /// <summary> Initializes a new instance of SendMessageRequest. </summary>
        /// <param name="from"> The sender&apos;s phone number in E.164 format that is owned by the authenticated account. </param>
        /// <param name="to"> The recipient&apos;s phone number in E.164 format. In this version, a minimum of 1 and upto 100 recipients in the list are supported. </param>
        /// <param name="message"> The contents of the message that will be sent to the recipient. The allowable content is defined by RFC 5724. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="from"/>, <paramref name="to"/>, or <paramref name="message"/> is null. </exception>
        public SendMessageRequest(string @from, IEnumerable<string> to, string message)
        {
            if (@from == null)
            {
                throw new ArgumentNullException(nameof(@from));
            }
            if (to == null)
            {
                throw new ArgumentNullException(nameof(to));
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            From = @from;
            To = to.ToList();
            Message = message;
        }

        /// <summary> The sender&apos;s phone number in E.164 format that is owned by the authenticated account. </summary>
        public string From { get; }
        /// <summary> The recipient&apos;s phone number in E.164 format. In this version, a minimum of 1 and upto 100 recipients in the list are supported. </summary>
        public IList<string> To { get; }
        /// <summary> The contents of the message that will be sent to the recipient. The allowable content is defined by RFC 5724. </summary>
        public string Message { get; }
        /// <summary> Optional configuration for sending SMS messages. </summary>
        public SendSmsOptions SendSmsOptions { get; set; }
    }
}
