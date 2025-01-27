using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DND_App.Web.Data
{
    public class DnDDbContextFactory : IDesignTimeDbContextFactory<DnDDbContext>
    {
        public DnDDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<DnDDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                sqlOptions => sqlOptions.MigrationsHistoryTable("__EFMigrationsHistory", "DND_DbSchema"));

            return new DnDDbContext(optionsBuilder.Options);
        }
    }
}

