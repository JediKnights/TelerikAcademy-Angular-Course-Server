using System;

namespace Angular.Server.Models.DomainModels
{
    public class ElectricalDevicesConsumptionHistory
    {
        public int Id { get; set; }

        public virtual ElectricalDevice ElectricalDevice { get; set; }

        public int ElectricalDeviceId { get; set; }

        public double PowerConsumptionRate { get; set; }

        public DateTime DateOfMeasure { get; set; }
    }
}
