using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GradeBook.Common.Models
{
    public class TeacherDTO
    {
        [Newtonsoft.Json.JsonProperty("firstName")]
        public string FirstName { get; set; }

        [Newtonsoft.Json.JsonProperty("lastName")]
        public string LastName { get; set; }

        [Newtonsoft.Json.JsonProperty("patronymic")]
        public string Patronymic { get; set; }
    }
}
