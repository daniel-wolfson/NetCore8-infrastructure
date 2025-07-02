using Isrotel.Framework.Configuration.Optima;

namespace Isrotel.Framework.Configuration.Umbraco
{
    public class OptimaSiteSettings
    {
        public int OptimaSiteSettingsId { get; set; }
        public int HomeRootNodeId { get; set; }
        public CustomerIds OptimaCustomerId { get; set; }

        public int OptimaSettingsId { get; set; }
        public OptimaSettings OptimaSettings { get; set; }
    }
}
