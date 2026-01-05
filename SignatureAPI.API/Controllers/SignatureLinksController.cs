using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignatureAPI.Application.Features.Queries.SignatureLink.GetAllSignatureLink;

namespace SignatureAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignatureLinksController : ControllerBase
    {
        readonly IMediator _mediator;
        public SignatureLinksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllSignatureLinks(GetAllSignatureLinkQueryRequest getAllSignatureLinkQueryRequest)
        {
            GetAllSignatureLinkQueryResponse response = await _mediator.Send(getAllSignatureLinkQueryRequest);
            return Ok(response);
        }
    }
}
