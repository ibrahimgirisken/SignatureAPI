using MediatR;

namespace SignatureAPI.Application.Features.Commands.SignatureLink.UpdateSignatureLink
{
    public class UpdateSignatureLinkCommandRequest:IRequest<UpdateSignatureLinkCommandResponse>
    {
        public string Id { get; set; }
        public string? LinkType { get; set; }
        public string? Url { get; set; }
        public string? Title { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
        public string? SignatureId { get; set; }
    }
}
