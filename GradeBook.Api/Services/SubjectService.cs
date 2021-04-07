using GradeBook.Api.Services.Interfaces;
using GradeBook.Common.Models;
using GradeBook.Data.Entities;
using GradeBook.Data.Repositories.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Api.Services
{
    public class SubjectService : ISubjectService
    {
        private ISubjectRepository subjectRepository;

        public SubjectService( ISubjectRepository subjectRepository)
        {
            this.subjectRepository = subjectRepository;
        }

        public async Task<Subject> AddSubjectAsync(Subject subject)
        {
            var result = await subjectRepository.InsertAsync(subject);
            return result;
        }

        public async Task<List<Subject>> GetAllSubjectsAsync()
        {
            var result = await subjectRepository.GetAllAsync();
            return result;
        }
    }
}
