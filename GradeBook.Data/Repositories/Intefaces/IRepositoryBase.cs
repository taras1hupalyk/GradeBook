
using System.Collections.Generic;

using System.Threading.Tasks;

namespace GradeBook.Data.Repositories.Intefaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        

        Task<TEntity> InsertAsync(TEntity entity);

        Task DeleteEntityAsync(TEntity entity);

        Task<int> Count();
        Task<List<TEntity>> GetAllAsync();
    }
}
