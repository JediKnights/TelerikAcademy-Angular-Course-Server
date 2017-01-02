namespace Angular.Server.Models.DomainModels
{
    using System.Collections.Generic;
    using Angular.Server.Models.SystemModels;

    public class Manufacturer : AuditableEntity
    {
        private ICollection<ElectricalDeviceModel> electricalDeviceModels;

        private ICollection<BatteryPackModel> batteryPackModels;

        public Manufacturer()
        {
            this.electricalDeviceModels = new HashSet<ElectricalDeviceModel>();
            this.batteryPackModels = new HashSet<BatteryPackModel>();
        }
         
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<ElectricalDeviceModel> ElectricalDeviceModels
        {
            get { return this.electricalDeviceModels; }
            set { this.electricalDeviceModels = value; }
        }

        public virtual ICollection<BatteryPackModel> BatteryPackModels
        {
            get { return this.batteryPackModels; }
            set { this.batteryPackModels = value; }
        }
    }
}
