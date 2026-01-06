using SignatureAPI.Application.DTOs.Signature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Queries.SignatureLink.GetAllSignatureLink
{
    public class GetAllSignatureLinkQueryResponse
    {
        public List<SignatureLinkDTO> SignatureLinks { get; set; }
    }
}
