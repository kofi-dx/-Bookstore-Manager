using Microsoft.AspNetCore.Rewrite;

namespace Bookstore.Services
{
    public static class UrlRewriterService
    {
        public static void ConfigureRewriter(RewriteOptions options)
        {
            // Redirect old URLs to new ones
            options.AddRedirect("^books/list$", "/Books");
            options.AddRedirect("^products/books$", "/Books");
            
            // Custom URL for book details
            options.AddRewrite(@"^book/(\d+)$", "Books/Details/$1", skipRemainingRules: false);
            
            // Friendly URLs for common searches
            options.AddRewrite(@"^books/by/([^/]+)$", "Books/Index?author=$1", skipRemainingRules: false);
            
            // Lowercase URLs
            options.Add(new LowercaseRule());
        }
    }

    public class LowercaseRule : IRule
    {
        public void ApplyRule(RewriteContext context)
        {
            var request = context.HttpContext.Request;
            var path = request.Path.Value;

            if (!string.IsNullOrEmpty(path) && path.Any(char.IsUpper))
            {
                var newPath = path.ToLowerInvariant();
                context.HttpContext.Request.Path = newPath;
                context.Result = RuleResult.SkipRemainingRules;
            }
        }
    }
}