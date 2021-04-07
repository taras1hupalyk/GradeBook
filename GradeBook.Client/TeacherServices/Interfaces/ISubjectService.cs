
using GradeBook.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Client.TeacherServices.Interfaces
{
    public interface ISubjectService
    {
        Task AddSubject(SubjectDTO subject);
        Task<List<SubjectDTO>> GetAllSubjects();
    }
}
