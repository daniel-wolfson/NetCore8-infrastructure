using Isrotel.Framework.Configuration.Models;
using Isrotel.Framework.Extensions;
using Isrotel.Framework.Identity;
using Microsoft.AspNetCore.Http;

namespace Isrotel.Framework.Middleware
{
    public class ApiAuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public ApiAuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            var token = httpContext.GetRequestToken();
            if (!string.IsNullOrEmpty(token))
            {
                var loggedUser = AppUser.Create(new SunClubUserDetails()); //ApiHelper.ReadToken<AppUser>(token, authOptions.KEY);
                if (loggedUser != null && !Convert.ToBoolean(httpContext.User?.Identity?.IsAuthenticated))
                {
                    httpContext.Items.TryAdd(HttpContextItemsKeys.LoggedUser, loggedUser);
                    //await httpContext.SignInAsync(loggedUser);
                }
            }

            // Call the next delegate/middleware in the pipeline
            await _next(httpContext);
        }
    }
}
