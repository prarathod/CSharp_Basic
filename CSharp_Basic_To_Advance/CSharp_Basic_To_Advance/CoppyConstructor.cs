using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basic_To_Advance
{
    internal class CoppyConstructor
    {
        string name;
        int age;
        bool dis;

        public CoppyConstructor(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public CoppyConstructor(CoppyConstructor e, bool val)
        {
            this.name = e.name;
            this.age = e.age;
            this.dis = val;
        }
        
        public static void main()
        {
            CoppyConstructor s1 = new CoppyConstructor("ram", 23);

            Console.WriteLine(s1);

        }
    }
}
