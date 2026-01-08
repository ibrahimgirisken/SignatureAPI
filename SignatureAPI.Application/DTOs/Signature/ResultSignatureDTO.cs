
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

    }
}
