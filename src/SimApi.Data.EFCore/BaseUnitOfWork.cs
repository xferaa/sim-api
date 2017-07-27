using SimApi.Data.Factory;
using System.Threading.Tasks;

namespace SimApi.Data.EFCore
{
    public abstract class BaseUnitOfWork : IUnitOfWork
    {
        private readonly SimApiContext _dbContext;

        protected BaseUnitOfWork(SimApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return new GenericRepository<TEntity>(_dbContext);
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public void RollBack()
        {
           // _dbContext
           //.ChangeTracker
           //.Entries()
           //.ToList()
           //.ForEach(x => x.Reload());
        }

        public void Dispose()
        {
            if (_dbContext != null)
                _dbContext.Dispose();
        }
    }
}
