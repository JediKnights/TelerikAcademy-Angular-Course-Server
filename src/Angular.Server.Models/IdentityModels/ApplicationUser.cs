namespace Angular.Server.Models.IdentityModels
{
    using System;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    
    using SystemModels;

    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser, IAuditableEntity
    {
        public string Address { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? LastUpdatedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public string DeletedBy { get; set; }
    }
}
