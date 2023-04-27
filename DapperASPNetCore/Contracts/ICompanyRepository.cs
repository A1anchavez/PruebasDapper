using DapperASPNetCore.Entities;

namespace DapperASPNetCore.Contracts
{
    public interface ICompanyRepository
    {
        public Task<IEnumerable<Company>> GetCompanies();
    }
}
