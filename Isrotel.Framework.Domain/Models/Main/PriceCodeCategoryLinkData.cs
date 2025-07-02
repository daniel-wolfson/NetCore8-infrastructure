using Isrotel.Domain.Optima.Models.Base;

namespace Isrotel.Domain.Optima.Models.Main
{
    public class PriceCodeCategoryLinkData : OptimaData
    {
        public int PriceCodeCategoryID { get; set; }
        public int HotelID { get; set; }
        public string PriceCode { get; set; }
    }
}