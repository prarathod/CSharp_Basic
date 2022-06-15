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
            DerivedClass2 obj1 = new DerivedClass2();
            obj1.Show1();
            obj1.Show2();
            obj1.Show3();
            Console.WriteLine("Hello World!");
        }
    }
}
