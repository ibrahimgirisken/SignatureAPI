using MediatR;

namespace SignatureAPI.Application.Features.Commands.SignatureLink.UpdateSignatureLink
{
    public class UpdateSignatureLinkCommandRequest:IRequest<UpdateSignatureLinkCommandResponse>
    {
        public Guid Id { get; set; }
        public int? LinkType { get; set; }
        public string? Url { get; set; }
        public string? Title { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; } = true;
        public Guid? SignatureId { get; set; }
    }
}
