namespace Angular.Server.Data.Repositories.Abstractions
{
    using System.Linq;

    public interface IAuditableEntityRepository<T> : IGenericRepository<T> where T : class
    {
        IQueryable<T> AllWithDeleted();

        void HardDelete(T entity);
    }
}
