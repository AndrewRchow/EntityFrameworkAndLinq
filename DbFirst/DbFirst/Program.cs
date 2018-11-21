using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    class Program
    {
        public enum Level : byte
        {
            Beginner = 1,
            Intermediate = 2,
            Advanced = 3
        }

        static void Main(string[] args)
        {
            var course = new Course();
            course.Level = CourseLevel.Beginner //1

            //var dbContext = new PlutoDbContext();

            //dbContext.GetAuthorCourses(1);

            //var courses = dbContext.GetCourses();
            //foreach (var c in courses)
            //{
            //    Console.WriteLine(c.Title);

            //}
            //Console.ReadKey();
        }
    }
}
