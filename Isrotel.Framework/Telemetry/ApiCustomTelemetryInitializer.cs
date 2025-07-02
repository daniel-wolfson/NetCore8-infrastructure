using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility;

namespace Isrotel.Framework.Telemetry
{
    public class ApiCustomTelemetryInitializer : ITelemetryInitializer
    {
        public void Initialize(ITelemetry telemetry)
        {
            // Custom logic to initialize telemetry
        }
    }
}