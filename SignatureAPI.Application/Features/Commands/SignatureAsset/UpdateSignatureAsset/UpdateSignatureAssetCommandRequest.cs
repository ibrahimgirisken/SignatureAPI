using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Commands.SignatureAsset.UpdateSignatureAsset
{
    public class UpdateSignatureAssetCommandRequest:IRequest<UpdateSignatureAssetCommandResponse>
    {
        public Guid Id { get; set; }
        public int? SignatureType { get; set; }
        public string? Url { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; } = true;
        public Guid? SignatureId { get; set; }
    }
}
