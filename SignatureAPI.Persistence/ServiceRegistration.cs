using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SignatureAPI.Application.Abstractions.Services;
using SignatureAPI.Application.Abstractions.Token;
using SignatureAPI.Application.Repositories.Company;
using SignatureAPI.Infrastracture.Services.Token;
using SignatureAPI.Persistence.Context;
using SignatureAPI.Persistence.Repositories.Company;
using SignatureAPI.Persistence.Services;

namespace SignatureAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<SignatureAPIDbContext>(options =>
            {
                options.UseMySql(Configuration.ConnectionString, ServerVersion.AutoDetect(Configuration.ConnectionString));
            });

            services.AddScoped<ICompanyReadRepository, CompanyReadRepository>();
            services.AddScoped<ICompanyWriteRepository, CompanyWriteRepository>();


            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ITokenHandler, TokenHandler>();
        }
    }
}
