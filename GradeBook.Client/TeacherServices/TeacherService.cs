using GradeBook.Client.TeacherServices.Interfaces;
using GradeBook.Common.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GradeBook.Client.TeacherServices
{
    public class TeacherService : ITeacherService
    {
        private HttpClient httpClient;

        public TeacherService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task AddTeacher(TeacherDTO teacher)
        {
             await httpClient.PostAsJsonAsync<TeacherDTO>("https://localhost:44383/api/teacher", teacher);
            
        }

        public async  Task<List<TeacherDTO>> GetAllTeachers()
        {           
            var result = await httpClient.GetFromJsonAsync<List<TeacherDTO>>("https://localhost:44383/api/teacher");
            return result;
        }
    }
}
