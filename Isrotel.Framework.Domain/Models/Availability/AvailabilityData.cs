﻿using Isrotel.Domain.Optima.Models.Base;

namespace Isrotel.Domain.Optima.Models.Availability
{
    public class AvailabilityData : OptimaData
    {
        public PackageToBookPerPax PackageToBookPerPax { get; set; }

        public RoomsAvailability? RoomsAvailability { get; set; } = null;

        public List<PctList>? PctList { get; set; } = null;

        public bool IsSplited { get; set; }
    }
}