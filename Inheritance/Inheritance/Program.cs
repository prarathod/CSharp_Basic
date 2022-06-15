using System;

namespace Inheritance
{
    class BaseClass 
    { 
        public void Show1()
        {
            Console.WriteLine("Output from Show1");
        }
    }

    class DerivedClass:BaseClass
    {
        public void Show2()
        {
            Console.WriteLine("Output from Show2");
        }
    }


    internal class Program
    {
        
       
        static void Main(string[] args)
        {
            DerivedClass obj1 = new DerivedClass();
            obj1.Show1();
            obj1.Show2();
            Console.WriteLine("Hello World!");
        }
    }
}
