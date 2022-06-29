using Microsoft.EntityFrameworkCore;


namespace FriendList.API.Data
{
    public class FriendListDbContext : DbContext
    {
        public FriendListDbContext(DbContextOptions options) : base(options) { }
       
    };
    
}
