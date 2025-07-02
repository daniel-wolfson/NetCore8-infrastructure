using Microsoft.Extensions.Configuration;

namespace Isrotel.Framework.Configuration
{
    public class ApiConfigurationReloader
    {
        private readonly IConfigurationRoot _configurationRoot;

        public ApiConfigurationReloader(IConfiguration configuration)
        {
            _configurationRoot = (IConfigurationRoot)configuration;
        }

        public void ReloadConfiguration()
        {
            _configurationRoot.Reload();
        }
    }
}

