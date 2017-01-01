namespace Angular.Server.Data.Repositories
{
    using System;
    using System.Linq;
    using Abstractions;
    using Models.SystemModels;

    public class AuditableEntityRepository<T> : GenericRepository<T>, IAuditableEntityRepository<T> where T :
        class, IAuditableEntity
    {
        public AuditableEntityRepository(IApplicationDbContext context) : base(context)
        {
        }

        public override IQueryable<T> All()
        {
            return base.All().Where(x => !x.IsDeleted);
        }

        public IQueryable<T> AllWithDeleted()
        {
            return base.All();
        }

        public override void Add(T entity)
        {
            entity.CreatedOn = DateTime.Now;
            base.DbSet.Add(entity);
        }

        public override void Update(T entity)
        {
            entity.LastUpdatedOn = DateTime.Now;
            base.DbSet.Update(entity);
        }

        public override void Delete(T entity)
        {
            entity.IsDeleted = true;
            entity.DeletedOn = DateTime.Now;
            base.Update(entity);
        }

        public void HardDelete(T entity)
        {
            base.Delete(entity);
        }
    }
}
