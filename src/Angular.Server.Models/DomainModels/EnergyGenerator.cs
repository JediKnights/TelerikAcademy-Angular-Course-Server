using Angular.Server.Models.SystemModels;

namespace Angular.Server.Models.DomainModels
{
    public class EnergyGenerator : AuditableEntity
    {
        public int Id { get; set; }

        public string SerialNumber { get; set; }

        public ElectricalDeviceModel ElectricalDeviceModel { get; set; }

        public int ElectricalDeviceModelId { get; set; }
    }
}
