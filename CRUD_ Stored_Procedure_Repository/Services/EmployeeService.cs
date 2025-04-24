
using CRUD__Stored_Procedure_Repository.Data;
using CRUD__Stored_Procedure_Repository.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;
using System.Reflection.Metadata;

namespace CRUD__Stored_Procedure_Repository.Services
{
    public class EmployeeService : IEmployee
    {
        private readonly AppDbContext appDbContext;
        public EmployeeService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<List<Employee>> GetAll()
        {
            return await appDbContext.Employees
           .FromSqlRaw("EXEC Sp_Employees_CRUD @Action={0}", "SELECT")
           .ToListAsync();
        }

        public async Task<Employee> GetById(int id)
        {
            return await appDbContext.Employees.FromSqlRaw("EXEC Sp_Employees_CRUD @Action={0}, @Id={1}", "GETBYID", id)
                .FirstOrDefaultAsync();
        }
    }
}
