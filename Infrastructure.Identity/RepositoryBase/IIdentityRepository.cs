using Infrastructure.Shared.GenericRepository;

namespace Infrastructure.Identity.RepositoryBase
{    
    public interface IIdentityRepository<TEntity> : IRepository<TEntity> where TEntity : class { }
}
