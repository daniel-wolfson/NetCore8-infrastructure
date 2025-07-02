using Isrotel.Framework.Configuration.Models;
using Isrotel.Framework.StaticData.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Isrotel.Framework.StaticData.Contracts
{
    public interface IApiReloadTaskQueue
    {
        // Enqueues the given task.
        void EnqueueTask(SettingKeys settingKey, Func<IServiceScopeFactory, CancellationToken, Task> task);

        // Dequeues and returns one task. This method blocks until a task becomes available.
        Task<ReloadTaskQueueItem?> DequeueAsync(CancellationToken cancellationToken);

        bool Contains(SettingKeys settingKey);

        public bool IsEmpty { get; }
    }
}
