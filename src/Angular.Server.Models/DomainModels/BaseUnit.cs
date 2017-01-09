using System.Collections.Generic;

using Angular.Server.Models.SystemModels;

namespace Angular.Server.Models.DomainModels
{
    public class BaseUnit : AuditableEntity
    {
        private ICollection<ElectricalSystem> electricalSystems;

        public BaseUnit()
        {
            this.electricalSystems = new HashSet<ElectricalSystem>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public double Area { get; set; }

        public double Volume { get; set; }

        public virtual ICollection<ElectricalSystem> ElectricalSystems
        {
            get { return this.electricalSystems; }
            set { this.electricalSystems = value; }
        }
    }
}
