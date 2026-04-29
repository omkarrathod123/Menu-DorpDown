using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestMenu.Classes;

namespace TestMenu.Data
{
    public class TestMenuContext : DbContext
    {
        public TestMenuContext (DbContextOptions<TestMenuContext> options)
            : base(options)
        {
        }

        public DbSet<TestMenu.Classes.Country> Country { get; set; } = default!;
    }
}
