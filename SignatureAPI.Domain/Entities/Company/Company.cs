using SignatureAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Domain.Entities.Company
{
    public class Company:BaseEntity
    {
        public string? CompanyName { get; set; }
        public Guid SignatureId { get; set; }
        public SignatureAPI.Domain.Entities.Signature.Signature? Signature { get; set; }=new Signature.Signature();
    }
}
