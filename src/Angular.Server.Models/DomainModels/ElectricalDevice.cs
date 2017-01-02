namespace Angular.Server.Models.DomainModels
{
    using System;
    using SystemModels;

    public class ElectricalDevice : AuditableEntity
    {
        public int Id { get; set; }

        public string SerialNumber { get; set; }

        public virtual ElectricalDeviceModel ElectricalDeviceModel { get; set; }

        public int ElectricalDeviceModelId { get; set; }

        public virtual ElectricalSystem ElectricalSystem { get; set; }

        public int ElectricalSystemId { get; set; }

        public DateTime ManufacturingDate { get; set; }
    }
}
