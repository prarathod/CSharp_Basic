using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstApprochWithPostAndGetMethods
{
    internal class Program
    {

        public void AddEmployee(string name, string gameName) {
            Table_1 tb = new Table_1();
            tb.Name = name;
            tb.GameName = gameName;

            SportEntities sportEntities = new SportEntities();
            sportEntities.Table_1.Add(tb);
            sportEntities.SaveChanges();
        }

        public void ShowEmployeDetail()
        {
            SportEntities tb = new SportEntities();
            foreach(Table_1 table in tb.Table_1)
            {
                Console.WriteLine(" name:- {0} and game Name {1}",table.Name, table.GameName);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("************  Console APP *************");

            Console.Write("Enter Your Name:- ");
            string name1 = Console.ReadLine();

            Console.Write("Enter Your Game Name:- ");
            string game1 = Console.ReadLine();

            Program program = new Program();
            program.AddEmployee(name1, game1);


            Console.ReadLine();
            program.ShowEmployeDetail();
            Console.ReadLine();
        }
    }
}
