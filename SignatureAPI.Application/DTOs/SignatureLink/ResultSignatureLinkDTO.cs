using SignatureAPI.Domain.Entities.Signature.Enums;

namespace SignatureAPI.Application.DTOs.SignatureLink
{
    public class ResultSignatureLinkDTO
    {
        public string Id { get; set; }
        public string? LinkType { get; set; }
        public string? Url { get; set; }
        public string? Title { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; } = true;
        public string? SignatureId { get; set; }
    }
}
