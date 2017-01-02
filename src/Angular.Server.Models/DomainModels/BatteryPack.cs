namespace Angular.Server.Models.DomainModels
{
    using Angular.Server.Models.SystemModels;

    public class BatteryPack : AuditableEntity
    {
        public int Id { get; set; }

        public virtual BatteryPackModel BatteryPackModel { get; set; }

        public int BatteryPackModelId { get; set; }

        public double CurrentCharge { get; set; }
    }
}
