using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace efcore.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
