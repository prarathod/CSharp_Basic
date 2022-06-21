using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDBConsoleApp
{
    internal class Program

    {

        public void AddEmployeeData()
        {
            Console.Write("Enter Employee Name:- ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee Name:- ");
            int age = Convert.ToInt32(Console.ReadLine());



            EmployeeTable table = new EmployeeTable();
            table.EmployeeName = name;
            table.EmployeeAge = age;

            EmployeeEntities db = new EmployeeEntities();
            db.EmployeeTables.Add(table);
            db.SaveChanges();

            Console.WriteLine("Your Name is {0} and Age is {1}, saved succesfully", name, age);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("********* Employee Detail App **********");

            Program p1 = new Program();
            bool repeat = true;
            do {
               
                p1.AddEmployeeData();
                Console.Write("Do you want to add Data again if yes press Y :- ");
               string repeatVal = Console.ReadLine().Trim().ToLower();
                if (repeatVal != "y")
                {
                    repeat = false;
                };

            } while (repeat);

        }
    }
}
