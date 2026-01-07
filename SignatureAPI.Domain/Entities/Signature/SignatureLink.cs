using SignatureAPI.Domain.Entities.Common;
using SignatureAPI.Domain.Entities.Signature.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Domain.Entities.Signature
{
    public class SignatureLink : BaseEntity
    {
        public SignatureLinkType LinkType { get; set; }
        public string? Url { get; set; }
        public string? Title { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
        public Guid? SignatureId { get; set; }
        public Signature Signature { get; set; }
    }
}
