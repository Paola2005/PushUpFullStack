using System.Net;
using System.Net.Mime;
using System.Text.Json;
using API.Helpers;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionMiddleware> _logger;
    private readonly IHostEnvironment _env;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ExceptionMiddleware(RequestDelegate next,
        ILogger<ExceptionMiddleware> logger, IHostEnvironment env,
        IHttpContextAccessor httpContextAccessor)
    {
        _next = next;
        _logger = logger;
        _env = env;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            var statusCode = (int)HttpStatusCode.InternalServerError;

            _logger.LogError(ex, ex.Message);

            var response = _env.IsDevelopment()
                            ? new ApiException(statusCode, ex.Message, ex.StackTrace)
                            : new ApiException(statusCode);

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            var json = JsonSerializer.Serialize(response, options);

            context.Response.ContentType = MediaTypeNames.Application.Json;
            context.Response.StatusCode = statusCode;

            await context.Response.WriteAsync(json);
        }
    }
}