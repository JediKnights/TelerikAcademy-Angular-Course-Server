using Angular.Server.Models.DomainModels;

namespace Angular.Server.Data.Repositories.Abstractions
{
    public interface IPersonRepository : IAuditableEntityRepository<Person>
    {
    }
}
