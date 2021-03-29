using System;

namespace GradeBook.Data.Entities
{
    public class Subject
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsMajor { get; set; }

        public Guid LectureTeacherId { get; set; }

    }
}