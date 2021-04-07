using GradeBook.Data.Entities;
using GradeBook.Data.Repositories.Intefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.Data.Repositories
{
    public class SubjectRepository : RepositoryBase<Subject>, ISubjectRepository
    {
        public SubjectRepository(ApplicationDbContext dbContext) : 
            base(dbContext)
        {
        }


    }
}
