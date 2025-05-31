using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Supermarket_Managment_System_SMS.Data;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDContext>
{
    public ApplicationDContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDContext>();
        optionsBuilder.UseSqlite("Data Source=supermarket.db");
        return new ApplicationDContext(optionsBuilder.Options);
    }
}
