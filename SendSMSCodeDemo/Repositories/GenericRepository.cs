using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SendSMSCodeDemo.Data;

namespace SendSMSCodeDemo.Repositories
{

    public class GenericRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationDbContext _dbContext;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public TEntity? GetById(Guid id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }
        
        public void Create(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
        }

    }
}