using Microsoft.AspNetCore.Mvc;
using SignatureAPI.Domain.Entities.CompanyComponent.Enums;


namespace SignatureAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnumsController : ControllerBase
    {
        [HttpGet("signature-asset-types")]
        public IActionResult GetSignatureTypes()
        {
            return Ok(Enum.GetValues<ComponentType>()
                .Select(x => new
                {
                    Value = (int)x,
                    Name = x.ToString()
                }));
        }
    }
}
