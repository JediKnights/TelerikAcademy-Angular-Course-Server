using System;

namespace Angular.Server.Models.DomainModels
{
    public class BatteryPackChargeHistory
    {
        public int Id { get; set; }

        public double ChargeLevel { get; set; }

        public DateTime DateOfMeasure { get; set; }
    }
}
