using Infrastructure.Shared.GenericRepository;

namespace Infrastructure.Persistence.RepositoryBase
{    
    public interface IApplicationRepository<TEntity> : IRepository<TEntity> where TEntity : class 
    { 

    }
}
