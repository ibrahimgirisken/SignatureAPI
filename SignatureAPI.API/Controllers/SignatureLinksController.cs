using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignatureAPI.Application.Features.Commands.SignatureLink.CreateSignatureLink;
using SignatureAPI.Application.Features.Commands.SignatureLink.RemoveSignatureLink;
using SignatureAPI.Application.Features.Commands.SignatureLink.UpdateSignatureLink;
using SignatureAPI.Application.Features.Queries.SignatureLink.GetAllSignatureLink;
using System.Net;

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
        public async Task<IActionResult> GetAllSignatureLinks([FromQuery] GetAllSignatureLinkQueryRequest getAllSignatureLinkQueryRequest)
        {
            GetAllSignatureLinkQueryResponse response = await _mediator.Send(getAllSignatureLinkQueryRequest);
            return Ok(response);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddSignatureLink(CreateSignatureLinkCommandRequest createSignatureLinkCommandRequest)
        {
            CreateSignatureLinkCommandResponse response = await _mediator.Send(createSignatureLinkCommandRequest);
            return StatusCode((int)HttpStatusCode.OK);
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateSignatureLink(UpdateSignatureLinkCommandRequest updateSignatureLinkCommandRequest)
        {
            UpdateSignatureLinkCommandResponse response = await _mediator.Send(updateSignatureLinkCommandRequest);
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteSignatureLink([FromQuery] RemoveSignatureLinkCommandRequest removeSignatureLinkCommandRequest)
        {
            RemoveSignatureLinkCommandResponse response = await _mediator.Send(removeSignatureLinkCommandRequest);
            return Ok(response);
        }
    }
}
