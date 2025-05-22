using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Infrastructure
{
    public class AdvertiserContextFactory : IDesignTimeDbContextFactory<AdvertiserContext>
    {
        public AdvertiserContext CreateDbContext(string[] args)
        {
            var basePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "EndPoints");
            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<AdvertiserContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("AdvertiserDb"));

            return new AdvertiserContext(optionsBuilder.Options);
        }
    }
}

