using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDatabaseFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var databaseobj = new DemoDatabaseFirstEntities();
            var post = new Post
            {
                PublishDate = DateTime.Now,
                Title = "Test Title",
                Body = "test Body"
            };
            databaseobj.Posts.Add(post);
            databaseobj.SaveChanges();
        }
    }
}
