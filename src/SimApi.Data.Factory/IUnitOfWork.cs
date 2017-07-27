using System;
using System.Threading.Tasks;

namespace SimApi.Data.Factory
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        int SaveChanges();
        Task<int> SaveChangesAsync();
        void RollBack();
    }
}