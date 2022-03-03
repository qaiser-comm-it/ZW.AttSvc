using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace ZW.AttSvc.EntityFrameworkCore;

public class AttSvcHttpApiHostMigrationsDbContext : AbpDbContext<AttSvcHttpApiHostMigrationsDbContext>
{
    public AttSvcHttpApiHostMigrationsDbContext(DbContextOptions<AttSvcHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureAttSvc();
    }
}
