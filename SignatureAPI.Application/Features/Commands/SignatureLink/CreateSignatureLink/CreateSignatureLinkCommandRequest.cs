using MediatR;

namespace SignatureAPI.Application.Features.Commands.SignatureLink.CreateSignatureLink
{
    public class CreateSignatureLinkCommandRequest:IRequest<CreateSignatureLinkCommandResponse>
    {
        public string? LinkType { get; set; }
        public string? Url { get; set; }
        public string? Title { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
        public string? SignatureId { get; set; }
    }
}
