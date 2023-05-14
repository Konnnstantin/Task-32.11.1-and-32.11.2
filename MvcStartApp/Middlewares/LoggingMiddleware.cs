using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MvcStartApp.Models;
using MvcStartApp.Models.Repository;
using System;
using System.Threading.Tasks;

namespace MvcStartApp.Middlewares
{
    public class LoggingMiddleware : Controller
    {
        private readonly RequestDelegate _requestDelegate;

        public LoggingMiddleware(RequestDelegate request)
        {
            _requestDelegate = request;
        }
        
        public async Task InvokeAsync(HttpContext httpContext,ILoggerRepository logger)
        {
            var request = new Request()
            {
                Url = $" New request to http:// {httpContext.Request.Host.Value + httpContext.Request.Path}"
            };

            await logger.AddLogger(request);

            await _requestDelegate.Invoke(httpContext);
        }

    }
}
