using MediatR;

namespace SignatureAPI.Application.Features.Commands.Signature.CreateSignature
{
    public class CreateSignatureCommandRequest:IRequest<CreateSignatureCommandResponse>
    {
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Address { get; set; }
        public string? KdvText { get; set; }
        public string? InformationText { get; set; }
        public string? EnvironmentText { get; set; }
        public string CompanyId { get; set; }
    }
}
