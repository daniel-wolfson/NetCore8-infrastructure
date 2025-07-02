using Isrotel.Framework.Configuration.Models;

namespace Isrotel.Framework.Contracts
{
    public interface IApiConfigurationFactory
    {
        Task InitConfigurationSources(SettingKeys rootSectionSettingKey, CancellationToken? cancelToken = null);
    }
}