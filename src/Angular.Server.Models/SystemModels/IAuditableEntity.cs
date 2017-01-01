namespace Angular.Server.Models.SystemModels
{
    using System;

    public interface IAuditableEntity
    {
        DateTime? CreatedOn { get; set; }

        DateTime? LastUpdatedOn { get; set; }

        bool IsDeleted { get; set; }

        DateTime? DeletedOn { get; set; }

        string DeletedBy { get; set; }
    }
}
