using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApplication.Middlewares
{
    public static class CustomMiddleware
    {
        public static void UseCustomMiddleware(this IApplicationBuilder appBuilder, string name)
        {

            appBuilder.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello " + name);

                await next();
            });
        }

    }
}
