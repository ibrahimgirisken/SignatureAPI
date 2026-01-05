using SignatureAPI.Application.Repositories.Signature;
using SignatureAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Persistence.Repositories.Signature
{
    public class SignatureReadRepository : ReadRepository<Domain.Entities.Signature.Signature>, ISignatureReadRepository
    {
        public SignatureReadRepository(SignatureAPIDbContext context) : base(context)
        {
        }
    }
}
