using SignatureAPI.Application.DTOs.SignatureAsset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Queries.SignatureAsset.GetAllSignatureAsset
{
    public class GetAllSignatureAssetQueryResponse
    {
        public List<ResultSignatureAssetDTO> SignatureAssets { get; set; }
    }
}
