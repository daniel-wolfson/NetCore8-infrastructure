using Newtonsoft.Json;

namespace Isrotel.Domain.Optima.Models.Availability
{
    public class FromDateObj
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }
    }
}