using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware.Crosscutting.CrosscuttingExtensions
{
    public static class LoggerExtension
    {
        public static IHostBuilder AddSerilog(this IHostBuilder app) 
        {
            var jsonFilePath = new ConfigurationBuilder()
                                .AddJsonFile("serilogsettings.json")
                                .Build();


            Log.Logger = new LoggerConfiguration()
                            .ReadFrom.Configuration(jsonFilePath)
                            .CreateLogger();

            return app.UseSerilog();
        }
    }
}
