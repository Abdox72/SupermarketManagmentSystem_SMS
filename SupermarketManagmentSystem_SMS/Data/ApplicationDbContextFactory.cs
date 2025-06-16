using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SupermarketManagmentSystem_SMS.Data;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[]? args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        var txt = "SupermarketManagementSystem.db";
        optionsBuilder.UseSqlite($"Data Source={txt}");
        return new ApplicationDbContext(optionsBuilder.Options);
    }
}
