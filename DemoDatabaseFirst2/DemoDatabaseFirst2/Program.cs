using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDatabaseFirst2
{
    internal class Program
    {
        public void AddElm(string name, int age){
            PlutoDbContext db = new PlutoDbContext();
            db.Authors.age = age;
            db.Authors.name = name;
            PlutoDbContext db1 = new PlutoDbContext();
            db1.Authors.Add(db1);
        
        }
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
