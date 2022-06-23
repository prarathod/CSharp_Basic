using ConsoleApp9.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Contexts
{
    internal class SchoolContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=VIKLELE\SQLEXPRESS;Initial Catalog=StudentMaster;Integrated Security=true;");
        }

        public DbSet<Student>Student { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
    }
}
