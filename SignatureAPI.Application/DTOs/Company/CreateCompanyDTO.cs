namespace SignatureAPI.Application.DTOs.Company
{
    public class CreateCompanyDTO
    {
        public string? CompanyName { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Address { get; set; }
        public string? KdvText { get; set; }
        public string? InformationText { get; set; }
        public string? EnvironmentText { get; set; }
    }
}
