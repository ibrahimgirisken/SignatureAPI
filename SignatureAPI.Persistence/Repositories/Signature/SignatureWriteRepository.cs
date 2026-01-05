using SignatureAPI.Application.Repositories.Signature;
using SignatureAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Persistence.Repositories.Signature
{
    public class SignatureWriteRepository : WriteRepository<Domain.Entities.Signature.Signature>, ISignatureWriteRepository
    {
        public SignatureWriteRepository(SignatureAPIDbContext context) : base(context)
        {
        }
    }
}
