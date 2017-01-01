namespace Angular.Server.Models.DomainModels
{
    using Angular.Server.Models.IdentityModels;
    using Angular.Server.Models.SystemModels;

    public class Person: AuditableEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ApplicationUser ApplicationUser  { get; set; }

        public string ApplicationUserId { get; set; }
    }
}
