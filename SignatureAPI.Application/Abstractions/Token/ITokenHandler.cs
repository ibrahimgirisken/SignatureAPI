using SignatureAPI.Domain.Entities.Identity;

namespace SignatureAPI.Application.Abstractions.Token
{
    public interface ITokenHandler
    {
        DTOs.Token.Token CreateAccessToken(AppUser user,int minute);
        string CreateRefreshToken();
    }
}
