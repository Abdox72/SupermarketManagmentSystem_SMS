using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SupermarketManagmentSystem_SMS.Data;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDContext>
{

    //public ApplicationDContext CreateDbContext(string[] args)
    //{
    //    var optionsBuilder = new DbContextOptionsBuilder<ApplicationDContext>();
    //    optionsBuilder.UseSqlite("Data Source=supermarket.db");
    //    return new ApplicationDContext(optionsBuilder.Options);

    public ApplicationDContext CreateDbContext(string[]? args)
    {

        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDContext>();
        var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\SupermarketManagementSystem.db");
        var txt = Path.GetFullPath(dbPath);
        optionsBuilder.UseSqlite($"Data Source={txt}");
        return new ApplicationDContext(optionsBuilder.Options);

    }
}
