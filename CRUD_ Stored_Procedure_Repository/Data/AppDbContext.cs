using CRUD__Stored_Procedure_Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD__Stored_Procedure_Repository.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
      public DbSet<Employee> Employees { get; set; }
        
    }
}
