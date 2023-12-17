global using Microsoft.EntityFrameworkCore;
//using DempApp2.Model;

namespace DempApp2.Model;

public class SiteDbContext : DbContext
{
    // internal object Customers;

    public DbSet<Emp> Employee_03 { get; set; }
    public DbSet<Dept> Department_03 { get; set; }

    public SiteDbContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=iitdac.met.edu;Database=Shop2;User Id=dac2; Password=Dac2@1234;Encrypt=False");
    }
}