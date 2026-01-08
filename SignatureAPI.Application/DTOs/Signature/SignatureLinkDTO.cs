
namespace SignatureAPI.Application.DTOs.Signature
{
    public class SignatureLinkDTO
    {
        public Guid Id { get; set; }
        public int? LinkType { get; set; }
        public string? Url { get; set; }
        public string? Title { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
        public Guid? SignatureId { get; set; }
    }
}
