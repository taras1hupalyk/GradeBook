using GradeBook.Client.TeacherServices.Interfaces;
using GradeBook.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Net.Http;

namespace GradeBook.Client.TeacherServices
{
    public class SubjectService : ISubjectService
    {
        private HttpClient httpClient;

        public SubjectService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task AddSubject(SubjectDTO subject)
        {
            var response = await httpClient.PostAsJsonAsync<SubjectDTO>("https://localhost:44383/api/subject", subject);
        }

        public async Task<List<SubjectDTO>> GetAllSubjects()
        {
            var response = await httpClient.GetFromJsonAsync<List<SubjectDTO>>("https://localhost:44383/api/subject");
            return response;
        }
    }
}
