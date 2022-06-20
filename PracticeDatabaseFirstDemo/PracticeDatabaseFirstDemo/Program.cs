using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDatabaseFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var databaseobj = new DemoDatabaseFirstEntities();
            var post = new Post
            {
                PublishDate = DateTime.Now,
                Title = "second Test title",
                Body = "Second body test"
            };
            databaseobj.Posts.Add(post);
            databaseobj.SaveChanges();
        }
    }
}
