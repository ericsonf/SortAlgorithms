using System.Net;
using Microsoft.AspNetCore.Diagnostics;
using Newtonsoft.Json;

namespace SortAlgorithms;

public static class ErrorHandlerExtensions
{
    public static void UseErrorHandler(this IApplicationBuilder appBuilder, ILoggerFactory loggerFactory)
    {
        appBuilder.UseExceptionHandler(builder =>
        {
            builder.Run(async context =>
            {
                if (context.Features.Get<IExceptionHandlerFeature>() is { } exceptionHandlerFeature)
                {
                    var logger = loggerFactory.CreateLogger("ErrorHandler");
                    logger.LogError($@"{exceptionHandlerFeature.Error.Message}
Machine Name: {Environment.MachineName}
OS: {Environment.OSVersion.VersionString}");

                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";

                    var json = (context.Response.StatusCode, Message: "Internal Server Error");
                    await context.Response.WriteAsync(JsonConvert.SerializeObject(value: json));
                }
            });
        });
    }
}