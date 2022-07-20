using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Disctroctor
    {
        public string name;
        public int age;
        public int distructorCount = 1;
        public Disctroctor(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string ShowName()
        {
            return name;

        }
        public int ShowAge()
        {
            return age;
        }

        ~Disctroctor()
        {
            Console.WriteLine("Distructor involked {0}",distructorCount);
            distructorCount++;
        }
    }
}
