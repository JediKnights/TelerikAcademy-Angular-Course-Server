using System;

namespace Angular.Server.Models.DomainModels
{
    public class EnergyGeneratorProductionHistory
    {
        public int Id { get; set; }

        public virtual EnergyGenerator EnergyGenerator { get; set; }

        public int EnergyGeneratorId { get; set; }

        public double PowerProductionRate { get; set; }

        public DateTime DateOfMeasure { get; set; }
    }
}
