using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDatabaseFirst2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlutoDbContext _db = new PlutoDbContext();
            var courseList = _db.GetCourses();

            

            foreach(var elm  in courseList)
            {
                Console.WriteLine(elm.Title);
            }
            Console.ReadLine();
        }
    }
}
