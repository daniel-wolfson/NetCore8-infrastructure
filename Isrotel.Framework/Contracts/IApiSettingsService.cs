using Isrotel.Framework.Configuration;
using Isrotel.Framework.Configuration.Models;
using Microsoft.Extensions.Caching.Memory;

namespace Isrotel.Framework.Contracts
{
    public interface IApiSettingsService_
    {
        T? Get<T>(SettingKeys requestedSettings);

        Task<T?> GetAsync<T>(SettingKeys requestedSettings);

        Task<bool> SetAsync<T>(string blobName, T data);

        ApiSettings? GetAll(ApiSettings? _apiSettings);

        Task<ApiSettings?> GetAllAsync();
    }
}