namespace Angular.Server.WebAPI.Models.ElectricalDevice
{
    public class ElectricalDeviceEditModel
    {
        public int Id { get; set; }

        public string SerialNumber { get; set; }

        public string ModelName { get; set; }

        public int ManufacturerId { get; set; }

        public double? MeasuringUnitCurrentLevel { get; set; }

        public int ElectricalDeviceModelId { get; set; }

        public int ElectricalSystemId { get; set; }
    }
}
