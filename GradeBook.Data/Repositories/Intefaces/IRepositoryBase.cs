using GradeBook.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.Data.Repositories.Intefaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAllAsync();
    }
}
