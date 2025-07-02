using Isrotel.Framework.Configuration.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Isrotel.Framework.StaticData.Services
{
    public class ReloadTaskQueueItem
    {
        public SettingKeys SettingKey { get; set; }
        public Func<IServiceScopeFactory, CancellationToken, Task> GetReloadTask { get; set; } = default!;
    }
}
