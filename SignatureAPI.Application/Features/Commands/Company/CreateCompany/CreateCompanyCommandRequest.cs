using MediatR;
using SignatureAPI.Application.DTOs.Company;

namespace SignatureAPI.Application.Features.Commands.Company.CreateCompany
{
    public class CreateCompanyCommandRequest:IRequest<CreateCompanyCommandResponse>
    {
        public CreateCompanyDTO CreateCompanyDTO { get; set; }
    }
}
