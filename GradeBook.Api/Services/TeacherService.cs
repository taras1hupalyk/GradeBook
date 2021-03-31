using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GradeBook.Api.Services.Interfaces;
using GradeBook.Data.Entities;
using GradeBook.Data.Repositories;
using GradeBook.Data.Repositories.Intefaces;

namespace GradeBook.Api.Services
{
    public class TeacherService: ITeacherService
    {
        private ITeacherRepository teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            this.teacherRepository = teacherRepository;
        }

        public async Task<Teacher> AddTeacherAsync(Teacher teacher)
        {
           var result = await teacherRepository.InsertAsync(teacher);
            return result;
        }

        public async Task<List<Teacher>> GetAllTeachersAsync()
        {
            var result = await teacherRepository.GetAllAsync();
            return result;
        }
    }
}
