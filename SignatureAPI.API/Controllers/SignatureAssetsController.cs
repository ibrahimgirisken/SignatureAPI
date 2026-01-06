using MediatR;
using Microsoft.AspNetCore.Mvc;
using SignatureAPI.Application.Features.Commands.SignatureAsset.CreateSignatureAsset;
using SignatureAPI.Application.Features.Commands.SignatureAsset.RemoveSignatureAsset;
using SignatureAPI.Application.Features.Commands.SignatureAsset.UpdateSignatureAsset;
using SignatureAPI.Application.Features.Queries.SignatureAsset.GetAllSignatureAsset;
using System.Net;

namespace SignatureAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignatureAssetsController : ControllerBase
    {
        readonly IMediator _mediator;

        public SignatureAssetsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllSignatureAssets([FromQuery] GetAllSignatureAssetQueryRequest getAllSignatureAssetsQueryRequest)
        {
            GetAllSignatureAssetQueryResponse response = await _mediator.Send(getAllSignatureAssetsQueryRequest);
            return Ok(response);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddSignatureAsset(CreateSignatureAssetCommandRequest createSignatureAssetCommandRequest)
        {   
            CreateSignatureAssetCommandResponse response=await _mediator.Send(createSignatureAssetCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateSignatureAsset(UpdateSignatureAssetCommandRequest updateSignatureAssetCommandRequest)
        {
            UpdateSignatureAssetCommandResponse response = await _mediator.Send(updateSignatureAssetCommandRequest);
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteSignatureAsset([FromQuery] RemoveSignatureAssetCommandRequest removeSignatureAssetCommandRequest)
        {
            RemoveSignatureAssetCommandResponse response = await _mediator.Send(removeSignatureAssetCommandRequest);
            return Ok(response);
        }
    }
}
