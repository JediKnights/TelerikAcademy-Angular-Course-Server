namespace Angular.Server.Models.DomainModels
{
    using System;
    using Angular.Server.Models.SystemModels;

    public class BaseUnit : AuditableEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
