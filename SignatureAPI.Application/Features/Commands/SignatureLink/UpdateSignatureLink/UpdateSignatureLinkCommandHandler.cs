using AutoMapper;
using MediatR;
using SignatureAPI.Application.Repositories.SignatureLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Commands.SignatureLink.UpdateSignatureLink
{
    public class UpdateSignatureLinkCommandHandler:IRequestHandler<UpdateSignatureLinkCommandRequest, UpdateSignatureLinkCommandResponse>
    {
        readonly ISignatureLinkWriteRepository _signatureLinkWriteRepository;
        readonly IMapper _mapper;

        public UpdateSignatureLinkCommandHandler(ISignatureLinkWriteRepository signatureLinkWriteRepository, IMapper mapper)
        {
            _signatureLinkWriteRepository = signatureLinkWriteRepository;
            _mapper = mapper;
        }

        public Task<UpdateSignatureLinkCommandResponse> Handle(UpdateSignatureLinkCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
