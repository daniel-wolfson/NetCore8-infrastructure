using Isrotel.Domain.Optima.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Isrotel.Domain.Optima.Models.Main
{
    public class PriceGroupData : OptimaData
    {
        public string PriceGroupId { get; set; }
        public int HotelID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}