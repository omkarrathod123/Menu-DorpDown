using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestMenu.Classes;

namespace TestMenu.Data
{
    public class TestMenuContextDB : DbContext
    {
        public TestMenuContextDB (DbContextOptions<TestMenuContextDB> options)
            : base(options)
        {
        }

        public DbSet<TestMenu.Classes.Country> Country { get; set; } = default!;
    }
}
