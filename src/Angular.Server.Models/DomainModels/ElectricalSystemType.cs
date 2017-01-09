using System.Collections.Generic;

using Angular.Server.Models.SystemModels;

namespace Angular.Server.Models.DomainModels
{
    public class ElectricalSystemType : AuditableEntity
    {
        private ICollection<ElectricalSystem> electricalSystems;

        public ElectricalSystemType()
        {
            this.electricalSystems = new HashSet<ElectricalSystem>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<ElectricalSystem> ElectricalSystems
        {
            get { return this.electricalSystems; }
            set { this.electricalSystems = value; }
        }
    }
}
