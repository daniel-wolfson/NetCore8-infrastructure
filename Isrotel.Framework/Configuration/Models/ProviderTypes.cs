using Isrotel.Framework.Configuration.AzureStorage;
using Isrotel.Framework.Configuration.Dal;
using Isrotel.Framework.Configuration.Optima;
using Isrotel.Framework.Configuration.Umbraco;
using System.ComponentModel.DataAnnotations;

namespace Isrotel.Framework.Configuration.Models
{
    public static class ProviderTypes
    {
        [Display(ResourceType = typeof(object))]
        public const string Unknown = "Unknown";
        [Display(ResourceType = typeof(string))]
        public const string String = "String";
        [Display(ResourceType = typeof(int))]
        public const string Number = "Number";

        [Display(ResourceType = typeof(List<ConfigData>))]
        public const string All = "All";
        [Display(ResourceType = typeof(List<ConfigData>))]
        public const string AllPreload = "AllPreload"; 
        [Display(ResourceType = typeof(List<ConfigData>))]
        public const string AllPreloadStaticList = "AllPreloadStaticList";
        [Display(ResourceType = typeof(List<ConfigData>))]
        public const string StaticList = "StaticList";

        [Display(ResourceType = typeof(ApiBlobConfigurationProvider))]
        public const string AzureStorage = "AzureStorage";
        [Display(ResourceType = typeof(ApiOptimaConfigurationProvider))]
        public const string Optima = "Optima";
        [Display(ResourceType = typeof(ApiUmbracoConfigurationProvider))]
        public const string Umbraco = "Umbraco";
        [Display(ResourceType = typeof(ApiConfigurationProvider))]
        public const string Nop = "Nop";
        [Display(ResourceType = typeof(ApiDbConfigurationProvider))]
        public const string Dal = "Dal";
    }
}