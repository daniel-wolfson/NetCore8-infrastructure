using System.ComponentModel.DataAnnotations;

namespace Isrotel.Domain.Optima.Models.Availability
{
    public static class PriceCodes
    {
        [Display(Description = "Best Available Rate")]
        public static string BAR => "BAR";

        [Display(Description = "Best Available Rate")]
        public static string CLUB_RATE => "Club Rate";
    }
}