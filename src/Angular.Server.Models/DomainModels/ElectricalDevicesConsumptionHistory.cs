namespace Angular.Server.Models.DomainModels
{
    using System;

    using Angular.Server.Models.SystemModels;

    public class ElectricalDevicesConsumptionHistory
    {
        public int Id { get; set; }

        public virtual ElectricalDevice ElectricalDevice { get; set; }

        public int ElectricalDeviceId { get; set; }

        public double PowerConsumptionRate { get; set; }

        public DateTime DateOfMeasure { get; set; }
    }
}
