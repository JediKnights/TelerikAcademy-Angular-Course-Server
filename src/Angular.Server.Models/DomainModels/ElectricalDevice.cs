using System;

using Angular.Server.Models.SystemModels;

namespace Angular.Server.Models.DomainModels
{
    public class ElectricalDevice : AuditableEntity
    {
        public int Id { get; set; }

        public string SerialNumber { get; set; }

        public double? MeasuringUnitCurrentLevel { get; set; }

        public virtual ElectricalDeviceModel ElectricalDeviceModel { get; set; }

        public int ElectricalDeviceModelId { get; set; }

        public virtual ElectricalSystem ElectricalSystem { get; set; }

        public int ElectricalSystemId { get; set; }

        public DateTime ManufacturingDate { get; set; }
    }
}
