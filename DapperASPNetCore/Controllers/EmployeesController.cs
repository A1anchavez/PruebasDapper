using DapperASPNetCore.Contracts;
using DapperASPNetCore.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperASPNetCore.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepo;

        public EmployeesController(IEmployeeRepository employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await _employeeRepo.GetEmployees();

            return Ok(employees);
        }

        [HttpGet("{id}", Name = "EmployeeById")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var employee = await _employeeRepo.GetEmployee(id);
            if (employee is null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployeey([FromBody] EmployeeForCreationDto employee)
        {
            var createdEmployee = await _employeeRepo.CreateEmployee(employee);

            return CreatedAtRoute("EmployeeById", new { id = createdEmployee.Id }, createdEmployee);
        }

        [HttpPut("{ID}")]
        public async Task<IActionResult> UpdateEmployee(int id, [FromBody] EmployeeForUpdateDto employee)
        {
            var dbEmployee = await _employeeRepo.GetEmployee(id);
            if (dbEmployee is null)
            {
                return NotFound();
            }
            await _employeeRepo.UpdateEmployee(id, employee);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var dbEmployee = await _employeeRepo.GetEmployee(id);
            if (dbEmployee is null)
            {
                return NotFound();
            }
            await _employeeRepo.DeleteEmployee(id);

            return NoContent();
        }
    }
}
