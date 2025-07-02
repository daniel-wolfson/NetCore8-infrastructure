using Isrotel.Framework.Cache;
using Isrotel.Framework.Configuration.Dal;
using Isrotel.Framework.Configuration.Nop;
using Isrotel.Framework.Configuration.Optima;
using Isrotel.Framework.Configuration.Umbraco;
using Isrotel.Framework.Contracts;
using Isrotel.Framework.Telemetry;

namespace Isrotel.Framework.Configuration
{
    public class ApiSettings : IApiSettings
    {
        public required string Version { get; set; }
        public DalConfig Dal { get; set; } = null!;
        public OptimaConfig Optima { get; set; } = null!;
        public UmbracoConfig Umbraco { get; set; } = null!;
        public RedisConfig Redis { get; set; } = null!;
        public CurrencyConfig Currency { get; set; } = null!;
        public List<ConfigData> StaticData { get; set; } = null!;
        public AzureStorageConfig AzureStorage { get; set; } = null!;
        public OpenTelemetryConfig OpenTelemetry { get; set; } = null!;
        public string? EmptyTextReplacement { get; set; } = "...";
        public NopConfig Nop { get; set; }
    }
}