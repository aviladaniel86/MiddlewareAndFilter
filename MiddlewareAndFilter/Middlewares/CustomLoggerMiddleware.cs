using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareAndFilter.Middlewares
{
    public class CustomLoggerMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("Call before request Middleware");
            await next(context);
            Console.WriteLine("Call after request Middleware");
        }
    }
}
