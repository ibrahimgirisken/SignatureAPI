
namespace SignatureAPI.Application.DTOs.SignatureAsset
{
    public class ResultSignatureAssetDTO
    {
        public string Id { get; set; }
        public string? SignatureType { get; set; }
        public string? Url { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
        public string? SignatureId { get; set; }
    }
}
