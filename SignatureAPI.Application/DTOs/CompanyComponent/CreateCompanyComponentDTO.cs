using SignatureAPI.Domain.Entities.CompanyComponent.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.DTOs.CompanyComponent
{
    public class CreateCompanyComponentDTO
    {
        public string? Label { get; set; }
        public string? ImageUrl { get; set; }
        public string? TargetUrl { get; set; }

        public ComponentType Type { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; } = true;
        public Guid CompanyId { get; set; }

    }
}
