using MediatR;
using SignatureAPI.Application.DTOs.Company;

namespace SignatureAPI.Application.Features.Commands.Company.UpdateCompany
{
    public class UpdateCompanyCommandRequest:IRequest<UpdateCompanyCommandResponse>
    {
        public UpdateCompanyDTO UpdateCompanyDTO { get; set; }
    }
}
