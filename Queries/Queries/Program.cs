using System;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();
            var query =
                from c in context.Courses
                join a in context.Authors on c.AuthorId equals a.Id
                select new { CourseName = c.Name, AuthorName = c.Author.Name };

            foreach (var x in query)
                Console.WriteLine(x.CourseName + " " + x.AuthorName);
            Console.WriteLine("//////////////////");

            var queryGroup =
                from a in context.Authors
                join c in context.Courses on a.Id equals c.AuthorId into g
                select new { AuthorName = a.Name, Courses = g.Count() };

            foreach (var x in queryGroup)
                Console.WriteLine(x.AuthorName + " " + x.Courses);
            Console.WriteLine("/////////////////");

            var queryCross =
                from c in context.Courses
                from a in context.Authors
                select new { CourseName = c.Name, AuthorName = c.Author.Name };

            foreach (var x in queryCross)
                Console.WriteLine(x.CourseName + " " + x.AuthorName);

            //var context = new PlutoContext();

            ////LINQ
            //var query =
            //    from c in context.Courses
            //    where c.Name.Contains("c#")
            //    orderby c.Name
            //    select c;

            //foreach (var course in query)
            //    Console.WriteLine(course.Name);

            //var courses = context.Courses
            //    .Where(c => c.Name.Contains("c#"))
            //    .OrderBy(c => c.Name);

            //foreach (var course in courses)
            //    Console.WriteLine(course.Name);

            Console.ReadLine();


        }
    }
}
