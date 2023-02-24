using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOwned2
{
    public class TestDbContextDesignTimeContext : IDesignTimeDbContextFactory<TestDbContext>
    {
        public TestDbContext CreateDbContext(string[] args)
        {
            //var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            //optionsBuilder.UseSqlite("Data Source=blog.db");

            var optionsBuilder = new DbContextOptionsBuilder<TestDbContext>();
            //optionsBuilder.UseSqlite("Data Source=blog.db");
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=OwnedVOTest3;ConnectRetryCount=0");

            return new TestDbContext(optionsBuilder.Options);
        }
    }
}
