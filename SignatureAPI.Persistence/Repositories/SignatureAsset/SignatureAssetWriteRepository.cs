using SignatureAPI.Application.Repositories.SignatureAsset;
using SignatureAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Persistence.Repositories.SignatureAsset
{
    public class SignatureAssetWriteRepository : WriteRepository<Domain.Entities.Signature.SignatureAsset>, ISignatureAssetWriteRepository
    {
        public SignatureAssetWriteRepository(SignatureAPIDbContext context) : base(context)
        {
        }
    }
}
