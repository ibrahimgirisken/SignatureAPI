using Microsoft.AspNetCore.Identity;
using SignatureAPI.Application.Abstractions.Services;
using SignatureAPI.Application.Abstractions.Token;
using SignatureAPI.Application.DTOs.Token;
using SignatureAPI.Application.Exceptions;
using SignatureAPI.Domain.Entities.Identity;

namespace SignatureAPI.Persistence.Services
{
    public class AuthService : IAuthService
    {
        readonly UserManager<AppUser> _userManager;
        readonly SignInManager<AppUser> _signInManager;
        readonly ITokenHandler _tokenHandler;
        readonly IUserService _userService;

        public AuthService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ITokenHandler tokenHandler, IUserService userService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenHandler = tokenHandler;
            _userService = userService;
        }

        public async Task<Token> LoginAsync(string userNameOrEmail, string password, int accessTokenLifeTime)
        {
            AppUser? user = await _userManager.FindByNameAsync(userNameOrEmail);
            if (user == null)
                user = await _userManager.FindByEmailAsync(userNameOrEmail);
            if (user == null)
                throw new NotFoundUserException();
            SignInResult result = await _signInManager.CheckPasswordSignInAsync(user, password, false);
            if (result.Succeeded)
            {
                Token token = _tokenHandler.CreateAccessToken(user, accessTokenLifeTime);
                await _userService.UpdateRefreshTokenAsyc(token.AccessToken, user, token.Expiration, 15);
                return token;
            }
            throw new NotFoundUserException();
        }

        public Task PasswordResetAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<Token> RefreshTokenLoginAsync(string refreshToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> VerifyResetTokenAsync(string email, string resetToken)
        {
            throw new NotImplementedException();
        }
    }
}
