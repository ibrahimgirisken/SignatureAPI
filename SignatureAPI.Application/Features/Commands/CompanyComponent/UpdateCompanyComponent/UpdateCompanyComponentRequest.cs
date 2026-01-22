using MediatR;

namespace SignatureAPI.Application.Features.Commands.CompanyComponent.UpdateCompanyComponent
{
    public class UpdateCompanyComponentRequest:IRequest<UpdateCompanyComponentResponse>
    {
        public Guid Id { get; set; }
        public string? Label { get; set; }
        public string? ImageUrl { get; set; }
        public string? TargetUrl { get; set; }
        public string Type { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
