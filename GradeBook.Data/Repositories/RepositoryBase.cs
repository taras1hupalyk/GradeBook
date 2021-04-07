using GradeBook.Data.Repositories.Intefaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.Data.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected ApplicationDbContext dbContext;

        protected RepositoryBase(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> Count()
        {
            var result = await dbContext.Set<TEntity>().CountAsync();
            return result;
        }

        public async  Task DeleteEntityAsync(TEntity entity)
        {
            dbContext.Set<TEntity>().Remove(entity);
             await dbContext.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            var result = await dbContext.Set<TEntity>().ToListAsync();
            return result;
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            await dbContext.Set<TEntity>().AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
