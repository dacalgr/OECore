using Microsoft.EntityFrameworkCore;
using OECore.Domain.Entities;

namespace OECore.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
    public DbSet<Company> Companies => Set<Company>();
    public DbSet<Profile> Profiles => Set<Profile>();
    public DbSet<UserCompany> UserCompanies => Set<UserCompany>();
    public DbSet<Region> Regions => Set<Region>();
    public DbSet<CompanyRegion> CompanyRegions => Set<CompanyRegion>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}




