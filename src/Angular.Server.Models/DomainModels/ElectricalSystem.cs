namespace Angular.Server.Models.DomainModels
{
    using System.Collections.Generic;

    using Angular.Server.Models.SystemModels;

    public class ElectricalSystem : AuditableEntity
    {
        private ICollection<ElectricalDevice> electricalDevices;

        public ElectricalSystem()
        {
            this.electricalDevices = new HashSet<ElectricalDevice>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual BaseUnit BaseUnit { get; set; }

        public int BaseUnitId { get; set; }

        public virtual ElectricalSystemType ElectricalSystemType { get; set; }

        public int ElectricalSystemTypeId { get; set; }

        public ICollection<ElectricalDevice> ElectricalDevices
        {
            get { return this.electricalDevices; }
            set { this.electricalDevices = value; }
        }
    }
}
