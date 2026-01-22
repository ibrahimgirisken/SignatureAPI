using MediatR;

namespace SignatureAPI.Application.Features.Commands.CompanyComponent.UpdateCompanyComponent
{
    public class UpdateCompanyComponentHandler : IRequestHandler<UpdateCompanyComponentRequest, UpdateCompanyComponentResponse>
    {
        public Task<UpdateCompanyComponentResponse> Handle(UpdateCompanyComponentRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
