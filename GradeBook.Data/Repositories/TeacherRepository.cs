using GradeBook.Data.Entities;
using GradeBook.Data.Repositories.Intefaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.Data.Repositories
{
    public class TeacherRepository : RepositoryBase<Teacher>, ITeacherRepository
    {
        public TeacherRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Teacher> AddTeacherAsync(Teacher teacher)
        {
            dbContext.Teachers.Add(teacher);
            await dbContext.SaveChangesAsync();
            return teacher;
        }
    }
}
