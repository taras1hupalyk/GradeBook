using GradeBook.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Api.Services.Interfaces
{
    public interface ITeacherService
    {
        Task<List<Teacher>> GetAllTeachersAsync();
        Task<Teacher> AddTeacherAsync(Teacher teacher);

    }
}
