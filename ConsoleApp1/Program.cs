using GradeBook.Data;
using GradeBook.Data.Entities;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                dbContext.Database.EnsureDeleted();
                dbContext.Database.EnsureCreated();
                dbContext.Teachers.Add(new Teacher()
                {
                    FirstName="firsName",
                    LastName="lastName",
                    Patronymic= "Patronymic"
                    
                });
            }
        }
    }
}
