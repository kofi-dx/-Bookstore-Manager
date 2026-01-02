using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace Bookstore.Filters
{
    public class RequestLoggingFilter : IAsyncActionFilter
    {
        private readonly ILogger<RequestLoggingFilter> _logger;

        public RequestLoggingFilter(ILogger<RequestLoggingFilter> logger)
        {
            _logger = logger;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var stopwatch = Stopwatch.StartNew();
            var httpContext = context.HttpContext;
            var request = httpContext.Request;

            // Execute the action
            var resultContext = await next();

            stopwatch.Stop();

            _logger.LogInformation(
                "Request: {Method} {Path}{QueryString} - {StatusCode} - {Duration}ms",
                request.Method,
                request.Path,
                request.QueryString,
                httpContext.Response.StatusCode,
                stopwatch.ElapsedMilliseconds);
        }
    }
}