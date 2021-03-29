using GradeBook.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.Data.Repositories.Intefaces
{
    interface IAssignmentRepository: IRepositoryBase<Assignment>
    {
        Task<Assignment> GetAssignmentByNameAsync(string name);
    }
}
