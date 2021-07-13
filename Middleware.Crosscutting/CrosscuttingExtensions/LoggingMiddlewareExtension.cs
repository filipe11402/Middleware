using Microsoft.AspNetCore.Builder;
using Middleware.Crosscutting.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware.Crosscutting.CrosscuttingExtensions
{
    public static class LoggingMiddlewareExtension
    {

        public static IApplicationBuilder AddLoggingMiddleware(this IApplicationBuilder app) 
        {
            return app.UseMiddleware<LoggerMiddleware>();
        }
    }
}
