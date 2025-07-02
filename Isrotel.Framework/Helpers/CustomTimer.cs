using Isrotel.Framework.Configuration.Models;

namespace Isrotel.Framework.Helpers
{
    public class CustomTimer(SettingKeys key, string sourceType, int reloadInterval) 
        : System.Timers.Timer(reloadInterval)
    {
        public SettingKeys SettingKey { get; set; } = key;
        public string SourceType { get; set; } = sourceType;
    }
}
