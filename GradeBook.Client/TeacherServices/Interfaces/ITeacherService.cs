using GradeBook.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Client.TeacherServices.Interfaces
{
    public interface ITeacherService
    {
        Task AddTeacher(TeacherDTO teacher);
        Task<List<TeacherDTO>> GetAllTeachers();

    }
}
