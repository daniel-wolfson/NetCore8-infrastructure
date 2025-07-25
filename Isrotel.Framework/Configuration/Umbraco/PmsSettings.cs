﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Isrotel.Framework.Configuration.Umbraco
{
    public class PmsSettings
    {
        [NotMapped]
        public CrmSettings CrmSettings { get; set; }

        [NotMapped]
        public List<HotelPmsSetting> HotelsPmsSettings { get; set; }
    }
}
