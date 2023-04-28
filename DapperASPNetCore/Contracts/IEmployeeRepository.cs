using DapperASPNetCore.Dto;
using DapperASPNetCore.Entities;

namespace DapperASPNetCore.Contracts
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<Employee>> GetEmployees();
        public Task<Employee> GetEmployee(int id);
        public Task<Employee> CreateEmployee(EmployeeForCreationDto employee);
        public Task UpdateEmployee(int id, EmployeeForUpdateDto employee);
        public Task DeleteEmployee(int id);
    }
}
