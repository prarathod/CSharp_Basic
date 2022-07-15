using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Constractor
    {
        int age;
        public Constractor(int age)
        {
            this.age = age;
            Console.WriteLine("Age data from constructor: "+this.age);
        }
        public void Show()
        {
            Console.WriteLine(age);
        }

    }
}
