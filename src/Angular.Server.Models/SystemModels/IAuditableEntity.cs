using System;

namespace Angular.Server.Models.SystemModels
{
    public interface IAuditableEntity
    {
        DateTime? CreatedOn { get; set; }

        DateTime? LastUpdatedOn { get; set; }

        bool IsDeleted { get; set; }

        DateTime? DeletedOn { get; set; }

        string DeletedBy { get; set; }
    }
}
