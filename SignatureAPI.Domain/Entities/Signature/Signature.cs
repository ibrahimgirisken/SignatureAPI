using SignatureAPI.Domain.Entities.Common;
using SignatureAPI.Domain.Entities.Signature.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Domain.Entities.Signature
{
    public class Signature:BaseEntity
    {
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Address { get; set; }
        public string? KdvText { get; set; }
        public string? InformationText { get; set; }
        public string? EnvironmentText { get; set; }
        public Guid CompanyId { get; set; }
        public Domain.Entities.Company.Company Company { get; set; }
        public SignatureType SignatureType { get; set; }
        public ICollection<SignatureAsset> SignatureAssets { get; set; }=new List<SignatureAsset>();
        public ICollection<SignatureLink> SignatureLinks { get; set; }=new List<SignatureLink>();
    }
}
