namespace Angular.Server.Data.Repositories
{
    using Angular.Server.Data.Repositories.Abstractions;
    using Angular.Server.Models.IdentityModels;

    public class ApplicationUserRepository : AuditableEntityRepository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly IApplicationDbContext context;

        public ApplicationUserRepository(IApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public ApplicationDbContext Context
        {
            get { return (ApplicationDbContext)this.context; }
        }
    }
}
