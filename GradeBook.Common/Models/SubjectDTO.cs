using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.Common.Models
{
    public class SubjectDTO
    {
        public string Name { get; set; }

        public bool IsMajor { get; set; }

        public Guid LectureTeacherId { get; set; }

    }
}
