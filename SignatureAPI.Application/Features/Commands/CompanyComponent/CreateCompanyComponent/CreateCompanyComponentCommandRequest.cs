using MediatR;
using SignatureAPI.Application.DTOs.CompanyComponent;

namespace SignatureAPI.Application.Features.Commands.CompanyComponent.CreateCompanyComponent
{
    public class CreateCompanyComponentCommandRequest:IRequest<CreateCompanyComponentCommandResponse>
    {
        public CreateCompanyComponentDTO CreateCompanyComponentDTO { get; set; }
    }
}
