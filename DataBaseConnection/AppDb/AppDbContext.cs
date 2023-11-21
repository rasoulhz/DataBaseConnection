using DataBaseConnection.Entities;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

namespace DataBaseConnection.AppDb
{
    public class AppDbContext : DbContext
    {
        
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DataBaseConnection;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        
        public DbSet<product> products { get; set; }
    }
}
