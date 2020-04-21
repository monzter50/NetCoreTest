using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
namespace NetCore.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppCourseSaleContext())
            {
                // db.Database.EnsureDeleted();
                //db.Database.EnsureCreated();
                var courses = db.Course.ToList();
                foreach(var course in courses)
                {
                    Console.WriteLine(course.Title);
                }
            }
        }
    }
}
