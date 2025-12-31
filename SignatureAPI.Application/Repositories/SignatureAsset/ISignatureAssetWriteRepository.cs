using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Repositories.SignatureAsset
{
    public interface ISignatureAssetWriteRepository:IWriteRepository<Domain.Entities.Signature.SignatureAsset>
    {
    }
}
