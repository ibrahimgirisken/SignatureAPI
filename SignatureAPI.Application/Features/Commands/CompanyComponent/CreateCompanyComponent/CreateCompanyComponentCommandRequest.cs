using MediatR;
using SignatureAPI.Application.DTOs.Company;

namespace SignatureAPI.Application.Features.Commands.CompanyComponent.CreateCompanyComponent
{
    public class CreateCompanyComponentCommandRequest:IRequest<CreateCompanyComponentCommandResponse>
    {
        public CreateCompanyComponentDTO CreateCompanyComponentDTO { get; set; }
    }
}
