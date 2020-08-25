// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace OpenTelemetry.Exporter.AzureMonitor.Models
{
    /// <summary> An instance of PageViewPerf represents: a page view with no performance data, a page view with performance data, or just the performance data of an earlier page request. </summary>
    public partial class PageViewPerfData : MonitorDomain
    {
        /// <summary> Initializes a new instance of PageViewPerfData. </summary>
        /// <param name="ver"> Schema version. </param>
        /// <param name="id"> Identifier of a page view instance. Used for correlation between page view and other telemetry items. </param>
        /// <param name="name"> Event name. Keep it low cardinality to allow proper grouping and useful metrics. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="name"/> is null. </exception>
        public PageViewPerfData(int ver, string id, string name)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Ver = ver;
            Id = id;
            Name = name;
            Properties = new ChangeTrackingDictionary<string, string>();
            Measurements = new ChangeTrackingDictionary<string, double>();
        }

        /// <summary> Initializes a new instance of PageViewPerfData. </summary>
        /// <param name="test"> Ignored value. </param>
        /// <param name="ver"> Schema version. </param>
        /// <param name="id"> Identifier of a page view instance. Used for correlation between page view and other telemetry items. </param>
        /// <param name="name"> Event name. Keep it low cardinality to allow proper grouping and useful metrics. </param>
        /// <param name="url"> Request URL with all query string parameters. </param>
        /// <param name="duration"> Request duration in format: DD.HH:MM:SS.MMMMMM. For a page view (PageViewData), this is the duration. For a page view with performance information (PageViewPerfData), this is the page load time. Must be less than 1000 days. </param>
        /// <param name="perfTotal"> Performance total in TimeSpan &apos;G&apos; (general long) format: d:hh:mm:ss.fffffff. </param>
        /// <param name="networkConnect"> Network connection time in TimeSpan &apos;G&apos; (general long) format: d:hh:mm:ss.fffffff. </param>
        /// <param name="sentRequest"> Sent request time in TimeSpan &apos;G&apos; (general long) format: d:hh:mm:ss.fffffff. </param>
        /// <param name="receivedResponse"> Received response time in TimeSpan &apos;G&apos; (general long) format: d:hh:mm:ss.fffffff. </param>
        /// <param name="domProcessing"> DOM processing time in TimeSpan &apos;G&apos; (general long) format: d:hh:mm:ss.fffffff. </param>
        /// <param name="properties"> Collection of custom properties. TODO: max key length validate. </param>
        /// <param name="measurements"> Collection of custom measurements. TODO: max key length validate. </param>
        internal PageViewPerfData(string test, int ver, string id, string name, string url, TimeSpan? duration, TimeSpan? perfTotal, TimeSpan? networkConnect, TimeSpan? sentRequest, TimeSpan? receivedResponse, TimeSpan? domProcessing, IDictionary<string, string> properties, IDictionary<string, double> measurements) : base(test)
        {
            Ver = ver;
            Id = id;
            Name = name;
            Url = url;
            Duration = duration;
            PerfTotal = perfTotal;
            NetworkConnect = networkConnect;
            SentRequest = sentRequest;
            ReceivedResponse = receivedResponse;
            DomProcessing = domProcessing;
            Properties = properties;
            Measurements = measurements;
        }

        /// <summary> Schema version. </summary>
        public int Ver { get; set; }
        /// <summary> Identifier of a page view instance. Used for correlation between page view and other telemetry items. </summary>
        public string Id { get; set; }
        /// <summary> Event name. Keep it low cardinality to allow proper grouping and useful metrics. </summary>
        public string Name { get; set; }
        /// <summary> Request URL with all query string parameters. </summary>
        public string Url { get; set; }
        /// <summary> Request duration in format: DD.HH:MM:SS.MMMMMM. For a page view (PageViewData), this is the duration. For a page view with performance information (PageViewPerfData), this is the page load time. Must be less than 1000 days. </summary>
        public TimeSpan? Duration { get; set; }
        /// <summary> Performance total in TimeSpan &apos;G&apos; (general long) format: d:hh:mm:ss.fffffff. </summary>
        public TimeSpan? PerfTotal { get; set; }
        /// <summary> Network connection time in TimeSpan &apos;G&apos; (general long) format: d:hh:mm:ss.fffffff. </summary>
        public TimeSpan? NetworkConnect { get; set; }
        /// <summary> Sent request time in TimeSpan &apos;G&apos; (general long) format: d:hh:mm:ss.fffffff. </summary>
        public TimeSpan? SentRequest { get; set; }
        /// <summary> Received response time in TimeSpan &apos;G&apos; (general long) format: d:hh:mm:ss.fffffff. </summary>
        public TimeSpan? ReceivedResponse { get; set; }
        /// <summary> DOM processing time in TimeSpan &apos;G&apos; (general long) format: d:hh:mm:ss.fffffff. </summary>
        public TimeSpan? DomProcessing { get; set; }
        /// <summary> Collection of custom properties. TODO: max key length validate. </summary>
        public IDictionary<string, string> Properties { get; }
        /// <summary> Collection of custom measurements. TODO: max key length validate. </summary>
        public IDictionary<string, double> Measurements { get; }
    }
}