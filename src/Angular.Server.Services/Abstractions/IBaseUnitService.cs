using Angular.Server.Models.DomainModels;

namespace Angular.Server.Services.Abstractions
{
    public interface IBaseUnitService : IRepositoryService<BaseUnit>
    {
        BaseUnit GetById(int id);
    }
}
