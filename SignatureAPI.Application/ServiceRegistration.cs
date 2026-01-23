using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SignatureAPI.Application.Mapping;

namespace SignatureAPI.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection collection)
        {
            collection.AddMediatR(typeof(ServiceRegistration));
            collection.AddHttpClient();
            collection.AddAutoMapper(typeof(MappingProfile));
            collection.AddValidatorsFromAssembly(typeof(ServiceRegistration).Assembly);
        }
    }
}
