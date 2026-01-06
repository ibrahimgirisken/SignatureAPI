using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignatureAPI.Application.Features.Queries.Signature.GetAllSignature;

namespace SignatureAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignaturesController : ControllerBase
    {
        readonly IMediator _mediator;
        public SignaturesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllSignatures([FromQuery] GetAllSignatureQueryRequest getAllSignatureQueryRequest)
        {
            GetAllSignatureQueryResponse response = await _mediator.Send(getAllSignatureQueryRequest);
            return Ok(response);
        }
    }
}
