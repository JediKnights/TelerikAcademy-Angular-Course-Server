namespace Angular.Server.Models.DomainModels
{
    using System;

    using Angular.Server.Models.SystemModels;

    public class EnergyGeneratorProductionHistory
    {
        public int Id { get; set; }

        public virtual EnergyGenerator EnergyGenerator { get; set; }

        public int EnergyGeneratorId { get; set; }

        public double PowerProductionRate { get; set; }

        public DateTime DateOfMeasure { get; set; }
    }
}
