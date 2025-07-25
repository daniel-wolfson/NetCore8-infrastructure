﻿using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;

namespace Isrotel.Framework.Telemetry
{
    public class ApiCustomTelemetryProcessor : ITelemetryProcessor
    {
        private ITelemetryProcessor Next { get; set; }

        public ApiCustomTelemetryProcessor(ITelemetryProcessor next)
        {
            Next = next;
        }

        public void Process(ITelemetry item)
        {
            // Example: Filter out all requests to "/health" endpoint
            if (item is RequestTelemetry request && request.Url.AbsolutePath.Contains("/health"))
            {
                return; // Drop the telemetry item
            }

            // Example: Modify telemetry item
            if (item is TraceTelemetry trace)
            {
                trace.Properties["CustomProperty"] = "CustomValue";
            }

            // Pass the telemetry item to the next processor in the chain
            Next.Process(item);
        }
    }
}