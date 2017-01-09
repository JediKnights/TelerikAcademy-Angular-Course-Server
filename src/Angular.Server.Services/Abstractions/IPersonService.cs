using Angular.Server.Models.DomainModels;

namespace Angular.Server.Services.Abstractions
{
    public interface IPersonService : IRepositoryService<Person>
    {
        Person GetById(int id);
    }
}
