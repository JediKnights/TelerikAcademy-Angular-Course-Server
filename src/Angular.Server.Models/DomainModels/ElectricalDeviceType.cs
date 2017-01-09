using System.Collections.Generic;

using Angular.Server.Models.SystemModels;

namespace Angular.Server.Models.DomainModels
{
    public class ElectricalDeviceType : AuditableEntity
    {
        private ICollection<ElectricalDeviceModel> electricalDeviceModels;

        public ElectricalDeviceType()
        {
            this.electricalDeviceModels = new HashSet<ElectricalDeviceModel>();
        }

        public int Id { get; set; }

        public string TypeName { get; set; }


        public ICollection<ElectricalDeviceModel> ElectricalDeviceModels
        {
            get { return this.electricalDeviceModels; }
            set { this.electricalDeviceModels = value; }
        }
    }
}
