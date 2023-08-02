using Microsoft.EntityFrameworkCore;

namespace LivrariaPHD.Models
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> option)
            : base (option) { }

        public DbSet<Produto> todoProducts { get; set; }
    }
}
