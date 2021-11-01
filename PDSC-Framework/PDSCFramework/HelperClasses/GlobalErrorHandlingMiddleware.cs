using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace PDSCFramework
{
  public class GlobalErrorHandlingMiddleware
  {
    private readonly RequestDelegate _next;

    public GlobalErrorHandlingMiddleware(RequestDelegate next)
    {
      _next = next;
    }

    public async Task Invoke(HttpContext context, ILogger<GlobalErrorHandlingMiddleware> logger)
    {
      try {
        await _next.Invoke(context);
      }
      catch (Exception ex) {
        var response = context.Response;
        response.ContentType = "application/json";
        response.StatusCode = (int)HttpStatusCode.InternalServerError;

        var errorResponse = new
        {
          message = ex.Message,
          statusCode = response.StatusCode
        };

        var errorJson = JsonSerializer.Serialize(errorResponse);

        // Log the error
        logger.LogError(ex, errorJson);
        // Serilog.Log.CloseAndFlush();

        response.Redirect("/Error/Error", true);
      }
    }
  }
}
