using MediatR;

namespace SignatureAPI.Application.Features.Commands.Company.UpdateCompany
{
    public class UpdateCompanyCommandRequest:IRequest<UpdateCompanyCommandResponse>
    {
        public Guid Id { get; set; }
        public string? CompanyName { get; set; }
        public string? DomainName { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Address { get; set; }
        public string? KdvText { get; set; }
        public string? InformationText { get; set; }
        public string? EnvironmentText { get; set; }
    }
}
