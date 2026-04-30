using Microsoft.EntityFrameworkCore;
using TestMenu.Classes;

namespace TestMenu.Data
{
    public class TestMenuContextDB : DbContext
    {
        public TestMenuContextDB(DbContextOptions<TestMenuContextDB> options)
            : base(options)
        {
        }

        // 👇 This maps your Country model to a table
        public DbSet<Country> Country { get; set; }
    }
}
