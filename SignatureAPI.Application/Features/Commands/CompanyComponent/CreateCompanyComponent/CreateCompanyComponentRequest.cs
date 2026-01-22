using MediatR;
using SignatureAPI.Domain.Entities.CompanyComponent.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Commands.CompanyComponent.CreateCompanyComponent
{
    public class CreateCompanyComponentRequest:IRequest<CreateCompanyComponentResponse>
    {
        public string? Label { get; set; }
        public string? ImageUrl { get; set; }
        public string? TargetUrl { get; set; }

        public string Type { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
