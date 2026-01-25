using MediatR;
using SignatureAPI.Domain.Entities.CompanyComponent.Enums;
using System.ComponentModel.DataAnnotations;

namespace SignatureAPI.Application.Features.Commands.CompanyComponent.CreateCompanyComponent
{
    public class CreateCompanyComponentCommandRequest:IRequest<CreateCompanyComponentCommandResponse>
    {
        public string? Label { get; set; }
        public string? ImageUrl { get; set; }
        public string? TargetUrl { get; set; }

        public ComponentType Type { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; } = true;
        [Required]
        public Guid CompanyId { get; set; }
    }
}
