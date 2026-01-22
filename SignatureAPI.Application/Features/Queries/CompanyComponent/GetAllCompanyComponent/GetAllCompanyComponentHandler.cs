using MediatR;

namespace SignatureAPI.Application.Features.Queries.CompanyComponent.GetAllCompanyComponent
{
    public class GetAllCompanyComponentHandler : IRequestHandler<GetAllCompanyComponentRequest, GetAllCompanyComponentResponse>
    {
        public Task<GetAllCompanyComponentResponse> Handle(GetAllCompanyComponentRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
