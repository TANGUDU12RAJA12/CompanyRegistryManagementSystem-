using CurdOperationWithOnionArchitecture.Model;
using Microsoft.EntityFrameworkCore;

namespace CurdOperationWithOnionArchitecture
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<CompanyResistry> CompanyResistries { get; set; }
    }
  
}
