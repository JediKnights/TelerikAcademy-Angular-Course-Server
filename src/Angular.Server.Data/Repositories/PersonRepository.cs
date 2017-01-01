namespace Angular.Server.Data.Repositories
{
    using Angular.Server.Data.Repositories.Abstractions;
    using Angular.Server.Models.DomainModels;

    public class PersonRepository : AuditableEntityRepository<Person>, IPersonRepository
    {
        public PersonRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
