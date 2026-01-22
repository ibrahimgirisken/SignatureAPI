using SignatureAPI.Application.Repositories.CompanyComponent;
using SignatureAPI.Persistence.Context;


namespace SignatureAPI.Persistence.Repositories.CompanyComponent
{
    public class ComponyComponentWriteRepository : WriteRepository<SignatureAPI.Domain.Entities.CompanyComponent.CompanyComponent>, ICompanyComponentWriteRepository
    {
        public ComponyComponentWriteRepository(SignatureAPIDbContext context) : base(context)
        {
        }
    }
}
