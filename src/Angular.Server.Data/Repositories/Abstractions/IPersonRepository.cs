namespace Angular.Server.Data.Repositories.Abstractions
{
    using Models.DomainModels;

    public interface IPersonRepository : IAuditableEntityRepository<Person>
    {
    }
}
