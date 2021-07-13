using Microsoft.AspNetCore.Http;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware.Crosscutting.Middlewares
{
    public class LoggerMiddleware
    {
        private readonly RequestDelegate _requestDelegate;

        public LoggerMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context) 
        {
            Log.Information("This was a test for everytime there is a request");
            await _requestDelegate(context);
        }

    }
}
