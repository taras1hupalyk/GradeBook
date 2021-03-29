using GradeBook.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.Data
{
   public  class ApplicationDbContext : DbContext
    {

        public DbSet<Grade> Grades { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=GradeBookDb; Trusted_Connection=True; ");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            UpdateStructure(builder);
            base.OnModelCreating(builder);
        }

        private void UpdateStructure(ModelBuilder builder)
        {
            builder.Entity<Grade>()
                 .HasOne(a => a.Task)
                 .WithOne(b => b.Grade)
                 .HasForeignKey<Task>(c => c.Id);

            builder.Entity<Task>()
                .HasOne<Subject>(a => a.Subject)
                .WithMany(b => b.Task)
                .HasForeignKey(s => s.SubjectId);

            builder.Entity<Teacher>()
                .HasOne(a => a.Subject)
                .WithOne(b => b.Teacher)
                .HasForeignKey<Subject>(c => c.LectureTeacherId);

            builder.Entity<Teacher>()
                 .Property(p => p.FirstName).HasMaxLength(64);
            builder.Entity<Teacher>()
                 .Property(p => p.LastName).HasMaxLength(64);
            builder.Entity<Teacher>()
                 .Property(p => p.Patronymic).HasMaxLength(64);

        }
    }
}
