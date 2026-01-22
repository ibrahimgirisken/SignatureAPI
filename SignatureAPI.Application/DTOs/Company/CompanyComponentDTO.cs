namespace SignatureAPI.Application.DTOs.Company
{
    public class CompanyComponentDTO
    {
        public string? Label { get; set; }
        public string? ImageUrl { get; set; }
        public string? TargetUrl { get; set; }
        public string Type{ get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
    }
}
