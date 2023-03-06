namespace BDS.TransferPrice.Configuration;

public static class Endpoint
{
    public static IApplicationBuilder ConfigureEndpoints(this IApplicationBuilder app, IConfigurationSection section)
    {
        var apiHealthCheckUrl = section["APIHealthCheckUrl"];

        app
            .UseRouting()
            .UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapHealthChecks(apiHealthCheckUrl);
        });

        return app;
    }
}