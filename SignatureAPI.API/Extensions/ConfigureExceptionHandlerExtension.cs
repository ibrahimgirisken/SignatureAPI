using Microsoft.AspNetCore.Diagnostics;
using System.Net.Mime;
using System.Net;
using System.Text.Json;

namespace SignatureAPI.API.Extensions
{
    static public class ConfigureExceptionHandlerExtension
    {
        public static void ConfigureExceptionHandler<T>(this WebApplication application, ILogger<T> logger)
        {
            application.UseExceptionHandler(builder =>
            {
                builder.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = MediaTypeNames.Application.Json;

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        var exception = contextFeature.Error;

                        // Eğer hata FluentValidation'dan geliyorsa StatusCode'u 400 yap
                        if (exception is FluentValidation.ValidationException validationException)
                        {
                            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;

                            await context.Response.WriteAsync(JsonSerializer.Serialize(new
                            {
                                StatusCode = 400,
                                Title = "Validasyon Hatası",
                                // Sadece hata mesajlarını dizi olarak döndür
                                Errors = validationException.Errors.Select(e => new { e.PropertyName, e.ErrorMessage })
                            }));
                        }
                        else // Diğer beklenmedik (gerçek 500) hataları yönet
                        {
                            logger.LogError(exception.Message);
                            await context.Response.WriteAsync(JsonSerializer.Serialize(new
                            {
                                StatusCode = 500,
                                Message = "Sunucu tarafında beklenmedik bir hata oluştu!",
                                Title = "Hata alındı!"
                            }));
                        }
                    }
                });
            });
        }
    }
}
