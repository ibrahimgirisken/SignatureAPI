using AutoMapper;
using MediatR;
using SignatureAPI.Application.Repositories.SignatureAsset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Commands.SignatureAsset.UpdateSignatureAsset
{
    public class UpdateSignatureAssetCommandHandler:IRequestHandler<UpdateSignatureAssetCommandRequest, UpdateSignatureAssetCommandResponse>
    {
        readonly ISignatureAssetWriteRepository _signatureAssetWriteRepository;
        readonly IMapper _mapper;

        public UpdateSignatureAssetCommandHandler(ISignatureAssetWriteRepository signatureAssetWriteRepository, IMapper mapper)
        {
            _signatureAssetWriteRepository = signatureAssetWriteRepository;
            _mapper = mapper;
        }

        public Task<UpdateSignatureAssetCommandResponse> Handle(UpdateSignatureAssetCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
