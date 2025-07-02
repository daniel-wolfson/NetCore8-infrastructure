using Isrotel.Framework.Configuration.Models;

namespace Isrotel.Framework.Contracts
{
    public interface IApiConfigurationSource
    {
        int Order { get; set; }
        int? ReloadInterval { get; set; }
        bool? ReloadOnChange { get; set; }
        int? ReloadTimeout { get; set; }
        string ResourceType { get; set; }
        string SourceType { get; set; }
        SettingKeys SettingKey { get; set; }
        SettingKeys RootSettingKey { get; set; }

    }
}