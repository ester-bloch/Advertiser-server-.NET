using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Infrastructure
{
    public class AdvertiserContextFactory : IDesignTimeDbContextFactory<AdvertiserContext>
    {
        public AdvertiserContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<AdvertiserContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("AdvertiserDb"));

            return new AdvertiserContext(optionsBuilder.Options);
        }
    }
}

