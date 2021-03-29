using System;


namespace GradeBook.Data.Entities
{
    public class Grade
    {
        public Guid Id { get; set; }

        public double GradeValue { get; set; }

        public string Description { get; set; }

        


        public Task Task { get; set; }
    }
}
