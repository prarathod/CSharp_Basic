using EmployeeAPI_3.Repositories.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI_3.Repositories
{
    public class EmployeeAPIDbContext : DbContext
    {
        public EmployeeAPIDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
