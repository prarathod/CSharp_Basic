using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst
{
    class Program
    {
        public class Course
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public float FullPrice { get; set; }
            public Author Author { get; set; }

            public IList<Tag> Tags { get; set; }
        };

        public class Author
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public IList<Course> Courses { get; set; }
        };
        public class Tag
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public IList<Course> Courses { get; set; }
        };

        public class DatabaseContext : DbContext
        {
            public DatabaseContext():base("name=DefaultConnection")
            {
            }

            public DbSet<Course> Courses { get; set; }
            public DbSet<Author> Authors { get; set; }
            public DbSet<Tag> Tags { get; set; }
        }
        static void Main(string[] args)
        {
        }
    }
}
