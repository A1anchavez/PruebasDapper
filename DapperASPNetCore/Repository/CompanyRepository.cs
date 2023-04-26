using DapperASPNetCore.Context;
using DapperASPNetCore.Contracts;

namespace DapperASPNetCore.Repository
{
    public class CompanyRepository: ICompanyRepository
    {
        private readonly DapperContext _context;

        public CompanyRepository(DapperContext context)
        {
            _context = context;
        }
    }
}
