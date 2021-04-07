using System;
using System.Collections.Generic;

namespace GradeBook.Data.Entities
{
    public class Subject
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsMajor { get; set; }

        public Guid LectureTeacherId { get; set; }


        public IEnumerable<Assignment> Assignments { get; set; }
        public Teacher Teacher { get; set; }
    }
}