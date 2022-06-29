using Microsoft.EntityFrameworkCore;

namespace TodoListAPI.Data
{
    public class TodoListDbContext : DbContext
    {
        public TodoListDbContext(DbContextOptions options) : base(options) { }
        public DbSet<TodoWork> TodoWorks { get; set; }
    }
}
