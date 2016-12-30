namespace Angular.Server.Models.DomainModels
{
    using Angular.Server.Models.IdentityModels;

    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ApplicationUser ApplicationUser  { get; set; }

        public string ApplicationUserId { get; set; }
    }
}
