using System.Linq;

namespace Angular.Server.Data.Repositories.Abstractions
{
    public interface IAuditableEntityRepository<T> : IGenericRepository<T> where T : class
    {
        IQueryable<T> AllWithDeleted();

        void HardDelete(T entity);
    }
}
