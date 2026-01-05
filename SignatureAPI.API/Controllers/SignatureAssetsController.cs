using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignatureAPI.Application.Features.Queries.SignatureAsset.GetAllSignatureAsset;

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
    }
}
