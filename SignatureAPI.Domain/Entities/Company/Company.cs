using SignatureAPI.Domain.Entities.Common;

namespace SignatureAPI.Domain.Entities.Company
{
    public class Company:BaseEntity
    {
        public string? CompanyName { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Address { get; set; }
        public string? KdvText { get; set; }
        public string? InformationText { get; set; }
        public string? EnvironmentText { get; set; }
        public virtual ICollection<Entities.CompanyComponent.CompanyComponent> CompanyComponents { get; set; }

    }
}
