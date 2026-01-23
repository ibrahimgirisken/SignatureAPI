using MediatR;
using SignatureAPI.Application.DTOs.CompanyComponent;

namespace SignatureAPI.Application.Features.Commands.CompanyComponent.UpdateCompanyComponent
{
    public class UpdateCompanyComponentCommandRequest:IRequest<UpdateCompanyComponentCommandResponse>
    {
        public UpdateCompanyComponentDTO UpdateCompanyComponentDTO { get; set; }
    }
}
