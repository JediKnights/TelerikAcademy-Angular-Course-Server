namespace Angular.Server.Models.DomainModels
{
    using System;

    public class BatteryPackChargeHistory
    {
        public int Id { get; set; }

        public double ChargeLevel { get; set; }

        public DateTime DateOfMeasure { get; set; }
    }
}
