using MediatR;
using SignatureAPI.Domain.Entities.CompanyComponent.Enums;

namespace SignatureAPI.Application.Features.Commands.CompanyComponent.UpdateCompanyComponent
{
    public class UpdateCompanyComponentCommandRequest:IRequest<UpdateCompanyComponentCommandResponse>
    {
        public Guid Id { get; set; }
        public string? Label { get; set; }
        public string? ImageUrl { get; set; }
        public string? TargetUrl { get; set; }

        public ComponentType Type { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; } = true;
        public Guid CompanyId { get; set; }
    }
}
