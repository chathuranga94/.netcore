using System;

namespace efcore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppDBContext())
            {
                Student student1 = new Student { StudentId = 1000, Name = "Hey name" };
                db.Students.Add(student1);
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);
                
                Console.WriteLine();
                Console.WriteLine("All students in database:");
                foreach (var student in db.Students)
                {
                    Console.WriteLine("Student ID-{0} Name-{1}", student.StudentId, student.Name);
                }
            }
        }
    }
}



