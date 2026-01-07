
namespace SignatureAPI.Application.DTOs.SignatureAsset
{
    public class ResultSignatureAssetDTO
    {
        public Guid Id { get; set; }
        public string? SignatureType { get; set; }
        public string? Url { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; } = true;
        public Guid? SignatureId { get; set; }
    }
}
