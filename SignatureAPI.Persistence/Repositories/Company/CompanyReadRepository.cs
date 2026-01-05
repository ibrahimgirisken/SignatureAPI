
using SignatureAPI.Application.Repositories.Company;
using SignatureAPI.Persistence.Context;

namespace SignatureAPI.Persistence.Repositories.Company
{
    public class CompanyReadRepository : ReadRepository<Domain.Entities.Company.Company>, ICompanyReadRepository
    {
        public CompanyReadRepository(SignatureAPIDbContext context) : base(context)
        {
        }
    }
}
