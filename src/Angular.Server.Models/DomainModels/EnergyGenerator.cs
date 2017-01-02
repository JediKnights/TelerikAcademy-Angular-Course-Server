namespace Angular.Server.Models.DomainModels
{
    using Angular.Server.Models.SystemModels;

    public class EnergyGenerator : AuditableEntity
    {
        public int Id { get; set; }

        public ElectricalDeviceModel ElectricalDeviceModel { get; set; }

        public int ElectricalDeviceModelId { get; set; }
    }
}
