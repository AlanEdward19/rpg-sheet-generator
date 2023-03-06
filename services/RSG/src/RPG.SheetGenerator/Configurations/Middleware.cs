using RPG.SheetGenerator.API.Middlewares;

namespace BDS.TransferPrice.Configuration;

public static class Middleware
{
    public static IApplicationBuilder ConfigureMiddlewares(this IApplicationBuilder app) => app.UseMiddleware<ExceptionMiddleware>();
}