using System;

namespace CSharp_Basic_To_Advance
{
       
    internal class Student
    {
        string name;
        int age;
        // creating constructor.
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
           
        }
         public void getInfo()
        {
            
            int std = 0;
            if (this.age > 6)
            {
                std = this.age- 6;
            }
            
            Console.WriteLine("Name: {0} and age is {1}\n According to age the class is {2}",this.name,this.age,std);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("************* School Software **************");
            Student s1 = new Student("Ram", 20);
            s1.getInfo();
        }
    }
}
