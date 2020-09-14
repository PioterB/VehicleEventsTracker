using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    public class CustomMiddleware
    {
        private RequestDelegate _next;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, ITimeHolder timeholder)
        {
            var currentTime = DateTimeOffset.UtcNow;
            if (currentTime.Hour > 8 && currentTime.Hour < 16)
            {
                timeholder.Memorize(currentTime);

                BeforeGoingToNextMiddleware(context);

                await _next.Invoke(context);

                ReturningFromNextMiddleware(context);
            }
        }

        private void BeforeGoingToNextMiddleware(HttpContext context)
        {
        }

        private void ReturningFromNextMiddleware(HttpContext context)
        {
        }
    }

    public static class CustomMiddlewareExtensions 
    {

        /// <summary>
        /// keeps usage clean, help to focus on use it not to how to do it
        /// </summary>
        /// <param name="builder"></param>
        public static void UseCustomMiddleware(this IApplicationBuilder builder)
        {
            /*
             * holds usage details, logic how to configure this middleware
             */
            builder.UseMiddleware<CustomMiddleware>();
        }
    }
}
