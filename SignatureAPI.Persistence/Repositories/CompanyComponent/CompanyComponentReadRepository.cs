using SignatureAPI.Application.Repositories;
using SignatureAPI.Application.Repositories.CompanyComponent;
using SignatureAPI.Persistence.Context;

namespace SignatureAPI.Persistence.Repositories.CompanyComponent
{
    public class CompanyComponentReadRepository : ReadRepository<SignatureAPI.Domain.Entities.CompanyComponent.CompanyComponent>, ICompanyComponentReadRepository
    {
        public CompanyComponentReadRepository(SignatureAPIDbContext context) : base(context)
        {
        }
    }
}
