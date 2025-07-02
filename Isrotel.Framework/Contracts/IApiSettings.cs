using Isrotel.Framework.Cache;
using Isrotel.Framework.Configuration;
using Isrotel.Framework.Configuration.Dal;
using Isrotel.Framework.Configuration.Optima;
using Isrotel.Framework.Configuration.Umbraco;
using Isrotel.Framework.Telemetry;

namespace Isrotel.Framework.Contracts
{
    public interface IApiSettings
    {
        public string Version { get; set; }
        public DalConfig Dal { get; set; }
        public OptimaConfig Optima { get; set; }
        public UmbracoConfig Umbraco { get; set; }
        public RedisConfig Redis { get; set; }
        public CurrencyConfig Currency { get; set; }
        public List<ConfigData> StaticData { get; set; }
        public AzureStorageConfig AzureStorage { get; set; }
        public OpenTelemetryConfig OpenTelemetry { get; set; }
        public string? EmptyTextReplacement { get; set; }
    }
}