using System.Net;
using System.Text.Json;
using FluentValidation;

namespace LegalAssistant.API.Middlewares;

public sealed class GlobalExceptionMiddleware
{
    private readonly RequestDelegate _next;

    private readonly ILogger<GlobalExceptionMiddleware> _logger;

    public GlobalExceptionMiddleware(
        RequestDelegate next,
        ILogger<GlobalExceptionMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(
        HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (ValidationException ex)
        {
            context.Response.StatusCode =
                StatusCodes.Status400BadRequest;

            context.Response.ContentType =
                "application/json";

            var response = new
            {
                success = false,
                errors = ex.Errors
            };

            await context.Response.WriteAsync(
                JsonSerializer.Serialize(response));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex,
                "Unhandled Exception");

            context.Response.StatusCode =
                StatusCodes.Status500InternalServerError;

            context.Response.ContentType =
                "application/json";

            var response = new
            {
                success = false,
                message = "خطای داخلی سرور رخ داده است."
            };

            await context.Response.WriteAsync(
                JsonSerializer.Serialize(response));
        }
    }
}