using GradeBook.Common.Models;
using GradeBook.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Api.Services.Interfaces
{
    interface ISubjectService
    {
        Task<List<Subject>> GetAllSubjectsAsync();
        Task<Subject> AddSubjectAsync(Subject subject);
    }
}
