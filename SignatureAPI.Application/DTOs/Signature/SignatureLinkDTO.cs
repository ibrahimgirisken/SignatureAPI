using SignatureAPI.Domain.Entities.Signature.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.DTOs.Signature
{
    public class SignatureLinkDTO
    {
        public string? LinkType { get; set; }
        public string? Url { get; set; }
        public string? Title { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
        public string? SignatureId { get; set; }
    }
}
