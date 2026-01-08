using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignatureAPI.Domain.Entities.Signature.Enums;

namespace SignatureAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnumsController : ControllerBase
    {
        [HttpGet("signature-types")]
        public IActionResult GetSignatureTypes()
        {
            return Ok(Enum.GetValues<SignatureType>()
                .Select(x => new
                {
                    Value = (int)x,
                    Name = x.ToString()
                }));
        }

        [HttpGet("signature-link-types")]
        public IActionResult GetSignatureLinkTypes()
        {
            return Ok(Enum.GetValues<SignatureLinkType>()
                .Select(x => new
                {
                    Value = (int)x,
                    Name = x.ToString()
                }));
        }
    }
}
