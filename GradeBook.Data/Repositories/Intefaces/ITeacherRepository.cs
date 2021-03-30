using GradeBook.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.Data.Repositories.Intefaces
{
    public interface ITeacherRepository: IRepositoryBase<Teacher>
    {
        
        Task<Teacher> AddTeacherAsync(Teacher teacher);
    }
}
