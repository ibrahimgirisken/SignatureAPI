using SignatureAPI.Domain.Entities.Common;
using SignatureAPI.Domain.Entities.CompanyComponent.Enums;

namespace SignatureAPI.Domain.Entities.CompanyComponent
{
    public class CompanyComponent:BaseEntity
    {
        public string? Label { get; set; }
        public string? ImageUrl { get; set; }
        public string? TargetUrl { get; set; }

        public ComponentType Type { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; } = true;

        public Guid CompanyId { get; set; }
        public virtual Entities.Company.Company Company { get; set; }
    }
}
