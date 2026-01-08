using SignatureAPI.Application.DTOs.Signature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Queries.Signature.GetAllSignature
{
    public class GetAllSignatureQueryResponse
    {
        public List<SignatureDTO> Signatures{ get; set; }
    }
}
