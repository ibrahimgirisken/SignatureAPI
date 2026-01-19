using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignatureAPI.Application.Features.Commands.Signature.CreateSignature;
using SignatureAPI.Application.Features.Commands.Signature.RemoveSignature;
using SignatureAPI.Application.Features.Commands.Signature.UpdateSignature;
using SignatureAPI.Application.Features.Queries.Signature.GetAllSignature;
using SignatureAPI.Application.Features.Queries.Signature.GetByIdSignature;
using SignatureAPI.Application.Features.Queries.Signature.GetWhereSignature;

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

        [HttpGet("getById")]
        public async Task<IActionResult> GetByIdSignature([FromQuery] GetByIdSignatureQueryRequest getByIdSignatureQueryRequest)
        {
            GetByIdSignatureQueryResponse response=await _mediator.Send(getByIdSignatureQueryRequest);
            return Ok(response);
        }


        [HttpGet("getWhere")]
        public async Task<IActionResult> GetWhereSignature([FromQuery] GetWhereSignatureQueryRequest getWhereSignatureQueryRequest)
        {
            GetWhereSignatureQueryResponse response = await _mediator.Send(getWhereSignatureQueryRequest);
            return Ok(response);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddSignature(CreateSignatureCommandRequest createSignatureCommandRequest)
        {
            CreateSignatureCommandResponse response =await _mediator.Send(createSignatureCommandRequest);
            return Ok();
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateSignature(UpdateSignatureCommandRequest updateSignatureCommandRequest)
        {
            UpdateSignatureCommandResponse response = await _mediator.Send(updateSignatureCommandRequest);
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteSignature([FromQuery] RemoveSignatureCommandRequest removeSignatureCommandRequest)
        {
            RemoveSignatureCommandResponse response = await _mediator.Send(removeSignatureCommandRequest);
            return Ok(response);
        }
    }
}
