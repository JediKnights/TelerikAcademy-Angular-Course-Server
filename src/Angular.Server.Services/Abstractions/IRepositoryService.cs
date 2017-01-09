using System;
using System.Linq;

namespace Angular.Server.Services.Abstractions
{
    public interface IRepositoryService<T>
    {
        IQueryable<T> All();

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
