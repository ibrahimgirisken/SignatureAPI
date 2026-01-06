using MediatR;

namespace SignatureAPI.Application.Features.Commands.Company.UpdateCompany
{
    public class UpdateCompanyCommandRequest:IRequest<UpdateCompanyCommandResponse>
    {
        public string CompanyName { get; set; }
    }
}
