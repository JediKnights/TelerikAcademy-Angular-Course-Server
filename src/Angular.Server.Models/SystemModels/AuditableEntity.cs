namespace Angular.Server.Models.SystemModels
{
    using System;

    public class AuditableEntity : IAuditableEntity
    {
        public DateTime? CreatedOn { get; set; }

        public DateTime? LastUpdatedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public string DeletedBy { get; set; }
    }
}
