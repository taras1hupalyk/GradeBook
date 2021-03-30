using GradeBook.Data.Entities;
using GradeBook.Data.Repositories.Intefaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Api.Controllers
{
    [ApiController]
    [Route("api/teacher")]
    public class TeacherController : Controller
    {
        private ITeacherRepository teacherRepository;

        public TeacherController(ITeacherRepository teacherRepository)
        {
            this.teacherRepository = teacherRepository;
        }

        [HttpPost]
        public  async Task<ActionResult<Teacher>> CreateTeacher( Teacher teacher)
        {
            await teacherRepository.AddTeacherAsync(teacher);
            return teacher;
        }
    }
}
