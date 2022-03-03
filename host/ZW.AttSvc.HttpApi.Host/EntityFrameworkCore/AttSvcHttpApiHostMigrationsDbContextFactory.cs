using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ZW.AttSvc.EntityFrameworkCore;

public class AttSvcHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<AttSvcHttpApiHostMigrationsDbContext>
{
    public AttSvcHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AttSvcHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("AttSvc"));

        return new AttSvcHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
