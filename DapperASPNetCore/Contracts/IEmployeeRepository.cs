using DapperASPNetCore.Entities;

namespace DapperASPNetCore.Contracts
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<Employee>> GetEmployees();
    }
}
