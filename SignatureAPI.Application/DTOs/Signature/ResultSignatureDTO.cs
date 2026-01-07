
namespace SignatureAPI.Application.DTOs.Signature
{
    public class ResultSignatureDTO
    {
        public Guid Id { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Address { get; set; }
        public string? KdvText { get; set; }
        public string? InformationText { get; set; }
        public string? EnvironmentText { get; set; }
        public Guid? CompanyId { get; set; }
        public string? SignatureType { get; set; }
        public List<SignatureAssetDTO> SignatureAssets { get; set; }
        public List<SignatureLinkDTO> SignatureLinks { get; set; }

    }
}
