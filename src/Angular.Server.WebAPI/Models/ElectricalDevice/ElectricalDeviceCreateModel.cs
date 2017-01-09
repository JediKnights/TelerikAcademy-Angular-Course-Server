using System;

namespace Angular.Server.WebAPI.Models.ElectricalDevice
{
    public class ElectricalDeviceCreateModel
    {
        public string SerialNumber { get; set; }

        public double? MeasuringUnitCurrentLevel { get; set; }

        public int ElectricalDeviceModelId { get; set; }

        public int ElectricalSystemId { get; set; }

        public DateTime ManufacturingDate { get; set; }
    }
}
