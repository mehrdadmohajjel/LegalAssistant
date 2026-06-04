using LegalAssistant.API.Middlewares;
using LegalAssistant.Application;
using LegalAssistant.Infrastructure;
using LegalAssistant.Persistence;
using Microsoft.AspNetCore.RateLimiting;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((ctx, lc) =>
{
    lc.ReadFrom.Configuration(ctx.Configuration);
});

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddApplication();

builder.Services.AddPersistence(
    builder.Configuration);

builder.Services.AddInfrastructure(
    builder.Configuration);

builder.Services.AddRateLimiter(options =>
{
    options.AddFixedWindowLimiter(
        "ApiLimiter",
        opt =>
        {
            opt.PermitLimit = 50;

            opt.Window = TimeSpan.FromMinutes(1);

            opt.QueueLimit = 0;
        });
});

var app = builder.Build();

app.UseMiddleware<GlobalExceptionMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRateLimiter();

app.UseAuthorization();

app.MapControllers();

app.Run();