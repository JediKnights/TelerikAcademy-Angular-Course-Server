namespace Angular.Server.WebAPI.Models.ElectricalSystem
{
    public class ElectricalSystemListModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string BaseUnitName { get; set; }

        public int BaseUnitId { get; set; }

        public string ElectricalSystemTypeName { get; set; }
    }
}
