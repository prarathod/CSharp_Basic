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

        public void ShowDatabase()
        {
            EmployeeEntities db = new EmployeeEntities();

            foreach (EmployeeTable table in db.EmployeeTables)
            {
                Console.WriteLine("{0} {1} {2}", table.Id, table.EmployeeName, table.EmployeeAge);
            }
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("********* Employee Detail App **********");
            Program p1 = new Program();
            bool repeat = true;
            do {
                Console.Write("To see the database Enter S and to add employee Enter A:- ");
                string input = Console.ReadLine().Trim().ToLower();

                if (input == "s")
                {
                    p1.ShowDatabase();
                }
                else if (input == "a")
                {
                    p1.AddEmployeeData();
                }
                else
                {
                    Console.WriteLine("Thank you for visiting");
                }

                Console.Write("Do you want to run program again if yes press Y :- ");
                string repeatVal = Console.ReadLine().Trim().ToLower();
                if (repeatVal != "y")
                {
                    repeat = false;
                };

            } while (repeat);


        }
    }
}
