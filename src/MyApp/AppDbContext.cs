using Microsoft.EntityFrameworkCore;

namespace MyApp;

public class AppDbContext:DbContext
{
    public DbSet<Person> Persons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            "Server=localhost;Port=5432;Database=Github_Actions;User Id=postgres;Password=mysecretpassword;");
    }
}