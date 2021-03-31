using GradeBook.Api.Services.Interfaces;
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
        private ITeacherService teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            this.teacherService = teacherService;
        }

        [HttpPost]
        public  async Task<ActionResult<Teacher>> CreateTeacher( Teacher teacher)
        {
            await teacherService.AddTeacherAsync(teacher);
            return teacher;
        }



        [HttpGet]
        public async Task<List<Teacher>> GetTeachersAsync()
        {
            var result = await teacherService.GetAllTeachersAsync();
            return result;
        }

    }
}
