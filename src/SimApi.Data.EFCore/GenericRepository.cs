using SimApi.Data.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace SimApi.Data.EFCore
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly SimApiContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(SimApiContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> GetQuery()
        {
            return _dbSet;
        }

        public ICollection<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public async Task<ICollection<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public TEntity First(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.First(predicate);
        }

        public Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.FirstAsync(predicate);
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.FirstOrDefault(predicate);
        }

        public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public TEntity Single(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Single(predicate);
        }

        public async Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.SingleAsync(predicate);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.SingleOrDefault();
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.SingleOrDefaultAsync();
        }

        public void Add(TEntity entity)
        {
            _dbContext.Add(entity);
        }

        public void Remove(TEntity entity)
        {
            _dbContext.Remove(entity);
        }

        public void MarkModified(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Attach(TEntity entity)
        {
            _dbContext.Attach(entity);
        }

        public void Detach(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Detached;
        }
    }
}