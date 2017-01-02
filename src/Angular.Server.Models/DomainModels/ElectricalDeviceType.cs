namespace Angular.Server.Models.DomainModels
{
    using System.Collections.Generic;

    using Angular.Server.Models.SystemModels;

    public class ElectricalDeviceType : AuditableEntity
    {
        private ICollection<ElectricalDeviceModel> electricalDeviceModels;

        public ElectricalDeviceType()
        {
            this.electricalDeviceModels = new HashSet<ElectricalDeviceModel>();
        }

        public int Id { get; set; }

        public string TypeName { get; set; }


        public ICollection<ElectricalDeviceModel> ElectricalDeviceModels
        {
            get { return this.electricalDeviceModels; }
            set { this.electricalDeviceModels = value; }
        }
    }
}
