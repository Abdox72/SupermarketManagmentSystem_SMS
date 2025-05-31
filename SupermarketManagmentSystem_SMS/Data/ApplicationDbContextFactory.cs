using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Supermarket_Managment_System_SMS.Data;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {

        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\SupermarketManagementSystem.db");
        var txt = Path.GetFullPath(dbPath);
        optionsBuilder.UseSqlite($"Data Source={txt}");
        return new ApplicationDbContext(optionsBuilder.Options);
    }
}
