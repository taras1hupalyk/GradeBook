using GradeBook.Common.Models;
using GradeBook.Data.Entities;
using GradeBook.Data.Repositories.Intefaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Api.Controllers
{
    [Route("api/subject")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private ISubjectRepository subjectRepository;

        public SubjectController( ISubjectRepository subjectRepository )
        {
            this.subjectRepository = subjectRepository;
        }



        [HttpGet]
        public async Task<List<Subject>> GetSubjects()
        {
            var result = await subjectRepository.GetAllAsync();
            return result;
        }

        [HttpPost]
        public async Task<Subject> AddSubject( Subject subject)
        {
            var result = await subjectRepository.InsertAsync(subject);
            return result;
        }
    }
}
