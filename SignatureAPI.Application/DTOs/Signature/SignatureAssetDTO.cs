namespace SignatureAPI.Application.DTOs.Signature
{
    public class SignatureAssetDTO
    {
        public Guid Id { get; set; }
        public int? SignatureType { get; set; }
        public string? Url { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
        public Guid? SignatureId { get; set; }
    }
}
