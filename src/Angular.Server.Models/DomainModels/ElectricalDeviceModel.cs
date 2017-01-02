namespace Angular.Server.Models.DomainModels
{
    using Angular.Server.Models.SystemModels;
    using System.Collections.Generic;

    public class ElectricalDeviceModel : AuditableEntity
    {
        private ICollection<ElectricalDevice> electricalDevices;

        public ElectricalDeviceModel()
        {
            this.electricalDevices = new HashSet<ElectricalDevice>();
        }

        public int Id { get; set; }

        public string ModelName { get; set; }

        public string Description { get; set; }

        public string MeasuringUnit { get; set; }

        public double MinValue { get; set; }

        public double MaxValue { get; set; }

        public double Step { get; set; }

        public double PowerPerStep { get; set; }

        public double PowerAtLowestUnitLevel { get; set; }

        public string ModelIdentifier { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        public int ManufacturerId { get; set; }

        public virtual ElectricalDeviceType ElectricalDeviceType { get; set; }

        public int ElectricalDeviceTypeId { get; set; }

        public virtual ICollection<ElectricalDevice> ElectricalDevices
        {
            get { return this.electricalDevices; }
            set { this.electricalDevices = value; }
        }
    }
}
