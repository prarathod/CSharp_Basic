using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Class1
    {
        int age;
        string name;

        public void setStudent(int age , string name)
        {
            this.age = age;
            this.name = name;
        }

        public void getStudent()
        {
            Console.WriteLine("Hello {0}, Your age is {1}",this.name,this.age);
        }

    }
}
