using MediatR;

namespace SignatureAPI.Application.Features.Commands.Company.UpdateCompany
{
    public class UpdateCompanyCommandRequest:IRequest<UpdateCompanyCommandResponse>
    {
        public Guid Id { get; set; }
        public string? CompanyName { get; set; }
    }
}
