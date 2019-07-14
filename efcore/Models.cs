using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace efcore
{
    public class AppDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
