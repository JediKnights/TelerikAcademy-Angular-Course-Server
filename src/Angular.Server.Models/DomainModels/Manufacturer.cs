using System.Collections.Generic;

using Angular.Server.Models.SystemModels;

namespace Angular.Server.Models.DomainModels
{
    public class Manufacturer : AuditableEntity
    {
        private ICollection<ElectricalDeviceModel> electricalDeviceModels;

        public Manufacturer()
        {
            this.electricalDeviceModels = new HashSet<ElectricalDeviceModel>();
        }
         
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<ElectricalDeviceModel> ElectricalDeviceModels
        {
            get { return this.electricalDeviceModels; }
            set { this.electricalDeviceModels = value; }
        }
    }
}
