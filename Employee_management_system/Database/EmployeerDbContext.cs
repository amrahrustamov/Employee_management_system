using Employee_management_system.Database.Models;
using Microsoft.EntityFrameworkCore;
namespace Employee_management_system.Database
{
    public class EmployeerDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var connectionString = "Server=localhost;Port=5432;Database=Employee_management_system;User Id=postgres;Password=postgres;";

            optionsBuilder.UseNpgsql(connectionString);

            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Employeer> Employeers { get; set; }
    }
}
