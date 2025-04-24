using CRUD__Stored_Procedure_Repository.Models;
using CRUD__Stored_Procedure_Repository.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD__Stored_Procedure_Repository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _employeeService;

        public EmployeeController(IEmployee employee)
        {
            _employeeService = employee;
        }
       
        [HttpGet]
        public async Task<ActionResult<Employee>> GetAllEmployees()
        {
            var employees = await _employeeService.GetAll();
            return Ok(employees);
        }
    }
}
