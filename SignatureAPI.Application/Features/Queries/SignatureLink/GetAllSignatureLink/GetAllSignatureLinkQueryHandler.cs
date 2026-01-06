using AutoMapper;
using MediatR;
using SignatureAPI.Application.DTOs.Signature;
using SignatureAPI.Application.Repositories.SignatureLink;

namespace SignatureAPI.Application.Features.Queries.SignatureLink.GetAllSignatureLink
{
    public class GetAllSignatureLinkQueryHandler : IRequestHandler<GetAllSignatureLinkQueryRequest, GetAllSignatureLinkQueryResponse>
    {
        readonly ISignatureLinkReadRepository _signatureLinkReadRepository;
        readonly IMapper _mapper;

        public GetAllSignatureLinkQueryHandler(ISignatureLinkReadRepository signatureLinkReadRepository, IMapper mapper = null)
        {
            _signatureLinkReadRepository = signatureLinkReadRepository;
            _mapper = mapper;
        }

        public async Task<GetAllSignatureLinkQueryResponse> Handle(GetAllSignatureLinkQueryRequest request, CancellationToken cancellationToken)
        {
            var signatureLinkList = _signatureLinkReadRepository.GetAll();
            var signatureLinksDto = _mapper.Map<List<SignatureLinkDTO>>(signatureLinkList); // Updated type to match the expected return type
            return new()
            {
                SignatureLinks = signatureLinksDto
            };
        }
    }
}
