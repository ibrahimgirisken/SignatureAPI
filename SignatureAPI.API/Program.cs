using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SignatureAPI.API.Extensions;
using SignatureAPI.API.Filters;
using SignatureAPI.Application;
using SignatureAPI.Application.Features.Commands.Signature.CreateSignature;
using SignatureAPI.Application.Validators.ValidationBehavior;
using SignatureAPI.Domain.Entities.Identity;
using SignatureAPI.Persistence;
using SignatureAPI.Persistence.Context;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpContextAccessor();
builder.Services.AddPersistenceServices();
builder.Services.AddApplicationServices();
builder.Services.AddValidatorsFromAssembly(typeof(CreateSignatureValidator).Assembly);
builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
builder.Services.AddIdentity<AppUser,IdentityRole<Guid>>()
    .AddEntityFrameworkStores<SignatureAPIDbContext>()
    .AddDefaultTokenProviders();
// Add services to the container.

builder.Services.AddCors(options => {
    options.AddPolicy("AllowFrontend", policy => {
        policy.WithOrigins("http://localhost:3000", "https://localhost:3000").AllowAnyHeader().AllowAnyMethod().AllowCredentials();
    }
    );
});


builder.Services.AddControllers()
    .AddJsonOptions(o =>
    {
        o.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "SignatureAPI", Version = "v1" });

    c.SchemaFilter<StringEnumSchemaFilter>();
});

var app = builder.Build();

app.ConfigureExceptionHandler<Program>(app.Services.GetRequiredService<ILogger<Program>>());

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<SignatureAPIDbContext>();
    dbContext.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
