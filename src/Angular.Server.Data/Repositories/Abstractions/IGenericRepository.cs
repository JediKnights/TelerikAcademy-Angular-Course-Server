namespace Angular.Server.Data.Repositories.Abstractions
{
    using System;
    using System.Linq;

    public interface IGenericRepository<T>
    {
        IQueryable<T> All();

        T GetById(Guid id);

        T GetById(int id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void SaveChanges();
    }
}
