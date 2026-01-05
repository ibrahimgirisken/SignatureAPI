using SignatureAPI.Application.Repositories.Company;
using SignatureAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Persistence.Repositories.Company
{
    public class CompanyWriteRepository : WriteRepository<Domain.Entities.Company.Company>, ICompanyWriteRepository
    {
        public CompanyWriteRepository(SignatureAPIDbContext context) : base(context)
        {
        }
    }
}
