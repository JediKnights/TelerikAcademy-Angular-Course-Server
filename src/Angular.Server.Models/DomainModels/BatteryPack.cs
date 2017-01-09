using Angular.Server.Models.SystemModels;

namespace Angular.Server.Models.DomainModels
{
    public class BatteryPack : AuditableEntity
    {
        public int Id { get; set; }

        public string SerialNumber { get; set; }

        public virtual ElectricalDeviceModel ElectricalDeviceModel { get; set; }

        public int ElectricalDeviceModelId { get; set; }

        public double CurrentCharge { get; set; }
    }
}
