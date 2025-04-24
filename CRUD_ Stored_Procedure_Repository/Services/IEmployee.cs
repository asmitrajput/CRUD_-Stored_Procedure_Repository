using CRUD__Stored_Procedure_Repository.Models;

namespace CRUD__Stored_Procedure_Repository.Services
{
    public interface IEmployee
    {
        Task<List<Employee>> GetAll();// here we are using Task<List<Employee>> to return a list of employees
        Task<Employee> GetById(int id); // here we are using Task<Employee> to return a single employee

    }
}
