using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Supermarket_Managment_System_SMS.Data;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseSqlite("Data Source=supermarket.db");
        return new ApplicationDbContext(optionsBuilder.Options);
    }
}
