namespace Angular.Server.WebAPI.Models
{
    public class ElectricalDeviceModelViewModel
    {
        public string ModelName { get; set; }

        public string Description { get; set; }

        public string MeasuringUnit { get; set; }

        public double MinValue { get; set; }

        public double MaxValue { get; set; }

        public double Step { get; set; }

        public double PowerPerStep { get; set; }

        public double PowerAtLowestUnitLevel { get; set; }

        public string ManufacturerName { get; set; }

        public int ManufacturerId { get; set; }

        public string ElectricalDeviceTypeName { get; set; }
    }
}
