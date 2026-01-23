using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
