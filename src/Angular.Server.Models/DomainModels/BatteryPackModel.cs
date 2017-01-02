namespace Angular.Server.Models.DomainModels
{
    using System.Collections.Generic;

    using Angular.Server.Models.SystemModels;

    public class BatteryPackModel : AuditableEntity
    {
        private ICollection<BatteryPack> batteryPacks;

        public BatteryPackModel()
        {
            this.batteryPacks = new HashSet<BatteryPack>();
        }

        public int Id { get; set; }

        public string ModelName { get; set; }

        public string Description { get; set; }

        public int? Capacity { get; set; }

        public Manufacturer Manufacturer { get; set; }

        public int ManufacturerId { get; set; }

        public virtual ICollection<BatteryPack> BatteryPacks
        {
            get { return this.batteryPacks; }
            set { this.batteryPacks = value; }
        }
    }
}
