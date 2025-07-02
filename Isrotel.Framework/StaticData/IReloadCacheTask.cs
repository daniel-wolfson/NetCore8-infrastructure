namespace Isrotel.Framework.StaticData
{
    public interface IReloadCacheTask
    {
        Task ExecuteAsync(CancellationToken stoppingToken);
    }
}