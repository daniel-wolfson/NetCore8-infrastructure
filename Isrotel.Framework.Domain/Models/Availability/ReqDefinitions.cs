using Newtonsoft.Json;

namespace Isrotel.Domain.Optima.Models.Availability
{
    public class ReqDefinitions
    {
        [JsonProperty("isCityCodeSearchOnly")]
        public bool IsCityCodeSearchOnly { get; set; }
    }
}