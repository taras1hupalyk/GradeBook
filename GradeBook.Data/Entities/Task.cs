using System;


namespace GradeBook.Data.Entities
{
    public class Task
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public double MaxGrade { get; set; }

        public string Description { get; set; }

        public Guid SubjectId { get; set; }

        public Grade Grade { get; set; }
        public Subject Subject { get; set; }
        public Teacher Teacher { get; set; }
    }
}
